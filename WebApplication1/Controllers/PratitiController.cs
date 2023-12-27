using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PratitiController : ApiController
    {

        List<PratitiEmp> allEmployees;

        public PratitiController()
        {
            this.allEmployees = new List<PratitiEmp>() { 
                new PratitiEmp()
                {
                    EmpId = 101,
                    EmpName = "Gaurav",
                    EmpAge = 21,
                    EmpCity = "Amravati"
                },
                new PratitiEmp()
                {
                    EmpId = 102,
                    EmpName = "Aradhya",
                    EmpAge = 22,
                    EmpCity = "Mumbai"
                },
                new PratitiEmp()
                {
                    EmpId = 103,
                    EmpName = "Prem",
                    EmpAge = 35,
                    EmpCity = "Aurangabad"
                }
            };

        }

        public IHttpActionResult getAllRecords()
        {
            return Ok(this.allEmployees.ToList());
        }

        public IHttpActionResult addFreshEmployee(PratitiEmp empItem)
        {
            int oldRecordCount = this.allEmployees.Count;
            this.allEmployees.Add(empItem);
            string transactionMessage = "Record Not Added";
            if(oldRecordCount < this.allEmployees.Count)
            {
                transactionMessage = "Record added Successfully";
            }
            return Ok(transactionMessage);
        }

        [HttpPost]
        public IHttpActionResult addFreshEmployeesBulk([FromBody] List<PratitiEmp> empItem)
        { 
            int oldRecordCount = this.allEmployees.Count;
            foreach(PratitiEmp item in empItem)
            {
                this.allEmployees.Add(item);

            }
            string transactionMessage = "Bulk Record Not Added";
            if (oldRecordCount < this.allEmployees.Count)
            {
                transactionMessage = "Bulk Record added Successfully";
            }
            return Ok(transactionMessage);
        }

    }
}

/*
 * js provides us with an object call "XMLHttpRequest"
 * 
 * we actually create as object of type "XMLHttpRequest".
 * 
 * that object get references of certain properties, methods and events.
 * 
 * 
 * 1.   the first method to be used is "Open" method
 *      "Open" method takes following argument(s):-
 *          1.  GET/POST
 *          2.  Url where api is hosted
 *          3.  sybchronous or asynchronous call (optional)
 *          4.  Username (optional)
 *          5.  Password (optional)
 *          
 * 2.   the second method to be used is "Send" method.
 *      this method establishes connection between client and server/API
 *      
 * Important Properties :-
 *      1.  readyState      ->  Values form 0 to 4
 *      2.  status          ->  values form 100 to 5XX
 *      3.  responseText    ->  Content form api
 *      
 * Important Events :-
 *      1.  onreadstatechange   ->  fires every time whenever a mothod is 
 *                                  invoked as a result it chnages the value
 *                                  of "readyState" property.
 *     
 * 
 */
