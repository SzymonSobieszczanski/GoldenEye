using System;
using FluentValidation;
using GoldenEye.Backend.Core.DDD.Commands;

namespace GoldenEye.WebApi.Template.SimpleDDD.Contracts.Issues.Commands
{
    public class DeleteIssue: ICommand
    {
        public DeleteIssue(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }

    public class DeleteIssueValidator: AbstractValidator<DeleteIssue>
    {
        public DeleteIssueValidator()
        {
            RuleFor(r => r.Id).NotEmpty();
        }
    }
}
