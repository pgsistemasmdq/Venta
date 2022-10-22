using WebApplication1.Controllers;

namespace WebApplication1.Repository
{
    public static class Connection
    {


        public static string traerConnection()
        {
            return  "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
        }


    }

}
