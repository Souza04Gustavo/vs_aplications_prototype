from flask import Flask, request, render_template, jsonify, send_from_directory
import os

app = Flask(__name__)

# Configurações iniciais
title = "Servidor de Arquivos e Controle Lógico"
led_status = "Desligado"
image_filename = "Nenhuma imagem recebida"
gcode_filename = "Nenhum G-Code recebido"
UPLOAD_FOLDER = "uploads"
os.makedirs(UPLOAD_FOLDER, exist_ok=True)

@app.route('/')
def index():
    return render_template("index.html", title=title, led_status=led_status,
                           image_filename=image_filename, gcode_filename=gcode_filename)

@app.route('/upload-image', methods=['POST'])
def upload_image():
    global image_filename
    if 'file' not in request.files:
        return jsonify({"error": "Nenhum arquivo enviado"}), 400
    file = request.files['file']
    if file.filename == '':
        return jsonify({"error": "Nome de arquivo inválido"}), 400
    image_filename = file.filename
    file.save(os.path.join(UPLOAD_FOLDER, image_filename))
    return jsonify({"message": "Imagem recebida com sucesso", "filename": image_filename})

@app.route('/upload-gcode', methods=['POST'])
def upload_gcode():
    global gcode_filename
    if 'file' not in request.files:
        return jsonify({"error": "Nenhum arquivo enviado"}), 400
    file = request.files['file']
    if file.filename == '':
        return jsonify({"error": "Nome de arquivo inválido"}), 400
    gcode_filename = file.filename
    file.save(os.path.join(UPLOAD_FOLDER, gcode_filename))
    return jsonify({"message": "G-Code recebido com sucesso", "filename": gcode_filename})

@app.route('/toggle-led', methods=['POST'])
def toggle_led():
    global led_status
    led_status = "Ligado" if led_status == "Desligado" else "Desligado"
    return jsonify({"message": "LED atualizado", "status": led_status})

# Rota para servir arquivos estáticos da pasta uploads
@app.route('/uploads/<filename>')
def uploaded_file(filename):
    return send_from_directory(UPLOAD_FOLDER, filename)

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000, debug=True)
