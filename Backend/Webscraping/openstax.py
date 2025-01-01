import requests
from bs4 import BeautifulSoup

chapter_url = "https://openstax.org/books/prealgebra-2e/pages/3-3-subtract-integers"

response = requests.get(chapter_url)

if response.status_code == 200:
    # Parse the HTML content of the page with specified encoding
    soup = BeautifulSoup(response.text, "html.parser", from_encoding="utf-8")

    # Find the section with class 'section-exercises'
    section_exercises = soup.find("section", class_="section-exercises")

    # Find all sections within 'section-exercises'
    exercise_sections = section_exercises.find_all("section")

    # Extract and print the exercise content
    for section_index, section in enumerate(exercise_sections, start=1):
        exercise_elements = section.find_all("div")
        for exercise_index, exercise in enumerate(exercise_elements, start=1):
            exercise_text = exercise.get_text(strip=True)
            decoded_text = exercise_text
            print(
                "Section {}, Exercise {}:\n{}\n".format(
                    section_index, exercise_index, decoded_text
                )
            )

else:
    print(f"Failed to retrieve the page. Status code: {response.status_code}")
