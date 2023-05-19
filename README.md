# [Сервер глобальних даних](Kusto/Documents/20230519__GlobalDataServer.md)

```mermaid
---
title: Схема взаємодії систем Кусто Агро
---
flowchart TD
    subgraph PS ["Primary system"]
        subgraph OneS ["1C"]
        OneS_DB_Mng[("DB Упр.")]
        OneS_DB_Acc[("DB Бух.")]
        
        OneS_DB_Mng <.-> OneS_DB_Acc
        end

        subgraph GDS["Сервер глобальних даних"]
        KGDS_DB[(DB)]
        end
    end
    
    
    subgraph Elma ["ELMA"]
    Elma_DB[(DB)]
    end

    subgraph Cropio ["Cropio"]
    Cropio_DB[(DB)]
    end

    subgraph Aps ["APS Tender"]
    Aps_DB[(DB)]
    end
    
    
    OneS_DB_Mng <==>|DS01| GDS
    GDS <==>|DS02| Elma
    GDS <==>|DS03| Cropio
    GDS <==>|DS04| Aps
    Elma <-.->|DS05| Aps
    Elma <-.->|DS06| OneS
    Elma <-.->|DS07| Cropio
    
    style GDS stroke:#f66,stroke-width:2px,color:#fff
    style OneS stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
```

**Перелік глобальних даних, що синхронізіються між `1С` та Сервером глобальних даних: (далі `GDS` або `Global Data Server`)**
| Що буде передаватись між `1C` та | `GDS` |
| --- | :---: |
| Робітник | :heavy_check_mark: |
| Посада | :heavy_check_mark: |
| Підприємство | :heavy_check_mark: |
| Стаття б'юджету | :heavy_check_mark: |
| Группа номенклатури | :heavy_check_mark: |
| Номенклатура | :heavy_check_mark: |

| Що буде передаватись між `GDS` та | `ELMA` | `APS Tender` | `Cropio` |
| --- | :---: | :---: | :---: |
| Робітник | :heavy_check_mark: |  |  |
| Посада | :heavy_check_mark: |||
| Підприємство | :heavy_check_mark: |||
| Стаття б'юджету | :heavy_check_mark: |||
| Группа номенклатури | :heavy_check_mark: |||
| Номенклатура | :heavy_check_mark: |||


