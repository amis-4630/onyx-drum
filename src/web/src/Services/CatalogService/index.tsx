import React, {useEffect, useState} from "react";
import axios from "axios";
import { Product, emptyProducts } from '../../Models/Product';

const CatalogService = () => {
    const [products, setProducts]: [Product[], (products: Product[]) => void] = useState(emptyProducts);

    useEffect(() => {
        axios.get<Product[]>("http://http://localhost:5264/api/catalog/",
            { 
                headers: { 
                    "Content-Type": "application/json", 
                },
            })
            .then((response) => setProducts(response.data))
            .catch((error)) => console.log(error));
    }, []);
}

