## [Unreleased]

## 2026-11-10

### Added
- Carts (orders) can now be saved and displayed. The Cart class gained methods for saving and loading, and the forms were updated to support it (`b36f538`)
- Customer account logic, built on the new account system (`4c099f8`)
- Account system with loose, string-based password matching, allowing a user to "log in" (`d561e39`)
- Interface added as requested, with forms updated to use it (`c8b1129`)
- DateTimePicker functionality that follows the business rules in specialnotes.md (`4cb255f`)
- "Baker's dozen" pricing rule, as specified in the variant card (`a19716f`)
- "Clear order" button at checkout that removes all orders and generates a new cart (`a19716f`)
- This changelog (`fb0f4f8`)

### Changed
- Several UI elements (`fb0f4f8`)

### Fixed
- Bug in the account logic and in the baker's dozen business rule (`4c099f8`)

## 2026-11-09

### Added
- Sorting menu items by category (`343fc3d`)
- Seasonal items are hidden outside of their season (`d7cd35b`)

### Changed
- MenuItem is no longer abstract, because the abstraction was causing issues (`343fc3d`)
- MenuItem was made abstract again, with RegularItem and SeasonalItem inheriting from it (`962cc74`)

### Removed
- Unneeded classes that were taking up space (`962cc74`)

## 2026-11-03

### Added
- Cart class that keeps a rolling total of the items in the cart (`37183be`, `4d32286`)
- CustomerAccount class, inheriting from Account (`4d32286`)
- MenuService service (`47d37b8`)

### Changed
- Account is now an abstract class (`4d32286`)
- MenuItem is back to a single class, since a separate seasonal item class was judged unnecessary (`47d37b8`)
- MenuItem was briefly made abstract so SeasonalItem could inherit from it, then reverted (`b27c49f`, `d47f045`)

## 2026-10-27

### Added
- CustomerOrdering form now shows the pre-seeded data in a list view (`f8af901`)

### Changed
- Models and DataStore now read the JSON file and translate it into usable data (`59c9aca`)

## 2026-10-26

### Added
- Initial project files, `.gitattributes` and `.gitignore` (`5ebe207`, `5d604cc`)
- AppState service, which holds the lists of menu items and cart orders (`14f9b4a`)
- `data.json` seed data (menu items, prices, accounts) and the DataStore class that reads and writes it (`babd2c4`)
- Project notes markdown file with course-specific rules for the project (`b1eb389`)