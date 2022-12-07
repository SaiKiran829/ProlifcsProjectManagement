using System;


//Main Class
public class ProlificsProjectManagement
{


    public static void Main(string[] args)
    {
        Console.WriteLine("             ==========Hello Prolifics employee==========");
        Console.WriteLine("");
        Console.Write("Enter \"1\" for adding project               ");
        Console.WriteLine("Enter \"2\" to show all projects");
        Console.WriteLine("");
        Console.Write("Enter \"3\" for adding Employee              ");
        Console.WriteLine("Enter \"4\" for viewing all Employees");
        Console.WriteLine("");
        Console.Write("Enter \"5\" for adding Role                  ");
        Console.WriteLine("Enter \"6\" for viewing all Roles");
        Console.WriteLine("");
        Console.Write("Enter \"7\" for searching project            ");
        Console.WriteLine("Enter \"8\" for searching project through id");
        Console.WriteLine("");
        Console.WriteLine("Enter \"9\" to view all projects");
        Console.WriteLine("");
        Console.WriteLine("                           Enter \"x\" to exit application");
        ProjectManagement obj = new ProjectManagement();
        EmpManagement obj1 = new EmpManagement();
        RoleManagement objmain = new RoleManagement();
        AddingEmptoProject obj3 = new AddingEmptoProject();
        objmain.RoleList.Add(new Role(1, "Software Engineer"));
        objmain.RoleList.Add(new Role(2, "Associate Software Engineer"));
        objmain.RoleList.Add(new Role(3, "Trainee Software Engineer"));
        objmain.RoleList.Add(new Role(4, "Technical Lead"));


        Console.WriteLine("");
        var read = Console.ReadLine();
        while (true)
        {
            switch (read)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    try
                    {
                        Console.WriteLine("Enter Project Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name of project");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string start = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string end = Console.ReadLine();
                        Project project = new Project(name, start, end, id);
                        obj.AddingProjects(project);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Added Successfully!");
                        Console.WriteLine("");
                        Console.WriteLine("Enter any key to get to main menu");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nError : Only use numbers for id");

                    }

                    break;
                case "2":
                    obj.displayAllProjects();
                    break;



                case "3":

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter the Id of employee");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter employee first name");
                    var fname = Console.ReadLine();
                    Console.WriteLine("Enter employee last name");
                    var lname = Console.ReadLine();
                    Console.WriteLine("Enter employee email id");
                    var EMAIL = Console.ReadLine();
                    Console.WriteLine("Enter employee mobile number");
                    var mobile = Console.ReadLine();
                    Console.WriteLine("Enter address of the employee");
                    var address = Console.ReadLine();
                    Console.WriteLine("Select 1 for assinging employee with new role name and new role id");
                    Console.WriteLine("Select 2 for assinging existing role to the employee");
                    int selecting = Convert.ToInt32(Console.ReadLine());
                    if (selecting == 1)
                    {
                        try
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Enter the Role Id");
                            int roleID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the name of Role");
                            string role_name = Console.ReadLine();
                            Console.WriteLine(role_name);
                            Role newRole = new Role(roleID, role_name);
                            objmain.RoleAdd(newRole);
                            Employee yadding = new Employee(empId, fname, lname, EMAIL, mobile, address, roleID, role_name);
                            obj1.AddEmp(yadding);
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Added Successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Role Id can only be in numbers");
                        }
                    }
                    else if (selecting == 2)
                    {
                        try
                        {
                            objmain.displayRole();
                            Console.WriteLine("Select Role id from above list to assign role to employee");
                            int role1 = Convert.ToInt32(Console.ReadLine());
                            string? roleNAME1 = null;
                            switch (role1)
                            {
                                case 1:
                                    roleNAME1 = "Software Engineer";
                                    break;
                                case 2:
                                    roleNAME1 = "Associate Software Engineer";
                                    break;
                                case 3:
                                    roleNAME1 = "Trainee Software Engineer";
                                    break;
                                case 4:
                                    roleNAME1 = "Technical Lead";
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry");
                                    break;
                            }
                            Employee emp = new Employee(empId, fname, lname, EMAIL, mobile, address, role1, roleNAME1);
                            obj1.AddEmp(emp);
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Added Successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Emp id can only be in numbers");
                        }
                    }
                            
