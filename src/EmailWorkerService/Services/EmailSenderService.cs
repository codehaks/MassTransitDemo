using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailWorkerService.Services;
internal class EmailSenderService
{
    private readonly ILogger<EmailSenderService> _logger;

    public EmailSenderService(ILogger<EmailSenderService> logger)
    {
        _logger = logger;
    }

    public async Task SendEmail(SendEmailCommand command)
    {
        await Task.Delay(1000);
        _logger.LogInformation($"Email sent to {command.To}.");
    }

    public class SendEmailCommand
    {
        public required string To { get; set; }
        public required string Subject { get; set; }
        public required string Body { get; set; }
    }

}
