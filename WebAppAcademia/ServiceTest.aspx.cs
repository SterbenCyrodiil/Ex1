using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAcademia.ConvertTemp;

namespace WebAppAcademia
{
    //é necessário adicionar "Services References" ao projecto, sempre que o serviço é modificado é necessário realizar a actualização das referencias
    public partial class ServiceTest : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCallServiceMethod_Click(object sender, EventArgs e)
        {
            using(var client = new ServiceClient())
            {

                lblReturn.Text = client.GetData("Academia.NET");

                client.Close();
            }
        
        }

       
    }
}