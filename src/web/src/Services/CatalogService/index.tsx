import {useEffect, useState} from "react";
import axios from "axios";
import { Product, emptyProducts } from '../../Models/Product';

const CatalogService = () => {
    const [products, setProducts] = useState(emptyProducts);

    useEffect(() => {
        axios.get<Product[]>("http://localhost:5264/api/catalog/", { 
            headers: { 
                "Content-Type": "application/json", 
            },
        })
        .then((response) => setProducts(response.data))
        .catch((error) => console.error(error));
    }, []);

    return products;
}

export default CatalogService;

