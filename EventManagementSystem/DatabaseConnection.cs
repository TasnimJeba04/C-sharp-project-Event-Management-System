// ============================================================
// File: DatabaseConnection.cs
// Purpose: Centralised database access helper class.
//          Every form uses this so the connection string lives
//          in exactly ONE place (maintainable code).
// ============================================================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public class DatabaseConnection
    {
        // === ENCAPSULATION: connection string is private ===
        private readonly string connString =
            @"Server=(localdb)\MSSQLLocalDB;Database=EventManagementDB;Integrated Security=True;";

        // Open a fresh SqlConnection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        // -----------------------------------------------------
        // Run a SELECT query and return the result as a DataTable.
        // Used to bind data straight into a DataGridView.
        // -----------------------------------------------------
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // -----------------------------------------------------
        // Run an INSERT / UPDATE / DELETE statement.
        // Returns the number of rows affected.
        // -----------------------------------------------------
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rows = 0;
            try
            {
                using (SqlConnection con = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rows;
        }

        // -----------------------------------------------------
        // Run a query that returns ONE value (e.g. SELECT COUNT(*)).
        // -----------------------------------------------------
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection con = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    con.Open();
                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}