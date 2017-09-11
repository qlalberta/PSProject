using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Staff
{
    private float hourlyRate;
    private int hWorked;
    public float TotalPay
    {
        get
        {
            return TotalPay;
        }
        protected set
        {
            TotalPay = value;
        }
    }
    public float BasicPay
    {
        get
        {
            return BasicPay;
        }
        private set
        {
            BasicPay = value;
        }
    }
    public string NameOfStaff
    {
        get
        {
            return NameOfStaff;
        }
        private set
        {
            NameOfStaff = value;
        }
    }
    public int HoursWorked
    {
        get
        {
            return hWorked;
        }
        set
        {
            if (value > 0)
                hWorked = value;
            else
                hWorked = 0;
        }

    }

    public Staff(string name, float rate)
    {
        NameOfStaff = name;
        hourlyRate = rate;
    }
    public virtual void CalculatePay()
    {
        Console.WriteLine("Calculating the pay...");
        BasicPay = hWorked * hourlyRate;
        TotalPay = BasicPay;
        Console.WriteLine("Total pay is {0}: ", TotalPay);
    }
    public override string ToString()
    {
        return string.Format("Staff: TotalPay={0}, BasicPay={1}, NameOfStaff={2}, HoursWorked={3}", TotalPay, BasicPay, NameOfStaff, HoursWorked);
    }
}

public class Manager : Staff
{

    private const float mangerHourlyRate = 50f;
    public int Allowance
    {
        get
        {
            return Allowance;
        }
        private set
        {
            Allowance = value;
        }
    }
    public Manager(string Name): base(name, managerHourlyRate)
    {
    }
    public override void CalculatePay()
    {
        base.CalculatePay();
        //Allowance = 1000;
        if (HoursWorked > 160)
        {
            Allowance = 1000;
            TotalPay += Allowance;
        }
    }
    public override String ToString()
    {
        return string.Format("Manager: TotalPay={0}, BasicPay={1}, NameOfStaff={2}, HoursWorked={3}, Allowrance={4}", TotalPay, BasicPay, NameOfStaff, HoursWorked, Allowrance);
    }
}

public class Admin : Staff
{

    private const float overtimeRate = 15.5f;
    private const float adminHourlyRate = 30f;
    public float Overtime
    {
        get
        {
            return Overtime;
        }
        private set
        {
            Overtime = value;
        }
    }
    public Admin(string name) : base(name, adminHourlyRate)
    {
    }
    public override void CalculatePay()
    {
        base.CalculatePay();
        if (HoursWorked > 160)
        {
            Allowance = 1000;
            TotalPay += Allowance;
        }
        if (HoursWorked > 160)
        {
            Overtime = overtimeRate * (HoursWorked - 160);
            TotalPay += OverTime;
        }
    }
    public override String ToString()
    {
        return string.Format("[Administrater: TotalPay={0}, BasicPay={1}, NameOfStaff={2}, HoursWorked={3}, Overtime={4}]", TotalPay, BasicPay, NameOfStaff, HoursWorked, Overtime);
    }
}

