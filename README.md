# PC Hardware Information API

This API provides information about various PC hardware components, such as CPU, GPU, RAM, storage, and more. It is designed for applications that require detailed hardware data.

## Endpoints

### Authentication
- **POST** `/api/account/login`: Logs in and retrieves a JWT token.
- **POST** `/api/account/register`: Registers a new user and retrieves a JWT token.

### Hardware Components

#### Cases
- **GET** `/api/case`: Retrieves all cases.
- **GET** `/api/case/by-model`: Retrieves a case by model.
- **GET** `/api/case/by-brand`: Retrieves cases by brand.

#### Coolers
- **GET** `/api/cooler`: Retrieves all coolers.
- **GET** `/api/cooler/by-model`: Retrieves a cooler by model.
- **GET** `/api/cooler/by-brand`: Retrieves coolers by brand.

#### CPUs
- **GET** `/api/cpu`: Retrieves all CPUs.
- **GET** `/api/cpu/by-model`: Retrieves a CPU by model.
- **GET** `/api/cpu/by-brand`: Retrieves CPUs by brand.

#### GPUs
- **GET** `/api/gpu`: Retrieves all GPUs.
- **GET** `/api/gpu/by-model`: Retrieves a GPU by model.
- **GET** `/api/gpu/by-brand`: Retrieves GPUs by brand.

#### Motherboards
- **GET** `/api/mobo`: Retrieves all motherboards.
- **GET** `/api/mobo/by-model`: Retrieves a motherboard by model.
- **GET** `/api/mobo/by-brand`: Retrieves motherboards by brand.

#### PSUs
- **GET** `/api/psu`: Retrieves all PSUs.
- **GET** `/api/psu/by-model`: Retrieves a PSU by model.
- **GET** `/api/psu/by-brand`: Retrieves PSUs by brand.

#### RAM
- **GET** `/api/ram`: Retrieves all RAM modules.
- **GET** `/api/ram/by-model`: Retrieves a RAM module by model.
- **GET** `/api/ram/by-brand`: Retrieves RAM modules by brand.

#### Storage
- **GET** `/api/storage`: Retrieves all storage devices.
- **GET** `/api/storage/by-model`: Retrieves a storage device by model.
- **GET** `/api/storage/by-brand`: Retrieves storage devices by brand.
