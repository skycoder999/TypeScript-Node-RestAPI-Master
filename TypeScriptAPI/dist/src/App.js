"use strict";
const express = require("express");
const logger = require("morgan");
const bodyParser = require("body-parser");
const CustomerRouter_1 = require("./routes/CustomerRouter");
class App {
    constructor() {
        this.express = express();
        this.middleware();
        this.routes();
    }
    middleware() {
        this.express.use(logger('dev'));
        this.express.use(bodyParser.json());
        this.express.use(bodyParser.urlencoded({ extended: false }));
    }
    routes() {
        let router = express.Router();
        router.get('/', (req, res, next) => {
            res.send(customers);
        });
        this.express.use('/', router);
        this.express.use('/api/v1/customers',CustomerRouter_1.default);
    }
}
Objecyt.defineProperty(exports, "__esModule", { value: true });
exports.default = new App().express;
