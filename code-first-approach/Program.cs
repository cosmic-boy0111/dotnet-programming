using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first_approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1 model1Object = new Model1(); /// constructor gets executed
            PratitiDemoEntity entityObject = new PratitiDemoEntity() {
                Id = 1001,
                Name = "Jojo",
            };

            model1Object.pratitiDemoEntities.Add(entityObject);
            model1Object.SaveChanges(); 

            Console.WriteLine("press any key to continue : ");
            Console.ReadKey();
        }
    }
}

/*
 * Need of the hour:
 *      to Develop a distributed component that can be:-
 *              Accessed by anyone across the globe
 *              
 *              Accessed by application irrespective of their development lang
 *              
 *      API:
 *              Development using any pro lang
 *              
 *              Deployed on a web server enabling users across the globe
 *              to access and consume the same
 *              
 *              Return data in XML/JSON format which is readable by any application
 *              irrespective of tech/lang
 *      
 *      The working of web api is as follows
 *              1. the request from the browser comes to "Controller" first
 *              2. From Controller the required methods gets invoked
 *              3. if the result of the request needs information from a databse
 *                 then data is collected with the help of "Model"
 *              4. once the data is collected, result is returned back to the
 *                 browser in the "JSON" or "XML" format.
 *              5. if there is no need to pick data from a databse, then whatever
 *                 information needs to be returned, is returned in the "JSON" or "XML" format.
 *                 
 *                 
 *                 
 *              create controller
 *              
 *              controller > new controller > web api >web api 2 controller - Empty
 *                  -> add
 *                  -> Controller Name -> add
 *                  
 *                 
 *              
 * 
 */