                            Console.WriteLine("");
                            Console.WriteLine("Enter any key to get to main menu");
                            Console.ReadLine();
                            break;
                case "4":
                    obj1.ShowEmp();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Enter the Role Id");
                        int roleID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name of Role");
                        string role_name = Console.ReadLine();
                        Console.WriteLine(role_name);
                        Role newRole = new Role(roleID, role_name);
                        objmain.RoleAdd(newRole);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Added Successfully!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Role Id can only be in numbers");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "6":
                    objmain.displayRole();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine("Type to search for project");
                    read = Console.ReadLine();
                    obj.SearchProject(read);
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "8":
                    try
                    {
                        Console.WriteLine("Search via project id");
                        Console.WriteLine("Enter the id of project");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        obj.ShowProject(eid);
                        Console.WriteLine();
                        Console.WriteLine("Enter any key to get to main menu");
                    }
                    catch (Exception e) { Console.WriteLine("Id can only be in numbers"); }
                    break;

                case "9":
                    obj.displayAllProjects();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "10":

                    Console.WriteLine("");
                    obj.displayAllProjects();
                    Console.WriteLine("Above are the available projects");
                    Console.WriteLine();
                    obj1.ShowEmp();
                    Console.WriteLine("Above are the available employees");
                    Console.WriteLine("Enter the Name of the project from above list exactly");
                    var PROJname = Console.ReadLine();
                    Console.WriteLine("Enter the id of employee to add into project");
                    int EMPID = Convert.ToInt32(Console.ReadLine());
                    AddEmptoProject ADDTOPROJ = new AddEmptoProject();
                    Project ADDTOPROJ1 = new Project();
                    Employee EMPIDD = new Employee();
                    if(PROJname == ADDTOPROJ1.ProjectName && int.TryParse(EMPID, out int EmployeeID))
                    {
                        AddEmptoProject YADD = new AddEmptoProject(PROJname, EMPID);
                        AddingEmptoProject addition = new AddingEmptoProject();
                        addition.addingemp(YADD);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry bro");
                    }
                    var Read = Console.ReadLine();
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                          ======LIST======");
            Console.WriteLine("");
            Console.Write("Enter \"1\" for adding project               ");
            Console.WriteLine("Enter \"2\" to show all projects");
            Console.WriteLine("");
            Console.Write("Enter \"3\" for adding Employee              ");
            Console.WriteLine("Enter \"4\" for viewing all Employees");
            Console.WriteLine("");
            Console.Write("Enter \"5\" for adding Role                  ");
            Console.WriteLine("Enter \"6\" for viewing all Roles");
            Console.WriteLine("");
            Console.Write("Enter \"7\" for searching project            ");
            Console.WriteLine("Enter \"8\" for searching project through id");
            Console.WriteLine("");
            Console.WriteLine("Enter \"9\" to view all projects");
            Console.WriteLine("");
            Console.WriteLine("                           Enter \"x\" to exit application");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select operation from above list");
            read = Console.ReadLine();
        }
    }

}

//project class
public class Project
{
    public string ProjectName { get; set; }
    public string Startdate { get; set; }
    public string Enddate { get; set; }
    public int? id { get; set; }


    public Project(string projectname, string startdate, string enddate, int Id)
    {
        this.ProjectName = projectname;
        this.Startdate = startdate;
        this.Enddate = enddate;
        this.id = Id;
    }
    public Project()
    {

    }


}

//Class which consists of methods for adding and viewing projects
public class ProjectManagement
{
    public List<Project> Projects = new List<Project>();

