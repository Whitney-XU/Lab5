﻿using System;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection conn = new SqlConnection(" ");
            //SqlCommand cmd = new SqlCommand("sp_Myproc",conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();

            SqlConnection conn = new SqlConnection(" ");
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
