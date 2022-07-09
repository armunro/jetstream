![Jetstream Logo](Jetstream-LogoV1.png)

---
Jetstream is a web-based software suite for building custom software tools that centralize Information, Data and Resources (IDR). Emails, Calendar Events, Alarms, Vehicles, Help Articles are all examples of IDR that we conventionally manage within a variety of apps and services.

Jetstream provides tools for Modeling, Controlling and Instrumenting (MCI) this IDR and refining it into reactive applications with simple and ergonomic interfaces.

![Jetstream Screenshot](Jetstream-Sample.png)

## How it works
Most software languages and tools tend to think of information in terms of Classes, Types or Tables. Jetstream uses Info `Kinds` to label and prototype, but not define modeled information.

## Jetstream Process
The acronym `MITER` is useful for remembering process for handling IDR:
``` 
- M -  Model         Determine key IDR
- I -  Integrate     Inject real-world data (Manual entry, 3rd Party API, File)
- T -  Tool          Build scripts, schedules, screens, alarms, etc.
- E -  Employ       Use the tools -> Record feedback and telemetry -> Deliver
- R -  Reflect+Redo  Review telemetry -> Improve ->
```

## Core IDR Kinds
Jetstream uses *Kinds* to capture patterns of Information, Data and Resources. Since some Kinds of IDR are ubiquitous across teams, cultures and locations (Calendars, Alarms, Grocery Lists, etc.) Jetstream includes the following core *Kinds* to: A) Provide a solid start to prototyping your own kinds and B) to enable simple configuration and integration with the Jetstream core:

- `Note` - Simple `Name` and `Content` message to yourself.
- `TaskList` - A collection of tasks
- `Task` - Something that needs doing; Optionally it may have a deadline
- `Schedule` - Calendars, CRON expressions, iCal feeds. A collection of `ScheduleEvents`
- `ScheduleEvent` - Meetings, appointments, or other time based commitment.
- `Alarm` - Any time a person needs to be notified visually or auditorily. May optionally require acknowledgement for accountability.
- `Message` - A human-readable message with attached data
- `ServiceLink` -  A software component that establishes standardized communication between Jetstream and house-built and 3rd party services. ServiceLinks provide bidirectional communication by converting 3rd party data into Jetstream Resources and v. versa.
- `Screen` - View for a resource or set of resources



