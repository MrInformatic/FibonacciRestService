import requests
import argparse
from pathlib import Path

def main():
  parser = argparse.ArgumentParser(description='Does automated stick and stone testing!')
  parser.add_argument("-o", dest="output", metavar="FILE", nargs=1, required=True, type=str, help="The output file")
  parser.add_argument("-h", dest="host", metavar="HOST", nargs=1, required=True, type=str, help="The host")

  args = parser.parse_args()

  output_path = Path(args.output[0])
  host = args.host[0]

  request_values = [
    -100, 
    -10, 
    -3, 
    -2, 
    -1, 
    0, 
    1, 
    2, 
    3, 
    4, 
    5, 
    6, 
    7,
    8,
    9,
    10,
    11,
    12,
    13,
    14,
    100,
    1000,
    "test",
    "test2",
    "3test"
  ]

  with output_path.open("w") as output_file:
    for request_value in request_values:
      url = "http://{}/helloapi/fibonacci/{}".format(host, request_value)

      output_file.write("# Request:\n")
      output_file.write("curl -XGET \'{}\'\n\n".format(url))
      
      response = requests.get(url)

      output_file.write("# Response:\n")
      output_file.write("# status code: {}\n".format(response.status_code))
      output_file.write("# body: {}\n\n".format(response.text))

      output_file.write("# -------------------------------------------------\n\n")


if __name__ == "__main__":
  main()
