# Fibonacci Rest Service

This Microservice offers the ability to calculate the [Fibonacci numbers](https://en.wikipedia.org/wiki/Fibonacci_number) within the sending of an HTTP Request. Fibonacci numbers are clipped at 100.

## Summary

  - [Getting Started](#getting-started)
  - [Runing the tests](#running-the-tests)
  - [Deployment](#deployment)
  - [Built With](#built-with)
  - [Authors](#authors)
  - [License](#license)
  - [Acknowledgments](#acknowledgments)

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them:

- DotNet core: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

Optional:

- Docker: [https://www.docker.com/get-started](https://www.docker.com/get-started)
- Python: [https://wiki.python.org/moin/BeginnersGuide/Download](https://wiki.python.org/moin/BeginnersGuide/Download)

### Installing

A step by step series of examples that tell you how to get a development env running

**All the following commands have to be executed in the Service Directory.**

You could run the service by running:

    dotnet run

You are also able build a docker image by running:

    docker build -t $IMAGE_NAME .

you could then run the image by running:

    docker run -p 8080:80 -it $IMAGE_NAME .

Here are some example requests using curl:

    curl -XGET http://localhost:8080/helloapi/fibonacci/0
    curl -XGET http://localhost:8080/helloapi/fibonacci/5
    curl -XGET http://localhost:8080/helloapi/fibonacci/12

## Running the tests

The test could be run by running the following command in the Tests directory:

    dotnet test

### Stick and Stone Testing

There is also Python Script which can automate the process of generating a text file that contains sample requests with curl and the response from the server. It could be run like this:

    python stick_and_stone_testing.py -o $OUTPUT_FILE -h $HOST

The `$HOST` is the hostname and port of the machine running the service. For Example:

    localhost:8080

## Deployment

You could use the Dockerfile in the Service directory to build an image which could be deployed in a variety of environments.

## Built With

- [DotNet](https://dotnet.microsoft.com/) - Used ASP.Net as web framework
- [XUnit](https://xunit.net/) - Testing Framework
- [Docker](https://www.docker.com/) - Dockerization
- [Python](https://www.python.org/) - Automation

## Authors

  - **Philipp Haustein** - *Initial Work* -
    [MrInformatic](https://github.com/MrInformatic)

See also the list of
[contributors](https://github.com/MrInformatic/FibonacciRestService/contributors)
who participated in this project.

## License

This project is licensed under the [MIT](LICENSE.md)
License - see the [LICENSE.md](LICENSE.md) file for
details

## Acknowledgments

- The contributors of [a-good-readme-template](https://github.com/PurpleBooth/a-good-readme-template) for providing a good readme template
- [Rosetta Code](https://rosettacode.org/wiki/Rosetta_Code) for providing a starting of point for the Fibonacci Algorithm that I use.