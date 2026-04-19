

namespace HMS_VERSION2
{

    internal class Program
    {
        //replace array by list

        // System Storage

        //static string[] patientNames = new string[100];
        static List<string> patientNames = new List<string>();

        //static string[] patientIDs = new string[100];
        static List<string> patientIDs = new List<string>();

        //static string[] diagnosis = new string[100];
        static List<string> diagnoses = new List<string>();

        //static bool[] admitted = new bool[100];
        static List<bool> admitted = new List<bool>();

        //static string[] assignedDoctors = new string[100];
        static List<string> assignedDoctors = new List<string>();

        //static string[] department = new string[100];
        static List<string> department = new List<string>();

        //static int[] visitCount = new int[100];
        static List<int> visitCount = new List<int>();

        //static double[] billingAmount = new double[100];
        static List<double> billingAmounts = new List<double>();

        //static DateTime[] lastVisitDate = new DateTime[100];
        static List<DateTime> lastVisitDate = new List<DateTime>();

        //static DateTime[] lastDischargeDate = new DateTime[100];
        static List<DateTime> lastDischargeDate = new List<DateTime>();

        //static int[] daysInHospital = new int[100];
        static List<int> daysInHospital = new List<int>();

        //static string[] bloodType = new string[100];
        static List<string> bloodType = new List<string>();


        // string[] doctorNames = new string[50];
        static List<string> doctorNames = new List<string>();

        // static int[] doctorAvailableSlots = new int[50];
        static List<int> doctorAvailableSlots = new List<int>();

        //static int[] dctorVisitCount = new int[50];
        static List<int> doctorVisitCount = new List<int>();

        // static int lastDoctorIndex = -1;

        // static int lastIndex = -1;


        /// ///////////////////////////////////////////////////////////////
        /// </summary>



        // Seed Data
        static public void seedData()

        {

            // lastIndex++;


            //patientNames[lastIndex] = "Ali Hassan";
            patientNames.Add("Ali Hassan");

            //patientIDs[lastIndex] = "P001";
            patientIDs.Add("P001");

            //diagnosis[lastIndex] = "Flu";
            diagnoses.Add("Flu");

            //department[lastIndex] = "General";
            department.Add("General");

            // admitted[lastIndex] = false;
            admitted.Add(false);

            // assignedDoctors[lastIndex] = "";
            assignedDoctors.Add("");

            // visitCount[lastIndex] = 2;
            visitCount.Add(2);

            // billingAmount[lastIndex] = 0;
            billingAmounts.Add(0);
            //lastVisitDate[lastIndex] = DateTime.Parse("2025-01-10");
            lastVisitDate.Add(DateTime.Parse("2025-01-10"));

            //DischargeDate[lastIndex] = new DateTime(2025, 1, 15);
            lastDischargeDate.Add(DateTime.Parse("2025-01-15"));

            // daysInHospital[lastIndex] = 12;
            daysInHospital.Add(0);

            //bloodType[lastIndex] = "A+";
            bloodType.Add("A+");



            //lastDoctorIndex++;

            //doctorNames[lastDoctorIndex] = "Dr. Noor";
            doctorNames.Add("Dr.Noor");


            //doctorAvailableSlots[lastDoctorIndex] = 5;
            doctorAvailableSlots.Add(5);

            // doctorVisitCount[lastDoctorIndex] = 0;
            doctorVisitCount.Add(0);



            //lastIndex++;

            //patientNames[lastIndex] = "Sara Ahmed";
            patientNames.Add("Sara Ahmed");

            //patientIDs[lastIndex] = "P002";
            patientIDs.Add("P002");

            //diagnosis[lastIndex] = "Fracture";
            diagnoses.Add("Fracture");

            //department[lastIndex] = "Orthopedics";
            department.Add("Orthopedics");

            //admitted[lastIndex] = true;
            admitted.Add(true);

            //assignedDoctors[lastIndex] = "Dr. Noor";
            assignedDoctors.Add("Dr. Noor");

            // visitCount[lastIndex] = 4;
            visitCount.Add(4);

            //billingAmount[lastIndex] = 0;
            billingAmounts.Add(0);

            //lastVisitDate[lastIndex] = DateTime.Parse("2025-03-02");
            lastVisitDate.Add(DateTime.Parse("2025-03-02"));

            //lastDischargeDate[lastIndex] = DateTime.Parse("2025-01-15");
            lastDischargeDate.Add(DateTime.Parse("2025-01-15"));

            // daysInHospital[lastIndex] = 8;
            daysInHospital.Add(8);


            //bloodType[lastIndex] = "O-";
            bloodType.Add("O-");


            //lastDoctorIndex++;
            // doctorNames[lastDoctorIndex] = "Dr. Salem";
            doctorNames.Add("Dr.Salem");

            //doctorAvailableSlots[lastDoctorIndex] = 3;
            doctorAvailableSlots.Add(3);

            //doctorVisitCount[lastDoctorIndex] = 0;
            doctorVisitCount.Add(0);



            //lastIndex++;

            //patientNames[lastIndex] = "Omar Khalid";
            patientNames.Add("Omar Khalid");

            //patientIDs[lastIndex] = "P003";
            patientIDs.Add("P003");

            //diagnosis[lastIndex] = "Diabetes";
            diagnoses.Add("Diabetes");

            //department[lastIndex] = "Cardiology";
            department.Add("Cardiology");

            //admitted[lastIndex] = false;
            admitted.Add(false);

            //assignedDoctors[lastIndex] = "";
            assignedDoctors.Add("");

            //visitCount[lastIndex] = 1;
            visitCount.Add(1);

            //billingAmount[lastIndex] = 0;
            billingAmounts.Add(0);

            //lastVisitDate[lastIndex] = DateTime.Today;
            lastVisitDate.Add(DateTime.Today);

            //lastDischargeDate[lastIndex] = DateTime.Parse("2024-12-28");
            lastDischargeDate.Add(DateTime.Parse("2024-12-28"));

            //daysInHospital[lastIndex] = 5;
            daysInHospital.Add(5);

            //bloodType[lastIndex] = "B+";
            bloodType.Add("B+");


            // lastDoctorIndex++;

            // doctorNames[lastDoctorIndex] = "Dr. Hana";
            doctorNames.Add("Dr. Hana");

            // doctorAvailableSlots[lastDoctorIndex] = 8;
            doctorAvailableSlots.Add(8);

            //  doctorVisitCount[lastDoctorIndex] = 0;
            doctorVisitCount.Add(0);



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
            // lastIndex++;
            Console.WriteLine("Register the new patient");



            patientNames.Add(name);
            diagnoses.Add(Diagnosise);
            department.Add(Departments);
            bloodType.Add(bloodTypes);

            string patientId = $"P{patientIDs.Count + 1:D3}";
            patientIDs.Add(patientId);
            admitted.Add(false);
            assignedDoctors.Add("");
            visitCount.Add(0);
            billingAmounts.Add(0);

            lastVisitDate.Add(DateTime.Now);
            lastDischargeDate.Add(DateTime.Now);
            daysInHospital.Add(0);


            Console.WriteLine("Patient registered successfully :");

            return patientId;

        }


