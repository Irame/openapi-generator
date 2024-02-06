/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.3.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * ArrayOfNumberOnly.h
 *
 * 
 */

#ifndef ArrayOfNumberOnly_H_
#define ArrayOfNumberOnly_H_



#include <vector>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  ArrayOfNumberOnly 
{
public:
    ArrayOfNumberOnly() = default;
    explicit ArrayOfNumberOnly(boost::property_tree::ptree const& pt);
    virtual ~ArrayOfNumberOnly() = default;

    ArrayOfNumberOnly(const ArrayOfNumberOnly& other) = default; // copy constructor
    ArrayOfNumberOnly(ArrayOfNumberOnly&& other) noexcept = default; // move constructor

    ArrayOfNumberOnly& operator=(const ArrayOfNumberOnly& other) = default; // copy assignment
    ArrayOfNumberOnly& operator=(ArrayOfNumberOnly&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// ArrayOfNumberOnly members

    /// <summary>
    /// 
    /// </summary>
    std::vector<double> getArrayNumber() const;
    void setArrayNumber(std::vector<double> value);

protected:
    std::vector<double> m_ArrayNumber;
};

std::vector<ArrayOfNumberOnly> createArrayOfNumberOnlyVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<ArrayOfNumberOnly>(const ArrayOfNumberOnly& val) {
    return val.toPropertyTree();
}

template<>
inline ArrayOfNumberOnly fromPt<ArrayOfNumberOnly>(const boost::property_tree::ptree& pt) {
    ArrayOfNumberOnly ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* ArrayOfNumberOnly_H_ */
