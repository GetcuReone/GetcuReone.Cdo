<a name='assembly'></a>
# GetcuReone.Cdo

## Contents

- [AppDataFolderAdapter](#T-GetcuReone-Cdo-Folder-AppDataFolderAdapter 'GetcuReone.Cdo.Folder.AppDataFolderAdapter')
  - [#ctor()](#M-GetcuReone-Cdo-Folder-AppDataFolderAdapter-#ctor 'GetcuReone.Cdo.Folder.AppDataFolderAdapter.#ctor')
- [CurrentFolderAdapter](#T-GetcuReone-Cdo-Folder-CurrentFolderAdapter 'GetcuReone.Cdo.Folder.CurrentFolderAdapter')
  - [#ctor()](#M-GetcuReone-Cdo-Folder-CurrentFolderAdapter-#ctor 'GetcuReone.Cdo.Folder.CurrentFolderAdapter.#ctor')
- [EmailAdapter](#T-GetcuReone-Cdo-Email-EmailAdapter 'GetcuReone.Cdo.Email.EmailAdapter')
  - [#ctor()](#M-GetcuReone-Cdo-Email-EmailAdapter-#ctor 'GetcuReone.Cdo.Email.EmailAdapter.#ctor')
  - [OpenEmail()](#M-GetcuReone-Cdo-Email-EmailAdapter-OpenEmail-GetcuReone-Cdm-Communication-Email- 'GetcuReone.Cdo.Email.EmailAdapter.OpenEmail(GetcuReone.Cdm.Communication.Email)')
  - [OpenEmail()](#M-GetcuReone-Cdo-Email-EmailAdapter-OpenEmail-GetcuReone-Cdm-Communication-Email,System-String- 'GetcuReone.Cdo.Email.EmailAdapter.OpenEmail(GetcuReone.Cdm.Communication.Email,System.String)')
- [EmailService](#T-GetcuReone-Cdo-Email-EmailService 'GetcuReone.Cdo.Email.EmailService')
  - [FactoryName](#P-GetcuReone-Cdo-Email-EmailService-FactoryName 'GetcuReone.Cdo.Email.EmailService.FactoryName')
  - [OpenEmail()](#M-GetcuReone-Cdo-Email-EmailService-OpenEmail-GetcuReone-Cdm-Communication-Email- 'GetcuReone.Cdo.Email.EmailService.OpenEmail(GetcuReone.Cdm.Communication.Email)')
  - [OpenEmail()](#M-GetcuReone-Cdo-Email-EmailService-OpenEmail-GetcuReone-Cdm-Communication-Email,System-String- 'GetcuReone.Cdo.Email.EmailService.OpenEmail(GetcuReone.Cdm.Communication.Email,System.String)')
- [FileAdapter](#T-GetcuReone-Cdo-File-FileAdapter 'GetcuReone.Cdo.File.FileAdapter')
  - [#ctor()](#M-GetcuReone-Cdo-File-FileAdapter-#ctor 'GetcuReone.Cdo.File.FileAdapter.#ctor')
  - [Open(filePath,mode)](#M-GetcuReone-Cdo-File-FileAdapter-Open-System-String,System-IO-FileMode- 'GetcuReone.Cdo.File.FileAdapter.Open(System.String,System.IO.FileMode)')
  - [OpenRead(filePath)](#M-GetcuReone-Cdo-File-FileAdapter-OpenRead-System-String- 'GetcuReone.Cdo.File.FileAdapter.OpenRead(System.String)')
  - [OpenWrite(filePath)](#M-GetcuReone-Cdo-File-FileAdapter-OpenWrite-System-String- 'GetcuReone.Cdo.File.FileAdapter.OpenWrite(System.String)')
  - [ReadAllText(filePath)](#M-GetcuReone-Cdo-File-FileAdapter-ReadAllText-System-String- 'GetcuReone.Cdo.File.FileAdapter.ReadAllText(System.String)')
  - [ReadAllText(filePath,encoding)](#M-GetcuReone-Cdo-File-FileAdapter-ReadAllText-System-String,System-Text-Encoding- 'GetcuReone.Cdo.File.FileAdapter.ReadAllText(System.String,System.Text.Encoding)')
  - [WriteAllText(filePath,text)](#M-GetcuReone-Cdo-File-FileAdapter-WriteAllText-System-String,System-String- 'GetcuReone.Cdo.File.FileAdapter.WriteAllText(System.String,System.String)')
  - [WriteAllText(filePath,text,encoding)](#M-GetcuReone-Cdo-File-FileAdapter-WriteAllText-System-String,System-String,System-Text-Encoding- 'GetcuReone.Cdo.File.FileAdapter.WriteAllText(System.String,System.String,System.Text.Encoding)')
- [FileService](#T-GetcuReone-Cdo-File-FileService 'GetcuReone.Cdo.File.FileService')
  - [#ctor(filePath)](#M-GetcuReone-Cdo-File-FileService-#ctor-System-String- 'GetcuReone.Cdo.File.FileService.#ctor(System.String)')
  - [Open()](#M-GetcuReone-Cdo-File-FileService-Open-System-IO-FileMode- 'GetcuReone.Cdo.File.FileService.Open(System.IO.FileMode)')
  - [OpenRead()](#M-GetcuReone-Cdo-File-FileService-OpenRead 'GetcuReone.Cdo.File.FileService.OpenRead')
  - [OpenWrite()](#M-GetcuReone-Cdo-File-FileService-OpenWrite 'GetcuReone.Cdo.File.FileService.OpenWrite')
  - [ReadAllText()](#M-GetcuReone-Cdo-File-FileService-ReadAllText 'GetcuReone.Cdo.File.FileService.ReadAllText')
  - [ReadAllText()](#M-GetcuReone-Cdo-File-FileService-ReadAllText-System-Text-Encoding- 'GetcuReone.Cdo.File.FileService.ReadAllText(System.Text.Encoding)')
  - [WriteAllText()](#M-GetcuReone-Cdo-File-FileService-WriteAllText-System-String- 'GetcuReone.Cdo.File.FileService.WriteAllText(System.String)')
  - [WriteAllText()](#M-GetcuReone-Cdo-File-FileService-WriteAllText-System-String,System-Text-Encoding- 'GetcuReone.Cdo.File.FileService.WriteAllText(System.String,System.Text.Encoding)')
- [FolderAdapterBase](#T-GetcuReone-Cdo-Folder-FolderAdapterBase 'GetcuReone.Cdo.Folder.FolderAdapterBase')
  - [#ctor()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-#ctor-System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.#ctor(System.String)')
  - [ContainFile(fileName)](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-ContainFile-System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.ContainFile(System.String)')
  - [CreateCurrentFolder()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-CreateCurrentFolder 'GetcuReone.Cdo.Folder.FolderAdapterBase.CreateCurrentFolder')
  - [DeleteFile()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-DeleteFile-System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.DeleteFile(System.String)')
  - [DownloadFile()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-DownloadFile-System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.DownloadFile(System.String)')
  - [ExistsCurrentFolder()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-ExistsCurrentFolder 'GetcuReone.Cdo.Folder.FolderAdapterBase.ExistsCurrentFolder')
  - [GetFiles()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetFiles 'GetcuReone.Cdo.Folder.FolderAdapterBase.GetFiles')
  - [GetFiles()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetFiles-System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.GetFiles(System.String)')
  - [GetFullName(fileName)](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetFullName-System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.GetFullName(System.String)')
  - [GetPath()](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetPath 'GetcuReone.Cdo.Folder.FolderAdapterBase.GetPath')
  - [RenameFile(newName,oldName)](#M-GetcuReone-Cdo-Folder-FolderAdapterBase-RenameFile-System-String,System-String- 'GetcuReone.Cdo.Folder.FolderAdapterBase.RenameFile(System.String,System.String)')
- [FolderService](#T-GetcuReone-Cdo-Folder-FolderService 'GetcuReone.Cdo.Folder.FolderService')
  - [#ctor(folderPath)](#M-GetcuReone-Cdo-Folder-FolderService-#ctor-System-String- 'GetcuReone.Cdo.Folder.FolderService.#ctor(System.String)')
  - [CreateFolder()](#M-GetcuReone-Cdo-Folder-FolderService-CreateFolder 'GetcuReone.Cdo.Folder.FolderService.CreateFolder')
  - [DeleteFile()](#M-GetcuReone-Cdo-Folder-FolderService-DeleteFile-System-String- 'GetcuReone.Cdo.Folder.FolderService.DeleteFile(System.String)')
  - [DownloadFile()](#M-GetcuReone-Cdo-Folder-FolderService-DownloadFile-System-String- 'GetcuReone.Cdo.Folder.FolderService.DownloadFile(System.String)')
  - [ExistsCurrentFolder()](#M-GetcuReone-Cdo-Folder-FolderService-ExistsCurrentFolder 'GetcuReone.Cdo.Folder.FolderService.ExistsCurrentFolder')
  - [GetFileInfo()](#M-GetcuReone-Cdo-Folder-FolderService-GetFileInfo-System-String- 'GetcuReone.Cdo.Folder.FolderService.GetFileInfo(System.String)')
  - [GetFiles()](#M-GetcuReone-Cdo-Folder-FolderService-GetFiles 'GetcuReone.Cdo.Folder.FolderService.GetFiles')
  - [GetFiles()](#M-GetcuReone-Cdo-Folder-FolderService-GetFiles-System-String- 'GetcuReone.Cdo.Folder.FolderService.GetFiles(System.String)')
  - [GetPath()](#M-GetcuReone-Cdo-Folder-FolderService-GetPath 'GetcuReone.Cdo.Folder.FolderService.GetPath')
  - [MoveTo()](#M-GetcuReone-Cdo-Folder-FolderService-MoveTo-System-String,System-String- 'GetcuReone.Cdo.Folder.FolderService.MoveTo(System.String,System.String)')
- [IEmail](#T-GetcuReone-Cdo-Email-IEmail 'GetcuReone.Cdo.Email.IEmail')
  - [OpenEmail(email)](#M-GetcuReone-Cdo-Email-IEmail-OpenEmail-GetcuReone-Cdm-Communication-Email- 'GetcuReone.Cdo.Email.IEmail.OpenEmail(GetcuReone.Cdm.Communication.Email)')
  - [OpenEmail(email,fileEmail)](#M-GetcuReone-Cdo-Email-IEmail-OpenEmail-GetcuReone-Cdm-Communication-Email,System-String- 'GetcuReone.Cdo.Email.IEmail.OpenEmail(GetcuReone.Cdm.Communication.Email,System.String)')
- [IFile](#T-GetcuReone-Cdo-File-IFile 'GetcuReone.Cdo.File.IFile')
  - [Open(mode)](#M-GetcuReone-Cdo-File-IFile-Open-System-IO-FileMode- 'GetcuReone.Cdo.File.IFile.Open(System.IO.FileMode)')
  - [OpenRead()](#M-GetcuReone-Cdo-File-IFile-OpenRead 'GetcuReone.Cdo.File.IFile.OpenRead')
  - [OpenWrite()](#M-GetcuReone-Cdo-File-IFile-OpenWrite 'GetcuReone.Cdo.File.IFile.OpenWrite')
  - [ReadAllText()](#M-GetcuReone-Cdo-File-IFile-ReadAllText 'GetcuReone.Cdo.File.IFile.ReadAllText')
  - [ReadAllText(encoding)](#M-GetcuReone-Cdo-File-IFile-ReadAllText-System-Text-Encoding- 'GetcuReone.Cdo.File.IFile.ReadAllText(System.Text.Encoding)')
  - [WriteAllText(text)](#M-GetcuReone-Cdo-File-IFile-WriteAllText-System-String- 'GetcuReone.Cdo.File.IFile.WriteAllText(System.String)')
  - [WriteAllText(text,encoding)](#M-GetcuReone-Cdo-File-IFile-WriteAllText-System-String,System-Text-Encoding- 'GetcuReone.Cdo.File.IFile.WriteAllText(System.String,System.Text.Encoding)')
- [IFolder](#T-GetcuReone-Cdo-Folder-IFolder 'GetcuReone.Cdo.Folder.IFolder')
  - [CreateFolder()](#M-GetcuReone-Cdo-Folder-IFolder-CreateFolder 'GetcuReone.Cdo.Folder.IFolder.CreateFolder')
  - [DeleteFile(fileName)](#M-GetcuReone-Cdo-Folder-IFolder-DeleteFile-System-String- 'GetcuReone.Cdo.Folder.IFolder.DeleteFile(System.String)')
  - [DownloadFile(filePath)](#M-GetcuReone-Cdo-Folder-IFolder-DownloadFile-System-String- 'GetcuReone.Cdo.Folder.IFolder.DownloadFile(System.String)')
  - [ExistsCurrentFolder()](#M-GetcuReone-Cdo-Folder-IFolder-ExistsCurrentFolder 'GetcuReone.Cdo.Folder.IFolder.ExistsCurrentFolder')
  - [GetFileInfo(fileName)](#M-GetcuReone-Cdo-Folder-IFolder-GetFileInfo-System-String- 'GetcuReone.Cdo.Folder.IFolder.GetFileInfo(System.String)')
  - [GetFiles()](#M-GetcuReone-Cdo-Folder-IFolder-GetFiles 'GetcuReone.Cdo.Folder.IFolder.GetFiles')
  - [GetFiles(searchPattern)](#M-GetcuReone-Cdo-Folder-IFolder-GetFiles-System-String- 'GetcuReone.Cdo.Folder.IFolder.GetFiles(System.String)')
  - [GetPath()](#M-GetcuReone-Cdo-Folder-IFolder-GetPath 'GetcuReone.Cdo.Folder.IFolder.GetPath')
  - [MoveTo(newFilePath,oldName)](#M-GetcuReone-Cdo-Folder-IFolder-MoveTo-System-String,System-String- 'GetcuReone.Cdo.Folder.IFolder.MoveTo(System.String,System.String)')
- [IProcess](#T-GetcuReone-Cdo-Process-IProcess 'GetcuReone.Cdo.Process.IProcess')
  - [Start(processName,args)](#M-GetcuReone-Cdo-Process-IProcess-Start-System-String,System-String- 'GetcuReone.Cdo.Process.IProcess.Start(System.String,System.String)')
- [ProcessAdapter](#T-GetcuReone-Cdo-Process-ProcessAdapter 'GetcuReone.Cdo.Process.ProcessAdapter')
  - [#ctor()](#M-GetcuReone-Cdo-Process-ProcessAdapter-#ctor 'GetcuReone.Cdo.Process.ProcessAdapter.#ctor')
  - [Start()](#M-GetcuReone-Cdo-Process-ProcessAdapter-Start-System-String,System-String- 'GetcuReone.Cdo.Process.ProcessAdapter.Start(System.String,System.String)')
- [ProcessService](#T-GetcuReone-Cdo-Process-ProcessService 'GetcuReone.Cdo.Process.ProcessService')
  - [Start()](#M-GetcuReone-Cdo-Process-ProcessService-Start-System-String,System-String- 'GetcuReone.Cdo.Process.ProcessService.Start(System.String,System.String)')
- [XmlHelper](#T-GetcuReone-Cdo-Helpers-XmlHelper 'GetcuReone.Cdo.Helpers.XmlHelper')
  - [DeserializeFromXml\`\`1(stream)](#M-GetcuReone-Cdo-Helpers-XmlHelper-DeserializeFromXml``1-System-IO-Stream- 'GetcuReone.Cdo.Helpers.XmlHelper.DeserializeFromXml``1(System.IO.Stream)')
  - [DeserializeFromXml\`\`1(xml,encoding)](#M-GetcuReone-Cdo-Helpers-XmlHelper-DeserializeFromXml``1-System-String,System-Text-Encoding- 'GetcuReone.Cdo.Helpers.XmlHelper.DeserializeFromXml``1(System.String,System.Text.Encoding)')
  - [SerializeToStream\`\`2(serializeObj,stream)](#M-GetcuReone-Cdo-Helpers-XmlHelper-SerializeToStream``2-``0,``1- 'GetcuReone.Cdo.Helpers.XmlHelper.SerializeToStream``2(``0,``1)')
  - [SerializeToTextWriter\`\`1(serializeObj,writer)](#M-GetcuReone-Cdo-Helpers-XmlHelper-SerializeToTextWriter``1-``0,System-IO-TextWriter- 'GetcuReone.Cdo.Helpers.XmlHelper.SerializeToTextWriter``1(``0,System.IO.TextWriter)')
  - [Serialize\`\`1(serializeObj)](#M-GetcuReone-Cdo-Helpers-XmlHelper-Serialize``1-``0- 'GetcuReone.Cdo.Helpers.XmlHelper.Serialize``1(``0)')
  - [Serialize\`\`1(serializeObj,encoding)](#M-GetcuReone-Cdo-Helpers-XmlHelper-Serialize``1-``0,System-Text-Encoding- 'GetcuReone.Cdo.Helpers.XmlHelper.Serialize``1(``0,System.Text.Encoding)')

<a name='T-GetcuReone-Cdo-Folder-AppDataFolderAdapter'></a>
## AppDataFolderAdapter `type`

##### Namespace

GetcuReone.Cdo.Folder

##### Summary

Adapter for folder '{current_directory}/AppData'

<a name='M-GetcuReone-Cdo-Folder-AppDataFolderAdapter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='T-GetcuReone-Cdo-Folder-CurrentFolderAdapter'></a>
## CurrentFolderAdapter `type`

##### Namespace

GetcuReone.Cdo.Folder

##### Summary

Adapter for [IFolder](#T-GetcuReone-Cdo-Folder-IFolder 'GetcuReone.Cdo.Folder.IFolder'). Current folder.

<a name='M-GetcuReone-Cdo-Folder-CurrentFolderAdapter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='T-GetcuReone-Cdo-Email-EmailAdapter'></a>
## EmailAdapter `type`

##### Namespace

GetcuReone.Cdo.Email

##### Summary

Adapter for [IEmail](#T-GetcuReone-Cdo-Email-IEmail 'GetcuReone.Cdo.Email.IEmail').

<a name='M-GetcuReone-Cdo-Email-EmailAdapter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='M-GetcuReone-Cdo-Email-EmailAdapter-OpenEmail-GetcuReone-Cdm-Communication-Email-'></a>
### OpenEmail() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Email-EmailAdapter-OpenEmail-GetcuReone-Cdm-Communication-Email,System-String-'></a>
### OpenEmail() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Email-EmailService'></a>
## EmailService `type`

##### Namespace

GetcuReone.Cdo.Email

##### Summary

Service for email.

<a name='P-GetcuReone-Cdo-Email-EmailService-FactoryName'></a>
### FactoryName `property`

##### Summary

*Inherit from parent.*

<a name='M-GetcuReone-Cdo-Email-EmailService-OpenEmail-GetcuReone-Cdm-Communication-Email-'></a>
### OpenEmail() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Email-EmailService-OpenEmail-GetcuReone-Cdm-Communication-Email,System-String-'></a>
### OpenEmail() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-File-FileAdapter'></a>
## FileAdapter `type`

##### Namespace

GetcuReone.Cdo.File

##### Summary

adapter for [IFile](#T-GetcuReone-Cdo-File-IFile 'GetcuReone.Cdo.File.IFile').

<a name='M-GetcuReone-Cdo-File-FileAdapter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='M-GetcuReone-Cdo-File-FileAdapter-Open-System-String,System-IO-FileMode-'></a>
### Open(filePath,mode) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |
| mode | [System.IO.FileMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileMode 'System.IO.FileMode') | Opening mode. |

<a name='M-GetcuReone-Cdo-File-FileAdapter-OpenRead-System-String-'></a>
### OpenRead(filePath) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |

<a name='M-GetcuReone-Cdo-File-FileAdapter-OpenWrite-System-String-'></a>
### OpenWrite(filePath) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |

<a name='M-GetcuReone-Cdo-File-FileAdapter-ReadAllText-System-String-'></a>
### ReadAllText(filePath) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |

<a name='M-GetcuReone-Cdo-File-FileAdapter-ReadAllText-System-String,System-Text-Encoding-'></a>
### ReadAllText(filePath,encoding) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | File encoding. |

<a name='M-GetcuReone-Cdo-File-FileAdapter-WriteAllText-System-String,System-String-'></a>
### WriteAllText(filePath,text) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File text. |

<a name='M-GetcuReone-Cdo-File-FileAdapter-WriteAllText-System-String,System-String,System-Text-Encoding-'></a>
### WriteAllText(filePath,text,encoding) `method`

##### Summary

*Inherit from parent.*

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File text. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | File encoding. |

<a name='T-GetcuReone-Cdo-File-FileService'></a>
## FileService `type`

##### Namespace

GetcuReone.Cdo.File

##### Summary

*Inherit from parent.*

<a name='M-GetcuReone-Cdo-File-FileService-#ctor-System-String-'></a>
### #ctor(filePath) `constructor`

##### Summary

Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File path. |

<a name='M-GetcuReone-Cdo-File-FileService-Open-System-IO-FileMode-'></a>
### Open() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-FileService-OpenRead'></a>
### OpenRead() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-FileService-OpenWrite'></a>
### OpenWrite() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-FileService-ReadAllText'></a>
### ReadAllText() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-FileService-ReadAllText-System-Text-Encoding-'></a>
### ReadAllText() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-FileService-WriteAllText-System-String-'></a>
### WriteAllText() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-FileService-WriteAllText-System-String,System-Text-Encoding-'></a>
### WriteAllText() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Folder-FolderAdapterBase'></a>
## FolderAdapterBase `type`

##### Namespace

GetcuReone.Cdo.Folder

##### Summary

Base clas for folder adapter

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-ContainFile-System-String-'></a>
### ContainFile(fileName) `method`

##### Summary

Contain file.

##### Returns

True - file contain

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | имя файла |

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-CreateCurrentFolder'></a>
### CreateCurrentFolder() `method`

##### Summary

Create current folder.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-DeleteFile-System-String-'></a>
### DeleteFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-DownloadFile-System-String-'></a>
### DownloadFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-ExistsCurrentFolder'></a>
### ExistsCurrentFolder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetFiles'></a>
### GetFiles() `method`

##### Summary

Get files.

##### Returns

File paths.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetFiles-System-String-'></a>
### GetFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetFullName-System-String-'></a>
### GetFullName(fileName) `method`

##### Summary

Get file path.

##### Returns

File path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File name. |

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-GetPath'></a>
### GetPath() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderAdapterBase-RenameFile-System-String,System-String-'></a>
### RenameFile(newName,oldName) `method`

##### Summary

Rename file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | New name file. |
| oldName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Old name file. |

<a name='T-GetcuReone-Cdo-Folder-FolderService'></a>
## FolderService `type`

##### Namespace

GetcuReone.Cdo.Folder

##### Summary

*Inherit from parent.*

<a name='M-GetcuReone-Cdo-Folder-FolderService-#ctor-System-String-'></a>
### #ctor(folderPath) `constructor`

##### Summary

Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdo-Folder-FolderService-CreateFolder'></a>
### CreateFolder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-DeleteFile-System-String-'></a>
### DeleteFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-DownloadFile-System-String-'></a>
### DownloadFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-ExistsCurrentFolder'></a>
### ExistsCurrentFolder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-GetFileInfo-System-String-'></a>
### GetFileInfo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-GetFiles'></a>
### GetFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-GetFiles-System-String-'></a>
### GetFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-GetPath'></a>
### GetPath() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-FolderService-MoveTo-System-String,System-String-'></a>
### MoveTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Email-IEmail'></a>
## IEmail `type`

##### Namespace

GetcuReone.Cdo.Email

##### Summary

Service for email.

<a name='M-GetcuReone-Cdo-Email-IEmail-OpenEmail-GetcuReone-Cdm-Communication-Email-'></a>
### OpenEmail(email) `method`

##### Summary

Open email in default email program.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [GetcuReone.Cdm.Communication.Email](#T-GetcuReone-Cdm-Communication-Email 'GetcuReone.Cdm.Communication.Email') | Email Information |

<a name='M-GetcuReone-Cdo-Email-IEmail-OpenEmail-GetcuReone-Cdm-Communication-Email,System-String-'></a>
### OpenEmail(email,fileEmail) `method`

##### Summary

Open email in default email program.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [GetcuReone.Cdm.Communication.Email](#T-GetcuReone-Cdm-Communication-Email 'GetcuReone.Cdm.Communication.Email') |  |
| fileEmail | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Email Information |

<a name='T-GetcuReone-Cdo-File-IFile'></a>
## IFile `type`

##### Namespace

GetcuReone.Cdo.File

##### Summary

For work with [](#N-GetcuReone-Cdo-File 'GetcuReone.Cdo.File')

<a name='M-GetcuReone-Cdo-File-IFile-Open-System-IO-FileMode-'></a>
### Open(mode) `method`

##### Summary

Open.

##### Returns

File stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mode | [System.IO.FileMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileMode 'System.IO.FileMode') | Opening mode. |

<a name='M-GetcuReone-Cdo-File-IFile-OpenRead'></a>
### OpenRead() `method`

##### Summary

Open read.

##### Returns

File stream

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-IFile-OpenWrite'></a>
### OpenWrite() `method`

##### Summary

Open write.

##### Returns

File stream in write mode.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-IFile-ReadAllText'></a>
### ReadAllText() `method`

##### Summary

Read all text.

##### Returns

File text.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-File-IFile-ReadAllText-System-Text-Encoding-'></a>
### ReadAllText(encoding) `method`

##### Summary

Read all text.

##### Returns

File text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | File encoding. |

<a name='M-GetcuReone-Cdo-File-IFile-WriteAllText-System-String-'></a>
### WriteAllText(text) `method`

##### Summary

Write all text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdo-File-IFile-WriteAllText-System-String,System-Text-Encoding-'></a>
### WriteAllText(text,encoding) `method`

##### Summary

Write all text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File text. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | File encoding. |

<a name='T-GetcuReone-Cdo-Folder-IFolder'></a>
## IFolder `type`

##### Namespace

GetcuReone.Cdo.Folder

##### Summary

A service for working with folders in the file system.

<a name='M-GetcuReone-Cdo-Folder-IFolder-CreateFolder'></a>
### CreateFolder() `method`

##### Summary

Create current folder.

##### Returns

Folder info.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-IFolder-DeleteFile-System-String-'></a>
### DeleteFile(fileName) `method`

##### Summary

Delete file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | имя файла |

<a name='M-GetcuReone-Cdo-Folder-IFolder-DownloadFile-System-String-'></a>
### DownloadFile(filePath) `method`

##### Summary

Download file in folder.

##### Returns

File info.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | путь к файлу |

<a name='M-GetcuReone-Cdo-Folder-IFolder-ExistsCurrentFolder'></a>
### ExistsCurrentFolder() `method`

##### Summary

Is the current folder contained in the file system.

##### Returns

True - folder exists.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-IFolder-GetFileInfo-System-String-'></a>
### GetFileInfo(fileName) `method`

##### Summary

Return file info.

##### Returns

File info.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Relative file name. |

<a name='M-GetcuReone-Cdo-Folder-IFolder-GetFiles'></a>
### GetFiles() `method`

##### Summary

Get files.

##### Returns

Files.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-IFolder-GetFiles-System-String-'></a>
### GetFiles(searchPattern) `method`

##### Summary

Get files.

##### Returns

Files.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Search pattern. |

<a name='M-GetcuReone-Cdo-Folder-IFolder-GetPath'></a>
### GetPath() `method`

##### Summary

Get path current folder.

##### Returns

Current folder path.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Folder-IFolder-MoveTo-System-String,System-String-'></a>
### MoveTo(newFilePath,oldName) `method`

##### Summary

Move file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | New file path. |
| oldName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Old file name. |

<a name='T-GetcuReone-Cdo-Process-IProcess'></a>
## IProcess `type`

##### Namespace

GetcuReone.Cdo.Process

##### Summary

Service for process.

<a name='M-GetcuReone-Cdo-Process-IProcess-Start-System-String,System-String-'></a>
### Start(processName,args) `method`

##### Summary

Start process.

##### Returns

Process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| processName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Process name. |
| args | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Process arguments. |

<a name='T-GetcuReone-Cdo-Process-ProcessAdapter'></a>
## ProcessAdapter `type`

##### Namespace

GetcuReone.Cdo.Process

##### Summary

Adapter for [IProcess](#T-GetcuReone-Cdo-Process-IProcess 'GetcuReone.Cdo.Process.IProcess').

<a name='M-GetcuReone-Cdo-Process-ProcessAdapter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='M-GetcuReone-Cdo-Process-ProcessAdapter-Start-System-String,System-String-'></a>
### Start() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Process-ProcessService'></a>
## ProcessService `type`

##### Namespace

GetcuReone.Cdo.Process

##### Summary

*Inherit from parent.*

<a name='M-GetcuReone-Cdo-Process-ProcessService-Start-System-String,System-String-'></a>
### Start() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Helpers-XmlHelper'></a>
## XmlHelper `type`

##### Namespace

GetcuReone.Cdo.Helpers

##### Summary

Helper for xml operation.

<a name='M-GetcuReone-Cdo-Helpers-XmlHelper-DeserializeFromXml``1-System-IO-Stream-'></a>
### DeserializeFromXml\`\`1(stream) `method`

##### Summary

Deserialize obj `TDeserializeObj` type from `stream`.

##### Returns

Deserializable object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Stream. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDeserializeObj | The type of the object being deserialized. |

<a name='M-GetcuReone-Cdo-Helpers-XmlHelper-DeserializeFromXml``1-System-String,System-Text-Encoding-'></a>
### DeserializeFromXml\`\`1(xml,encoding) `method`

##### Summary

Desirialize from string.

##### Returns

Deserializable object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Xml string. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | Encoding. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDeserializeObj | The type of the object being deserialized. |

<a name='M-GetcuReone-Cdo-Helpers-XmlHelper-SerializeToStream``2-``0,``1-'></a>
### SerializeToStream\`\`2(serializeObj,stream) `method`

##### Summary

Serialize `serializeObj` in `stream`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serializeObj | [\`\`0](#T-``0 '``0') | Serializable object. |
| stream | [\`\`1](#T-``1 '``1') | Stream. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSerializeObj | The type of the object being serialized. |
| TStream | Stream type. |

<a name='M-GetcuReone-Cdo-Helpers-XmlHelper-SerializeToTextWriter``1-``0,System-IO-TextWriter-'></a>
### SerializeToTextWriter\`\`1(serializeObj,writer) `method`

##### Summary

Serialize `serializeObj` in `writer`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serializeObj | [\`\`0](#T-``0 '``0') | Serializable object. |
| writer | [System.IO.TextWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextWriter 'System.IO.TextWriter') | Write stream. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSerializeObj | The type of the object being serialized. |

<a name='M-GetcuReone-Cdo-Helpers-XmlHelper-Serialize``1-``0-'></a>
### Serialize\`\`1(serializeObj) `method`

##### Summary

Serialize `serializeObj` in [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

Xml text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serializeObj | [\`\`0](#T-``0 '``0') | Serializable object. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSerializeObj | The type of the object being serialized. |

<a name='M-GetcuReone-Cdo-Helpers-XmlHelper-Serialize``1-``0,System-Text-Encoding-'></a>
### Serialize\`\`1(serializeObj,encoding) `method`

##### Summary

Serialize `serializeObj` in [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

Xml text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serializeObj | [\`\`0](#T-``0 '``0') | Serializable object. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | Encoding. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSerializeObj | The type of the object being serialized. |
