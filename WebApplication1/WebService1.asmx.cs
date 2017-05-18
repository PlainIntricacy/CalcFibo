using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<int> CalcFibo(int input)
        {
            List<int> outputList = new List<int>();
            try
            {
                if (input <= 2)
                {
                    if (input < 0)
                    {
                        throw new Exception("Invalid input - Please enter an integer value between 0 and 100.");
                    }
                    else
                    {
                        if (input < 2)
                        {
                            outputList.Add(0);
                            return outputList;
                        }
                        else
                        {
                            outputList.Add(0);
                            outputList.Add(1);
                            return outputList;
                        }
                    }
                }
                else
                {
                    if (input > 100)
                    {
                        throw new Exception("Invalid input - Please enter an integer value between 0 and 100.");
                    }
                    else
                    {
                        outputList.Add(0);
                        outputList.Add(1);
                        int i0 = 0, i1 = 1;
                        for (int i = 3; i <= input; i++)
                        {
                            int output = i0 + i1;
                            outputList.Add(output);
                            i0 = i1;
                            i1 = output;
                        }
                        return outputList;
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Error", e);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Error", e);
            }
            //catch (Exception e)
            //{
            //    if (input < 0)
            //    {
            //        throw new Exception("Invalid input - please use positive integer values only.", e);
            //    }
            //    else
            //    {
            //        if (input > 100)
            //        {
            //            throw new Exception("Invalid input - please use a value equal or less than 100.", e);
            //        }
            //    }
            //}
            return outputList;
            }
    }
}
