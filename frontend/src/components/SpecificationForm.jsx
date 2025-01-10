import React, { useState } from "react";

const SpecificationForm = ({ onAddSpecification }) => {
  const [specification, setSpecification] = useState({
    name: "",
    description: "",
    quantity: 1,
    price: 0,
  });

  const handleSubmit = (e) => {
    e.preventDefault();
    onAddSpecification(specification);
    setSpecification({ name: "", description: "", quantity: 1, price: 0 });
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        placeholder="Name"
        value={specification.name}
        onChange={(e) =>
          setSpecification({ ...specification, name: e.target.value })
        }
        required
      />
      <textarea
        placeholder="Description"
        value={specification.description}
        onChange={(e) =>
          setSpecification({ ...specification, description: e.target.value })
        }
        required
      />
      <input
        type="number"
        placeholder="Quantity"
        value={specification.quantity}
        onChange={(e) =>
          setSpecification({ ...specification, quantity: +e.target.value })
        }
        required
      />
      <input
        type="number"
        placeholder="Price"
        value={specification.price}
        onChange={(e) =>
          setSpecification({ ...specification, price: +e.target.value })
        }
        required
      />
      <button type="submit">Add</button>
    </form>
  );
};

export default SpecificationForm;
