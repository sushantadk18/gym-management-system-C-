using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace programmingassignment.Database
{
    public class suscription
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SUSHANT\SQLEXPRESS;Initial Catalog=FitnessClub;Integrated Security=True");


        public bool manageSuscription(int Id,
            String CustomerName,
            String Address,
            String Contact,

            String TrainingPlan,
            Double CurrentWeight,
            Double TargetWeight,
            int PrivateTrainingHours,
            string SaunaOption,
            string SwimmingOption,
            Double Cost,
            int Mode)
        {
            bool result = false;
            try
            {
                String txtsql = "";
                if (Mode == 1)

                    txtsql = @"insert into CustomerSuscriptionTable
                   (CustomerName,Address,contact,trainingplan,currentWeight,
                   targetWeight,privatetraining,sauna,swimming,Cost)
                   values
                   (@CustomerName,@Address,@Contact,
                    @TrainingPlan,@CurrentWeight,@TargetWeight,
                    @PrivateTrainingHours,@SaunaOption,@SwimmingOption,@Cost)";
                if (Mode == 2)
                    txtsql = @"Update CustomerSuscriptionTable set
                            CustomerName=@CustomerName,
                             Address=@Address,
                             contact=@Contact,
                             
                             trainingplan=@TrainingPlan,
                             currentweight=@CurrentWeight,
                             targetweight=@TargetWeight,
                             privatetraining=@PrivateTrainingHours,
                             sauna=@SaunaOption,
                             swimming=@SwimmingOption,  
                             Cost=@Cost where Id=@Id ";
                if (Mode == 3)
                    txtsql = @"Delete from CustomerSuscriptionTable where Id=@Id";
                SqlCommand cmd = new SqlCommand(txtsql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Contact", Contact);

                cmd.Parameters.AddWithValue("@TrainingPlan", TrainingPlan);
                cmd.Parameters.AddWithValue("@CurrentWeight", CurrentWeight);
                cmd.Parameters.AddWithValue("@TargetWeight", TargetWeight);
                cmd.Parameters.AddWithValue("@PrivateTrainingHours", PrivateTrainingHours);
                cmd.Parameters.AddWithValue("@SaunaOption", SaunaOption);
                cmd.Parameters.AddWithValue("@SwimmingOption", SwimmingOption);
                cmd.Parameters.AddWithValue("@Cost", Cost);
                conn.Open();
                int rs = cmd.ExecuteNonQuery();
                conn.Close();
                if (rs > 0) result = true;
                else result = false;





            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;

        }
        public DataTable getAllSubscription()
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select * from CustomerSuscriptionTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable SearchSubscription(string CustomerName)
        {
            
            
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select * from CustomerSuscriptionTable
                                                where CustomerName =@CustomerName",conn );
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@CustomerName",CustomerName );
                conn.Open() ;
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close() ;
                return dt;  
            }
            catch (Exception ex)
            {
                throw ex; 
                
            }
            finally { conn.Close(); }   
        }
        public DataTable searchwithCustomerName(string CustomerName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select * from customerSuscriptionTable
                                                where CustomerName like + '%' + @CustomerName+ '%'", conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("CustomerName", CustomerName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { conn.Close(); }


        }
    }

}
