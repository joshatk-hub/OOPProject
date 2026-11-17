# Changelog

format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

## [week4-4d] - 2026-11-17

### Added
- Order confirmation system tied to accounts. Guest order confirmations are shown but not persisted (`1dff2b9`)
- Orders can be saved, deleted and applied to the cart, and are tied directly to accounts (`6ad1ef5`)
- Account creation. Accounts are saved so users can sign in later (`1d5ce34`)

### Security
- Account service properly implemented with salted and hashed passwords, replacing the earlier loose string-based password matching (`1d5ce34`)

## [week3-3c] - 2026-11-12

### Added
- Customer account logic, built on the new account system (`4c099f8`)
- Account system with loose, string-based password matching, allowing a user to "log in" (`d561e39`)
- Interface added as requested, with forms updated to use it (`c8b1129`)
- DateTimePicker functionality that follows the business rules in `specialnotes.md` (`4cb255f`)
- "Baker's dozen" pricing rule, as specified in the variant card (`a19716f`)
- "Clear order" button at checkout that removes all orders and generates a new cart (`a19716f`)
- This changelog (`fb0f4f8`)

### Changed
- Several UI elements (`fb0f4f8`)

### Fixed
- Bug in the account logic and in the baker's dozen business rule (`4c099f8`)

## [week2-3b] - 2026-11-10

### Added
- CustomerOrdering form now shows the pre-seeded data in a list view (`f8af901`)
- Cart class that keeps a rolling total of the items in the cart (`37183be`, `4d32286`)
- CustomerAccount class, inheriting from Account (`4d32286`)
- MenuService service (`47d37b8`)
- Sorting menu items by category (`343fc3d`)
- Seasonal items are hidden outside of their season (`d7cd35b`)
- Carts (orders) can be saved and displayed. The Cart class gained methods for saving and loading, and the forms were updated to support it (`b36f538`)

### Changed
- Models and DataStore now read the JSON file and translate it into usable data (`59c9aca`)
- Account is now an abstract class (`4d32286`)
- MenuItem went back and forth between abstract (with SeasonalItem, then RegularItem and SeasonalItem inheriting from it) and a single class, and ended up non-abstract because the abstraction was causing issues (`b27c49f`, `d47f045`, `47d37b8`, `962cc74`, `343fc3d`)

### Removed
- Unneeded classes that were taking up space (`962cc74`)

## [week1-3a] - 2026-10-26

### Added
- Initial project files, `.gitattributes` and `.gitignore` (`5ebe207`, `5d604cc`)
- Project notes markdown file with course-specific rules for the project (`b1eb389`)
- AppState service, which holds the lists of menu items and cart orders (`14f9b4a`)
- `data.json` seed data (menu items, prices, accounts) and the DataStore class that reads and writes it (`babd2c4`)

[week4-3d]: https://github.com/joshatk-hub/OOPProject/tree/week4-3d
[week3-3c]: https://github.com/joshatk-hub/OOPProject/tree/week3-3c
[week2-3b]: https://github.com/joshatk-hub/OOPProject/tree/week2-3b
[week1-3a]: https://github.com/joshatk-hub/OOPProject/tree/week1-3a