        static public int SearchPatient(string searchInput)
        {
            for (int i = 0; i < patientNames.Count; i++)
            {
                if (patientNames[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase) ||
                    patientIDs[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }


        static public void PrintPatientDetails(int index)
        {
            Console.WriteLine("Name: " + patientNames[index]);
            Console.WriteLine("ID: " + patientIDs[index]);
            Console.WriteLine("Diagnosis: " + diagnoses[index] + " (" + diagnoses[index].Length + " characters)");
            Console.WriteLine("Department: " + department[index]);
            Console.WriteLine("Admitted:       " + admitted[index]);
            Console.WriteLine("Total Visits:   " + visitCount[index]);
            Console.WriteLine("Doctor:         " + assignedDoctors[index]);

        }

        static public void AdmitPatient()
        {
            Console.Write("Enter Patient ID or Name: ");
            string input = (Console.ReadLine() ?? "").Trim();

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

            Console.Write("Enter admitt date (YYYY-MM-DD): ");
            string admissionDateInput = Console.ReadLine();

            if (DateTime.TryParse(admissionDateInput, out DateTime admitDate))
            {
                lastVisitDate[patientIndex] = admitDate;
            }
            else
            {
                Console.WriteLine("Invalid date format. Using current date.");
                lastVisitDate[patientIndex] = DateTime.Now;
            }

            // Doctor validation
            Console.Write("Doctor Name: ");
            string doctorInput = (Console.ReadLine() ?? "").Trim();

            int doctorIndex = -1;

            for (int i = 0; i < doctorNames.Count; i++)
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

            // Check slots
            if (doctorAvailableSlots[doctorIndex] <= 0)
            {
                Console.WriteLine("Dr. " + doctorNames[doctorIndex] + " has no available slots at this time.");
                return;
            }

            // Admit patient
            admitted[patientIndex] = true;
            visitCount[patientIndex]++;
            assignedDoctors[patientIndex] = doctorNames[doctorIndex];

            doctorAvailableSlots[doctorIndex]--;
            doctorVisitCount[doctorIndex]++;

            Console.WriteLine("Patient admitted successfully");
            Console.WriteLine("Dr. " + doctorNames[doctorIndex] +
                " now has " + doctorAvailableSlots[doctorIndex] + " slot(s) remaining.");
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
                daysInHospital[patientIndex] =
                     (dischargeDate - lastVisitDate[patientIndex]).Days;
            }
            else
            {
                lastDischargeDate[patientIndex] = DateTime.Now;
            }

            //  Save assigned doctor before clearing
            string assignedDoctor = assignedDoctors[patientIndex];

            int doctorIndex = -1;

            // Find doctor in registry
            for (int i = 0; i < doctorNames.Count; i++)
            {
                if (!string.IsNullOrEmpty(assignedDoctor) &&
                      doctorNames[i].Equals(assignedDoctor, StringComparison.OrdinalIgnoreCase))
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

            billingAmounts[patientIndex] += visitCharges;

            admitted[patientIndex] = false;
            assignedDoctors[patientIndex] = "";


            Console.WriteLine("Patient discharged successfully!");
            Console.WriteLine("Total charges added: " + visitCharges);
        }

        static void BillingReport()
        {
            Console.WriteLine("1. System-wide total, min, max");
            Console.WriteLine("2. Individual patient");
            Console.Write("Choose: ");

            int option;

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            // Part 1 1: System-Wide-Report

            if (option == 1)
            {
                double total = 0;

                double min = billingAmounts[0];
                double max = 0;

                bool firstValidMin = true;

                for (int i = 0; i < patientNames.Count; i++)
                {
                    double bill = billingAmounts[i];

                    // Total
                    total += bill;

                    // Max
                    if (bill > max)
                    {
                        max = bill;
                    }

                    // Min (skip zero values)
                    if (bill != 0)
                    {
                        if (firstValidMin)
                        {
                            min = bill;
                            firstValidMin = false;
                        }
                        else if (bill < min)
                        {
                            min = bill;
                        }
                    }
                }

                Console.WriteLine("===== System-wide Report =====");
                Console.WriteLine("Total billing: " + total);
                Console.WriteLine("Minimum billing: " + min);
                Console.WriteLine("Maximum billing: " + max);
            }


            // Par 2: individul Patient

            else if (option == 2)
            {
                Console.WriteLine("===== Individual Patient Report =====");

                Console.Write("Enter Patient ID or Name: ");
                string input = (Console.ReadLine() ?? "").Trim();

                int index = SearchPatient(input);

                if (index == -1)
                {
                    Console.WriteLine("Not found");
                }
                else
                {

                    // Zero billing guard

                    if (billingAmounts.Count == 0)
                    {
                        Console.WriteLine("No billing data");
                        return;
                    }

                    Console.WriteLine("Billing: " + billingAmounts[index]);


                    // Random discount

                    Random rng = new Random();
                    int discountPct = rng.Next(5, 21);

                    double discounted = billingAmounts[index] * (1 - discountPct / 100.0);
                    discounted = Math.Round(discounted, 2);

                    Console.WriteLine("Discount applied: " + discountPct + "%");
                    Console.WriteLine("Amount after discount: " + discounted + " OMR");
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

            for (int i = 0; i < patientNames.Count; i++)
            {
                if (admitted[i])
                {
                    Console.WriteLine("Name: " + patientNames[i] +
                        " | ID: " + patientIDs[i] +

                        " | Diagnosis: " + diagnoses[i] +
                        " | Department: " + department[i] +
                        " | Doctor: " + assignedDoctors[i] +
                        " | Last Visit: " + lastVisitDate[i]);


                    found = true;
                    count++;
                    highestBilling = Math.Max(highestBilling, billingAmounts[i]);
                }
            }

            if (!found)
                Console.WriteLine("No patients currently admitted");
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
            string currentDoctor = (Console.ReadLine() ?? "").Trim();

            Console.Write("Enter new doctor name: ");
            string newDoctor = (Console.ReadLine() ?? "").Trim();

            if (currentDoctor.Equals(newDoctor, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("New doctor must be different from current doctor");
                return;
            }

            // search for new doctor
            int newDoctorIndex = -1;

            for (int i = 0; i < doctorNames.Count; i++)
            {
                if (doctorNames[i].Equals(newDoctor, StringComparison.OrdinalIgnoreCase))
                {
                    newDoctorIndex = i;
                    break;
                }
            }

            if (newDoctorIndex == -1)
            {
                Console.WriteLine("New doctor not found in system");
                return;
            }

            bool found = false;

            for (int i = 0; i < patientNames.Count; i++)
            {
                if (admitted[i] &&
                    assignedDoctors[i].Equals(currentDoctor, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;

                    // update slots
                    if (doctorAvailableSlots[newDoctorIndex] <= 0)
                    {
                        Console.WriteLine("No available slots for new doctor");
                        return;
                    }

                    assignedDoctors[i] = doctorNames[newDoctorIndex];

                    doctorAvailableSlots[newDoctorIndex]--;
                    doctorVisitCount[newDoctorIndex]++;

                    Console.WriteLine("Patient: " + patientNames[i]);
                    Console.WriteLine("Transferred to: " + doctorNames[newDoctorIndex]);

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

            for (int i = 0; i < patientNames.Count; i++)
            {
                tempVisits[i] = visitCount[i];
            }

            for (int pass = 0; pass < patientNames.Count; pass++)
            {
                int maxIndex = -1;
                int maxValue = -1;

                for (int i = 0; i < patientNames.Count; i++)
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
            string searchDept = Console.ReadLine() ?? "".Trim();

            bool found = false;

            Console.WriteLine("Patients in department:");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < patientNames.Count; i++)
            {
                if (department[i].IndexOf(searchDept, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    found = true;

                    string status = admitted[i] ? "Admitted" : "Not Admitted";

                    string diagDisplay = diagnoses[i].Length > 15
                        ? diagnoses[i].Substring(0, 15) + "..."
                        : diagnoses[i];

                    Console.WriteLine("ID: " + patientIDs[i] + " | Name: " + patientNames[i] + " | Diagnoses: " + diagnoses[i] +
                                       " | Status: " + status + " | Blood Type: " + bloodType[i]);




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
            string name = (Console.ReadLine() ?? "").Trim();

            if (name == "")
            {
                Console.WriteLine("Invalid name. Doctor not registered.");
                return;
            }

            Console.Write("Enter available slots: ");
            string slotInput = (Console.ReadLine() ?? "").Trim();

            int slots;

            if (!int.TryParse(slotInput, out slots) || slots < 1)
            {
                Console.WriteLine("Invalid slot count. Doctor not registered.");
                return;
            }


            for (int i = 0; i < doctorNames.Count; i++)
            {
                if (doctorNames[i].ToLower() == name.ToLower())
                {
                    Console.WriteLine("Doctor already exists in the system.");
                    return;
                }
            }


            // lastDoctorIndex++;
            doctorNames.Add(name);
            doctorAvailableSlots.Add(slots);
            doctorVisitCount.Add(0);
            Console.WriteLine("Doctor " + name + " registered successfully with " + slots + " available slots.");
        }

        static void DoctorSalaryReport()
        {
            if (doctorNames.Count == 0)
            {
                Console.WriteLine("No doctors registered in the system.");
                return;
            }

            Console.WriteLine("Doctor Salary Report:");
            Console.WriteLine("----------------------------------------");

            double highestSalary = 0;
            int highestIndex = -1;

            for (int i = 0; i < doctorNames.Count; i++)
            {
                double salary = 300 + (doctorVisitCount[i] * 15);
                salary = Math.Round(salary, 2);

                if (salary > highestSalary)
                {
                    highestSalary = salary;
                    highestIndex = i;
                }

                Console.WriteLine($"Salary: {salary:F2} OMR");

                Console.WriteLine(doctorNames[i] + "  Visits: " + doctorVisitCount[i] +
                    "  Available Slots: " + doctorAvailableSlots[i] + "  Salary: " + salary + " OMR");



            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Highest earning doctor: " + doctorNames[highestIndex] + " — " + Convert.ToString(highestSalary) + "OMR");





        }
        static bool ExitSystem()
        {
            Console.WriteLine("Are you sure you want to exit? (true/false)");
            string confirm = Console.ReadLine() ?? "".Trim();

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

            while (exit == false)
            {

                displayMenu();


                Console.WriteLine("choose option");
                int choice = 0;

                try
                {
                    choice = int.Parse((Console.ReadLine() ?? "").Trim());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {

                    case 1: // Register New Patient


                        Console.Write("Patient name: ");
                        string name = (Console.ReadLine() ?? "").Trim();

                        Console.Write("Diagnosis: ");
                        string Diagnosise = (Console.ReadLine() ?? "").Trim();

                        Console.Write("Department: ");
                        string Department = (Console.ReadLine() ?? "").Trim();

                        Console.Write("blood Type: ");
                        string bloodTypes = (Console.ReadLine() ?? "").Trim().ToUpper();



                        string Pid = RegisterPatient(name, Diagnosise,
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
                        string searchInput = (Console.ReadLine() ?? "").Trim();

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
                        exit = ExitSystem();
                        break; ;




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

















