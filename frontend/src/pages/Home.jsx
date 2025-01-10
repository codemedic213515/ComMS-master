import React, { useState } from "react";
import SpecificationForm from "../components/SpecificationForm";
import api from "../services/api";

const Home = () => {
  const [specifications, setSpecifications] = useState([]);
  const [customerName, setCustomerName] = useState("");

  const addSpecification = (spec) => {
    setSpecifications([...specifications, spec]);
  };

  const saveQuotation = async () => {
    const quotation = { customerName, specifications };
    try {
      await api.post("/quotation", quotation);
      alert("Quotation saved successfully!");
    } catch (error) {
      console.error(error);
      alert("Error saving quotation");
    }
  };

  return (
    <div>
      <h1>Quotation System</h1>
      <input
        type="text"
        placeholder="Customer Name"
        value={customerName}
        onChange={(e) => setCustomerName(e.target.value)}
        required
      />
      <SpecificationForm onAddSpecification={addSpecification} />
      <button onClick={saveQuotation}>Save Quotation</button>
    </div>
  );
};

export default Home;
