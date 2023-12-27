using databse_first_approach_create_table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_first_approach_create_table
{
    public class Program
    {

        public static List<PratitiTask> getDatabseData()
        {
            Model1Container containerObject = new Model1Container();
            Random r = new Random();
            PratitiTask task = new PratitiTask() { 
                PratitiTaskId = r.Next(1,10000),
                PratitiTaskHeading = "Task 1",
                PratitiTaskDescription = "This is the first task",
                PratitiTaskAssignedBy = "Gaurav Bhagat",
                PratitiTaskAssignedDate = DateTime.Now,
                PratitiTaskAssignedTo = "Aradhya kamlakar",
                PratitiTaskDays = 1,
                PratitiTaskDeadLineDate = new DateTime(2023, 12, 25)
            };

            containerObject.PratitiTasks.Add(task);
            containerObject.SaveChanges();

            var allTaskDetails = from record in containerObject.PratitiTasks
                                 select record;

            List<PratitiTask> list= new List<PratitiTask>();
            foreach (var record in allTaskDetails)
            {
                list.Add(record);
            }
            return list;
        }

      
    }
}


// table by name Pratiti Task
/* Coloumn Name                 Type                Constrains
 * PratitiTaskId                int                 primary key
 * PratitiTaskHeading           String
 * PratitiTaskDescription       String
 * PratitiTaskAssignedBy        String
 * PratitiTaskAssignedTo        String
 * PratitiTaskAssignedDate      DateTime
 * PratitiTaskDays              int
 * PratitiTaskDeadLineDate      DateTime
 * 
 * 
 */