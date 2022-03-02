// See https://github.com/BED21/26-SOLID_DIP-Demo for source code


//ILogger fLogger = new FileLogger();
//ILogger dbLogger = new DbLogger();

//var fExceptionLog = new ExceptionLogger(fLogger);
//var dbExceptionLog = new ExceptionLogger(dbLogger);

//fExceptionLog.LogException(new IOException("Vi kastade ett fel som skall loggas i fil"));
//dbExceptionLog.LogException(new IOException("Vi kastade ett fel som skall loggas i databas"));

var exporter = new DataExporter();
exporter.ExportDataFromFile();

Console.ReadKey();