    //Method for adding projects
    public void AddingProjects(Project project)
    {
        Projects.Add(project);
    }
    public void displayProject(Project project)
    {
        Console.WriteLine(" Name of the project - " + project.ProjectName + "\n Project Id - " + project.id + "\n Start date of project - " + project.Startdate + "\n End date of project - " + project.Enddate);
        Console.WriteLine("");
    }

    public void displayAllProjects()
    {
        foreach (var e in Projects)
        {
            displayProject(e);
        }
    }

    //Method to view all projects
    public void ShowProject(int eid)
    {
        foreach (Project e in Projects)
        {

            if (e.id == eid)
            {
                Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n End date of project - " + e.Enddate);
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }

    public void SearchProject(string search)
    {
        var match = Projects.Where(c => c.ProjectName.Contains(search));
        foreach (var e in match)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n End date of project - " + e.Enddate);
        }
    }
}

//Employee class
public class Employee
{
    public int EmployeeID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string mobile { get; set; }
    public string address { get; set; }
    public int roleid { get; set; }
    public string roleName { get; set; }


    public Employee(int empid, string FirstName, string LastName, string Email, string Mobile, string Address, int ROleID, string ROlename)
    {
        EmployeeID = empid;
        firstName = FirstName;
        lastName = LastName;
        email = Email;
        mobile = Mobile;
        address = Address;
        roleid = ROleID;
        roleName = ROlename;
    }

    public Employee()
    {

    }

}

//Class which consists of methods for adding and viewing Employees
public class EmpManagement
{
    public List<Employee> empList = new List<Employee>();

    //Method for adding new employee
    public void AddEmp(Employee emp)
    {
        empList.Add(emp);
    }


    public void displayEmp(Employee emp)
    {
        Console.WriteLine(" Employee Id - " + emp.EmployeeID + "\n Employee first name - " + emp.firstName + "\n Employee last name - " + emp.lastName + "\n Employee email id - " + emp.email + "\n Employee mobile number - " + emp.mobile + "\n Employee address - " + emp.address + "\n Role Id - " + emp.roleid + "\n Role Name - " + emp.roleName);
        Console.WriteLine("");
        Console.WriteLine("");
    }

    //Method for viewing all employees
    public void ShowEmp()
    {
        foreach (var e in empList)
        {
            displayEmp(e);
        }
    }

    public void ShowEmployee(int eid)
    {
        foreach (Employee e in empList)
        {

            if (e.EmployeeID == eid)
            {
                Console.WriteLine(" Name of the Employee - " + e.firstName + " " + e.lastName + "\n Employee Id - " + e.EmployeeID);
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }
}

//Role class
public class Role
{
    public string RoleName { get; set; }
    public int RoleId { get; set; }

    public Role(int roleid, string roleName)
    {
        RoleName = roleName;
        RoleId = roleid;
    }
    
}

//Class which consists of methods for adding and viewing roles
public class RoleManagement
{


    public List<Role> RoleList = new List<Role>();



    //Method for adding roles
    public void RoleAdd(Role role)
    {
        RoleList.Add(role);
    }

    //Method for viewing all roles
    public void displayRole()
    {
        foreach (var e in RoleList)
        {
            Console.WriteLine(" Name of the Role - " + e.RoleName + "\n Role Id - " + e.RoleId);
            Console.WriteLine();
        }
    }

}

public class AddEmptoProject
{

    public string ProjectName { get; set; }
    public int EmployeeID { get; set; }
    Project projecting = new Project();
    Employee employing = new Employee();
    public AddEmptoProject(string projectName, int employeeID)
    {

        this.ProjectName = projectName;
        projectName = projecting.ProjectName;
        this.EmployeeID = employeeID;
        employeeID = employing.EmployeeID;
    }

    public AddEmptoProject()
    {

    }
}

public class AddingEmptoProject
{
    public List<AddEmptoProject> AddingEmplist = new List<AddEmptoProject>();

    public void addingemp(AddEmptoProject add)
    {
        AddingEmplist.Add(add);
    }
    
    public void displayingemp()
    {
        foreach (var e in AddingEmplist)
        {
            Console.WriteLine(e.ProjectName);
        }
    }
}
