# DataModel

* [Номенклатура](./Ojb__NmcCategory.md)
```mermaid
erDiagram
  Nmc {    
    String Title "Наименование"    
    String Name "Название"    
    UnitOfMeasure MeasureUnit "Единица измерения"
    EActualilty Actuality "Актуальнось"
    String Remarks "Примечания"
    
    Nmc Parent "Родительский объект"
    Boolean IsGroup "Является группой"
    
    GUID GlobalID "Глобальный ID"
    User CreationUser "Автор создания"
    DateTime CreationDate "Дата создания"
    User ModificationUser "Автор изменения"
    DateTime ModificationData "Дата модификации"
    EValidationResult ValidationResult "Валидный ли объект"
    InfoOfValidation ValidationInfo "Валидация"
  }
```

```mermaid
erDiagram
  EValidationResult {
    Int32_00 ValidationNotActual "Валидация не актуальна / не проводилась"
    Int32_10 Valid "Валидно"
    Int32_15 ValidWithSubjections "Валидно c замечаниями"
    Int32_20 Invalid "Не валидно"
  }
```



```mermaid
erDiagram
  InfoOfValidation {
    DateTime TimeStamp "Время заключения"
    Boolean IsDataCorrect "Содержит корректные данные"
    String DataObjections "Замечания по данным"
    Boolean IsDuplicate "Является ли дубликатом"
    InfoOfDuplicate DuplicateInfo "Информация о дубликате"
    String Remarks "Примечания"
  }
```

```mermaid
erDiagram
  InfoOfDuplicate {
    Int32 DuplicateNumber "Номер дубликата"
    Nmc DuplicateOf
    
    DateTime TimeStamp "Время заключения"
    EValidation ValidationResult "Результат валидации"    
    String Remarks "Примечания"
  }
```

* [Срок актуальности заключения СЕБ](./Ojb__SEBConclusionActualityTime.md)

```mermaid
erDiagram
  SEBConclusionActualityTime {
    String Title "Наименование"
    String Name "Название"
    EActualilty Actuality "Актуальнось"
    String Remarks "Примечания"
    TimeSpan ActualityTime_Days "Время актуальности, дней"    
  }
```
