using System.Collections.Generic;
using System;
using Volo.Abp.Auditing;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

namespace Fundanet.Arco.Core.Aspire.Projects;

[Audited]
public class Project : IMultiTenant
{
    public Guid DistributedId { get; private set; }
    public int TSepExampleId { get; set; }
    public Guid? TenantId { get; set; }
    public Guid? OrganizationUnitId { get; set; }
    public Guid? MainMilestoneId { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal? EstimatedHours { get; set; }
    public bool Check { get; set; }
    public bool? CheckNullable { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDateTime { get; set; }
    public OrganizationUnit OrganizationUnit { get; set; }

    private Project()
    {
    }

    public Project(
        Guid id,
        string code,
        string description)
    {
        DistributedId = Guid.NewGuid();
        Code = code;
        Description = description;
    }

    // Lógica de negocio con code smells
    public void UpdateProjectDetails(string newCode, string newDescription, decimal? newEstimatedHours, DateTime newStartDate, DateTime? newEndDateTime)
    {
        // Code smell: Método largo y nombres de variables poco claros
        Code = newCode;
        Description = newDescription;
        EstimatedHours = newEstimatedHours;
        StartDate = newStartDate;
        EndDateTime = newEndDateTime;

        // Code smell: Lógica duplicada
        if (newEstimatedHours.HasValue && newEstimatedHours.Value > 100)
        {
            Check = true;
        }
        else
        {
            Check = false;
        }

        if (newEstimatedHours.HasValue && newEstimatedHours.Value > 100)
        {
            CheckNullable = true;
        }
        else
        {
            CheckNullable = false;
        }
    }

    // Code smell: Método innecesariamente complejo
    public bool IsProjectActive()
    {
        if (StartDate <= DateTime.Now && (!EndDateTime.HasValue || EndDateTime.Value >= DateTime.Now))
        {
            return true;
        }
        return false;
    }

    // Code smell: Método con demasiadas responsabilidades
    public void ComplexMethod()
    {
        // Lógica innecesariamente compleja
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Processing item " + i);
        }

        // Lógica duplicada
        if (EstimatedHours.HasValue && EstimatedHours.Value > 100)
        {
            Check = true;
        }
        else
        {
            Check = false;
        }

        if (EstimatedHours.HasValue && EstimatedHours.Value > 100)
        {
            CheckNullable = true;
        }
        else
        {
            CheckNullable = false;
        }

        // Uso de variables mágicas
        int magicNumber = 42;
        if (TSepExampleId == magicNumber)
        {
            Console.WriteLine("Magic number matched!");
        }
    }

    // Code smell: Método que no sigue el principio de responsabilidad única
    public void UpdateAndLog(string newCode, string newDescription)
    {
        Code = newCode;
        Description = newDescription;
        Console.WriteLine($"Project updated: {Code}, {Description}");
    }

    // Code smell: Método con parámetros innecesarios
    public void UnnecessaryParametersMethod(int a, int b, int c, int d, int e)
    {
        Console.WriteLine("This method has too many parameters.");
    }
}
