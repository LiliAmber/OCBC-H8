from markupsafe import escape
from flask import Flask, request, render_template
# from flask import request
# from flask import render_template
import webbrowser
from authorBook import author_book

# instance dari Flask
app = Flask(__name__)

# @app.route('/endpoints name') => decorator bawaan dari flask
@app.route('/')

def hello_world():
    name = 'spongebob & patrick'
    # return f'<h1>Hello there !</h1> \n Welcome {name}'
    pageContent = f'<h1>Hello there !</h1> \n Welcome {name}'
    pageContent += '<p>this is paragraph</p>'
    return pageContent

# case yg seperti ini /<value>, maka setiap value yg di input ke dalam endpoint akan di pass ke dalam function yg menangkap variable dengan nama value, dan akan di proses dalam function tersebut
@app.route('/<name>')
# function yg menangkap value dari /<name>
def greeting(name):
    return f'Hello { escape(name) }'

# ===VARIABLE RULES===
# Variable RulesYou can add variable sections to a URL by marking sections with <variable_name>. Your function then receives the<variable_name> as a keyword argument. Optionally, you can use a converter to specify the type of the argumentlike<converter:variable_name>.

@app.route('/user/<username>')
def show_user_profile(username):    
    # show the user profile for that user    
    return f'User {escape(username)}'

@app.route('/post/<int:post_id>')
def show_post(post_id):    
    # show the post with the given id, the id is an integer    
    return f'Post {post_id}'

@app.route('/path/<path:subpath>')
def show_subpath(subpath):    
    # show the subpath after /path/    
    return f'Subpath {escape(subpath)}'

# HTTP METHOD
@app.route('/login', methods=['GET', 'POST'])
def login():    
    if request.method == 'POST':        
        # return do_the_login()
        return 'ini login'
    else:        
        # return show_the_login_form()
        return 'salah method'

# Rendering Templates
# url_for('static', filename='style.css')
@app.route('/hello/')
@app.route('/hello/<name>')
def hello(name=None):
    return render_template('hello.html', name=name)

@app.route('/author', methods=["GET", "POST"])
def author():
    if 'author_id' in request.form:
        author_book[request.form['author_id']] = []

    return render_template('author.html', author_book = author_book)

@app.route('/books/<int:author_id>')
def books(author_id):
    return render_template('book.html',  id = author_id)

@app.route('/book/<int:author_id>')
def books1(author_id):
    return render_template('book1.html',  authorId = author_id, bookList = author_book[author_id])
# apakah dijalankan sebagai stand alone script
if __name__ == '__main__':
    # debug = True --> digunakan supaya auto reload app.py tanpa terminate proses di app.py, tpi yg di browser harus tetep di refresh untuk liat perubahan yg udah dilakukan di app.py
    webbrowser.open('http://127.0.0.1:5000/')
    app.run(debug = True)