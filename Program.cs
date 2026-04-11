namespace HMS_VERSION2
{
    internal class Program
    {

        // System Storage

        static string[] patientNames = new string[100];
        static string[] patientIDs = new string[100];
        static string[] diagnoses = new string[100];
        static bool[] admitted = new bool[100];
        static string[] assignedDoctors = new string[100];
        static string[] departments = new string[100];
        static int[] visitCount = new int[100];
        static double[] billingAmount = new double[100];
        static DateTime[] lastVisitDate = new DateTime[100];
        static DateTime[] lastDischargeDate = new DateTime[100];
        static int[] daysInHospital = new int[100];
        static string[] bloodType = new string[100];

        static int lastIndex = 0;


        /// ///////////////////////////////////////////////////////////////
        /// </summary>



        // Seed Data
        static public void seedData()
        {

            patientNames[lastIndex] = "Ali Hassan";
            patientIDs[lastIndex] = "P001";
            diagnoses[lastIndex] = "Flu";
            departments[lastIndex] = "General";
            admitted[lastIndex] = false;
            assignedDoctors[lastIndex] = "";
            visitCount[lastIndex] = 2;
            billingAmount[lastIndex] = 0;
            lastVisitDate[lastIndex] = DateTime.Parse("2025-01-10");
            lastDischargeDate[lastIndex] = DateTime.Parse("2025 - 01 - 15");
            daysInHospital[lastIndex] = 12;
            bloodType[lastIndex] = "A+";



            lastIndex++;

            patientNames[lastIndex] = "Sara Ahmed";
            patientIDs[lastIndex] = "P002";
            diagnoses[lastIndex] = "Fracture";
            departments[lastIndex] = "Orthopedics";
            admitted[lastIndex] = true;
            assignedDoctors[lastIndex] = "Dr. Noor";
            visitCount[lastIndex] = 4;
            billingAmount[lastIndex] = 0;
            lastVisitDate[lastIndex] = DateTime.Parse("2025-03-02");
            lastDischargeDate[lastIndex] = DateTime.Parse("2025-01-15");
            daysInHospital[lastIndex] = 8;
            bloodType[lastIndex] = "O-";

            lastIndex++;

            patientNames[lastIndex] = "Omar Khalid";
            patientIDs[lastIndex] = "P003";
            diagnoses[lastIndex] = "Diabetes";
            departments[lastIndex] = "Cardiology";
            admitted[lastIndex] = false;
            assignedDoctors[lastIndex] = "";
            visitCount[lastIndex] = 1;
            billingAmount[lastIndex] = 0;
            lastVisitDate[lastIndex] = DateTime.Today;
            lastDischargeDate[lastIndex] = DateTime.Parse("2024-12-28");
            daysInHospital[lastIndex] = 5;
            bloodType[lastIndex] = "B+";
        }
        ////////////////////////////////////////////////////////////////////


        static public void displayMenu()
        {

            Console.WriteLine("===== Healthcare Management System =====");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1.  Register New Patient");  //1 easy
            Console.WriteLine("2.  Admit Patient");//4 easy
            Console.WriteLine("3.  Discharge Patient");
            Console.WriteLine("4.  Search Patient"); //2 easy
            Console.WriteLine("5.  List All Admitted Patients"); //3 easy
            Console.WriteLine("6.  Transfer Patient to Another Doctor");
            Console.WriteLine("7.  View Most Visited Patients");
            Console.WriteLine("8.  Search Patients by Department");
            Console.WriteLine("9.  Billing Report");
            Console.WriteLine("10. Exit");
            Console.Write("Choose option: ");

        }

        static public string RegisterPatient(string name, string Diagnosise,
                                           string Departments, string bloodTypes)
        {
            lastIndex++;
            Console.WriteLine("Register the new patient");



            patientNames[lastIndex] = name;
            diagnoses[lastIndex] = Diagnosise;
            departments[lastIndex] = Departments;
            bloodType[lastIndex] = bloodTypes;

            string patientId = string.Format("P{0:D3}", lastIndex);
            patientIDs[lastIndex] = patientId;
            admitted[lastIndex] = false;
            assignedDoctors[lastIndex] = "";
            visitCount[lastIndex] = 0;
            billingAmount[lastIndex] = 0;

            lastVisitDate[lastIndex] = DateTime.Now;
            lastDischargeDate[lastIndex] = DateTime.Now;
            daysInHospital[lastIndex] = 0;


            Console.WriteLine("Patient registered successfully :");

            return patientId;







        }
        static public int SearchPatient(string searchInput)
        {


            int pateintFound = -1;

            for (int i = 0; i <= lastIndex; i++)
            {
                if (patientNames[i] == searchInput || patientIDs[i] == searchInput)
                {
                    pateintFound = i;
                    break;
                }
            }
            return pateintFound;



        }


        static public void PrintPatientDetails(int searchFound);

        static void AdmitPatient()
        {
            Console.Write("Enter Patient ID: ");
            string input = Console.ReadLine();

            for (int i = 0; i <= lastIndex; i++)
            {
                if (patientIDs[i] == input)
                {
                    admitted[i] = true;
                    Console.WriteLine("Patient admitted");
                }
            }
        }

        static void DischargePatient();
        {
        Console.Write("Enter Patient ID or Name: ");
        string dischargeInput = Console.ReadLine();
        for (int i = 0; i <= lastIndex; i++)
{
    if (patientNames[i] == dischargeInput || patientIDs[i] == dischargeInput)
            if (admitted[i] == true)
            billingAmount[i] += fee;
           visitCharges += fee;
        Console.WriteLine("Patient discharged successfully!");
        
        
        
        
        
        }



        static void Main(string[] args)//  //startig point
        {
            seedData();

            bool exit = false;

            while (exit == false) {

                displayMenu();


                Console.WriteLine("choose option");
                int choice = 0;

                try
                {

                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid input. Please choose a number from 1 to 10.");
                }

                switch (choice)
                {

                    case 1: // Register New Patient


                        Console.Write("Patient name: ");
                        string patientName = Console.ReadLine().Trim();

                        Console.Write("Diagnosis: ");
                        string Diagnosise = Console.ReadLine().Trim();

                        Console.Write("Department: ");
                        string Department = Console.ReadLine();

                        Console.Write("blood Type: ");
                        string bloodTypes = Console.ReadLine().ToUpper();



                        string Pid = RegisterPatient(patientName, Diagnosise,
                                                Department, bloodTypes);

                        Console.WriteLine("Generated the patient ID:" + Pid);









                        break;

                    case 2: // Admit Patient

                        AdmitPatient();
                        Console.Write("Enter Patient ID or Name: ");
                        string admitInput = Console.ReadLine();
                        Console.Write("Enter the admittion date: ");
                        DateTime admissionDate = DateTime.Now;

                        string formattedAdmission = admissionDate.ToString("yyyy-MM-dd HH:mm");


                        Console.WriteLine("Admitted on: " + formattedAdmission);

                        bool admitFound = false;

                        for (int i = 0; i <= lastIndex; i++)
                        {
                            if (patientNames[i] == admitInput || patientIDs[i] == admitInput)
                            {
                                admitFound = true;

                                if (admitted[i] == false)
                                {
                                    Console.Write("Doctor Name: ");
                                    assignedDoctors[i] = Console.ReadLine();

                                    admitted[i] = true;
                                    visitCount[i]++;





                                    lastDischargeDate[i] = DateTime.Now;

                                    Console.WriteLine("Patient admitted successfully and assigned to " + assignedDoctors[i]);
                                    Console.WriteLine("Recorded admission date: " + admissionDate);

                                    if (visitCount[i] == 1)
                                    {
                                        Console.WriteLine("Patient has been admitted for the first time.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient has been admitted " + visitCount[i] + " times.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Patient is already admitted under " + assignedDoctors[i]);
                                }

                                break;
                            }
                        }


                        if (admitFound == false)
                        {
                            Console.WriteLine("Patient not found");
                        }

                        break;

                    case 3: // Discharge Patient


                        DischargePatient();


                        Console.Write("Enter Patient ID or Name: ");
                        string dischargeInput = Console.ReadLine();

                        bool dischargeFound = false;

                        for (int i = 0; i <= lastIndex; i++)
                        {
                            if (patientNames[i] == dischargeInput || patientIDs[i] == dischargeInput)
                            {
                                dischargeFound = true;

                                if (admitted[i] == true)
                                {
                                    double visitCharges = 0;

                                    if (visitCharges > 0)
                                    {
                                        billingAmount[i] += visitCharges;
                                        Console.WriteLine("Patient's running total: " + Math.Round(billingAmount[i], 2) + " OMR");
                                        Console.WriteLine("Total charges added this visit: " + Math.Round(visitCharges, 2));
                                    }
                                    else
                                    {
                                        Console.WriteLine("No charges recorded for this visit");
                                    }

                                    Console.Write("Enter discharge date (YYYY-MM-DD): ");
                                    string dischargeDateInput = Console.ReadLine();

                                    if (DateTime.TryParse(dischargeDateInput, out DateTime dischargeDate))
                                    {
                                        lastDischargeDate[i] = dischargeDate;
                                    }

                                    Console.Write("Enter number of days spent in hospital: ");
                                    if (int.TryParse(Console.ReadLine(), out int daysThisVisit))
                                    {
                                        daysInHospital[i] += daysThisVisit;
                                    }
                                    Console.WriteLine("Updated total days in hospital: " + daysInHospital[i]);

                                    Console.Write("Was there a consultation fee? (yes/no): ");
                                    string hasFee = Console.ReadLine().ToLower();

                                    if (hasFee == "yes")
                                    {
                                        Console.Write("Enter consultation fee amount: ");
                                        if (double.TryParse(Console.ReadLine(), out double fee) && fee > 0)
                                        {
                                            billingAmount[i] += fee;
                                            visitCharges += fee;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid amount entered. No charge added.");
                                        }
                                    }

                                    Console.Write("Any medication charges? (yes/no): ");
                                    string hasMeds = Console.ReadLine().ToLower();

                                    if (hasMeds == "yes")
                                    {
                                        Console.Write("Enter medication charges amount: ");
                                        if (double.TryParse(Console.ReadLine(), out double meds) && meds > 0)
                                        {
                                            billingAmount[i] += meds;
                                            visitCharges += meds;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid amount entered. No charge added.");
                                        }
                                    }

                                    if (visitCharges > 0)
                                    {
                                        Console.WriteLine("Total charges added this visit: " + Math.Round(visitCharges, 2) + " OMR");
                                        Console.WriteLine("Patient's running total: " + Math.Round(billingAmount[i], 2) + " OMR");
                                        Console.WriteLine("Total daysInHospital: " + daysInHospital[i]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No charges recorded for this visit");
                                    }

                                    admitted[i] = false;
                                    assignedDoctors[i] = "";

                                    Console.WriteLine("Patient discharged successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("This patient is not currently admitted");
                                }

                                break;
                            }
                        }

                        if (dischargeFound == false)
                        {
                            Console.WriteLine("Patient not found");
                        }
                        break;
                    case 4: // Search Patient

                        Console.Write("Enter Patient ID or Name: ");
                        string searchInput = Console.ReadLine().ToUpper();

                        int searchFound = SearchPatient(searchInput);

                        if (searchFound == -1)
                        {
                            Console.WriteLine("Patient not found");
                        }
                        else
                        {
                            PrintPatientDetails(int searchFound);
                        }

                        break;








                    case 5: // List All Admitted Patients
                        Console.WriteLine("Currently Admitted Patients:");
                        Console.WriteLine("----------------------------------------");
                        Console.Write("Filter by name keyword (press Enter to skip): ");
                        string keyword = Console.ReadLine().ToLower();

                        bool hasAdmitted = false;
                        int admittedCount = 0;
                        double highestbilling = 0;


                        for (int i = 0; i <= lastIndex; i++)
                        {
                            if (admitted[i] == true)

                            {
                                Console.WriteLine("Name: " + patientNames[i] + " | ID: " + patientIDs[i] + " | Diagnosis: " + diagnoses[i] + " | Department: " + departments[i] + " | Doctor: " + assignedDoctors[i] + " + lastVisitDate[i] Admitted Since: " + lastVisitDate[i]);
                                hasAdmitted = true;
                                admittedCount++;
                                highestbilling = Math.Max(highestbilling, billingAmount[i]);

                                if (hasAdmitted == false)
                                {
                                    Console.WriteLine("No patients currently admitted");
                                }
                                else
                                {
                                    Console.WriteLine("Total admitted patients found: " + admittedCount);
                                    Console.WriteLine("Highest billing among admitted patients: " + Math.Round(highestbilling, 2) + " OMR");
                                }
                            }
                        }



                        break;

                    case 6: // Transfer Patient to Another Doctor
                        Console.Write("Enter current doctor name: ");
                        string currentDoctor = Console.ReadLine().Trim();
                        currentDoctor = currentDoctor.Replace("Dr ", "Dr. ");

                        Console.Write("Enter new doctor name: ");
                        string newDoctor = Console.ReadLine().Trim();
                        newDoctor = newDoctor.Replace("Dr ", "Dr. ");

                        if (currentDoctor == newDoctor)
                            Console.WriteLine("The new doctor must be different than current doctor");


                        bool doctorFound = false;

                        for (int i = 0; i <= lastIndex; i++)
                        {
                            if (assignedDoctors[i] == currentDoctor && admitted[i] == true)
                            {
                                doctorFound = true;
                                assignedDoctors[i] = newDoctor;
                                Console.WriteLine("Patient '" + patientNames[i] + "' has been transferred to " + newDoctor);
                                Console.WriteLine("Patient last admitted on: " + lastVisitDate[i]);
                                break;
                            }
                        }

                        if (doctorFound == false)
                        {
                            Console.WriteLine("No admitted patients found under this doctor");
                        }

                        break;

                    case 7: // View Most Visited Patients
                        Console.WriteLine("Most Visited Patients (by visit count):");
                        Console.WriteLine("----------------------------------------");

                        int[] tempVisits = new int[100];

                        for (int i = 0; i <= lastIndex; i++)
                        {
                            tempVisits[i] = visitCount[i];
                        }

                        for (int pass = 0; pass <= lastIndex; pass++)
                        {
                            int maxIndex = 0;

                            for (int i = 0; i <= lastIndex; i++)
                            {
                                if (tempVisits[i] > tempVisits[maxIndex])
                                {
                                    maxIndex = i;
                                }
                            }

                            Console.WriteLine("ID: " + patientIDs[maxIndex] + " | Name: " + patientNames[maxIndex] + " | Visits: " + tempVisits[maxIndex]);

                            tempVisits[maxIndex] = -1;
                        }

                        break;


                    case 8: // Search Patients by Department
                        Console.Write("Enter department name: ");
                        string searchDept = Console.ReadLine().Trim();

                        bool deptFound = false;

                        Console.WriteLine("Patients in department '" + searchDept + "':");
                        Console.WriteLine("----------------------------------------");

                        for (int i = 0; i <= lastIndex; i++)
                        {
                            if (departments[i].IndexOf(searchDept, StringComparison.OrdinalIgnoreCase) >= 0)//here we can use part of name no need to enter the full of the deparment
                                if (departments[i].ToLower() == searchDept.ToLower())
                                {
                                    deptFound = true;


                                    string status = admitted[i] ? "Admitted" : "Not Admitted"; //ternary operator
                                    string displayDiagnosis;
                                    if (diagnoses[i].Length > 15)
                                    {
                                        displayDiagnosis = diagnoses[i].Substring(0, 15) + "...";
                                    }
                                    else
                                    {
                                        displayDiagnosis = diagnoses[i];
                                    }


                                    //string stat;
                                    //if (admitted[i] == true)
                                    //    stat = "admitted";
                                    //else
                                    //    stat = "not admitted";


                                    Console.WriteLine("ID: " + patientIDs[i] + " | Name: " + patientNames[i] + " | Diagnosis: " + diagnoses[i] + " | Status: " + status + "| Blood Type: " + bloodType[i]);
                                }
                        }

                        if (deptFound == false)
                        {
                            Console.WriteLine("No patients found in this department");
                        }

                        break;
                

                    case 9: // Billing Report

                        //part1:system-wide total
                        Console.WriteLine("Billing Report:");
                        Console.WriteLine("1. System-wide total");
                        Console.WriteLine("2. Individual patient");
                        Console.Write("Choose option: ");

                        int billingOption = 0;
                        try
                        {
                            billingOption = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)

                        { Console.WriteLine("Error: " + ex.Message); }


                        if (billingOption == 1)
                        {
                            double totalBilling = 0;

                            for (int i = 0; i <= lastIndex; i++)
                            {
                                totalBilling += billingAmount[i];
                            }

                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Total billing collected: " + Math.Round(totalBilling, 2) + " OMR");
                        }
                        else if (billingOption == 2)
                        {

                            //part2:individual system

                            Console.Write("Enter Patient ID or Name: ");
                            string billingInput = Console.ReadLine();

                            int billingFound = SearchPatient(billingInput);

                            if (billingFound == -1)
                            {
                                Console.WriteLine("No billing records found for this patient");

                            }
                            else

                            {


                                Console.WriteLine(billingAmount[billingFound]);

                            }

                            break;
                        }      

                        case 10: // Exit
                                        Console.WriteLine("Are you sure you want to exit:(true/false)");
                                        string Confirm = Console.ReadLine().ToLower();
                                        if (Confirm == "true")
                                        {

                                            Console.WriteLine("Exiting system...");
                                            Console.WriteLine("Thank you for using the Healthcare Management System!");
                                            Console.WriteLine("----------------------------------------");
                                            exit = true;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Returning to menu");
                                        }

                                        break;




                                    default:
                                        Console.WriteLine("Invalid option. Please try again.");
                                        break;
                                    }

                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                            }
                        }
                }
            
        
    

            
        
    


