using System;
using System.Numerics;
using static System.Reflection.Metadata.BlobBuilder;

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


        static string[] doctorNames= new string[50];
        static int []doctorAvailableSlots=new int[50];
        static int[] doctorVisitCount=new int[50];


        static int lastDoctorIndex = -1;   

        static int lastIndex = -1;


        /// ///////////////////////////////////////////////////////////////
        /// </summary>



        // Seed Data
        static public void seedData()
           
        {

            lastIndex++;

             lastDoctorIndex = -1;

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
            lastDoctorIndex++;
            doctorNames[lastDoctorIndex] = "Dr. Noor";
            doctorAvailableSlots[lastDoctorIndex] = 5;
            doctorVisitCount[lastDoctorIndex] = 0;


        

           
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

            lastDoctorIndex++;
            doctorNames[lastDoctorIndex] = "Dr. Salem";
            doctorAvailableSlots[lastDoctorIndex] = 3;
            doctorVisitCount[lastDoctorIndex] = 0;




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

            lastDoctorIndex++;
            doctorNames[lastDoctorIndex] = "Dr. Hana";
            doctorAvailableSlots[lastDoctorIndex] = 8;
            doctorVisitCount[lastDoctorIndex] = 0;

           
           

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
            Console.WriteLine("10. Add Doctor");
            Console.WriteLine("11. Doctor Salary Report");
            Console.WriteLine("12. Exit");
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


        static public void PrintPatientDetails(int index)
        {
            Console.WriteLine("Name: " + patientNames[index]);
            Console.WriteLine("ID: " + patientIDs[index]);
            Console.WriteLine("Diagnosis: " + diagnoses[index]);
            Console.WriteLine("Department: " + departments[index]);
        }

        static void AdmitPatient()
        {
            Console.Write("Enter Patient ID or Name: ");
            string input = (Console.ReadLine() ?? "").Trim();

            Console.Write("Enter admitt date (YYYY-MM-DD): ");
            string admittionDateInput = Console.ReadLine();


            int patientIndex = SearchPatient(input);

            if (patientIndex == -1)
            {
                Console.WriteLine("Patient not found");
                return;
            }

            if (admitted[patientIndex])
            {
                Console.WriteLine("Patient already admitted");
                return;
            }

            // Step 1: Doctor validation
            Console.Write("Doctor Name: ");
            string doctorInput = (Console.ReadLine() ?? "").Trim();

            int doctorIndex = -1;

            for (int i = 0; i <= lastDoctorIndex; i++)
            {
                if (doctorNames[i].ToLower() == doctorInput.ToLower())
                {
                    doctorIndex = i;
                    break;
                }
            }

            if (doctorIndex == -1)
            {
                Console.WriteLine("Doctor not found in the system. Please register the doctor first.");
                return;
            }

            //  Step 2: Check slots
            if (doctorAvailableSlots[doctorIndex] <= 0)
            {
                Console.WriteLine("Dr. " + doctorNames[doctorIndex] + " has no available slots at this time.");
                return;
            }

            // Step 3: Admit patient
            admitted[patientIndex] = true;
            visitCount[patientIndex]++;
            assignedDoctors[patientIndex] = doctorNames[doctorIndex];

            doctorAvailableSlots[doctorIndex]--;
            doctorVisitCount[doctorIndex]++;

            lastVisitDate[patientIndex] = DateTime.Now;

            Console.WriteLine("Patient admitted successfully");
            Console.WriteLine("Dr. " + doctorNames[doctorIndex] + " now has " + doctorAvailableSlots[doctorIndex] + " slot(s) remaining.");

        }


        static void DischargePatient()
        {
            Console.Write("Enter Patient ID or Name: ");
            string input = (Console.ReadLine() ?? "").Trim();

            Console.Write("Enter discharge date (YYYY-MM-DD): ");
            string dischargeDateInput = Console.ReadLine();
            

            int patientIndex = SearchPatient(input);

            if (patientIndex == -1)
            {
                Console.WriteLine("Patient not found");
                return;
            }

            if (!admitted[patientIndex])
            {
                Console.WriteLine("Patient is not currently admitted");
                return;
            }
            if (DateTime.TryParse(dischargeDateInput, out DateTime dischargeDate))
            {
                lastDischargeDate[patientIndex] = dischargeDate;
            }
            else
            {
                lastDischargeDate[patientIndex] = DateTime.Now;
            }

            //  Save assigned doctor before clearing
            string assignedDoctor = assignedDoctors[patientIndex];

            int doctorIndex = -1;

            // Find doctor in registry
            for (int i = 0; i <= lastDoctorIndex; i++)
            {
                if (doctorNames[i].ToLower() == assignedDoctor.ToLower())
                {
                    doctorIndex = i;
                    break;
                }
            }

            // Restore slot if found
            if (doctorIndex != -1)
            {
                doctorAvailableSlots[doctorIndex]++;

                Console.WriteLine("Dr. " + doctorNames[doctorIndex] + " now has " + doctorAvailableSlots[doctorIndex] + " slot(s) available.");


                   
              
            }
            else
            {
                Console.WriteLine("Warning: assigned doctor not found in registry. Slots not updated.");
            }

            // Original discharge logic
            double visitCharges = 0;

            Console.Write("Consultation fee: ");
            double fee;
            if (double.TryParse(Console.ReadLine(), out fee))
            {
                visitCharges += fee;
            }

            Console.Write("Medication charges: ");
            double meds;
            if (double.TryParse(Console.ReadLine(), out meds))
            {
                visitCharges += meds;
            }

            billingAmount[patientIndex] += visitCharges;

            admitted[patientIndex] = false;
            assignedDoctors[patientIndex] = "";


            Console.WriteLine("Patient discharged successfully!");
            Console.WriteLine("Total charges added: " + visitCharges);
        }

        static void BillingReport()
        {
            Console.WriteLine("1. System-wide total");
            Console.WriteLine("2. Individual patient");
            Console.Write("Choose: ");

            int option;

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (option == 1)
            {
                double total = 0;

                for (int i = 0; i <= lastIndex; i++)
                {
                    total += billingAmount[i];
                }

                Console.WriteLine("Total billing: " + total);
            }
            else if (option == 2)
            {
                Console.Write("Enter Patient ID or Name: ");
                string input = Console.ReadLine();

                int index = SearchPatient(input);

                if (index == -1)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine("Billing: " + billingAmount[index]);
                }
            }
        }

        static void ListAdmittedPatients()
        {
            Console.WriteLine("Currently Admitted Patients:");
            Console.WriteLine("----------------------------------------");

            bool found = false;
            int count = 0;
            double highestBilling = 0;

            for (int i = 0; i <= lastIndex; i++)
            {
                if (admitted[i])
                {
                    Console.WriteLine(
                        "Name: " + patientNames[i] +
                        " | ID: " + patientIDs[i] +
                        " | Diagnosis: " + diagnoses[i] +
                        " | Department: " + departments[i] +
                        " | Doctor: " + assignedDoctors[i] +
                        " | Last Visit: " + lastVisitDate[i]
                    );

                    found = true;
                    count++;
                    highestBilling = Math.Max(highestBilling, billingAmount[i]);
                }
            }

            if (!found)
            {
                Console.WriteLine("No patients currently admitted");
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Total admitted patients: " + count);
                Console.WriteLine("Highest billing: " + highestBilling + " OMR");
            }
        }

        static void TransferPatientDoctor()
        {
            Console.Write("Enter current doctor name: ");
            string currentDoctor = Console.ReadLine();

            Console.Write("Enter new doctor name: ");
            string newDoctor = Console.ReadLine();

            if (currentDoctor == newDoctor)
            {
                Console.WriteLine("New doctor must be different from current doctor");
                return;
            }

            bool found = false;

            for (int i = 0; i <= lastIndex; i++)
            {
                if (admitted[i] && assignedDoctors[i] == currentDoctor)
                {
                    assignedDoctors[i] = newDoctor;

                    Console.WriteLine("Patient: " + patientNames[i]);
                    Console.WriteLine("Transferred to: " + newDoctor);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No admitted patients found under this doctor");
            }
        }

        static void ViewMostVisitedPatients()
        {
            Console.WriteLine("Most Visited Patients:");
            Console.WriteLine("----------------------------------------");

            bool found = false;

            int[] tempVisits = new int[100];

            for (int i = 0; i <= lastIndex; i++)
            {
                tempVisits[i] = visitCount[i];
            }

            for (int pass = 0; pass <= lastIndex; pass++)
            {
                int maxIndex = -1;
                int maxValue = -1;

                for (int i = 0; i <= lastIndex; i++)
                {
                    if (tempVisits[i] > maxValue)
                    {
                        maxValue = tempVisits[i];
                        maxIndex = i;
                    }
                }

                if (maxIndex == -1 || maxValue == -1)
                    break;

                Console.WriteLine(
                    "ID: " + patientIDs[maxIndex] +
                    " | Name: " + patientNames[maxIndex] +
                    " | Visits: " + tempVisits[maxIndex]
                );

                tempVisits[maxIndex] = -1;
                found = true;
            }

            if (!found)
            {
                Console.WriteLine("No visit data available");
            }
        }
        static void SearchByDepartment()
        {
            Console.Write("Enter department name: ");
            string searchDept = Console.ReadLine() ?? "";

            bool found = false;

            Console.WriteLine("Patients in department:");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i <= lastIndex; i++)
            {
                if (departments[i].ToLower() == searchDept.ToLower())
                {
                    found = true;

                    string status = admitted[i] ? "Admitted" : "Not Admitted";

                    Console.WriteLine(
                        "ID: " + patientIDs[i] +
                        " | Name: " + patientNames[i] +
                        " | Diagnosis: " + diagnoses[i] +
                        " | Status: " + status +
                        " | Blood Type: " + bloodType[i]
                    );
                }
            }

            if (!found)
            {
                Console.WriteLine("No patients found in this department");
            }
        }

        static void AddDoctor()
        {
            Console.Write("Enter doctor full name: ");
            string name = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (name == "")
            {
                Console.WriteLine("Invalid name. Doctor not registered.");
                return;
            }

            Console.Write("Enter available slots: ");
            string slotInput = Console.ReadLine() ?? "";

            int slots;

            if (!int.TryParse(slotInput, out slots) || slots < 1)
            {
                Console.WriteLine("Invalid slot count. Doctor not registered.");
                return;
            }

           
            for (int i = 0; i <= lastDoctorIndex; i++)
            {
                if (doctorNames[i].ToLower() == name.ToLower())
                {
                    Console.WriteLine("Doctor already exists in the system.");
                    return;
                }
            }

            
            lastDoctorIndex++;

            doctorNames[lastDoctorIndex] = name;
            doctorAvailableSlots[lastDoctorIndex] = slots;
            doctorVisitCount[lastDoctorIndex] = 0;

            Console.WriteLine("Doctor " + name + " registered successfully with " + slots + " available slots.");
        }

        static void DoctorSalaryReport()
        {
            if (lastDoctorIndex == -1)
            {
                Console.WriteLine("No doctors registered in the system.");
                return;
            }

            Console.WriteLine("Doctor Salary Report:");
            Console.WriteLine("----------------------------------------");

            double highestSalary = 0;
            int highestIndex = -1;

            for (int i = 0; i <= lastDoctorIndex; i++)
            {
                double salary = 300 + (doctorVisitCount[i] * 15);
                salary = Math.Round(salary, 2);

                if (salary > highestSalary)
                {
                    highestSalary = salary;
                    highestIndex = i;
                }

                string salaryText = Convert.ToString(salary);

                Console.WriteLine(doctorNames[i] + "  Visits: " + doctorVisitCount[i] +
                    "  Available Slots: " + doctorAvailableSlots[i] + "  Salary: " + salaryText + " OMR");


               
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Highest earning doctor: " + doctorNames[highestIndex] + " — " + Convert.ToString(highestSalary) +"OMR");




            
        }
        static bool ExitSystem()
        {
            Console.WriteLine("Are you sure you want to exit? (true/false)");
            string confirm = Console.ReadLine() ?? "";

            if (confirm.ToLower() == "true")
            {
                Console.WriteLine("Exiting system...");
                return true;
            }

            Console.WriteLine("Returning to menu...");
            return false;
        }
        static void ShowError(string message)
        {
            Console.WriteLine("error: " + message);
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
                       

                       
                        break;

                    case 3: // Discharge Patient


                        DischargePatient();


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
                            PrintPatientDetails(searchFound);
                        }

                        break;








                    case 5: // List All Admitted Patients
                        ListAdmittedPatients();


                        break;

                    case 6: // Transfer Patient to Another Doctor
                        TransferPatientDoctor();

                        break;

                    case 7: // View Most Visited Patients
                        ViewMostVisitedPatients();
                

                        break;


                    case 8: // Search Patients by Department

                        SearchByDepartment();
                        break;
                        
                    case 9: // Billing Report

                        BillingReport();
                        break;

                        case 10://Add Doctor

                        AddDoctor();


                        break;


                    
                    case 11:// Doctor Salary Report


                        DoctorSalaryReport();

                        break;



                    case 12: // Exit
                         ExitSystem();
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
            
        
    

            
        
    


