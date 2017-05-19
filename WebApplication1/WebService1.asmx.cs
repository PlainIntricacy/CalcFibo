using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Fibonacci Sequence generator via ASMX Web Service
    /// Tudor Laptes, 05/18/17
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        //Receive an integer input, and return a list of integers.
        public List<int> CalcFibo(int input)
        {
            //Initialize list/sequence of Fibonacci numbers.
            List<int> outputList = new List<int>();
            try
            {
                ///If the input value is less than or equal to 2, verify that it's not less than 0, then
                ///return a list of [0] or [0,1] depending on the value of the input.
                if (input <= 2)
                {
                    if (input < 0)
                    {
                        throw new Exception("Invalid input - Please enter an integer value between 0 and 33.");
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
                    ///If the input value is more than 2, verify that it isn't more than 33 or throw an exception error.
                    ///If the input value is valid, being running through the Fibonacci sequence loop to populate the list
                    ///of Fibonacci numbers.
                    if (input > 33)
                    {
                        throw new Exception("Invalid input - Please enter an integer value between 0 and 33.");
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
            return outputList;
        }
    }
}
