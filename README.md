# Jetstream IDR-MCIS

Information, Data, Resources -> (Model, Command, Instrument) System

## Abstract
IT individuals and teams are perfectly equipped for building custom tooling. Such custom tools can offer increases in efficiency and engagement. When this tooling is a direct translation of a person or groups experienced problems and solutions, things like efficiency and ergonomics can be finely tuned.

In reality, tooling requirements are often treated by engineers and their managers a secondary concern to the primary business needs. My experience is that IT self-tooling largely perceived as either A) extraneous work or B) a quality possessed by only the most passionate/experienced engineers. When compared to today's turnkey and bespoke info and process management solutions (E.g. Wikis, Issue Trackers, CRM/ERP) custom tooling does indeed have a greater barrier of entry. 

IDR-MCIS is an acronym that captures the respective scope and process in which Jetstream attempts to develop and promote custom tooling for.

## How it works
Most software languages and tools tend to think of information in terms of Classes, Types or Tables. Jetstream uses Info Kinds.

## Jetstream Process
The acronym `MITER` is useful for remembering the design process
``` 
- M -  Model         Determine key IDR
- I -  Integrate     Inject real-world data (Manual entry, 3rd Party API, File)
- T -  Tool          Build scripts, schedules, screens, alarms, etc.
- E -  Employ       Use the tools -> Record feedback and telemetry -> Deliver
- R -  Reflect+Redo  Review telemetry -> Improve ->
```

## Core Information Kinds
- `Note` - Simple `Name` and `Content` message to yourself.
- `TaskList` - A collection of tasks
- `Task` - Something that needs doing; Optionally it may have a deadline
- `Schedule` - Calendars, CRON expressions, iCal feeds. A collection of `ScheduleEvents`
- `ScheduleEvent` - Meetings, appointments, or other time based commitment.
- `Alarm` - Any time a person needs to be notified visually or auditorily. May optionally require acknowledgement for accountability.
- `Message` - A human-readable message with attached data
- `ServiceLink` -  A software component that establishes standardized communication between Jetstream and house-built and 3rd party services. ServiceLinks provide bidirectional communication by converting 3rd party data into Jetstream Resources and v. versa.
- `Screen` - View for a resource or set of resources
