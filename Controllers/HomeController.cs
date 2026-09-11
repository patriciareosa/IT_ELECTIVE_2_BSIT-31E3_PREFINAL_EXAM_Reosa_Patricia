using IT_ELECTIVE_2_BSIT_31E3_PREFINAL_EXAM_Reosa_Patricia.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_BSIT_31E3_PREFINAL_EXAM_Reosa_Patricia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Number = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    ChoiceA = "It makes C# code shorter",
                    ChoiceB = "It prevents the application from restarting",
                    ChoiceC = "It allows data to persist after the application stops",
                    ChoiceD = "It removes the need for MVC",
                    Answer = "C. It allows data to persist after the application stops"
                },

                new Question
                {
                    Number = 2,
                    QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    ChoiceA = "Code-First",
                    ChoiceB = "Database-First",
                    ChoiceC = "Model-First",
                    ChoiceD = "Controller-First",
                    Answer = "B. Database-First"
                },

                new Question
                {
                    Number = 3,
                    QuestionText = "What is the primary purpose of Entity Framework Core?",
                    ChoiceA = "To create HTML pages automatically",
                    ChoiceB = "To replace the MVC Controller",
                    ChoiceC = "To map objects in code to relational database data",
                    ChoiceD = "To replace the C# compiler",
                    Answer = "C. To map objects in code to relational database data"
                },

                new Question
                {
                    Number = 4,
                    QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                    ChoiceA = "DbContext",
                    ChoiceB = "DbSetView",
                    ChoiceC = "ControllerContext",
                    ChoiceD = "RazorContext",
                    Answer = "A. DbContext"
                },

                new Question
                {
                    Number = 5,
                    QuestionText = "What does the dotnet ef dbcontext scaffold command primarily do?",
                    ChoiceA = "Deletes the database",
                    ChoiceB = "Creates a new MVC project",
                    ChoiceC = "Generates EF Core models and a DbContext from an existing database",
                    ChoiceD = "Starts the MVC application",
                    Answer = "C. Generates EF Core models and a DbContext from an existing database"
                },

                new Question
                {
                    Number = 6,
                    QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    ChoiceA = "Program.cs only",
                    ChoiceB = "appsettings.json",
                    ChoiceC = "Index.cshtml",
                    ChoiceD = "Student.cs",
                    Answer = "B. appsettings.json"
                },

                new Question
                {
                    Number = 7,
                    QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    ChoiceA = "One-to-One",
                    ChoiceB = "One-to-Many",
                    ChoiceC = "Many-to-Many",
                    ChoiceD = "Many-to-One only",
                    Answer = "B. One-to-Many"
                },

                new Question
                {
                    Number = 8,
                    QuestionText = "In the given example, what is SectionId?",
                    ChoiceA = "Primary key of Student",
                    ChoiceB = "Foreign key referencing Section",
                    ChoiceC = "Navigation property",
                    ChoiceD = "Database connection string",
                    Answer = "B. Foreign key referencing Section"
                },

                new Question
                {
                    Number = 9,
                    QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    ChoiceA = "It stores the database password",
                    ChoiceB = "It represents a relationship to another entity",
                    ChoiceC = "It creates a new database",
                    ChoiceD = "It validates the student's name",
                    Answer = "B. It represents a relationship to another entity"
                },

                new Question
                {
                    Number = 10,
                    QuestionText = "What does .Include() generally allow EF Core to do?",
                    ChoiceA = "Delete the Section table",
                    ChoiceB = "Load related Section data together with Students",
                    ChoiceC = "Create a new Student",
                    ChoiceD = "Validate Student input",
                    Answer = "B. Load related Section data together with Students"
                },

                new Question
                {
                    Number = 11,
                    QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                    ChoiceA = "To replace the database",
                    ChoiceB = "To combine or shape the data specifically needed by the view",
                    ChoiceC = "To automatically create database tables",
                    ChoiceD = "To prevent controllers from using LINQ",
                    Answer = "B. To combine or shape the data specifically needed by the view"
                },

                new Question
                {
                    Number = 12,
                    QuestionText = "What is the main benefit of Include(s => s.Section)?",
                    ChoiceA = "It loads the related Section navigation property",
                    ChoiceB = "It creates a Section object manually",
                    ChoiceC = "It removes the foreign key",
                    ChoiceD = "It prevents the query from accessing the database",
                    Answer = "A. It loads the related Section navigation property"
                },

                new Question
                {
                    Number = 13,
                    QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                    ChoiceA = "Database-level validation",
                    ChoiceB = "Client-side validation",
                    ChoiceC = "Server-side validation",
                    ChoiceD = "EF Core migration validation",
                    Answer = "B. Client-side validation"
                },

                new Question
                {
                    Number = 14,
                    QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                    ChoiceA = "Client-side validation can be bypassed",
                    ChoiceB = "Client-side validation automatically modifies the database",
                    ChoiceC = "Server-side validation only works with SQLite",
                    ChoiceD = "Client-side validation cannot display messages",
                    Answer = "A. Client-side validation can be bypassed"
                },

                new Question
                {
                    Number = 15,
                    QuestionText = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    ChoiceA = "Student Number should always be nullable",
                    ChoiceB = "Student Number should be unique",
                    ChoiceC = "Student Number should always be the same",
                    ChoiceD = "Student Number should contain only spaces",
                    Answer = "B. Student Number should be unique"
                },

                new Question
                {
                    Number = 16,
                    QuestionText = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                    ChoiceA = "It protects data integrity even if application-level validation is bypassed",
                    ChoiceB = "It makes Razor Views render faster",
                    ChoiceC = "It removes the need for a Controller",
                    ChoiceD = "It automatically creates a ViewModel",
                    Answer = "A. It protects data integrity even if application-level validation is bypassed"
                },

                new Question
                {
                    Number = 17,
                    QuestionText = "What is the purpose of a try...catch block in a controller?",
                    ChoiceA = "To create navigation properties",
                    ChoiceB = "To catch and handle exceptions that may occur during execution",
                    ChoiceC = "To generate database tables",
                    ChoiceD = "To perform client-side validation",
                    Answer = "B. To catch and handle exceptions that may occur during execution"
                },

                new Question
                {
                    Number = 18,
                    QuestionText = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                    ChoiceA = "UseDatabase()",
                    ChoiceB = "UseExceptionHandler()",
                    ChoiceC = "UseValidationHandler()",
                    ChoiceD = "UseMvcDatabase()",
                    Answer = "B. UseExceptionHandler()"
                },

                new Question
                {
                    Number = 19,
                    QuestionText = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                    ChoiceA = "Display the student's information anyway",
                    ChoiceB = "Display a Not Found (404) response/page",
                    ChoiceC = "Delete Student 999",
                    ChoiceD = "Create Student 999 automatically",
                    Answer = "B. Display a Not Found (404) response/page"
                },

                new Question
                {
                    Number = 20,
                    QuestionText = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                    ChoiceA = "Data integrity",
                    ChoiceB = "HTML formatting",
                    ChoiceC = "CSS inheritance",
                    ChoiceD = "Razor syntax",
                    Answer = "A. Data integrity"
                }
            };

            return View(questions);
        }
    }
} 
 
 
  

 