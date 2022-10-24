using WebApiCoder.Controllers;

namespace WebApiCoder.Repository
{
    public static class Connection
    {


        public static string traerConnection()
        {
            return  "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
        }


    }

}
