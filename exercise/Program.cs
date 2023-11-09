using System;
using System.Collections.Generic;
namespace exercise
{
    public enum ProjectStatus
    {
        Проект,
        Исполнение,
        Закрыт
    }

    public enum TaskStatus
    {
        Назначена,
        В_работе,
        На_проверке,
        Выполнена
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> team = new List<string>()
        {
            "Иван",
            "Артем",
            "Лия",
            "Антон",
            "Ясмина",
            "Адель",
            "Диана",
            "Андрей",
            "Дмитрий",
            "Дарья"
        };
            Project project = new Project("Проект 1", DateTime.Now.AddDays(7), "Олег", "Любовь");
            Console.WriteLine($"Название проекта: {project.Description}\n" +
                $"Статус проекта: {project.Status}\n" +
                $"Крайний срок проекта: {project.Deadline}\n" +
                $"Инициатор проекта: {project.Initiator}\n" +
                $"Руководитель проекта: {project.TeamLead}");
            bool allTasksCompleted = true;
            for (int i = 0; i < 10; i++)
            {
                Task task = new Task("Задача " + (i + 1), DateTime.Now.AddDays(3), "Любовь", team[i]);
                project.Tasks.Add(task);
                project.Status = ProjectStatus.Исполнение;
                if (task.Status == TaskStatus.Назначена)
                {
                    task.Status = TaskStatus.В_работе;
                }
                Report report = new Report("Отчет", DateTime.Now, task.Assignee);
                task.Reports.Add(report);
                Console.WriteLine($"Задача: {task.Description}\n" +
                    $"Статус задачи: {task.Status}\n" +
                    $"   Крайний срок задачи: {task.Deadline}\n" +
                    $"   Инициатор задачи: {task.Initiator}\n" +
                    $"   Исполнитель задачи: {task.Assignee}\n" +
                    $"     Отчет: {report.Text}\n\t" +
                    $"Дата создания отчета: {report.ExecutionDate}\n\t" +
                    $"Исполнитель отчета: {report.Executor}");
                if (task.Reports.Count > 0)
                {
                    if (task.Status == TaskStatus.Выполнена)
                    {
                        Console.WriteLine("     Отчет утвержден");
                    }
                    else
                    {
                        Console.WriteLine("     Отчет возвращен на доработку");
                    }
                }
                if (task.Status != TaskStatus.Выполнена)
                {
                    allTasksCompleted = false;
                }
            }
            if (allTasksCompleted)
            {
                project.Status = ProjectStatus.Закрыт;
                Console.WriteLine("Статус проекта: {0}", project.Status);
            }
            Console.ReadKey();
        }
    }
}
