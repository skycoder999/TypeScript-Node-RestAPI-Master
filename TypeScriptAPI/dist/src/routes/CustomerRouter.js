"use strict";
const express_1 = require("express");
const customers = require('../data');
class CustomerRouter {
    constructor() {
        this.router = express_1.Router();
        this.init();
    }
    getAll(req, res, next) {
        res.send(customers);
    }
    init() {
        this.router.get('/', this.getAll);
    }
}
exports.CustomerRouter = CustomerRouter;
const customerRoutes = new CustomerRouter();
customerRoutes.init();
Object.defineProperty(exports, "__esModule", { value: true });
exports.default = customerRoutes.router;
