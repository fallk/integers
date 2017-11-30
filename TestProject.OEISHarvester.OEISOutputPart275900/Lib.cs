using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A078263
{
public static readonly BigInteger[] Value={ 1L,252L,39483L,5332114L,670592745L,80779853376L,9449772114007L,1082152022374638L,121932631112635269L,BigInteger.Parse("135650052221140070110"),BigInteger.Parse("1371589685334334871208531"),BigInteger.Parse("14951973660666886818972704952") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078263Inst Instance=new A078263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078264
{
public static readonly BigInteger[] Value={ 1L,15L,198L,2309L,25895L,284217L,3074048L,32896079L,349188532L,11646890238L,1171148874112L,122278263238675L,12727490844526758L,1320830780128673820L,BigInteger.Parse("136722265049041488664"),BigInteger.Parse("14120912163801368446154") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078264Inst Instance=new A078264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078265
{
public static readonly long[] Value={ 1L,15L,207L,2544L,30091L,347096L,3931343L,43906441L,484912312L,5306957044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078265Inst : IEnumerable<long>
{
public static readonly long[] Value=A078265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078265.Bytes);
public long this[int i]=>Value[i];

public static A078265Inst Instance=new A078265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078266
{
public static readonly BigInteger[] Value={ 1L,16L,222L,2777L,33333L,388888L,4444444L,49999999L,555555555L,46464646464L,4102564102563L,377777777777777L,35947712418300653L,3508771929824561403L,BigInteger.Parse("349206349206349206348"),BigInteger.Parse("35265700483091787439613"),BigInteger.Parse("3599999999999999999999999") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078266Inst Instance=new A078266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078267
{
public static readonly long[] Value={ 10L,5L,10L,5L,2L,5L,10L,5L,10L,10L,100L,25L,100L,50L,20L,25L,100L,50L,100L,5L,100L,50L,100L,25L,4L,50L,100L,25L,100L,10L,100L,25L,100L,50L,20L,25L,100L,50L,100L,5L,100L,50L,100L,25L,20L,50L,100L,25L,100L,2L,100L,25L,100L,50L,20L,25L,100L,50L,100L,5L,100L,50L,100L,25L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078267Inst : IEnumerable<long>
{
public static readonly long[] Value=A078267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078267.Bytes);
public long this[int i]=>Value[i];

public static A078267Inst Instance=new A078267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078268
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,3L,7L,4L,9L,1L,11L,3L,13L,7L,3L,4L,17L,9L,19L,1L,21L,11L,23L,6L,1L,13L,27L,7L,29L,3L,31L,8L,33L,17L,7L,9L,37L,19L,39L,2L,41L,21L,43L,11L,9L,23L,47L,12L,49L,1L,51L,13L,53L,27L,11L,14L,57L,29L,59L,3L,61L,31L,63L,16L,13L,33L,67L,17L,69L,7L,71L,18L,73L,37L,3L,19L,77L,39L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078268Inst : IEnumerable<long>
{
public static readonly long[] Value=A078268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078268.Bytes);
public long this[int i]=>Value[i];

public static A078268Inst Instance=new A078268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078269
{
public static readonly BigInteger[] Value={ 11L,1221L,132231L,14233241L,1524334251L,162534435261L,17263544536271L,1827364554637281L,192837465564738291L,BigInteger.Parse("1120394857667584931201"),BigInteger.Parse("11213140596877869514031211"),BigInteger.Parse("112231415160798897160514131221") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078269Inst Instance=new A078269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078270
{
public static readonly BigInteger[] Value={ 1L,111L,12021L,1293931L,138575841L,14775857751L,1569413139661L,166124050421571L,17530678687703481L,BigInteger.Parse("101854077969780448291"),BigInteger.Parse("1019376417897988137639201"),BigInteger.Parse("10202855923708990650955830111") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078270Inst Instance=new A078270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078271
{
public static readonly BigInteger[] Value={ 11L,2112L,312213L,41322314L,5142332415L,615243342516L,71625344352617L,8172635445362718L,918273645546372819L,BigInteger.Parse("1102938475665748392110"),BigInteger.Parse("11121304958677685941302111"),BigInteger.Parse("112213141506978879615041312112") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078271Inst Instance=new A078271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078272
{
public static readonly BigInteger[] Value={ 1L,192L,28383L,3756574L,467484765L,55931212956L,6511394941147L,742966858669338L,83479422322397529L,BigInteger.Parse("100267134151431672010") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078272Inst Instance=new A078272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078273
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,100L,1111L,1212L,1131L,1414L,555L,1616L,1717L,1188L,1919L,200L,2121L,2222L,322L,2424L,225L,2262L,2727L,2828L,2929L,300L,1333L,3232L,3333L,3434L,3535L,3636L,333L,3838L,3393L,400L,4141L,4242L,344L,4444L,4455L,644L,4747L,4848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078273Inst : IEnumerable<long>
{
public static readonly long[] Value=A078273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078273.Bytes);
public long this[int i]=>Value[i];

public static A078273Inst Instance=new A078273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078274
{
public static readonly BigInteger[] Value={ 11L,1331L,153351L,17355371L,1937557391L,11315977951311L,133151719917151331L,BigInteger.Parse("1531537191111917351351"),BigInteger.Parse("17315571931111113917551371"),BigInteger.Parse("193157719511131131115917751391"),BigInteger.Parse("1132597197111511331151117917952311"),BigInteger.Parse("13325172991117113511531171119927152331") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078274Inst Instance=new A078274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078275
{
public static readonly BigInteger[] Value={ 22L,2442L,264462L,28466482L,214068861402L,2142618018061422L,BigInteger.Parse("21446182110018261442"),BigInteger.Parse("214661841102112018461462"),BigInteger.Parse("2148618611041122114018661482"),BigInteger.Parse("22406188110611241142116018862402") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078275Inst Instance=new A078275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078308
{
public static readonly long[] Value={ 1L,5L,10L,25L,26L,80L,50L,161L,163L,290L,122L,988L,170L,796L,1580L,2305L,290L,5561L,362L,10670L,9404L,5912L,530L,58436L,16251L,19258L,66340L,118640L,842L,381740L,962L,431105L,547172L,268214L,509500L,3534037L,1370L,1056880L,4813052L,8616326L,1682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078308Inst : IEnumerable<long>
{
public static readonly long[] Value=A078308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078308.Bytes);
public long this[int i]=>Value[i];

public static A078308Inst Instance=new A078308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078309
{
public static readonly long[] Value={ 1L,4L,7L,11L,14L,17L,21L,24L,27L,31L,34L,37L,41L,44L,47L,51L,54L,57L,61L,64L,67L,71L,74L,77L,81L,84L,87L,91L,94L,97L,101L,104L,107L,111L,114L,117L,121L,124L,127L,131L,134L,137L,141L,144L,147L,151L,154L,157L,161L,164L,167L,171L,174L,177L,181L,184L,187L,191L,194L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078309Inst : IEnumerable<long>
{
public static readonly long[] Value=A078309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078309.Bytes);
public long this[int i]=>Value[i];

public static A078309Inst Instance=new A078309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078310
{
public static readonly long[] Value={ 2L,5L,10L,9L,26L,37L,50L,17L,28L,101L,122L,73L,170L,197L,226L,33L,290L,109L,362L,201L,442L,485L,530L,145L,126L,677L,82L,393L,842L,901L,962L,65L,1090L,1157L,1226L,217L,1370L,1445L,1522L,401L,1682L,1765L,1850L,969L,676L,2117L,2210L,289L,344L,501L,2602L,1353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078310Inst : IEnumerable<long>
{
public static readonly long[] Value=A078310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078310.Bytes);
public long this[int i]=>Value[i];

public static A078310Inst Instance=new A078310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078311
{
public static readonly long[] Value={ 2L,5L,2L,3L,2L,37L,2L,17L,2L,101L,2L,73L,2L,197L,2L,3L,2L,109L,2L,3L,2L,5L,2L,5L,2L,677L,2L,3L,2L,17L,2L,5L,2L,13L,2L,7L,2L,5L,2L,401L,2L,5L,2L,3L,2L,29L,2L,17L,2L,3L,2L,3L,2L,5L,2L,5L,2L,5L,2L,1801L,2L,5L,2L,3L,2L,4357L,2L,3L,2L,13L,2L,433L,2L,5477L,2L,3L,2L,5L,2L,3L,2L,5L,2L,3529L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078311Inst : IEnumerable<long>
{
public static readonly long[] Value=A078311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078311.Bytes);
public long this[int i]=>Value[i];

public static A078311Inst Instance=new A078311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078312
{
public static readonly long[] Value={ 2L,5L,5L,3L,13L,37L,5L,17L,7L,101L,61L,73L,17L,197L,113L,11L,29L,109L,181L,67L,17L,97L,53L,29L,7L,677L,41L,131L,421L,53L,37L,13L,109L,89L,613L,31L,137L,17L,761L,401L,29L,353L,37L,19L,13L,73L,17L,17L,43L,167L,1301L,41L,281L,13L,89L,157L,13L,673L,1741L,1801L,1861L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078312Inst : IEnumerable<long>
{
public static readonly long[] Value=A078312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078312.Bytes);
public long this[int i]=>Value[i];

public static A078312Inst Instance=new A078312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078313
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,2L,3L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,1L,2L,2L,3L,3L,2L,2L,4L,1L,2L,2L,2L,3L,3L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,1L,4L,1L,2L,2L,3L,2L,2L,2L,2L,2L,4L,1L,2L,2L,3L,2L,3L,2L,3L,3L,3L,1L,2L,1L,3L,1L,3L,3L,2L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078313Inst : IEnumerable<long>
{
public static readonly long[] Value=A078313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078313.Bytes);
public long this[int i]=>Value[i];

public static A078313Inst Instance=new A078313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078314
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,2L,4L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,3L,2L,1L,3L,2L,4L,3L,4L,2L,4L,2L,4L,2L,2L,3L,3L,3L,3L,2L,5L,2L,2L,1L,2L,2L,3L,2L,2L,1L,3L,3L,2L,3L,2L,1L,4L,1L,2L,4L,3L,2L,2L,3L,3L,3L,4L,1L,2L,2L,3L,2L,3L,2L,3L,3L,4L,1L,2L,1L,3L,1L,4L,3L,2L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078314Inst : IEnumerable<long>
{
public static readonly long[] Value=A078314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078314.Bytes);
public long this[int i]=>Value[i];

public static A078314Inst Instance=new A078314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078315
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078315Inst : IEnumerable<long>
{
public static readonly long[] Value=A078315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078315.Bytes);
public long this[int i]=>Value[i];

public static A078315Inst Instance=new A078315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078316
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078316Inst : IEnumerable<long>
{
public static readonly long[] Value=A078316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078316.Bytes);
public long this[int i]=>Value[i];

public static A078316Inst Instance=new A078316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078317
{
public static readonly long[] Value={ 2L,2L,4L,3L,4L,2L,6L,2L,6L,2L,4L,2L,8L,2L,4L,4L,8L,2L,4L,4L,8L,4L,8L,4L,12L,2L,4L,4L,4L,4L,8L,4L,8L,4L,4L,4L,8L,6L,4L,2L,6L,4L,12L,8L,9L,4L,16L,3L,8L,4L,4L,8L,8L,6L,8L,4L,16L,4L,4L,2L,4L,4L,6L,4L,4L,2L,8L,6L,4L,6L,4L,2L,16L,2L,4L,8L,8L,4L,4L,6L,6L,6L,16L,2L,4L,4L,8L,4L,8L,4L,8L,8L,12L,2L,4L,2L,8L,2L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078317Inst : IEnumerable<long>
{
public static readonly long[] Value=A078317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078317.Bytes);
public long this[int i]=>Value[i];

public static A078317Inst Instance=new A078317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078318
{
public static readonly long[] Value={ 3L,6L,18L,13L,42L,38L,93L,18L,56L,102L,186L,74L,324L,198L,342L,48L,540L,110L,546L,272L,756L,588L,972L,180L,312L,678L,126L,528L,1266L,972L,1596L,84L,1980L,1260L,1842L,256L,2484L,1842L,2286L,402L,2613L,2124L,3534L,1440L,1281L,2220L,4536L,307L,660L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078318Inst : IEnumerable<long>
{
public static readonly long[] Value=A078318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078318.Bytes);
public long this[int i]=>Value[i];

public static A078318Inst Instance=new A078318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078319
{
public static readonly long[] Value={ 2L,5L,7L,3L,15L,37L,7L,17L,9L,101L,63L,73L,24L,197L,115L,14L,36L,109L,183L,70L,32L,102L,60L,34L,12L,677L,43L,134L,423L,70L,52L,18L,116L,102L,615L,38L,144L,22L,763L,401L,31L,358L,44L,39L,15L,102L,37L,17L,45L,170L,1303L,55L,288L,18L,108L,162L,20L,678L,1743L,1801L,1863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078319Inst : IEnumerable<long>
{
public static readonly long[] Value=A078319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078319.Bytes);
public long this[int i]=>Value[i];

public static A078319Inst Instance=new A078319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078320
{
public static readonly long[] Value={ 2L,5L,7L,6L,15L,37L,12L,17L,11L,101L,63L,73L,24L,197L,115L,14L,36L,109L,183L,70L,32L,102L,60L,34L,15L,677L,43L,134L,423L,70L,52L,18L,116L,102L,615L,38L,144L,39L,763L,401L,60L,358L,49L,39L,30L,102L,37L,34L,49L,170L,1303L,55L,288L,23L,108L,162L,30L,678L,1743L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078320Inst : IEnumerable<long>
{
public static readonly long[] Value=A078320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078320.Bytes);
public long this[int i]=>Value[i];

public static A078320Inst Instance=new A078320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078321
{
public static readonly long[] Value={ 1L,4L,4L,6L,12L,36L,20L,16L,12L,100L,60L,72L,64L,196L,112L,20L,112L,108L,180L,132L,192L,384L,208L,112L,36L,676L,40L,260L,420L,832L,432L,48L,432L,1056L,612L,180L,544L,1088L,760L,400L,812L,1408L,720L,576L,312L,2016L,768L,272L,168L,332L,1300L,800L,1120L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078321Inst : IEnumerable<long>
{
public static readonly long[] Value=A078321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078321.Bytes);
public long this[int i]=>Value[i];

public static A078321Inst Instance=new A078321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078322
{
public static readonly long[] Value={ 2L,5L,10L,3L,26L,37L,10L,17L,14L,101L,122L,73L,170L,197L,226L,33L,290L,109L,362L,201L,442L,485L,530L,145L,42L,677L,82L,393L,842L,901L,962L,65L,1090L,1157L,1226L,217L,1370L,85L,1522L,401L,58L,1765L,370L,969L,26L,2117L,2210L,17L,86L,501L,2602L,1353L,2810L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078322Inst : IEnumerable<long>
{
public static readonly long[] Value=A078322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078322.Bytes);
public long this[int i]=>Value[i];

public static A078322Inst Instance=new A078322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078323
{
public static readonly long[] Value={ 1L,1L,7L,6L,15L,1L,45L,1L,32L,1L,63L,1L,129L,1L,115L,14L,213L,1L,183L,70L,281L,102L,381L,34L,165L,1L,43L,134L,423L,70L,581L,18L,773L,102L,615L,38L,969L,459L,763L,1L,957L,358L,1715L,431L,780L,102L,1847L,34L,524L,170L,1303L,607L,1977L,155L,1725L,162L,3825L,678L,1743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078323Inst : IEnumerable<long>
{
public static readonly long[] Value=A078323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078323.Bytes);
public long this[int i]=>Value[i];

public static A078323Inst Instance=new A078323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078468
{
public static readonly long[] Value={ 1L,4L,13L,47L,188L,825L,3937L,20270L,111835L,657423L,4097622L,26965867L,186685725L,1355314108L,10289242825L,81481911259L,671596664012L,5749877335253L,51042081429213L,469037073951694L,4454991580211951L,43677136038927595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078468Inst : IEnumerable<long>
{
public static readonly long[] Value=A078468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078468.Bytes);
public long this[int i]=>Value[i];

public static A078468Inst Instance=new A078468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078469
{
public static readonly long[] Value={ 1L,2L,12L,74L,456L,2810L,17316L,106706L,657552L,4052018L,24969660L,153869978L,948189528L,5843007146L,36006232404L,221880401570L,1367288641824L,8425612252514L,51920962156908L,319951385193962L,1971629273320680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078469Inst : IEnumerable<long>
{
public static readonly long[] Value=A078469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078469.Bytes);
public long this[int i]=>Value[i];

public static A078469Inst Instance=new A078469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078470
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,22L,209L,2L,1L,15L,25L,2L,1L,11L,1L,1L,5L,8L,2L,2L,20L,1L,4L,1L,2L,3L,3L,2L,1L,2L,2L,5L,1L,1L,2L,195L,1L,1L,1L,1L,1L,27L,27L,1L,45L,4L,5L,1L,2L,82L,1L,1L,2L,1L,6L,6L,1L,8L,1L,2L,1L,17L,3L,8L,1L,4L,1L,1L,2L,4L,8L,6L,2L,3L,6L,2L,2L,5L,2L,3L,5L,1L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078470Inst : IEnumerable<long>
{
public static readonly long[] Value=A078470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078470.Bytes);
public long this[int i]=>Value[i];

public static A078470Inst Instance=new A078470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078471
{
public static readonly long[] Value={ 1L,2L,6L,7L,13L,17L,25L,26L,39L,45L,57L,61L,75L,83L,107L,108L,126L,139L,159L,165L,197L,209L,233L,237L,268L,282L,322L,330L,360L,384L,416L,417L,465L,483L,531L,544L,582L,602L,658L,664L,706L,738L,782L,794L,872L,896L,944L,948L,1005L,1036L,1108L,1122L,1176L,1216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078471Inst : IEnumerable<long>
{
public static readonly long[] Value=A078471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078471.Bytes);
public long this[int i]=>Value[i];

public static A078471Inst Instance=new A078471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078472
{
public static readonly long[] Value={ 1L,6L,12L,22L,46L,67L,107L,137L,168L,228L,292L,342L,426L,546L,606L,656L,800L,920L,1044L,1129L,12L,73L,1473L,1633L,1759L,1850L,2030L,2270L,2510L,2665L,2869L,3089L,3389L,3799L,4119L,4275L,453L,9L,4819L,5029L,5389L,5689L,5993L,6377L,6797L,6967L,7367L,7871L,8231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078472Inst : IEnumerable<long>
{
public static readonly long[] Value=A078472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078472.Bytes);
public long this[int i]=>Value[i];

public static A078472Inst Instance=new A078472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078473
{
public static readonly long[] Value={ 1L,0L,0L,5L,6L,0L,0L,0L,10L,0L,24L,0L,0L,0L,0L,21L,0L,0L,40L,30L,0L,0L,0L,0L,31L,0L,0L,0L,60L,0L,64L,0L,0L,0L,0L,50L,0L,0L,0L,0L,84L,0L,0L,120L,60L,0L,0L,0L,50L,0L,0L,0L,0L,0L,144L,0L,0L,0L,120L,0L,124L,0L,0L,85L,0L,0L,0L,0L,0L,0L,144L,0L,0L,0L,0L,200L,0L,0L,160L,126L,91L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078473Inst : IEnumerable<long>
{
public static readonly long[] Value=A078473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078473.Bytes);
public long this[int i]=>Value[i];

public static A078473Inst Instance=new A078473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078474
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,10L,11L,12L,12L,12L,12L,13L,14L,15L,16L,16L,16L,16L,17L,18L,19L,20L,20L,20L,20L,21L,22L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,29L,30L,31L,31L,31L,31L,32L,32L,32L,32L,33L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078474Inst : IEnumerable<long>
{
public static readonly long[] Value=A078474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078474.Bytes);
public long this[int i]=>Value[i];

public static A078474Inst Instance=new A078474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078475
{
public static readonly long[] Value={ 1L,-2L,15L,-594L,-5187L,23244L,122475L,-279292L,-1157143L,1850930L,6642839L,-8529278L,-27810555L,30741424L,93575187L,-92784984L,-268191855L,244875462L,679807583L,-581798410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078475Inst : IEnumerable<long>
{
public static readonly long[] Value=A078475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078475.Bytes);
public long this[int i]=>Value[i];

public static A078475Inst Instance=new A078475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078476
{
public static readonly long[] Value={ 1L,2L,6L,11L,16L,22L,28L,35L,42L,50L,58L,67L,76L,86L,96L,107L,118L,130L,142L,155L,168L,182L,196L,211L,226L,242L,258L,275L,292L,310L,328L,347L,366L,386L,406L,427L,448L,470L,492L,515L,538L,562L,586L,611L,636L,662L,688L,715L,742L,770L,798L,827L,856L,886L,916L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078476Inst : IEnumerable<long>
{
public static readonly long[] Value=A078476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078476.Bytes);
public long this[int i]=>Value[i];

public static A078476Inst Instance=new A078476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078477
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,6L,7L,15L,15L,30L,31L,63L,63L,126L,127L,255L,255L,510L,511L,1023L,1023L,2046L,2047L,4095L,4095L,8190L,8191L,16383L,16383L,32766L,32767L,65535L,65535L,131070L,131071L,262143L,262143L,524286L,524287L,1048575L,1048575L,2097150L,2097151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078477Inst : IEnumerable<long>
{
public static readonly long[] Value=A078477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078477.Bytes);
public long this[int i]=>Value[i];

public static A078477Inst Instance=new A078477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078478
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,9L,6L,29L,30L,99L,112L,351L,450L,1275L,1734L,4707L,6762L,17577L,26208L,66197L,101862L,250953L,395804L,956385L,1540110L,3660541L,5997600L,14061141L,23382294L,54177741L,91246662L,209295261L,356432166L,810375651L,1393592512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078478Inst : IEnumerable<long>
{
public static readonly long[] Value=A078478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078478.Bytes);
public long this[int i]=>Value[i];

public static A078478Inst Instance=new A078478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078479
{
public static readonly long[] Value={ 1L,2L,4L,8L,4L,8L,6L,12L,4L,8L,6L,12L,6L,12L,8L,8L,4L,8L,6L,12L,6L,10L,8L,16L,6L,8L,8L,8L,8L,16L,6L,12L,4L,10L,6L,10L,6L,12L,8L,10L,6L,12L,8L,16L,8L,8L,10L,20L,6L,12L,6L,8L,8L,16L,6L,10L,8L,10L,10L,20L,6L,12L,8L,10L,4L,10L,8L,16L,6L,12L,8L,16L,6L,12L,8L,8L,8L,12L,8L,16L,6L,8L,8L,16L,8L,8L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078479Inst : IEnumerable<long>
{
public static readonly long[] Value=A078479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078479.Bytes);
public long this[int i]=>Value[i];

public static A078479Inst Instance=new A078479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078480
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,21L,117L,792L,6205L,55005L,543597L,5922930L,70518905L,910711193L,12678337945L,189252400480L,3015217932073L,51067619064873L,916176426422089L,17355904144773970L,346195850534379613L,7252654441500887309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078480Inst : IEnumerable<long>
{
public static readonly long[] Value=A078480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078480.Bytes);
public long this[int i]=>Value[i];

public static A078480Inst Instance=new A078480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078481
{
public static readonly long[] Value={ 0L,1L,1L,3L,7L,19L,53L,153L,453L,1367L,4191L,13015L,40857L,129441L,413337L,1328971L,4298727L,13978971L,45673981L,149867513L,493638797L,1631616239L,5410015615L,17990076527L,59981630321L,200476419713L,671564145137L,2254338511507L,7582179238151L,25547868961315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078481Inst : IEnumerable<long>
{
public static readonly long[] Value=A078481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078481.Bytes);
public long this[int i]=>Value[i];

public static A078481Inst Instance=new A078481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078482
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,70L,254L,948L,3618L,14058L,55432L,221262L,892346L,3630680L,14885042L,61432382L,255025212L,1064190214L,4461325382L,18780710508L,79357572866L,336466650450L,1431007889744L,6103431668830L,26099839562738L,111877997049648L,480635694869218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078482Inst : IEnumerable<long>
{
public static readonly long[] Value=A078482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078482.Bytes);
public long this[int i]=>Value[i];

public static A078482Inst Instance=new A078482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078483
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,69L,243L,869L,3145L,11491L,42312L,156807L,584288L,2187298L,8221257L,31009841L,117331070L,445174418L,1693270531L,6454992143L,24657428519L,94363587324L,361741068087L,1388892123038L,5340282880156L,20560742443041L,79259430563491L,305889059254747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078483Inst : IEnumerable<long>
{
public static readonly long[] Value=A078483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078483.Bytes);
public long this[int i]=>Value[i];

public static A078483Inst Instance=new A078483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078500
{
public static readonly long[] Value={ 23L,29L,31L,37L,53L,59L,61L,67L,83L,89L,151L,157L,163L,167L,173L,179L,233L,239L,251L,257L,263L,269L,271L,277L,281L,283L,331L,337L,347L,349L,353L,359L,373L,379L,383L,389L,401L,409L,443L,449L,491L,499L,503L,509L,521L,523L,541L,547L,563L,569L,571L,577L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078500Inst : IEnumerable<long>
{
public static readonly long[] Value=A078500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078500.Bytes);
public long this[int i]=>Value[i];

public static A078500Inst Instance=new A078500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078501
{
public static readonly long[] Value={ 1L,7L,26L,78L,211L,537L,1312L,3112L,7217L,16443L,36934L,82002L,180319L,393325L,852092L,1835148L,3932317L,8388783L,17825986L,37748950L,79692011L,167772417L,352321816L,738197808L,1543504201L,3221225827L,6710886782L,13958644122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078501Inst : IEnumerable<long>
{
public static readonly long[] Value=A078501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078501.Bytes);
public long this[int i]=>Value[i];

public static A078501Inst Instance=new A078501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078502
{
public static readonly long[] Value={ 3L,6L,12L,12L,174600L,7224840L,10780560L,10780560L,1086338816640L,50060257410240L,7720634052774720L,227457297898150320L,7272877497848202240L,7272877497848202240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078502Inst : IEnumerable<long>
{
public static readonly long[] Value=A078502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078502.Bytes);
public long this[int i]=>Value[i];

public static A078502Inst Instance=new A078502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078503
{
public static readonly long[] Value={ 1L,2L,1L,6L,0L,15L,0L,15L,0L,210L,0L,495L,0L,28L,1L,12870L,0L,18564L,0L,495L,0L,646646L,0L,125970L,0L,18564L,0L,30421755L,0L,5852925L,0L,4845L,0L,735471L,0L,1251677700L,0L,134596L,0L,62852101650L,0L,11058116888L,0L,10626L,0L,7890371113950L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078503Inst : IEnumerable<long>
{
public static readonly long[] Value=A078503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078503.Bytes);
public long this[int i]=>Value[i];

public static A078503Inst Instance=new A078503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078504
{
public static readonly BigInteger[] Value={ 3L,4L,35L,0L,924L,0L,6435L,0L,8568L,0L,30421755L,0L,1961256L,1L,2629575L,0L,62359143990L,0L,513791607420L,0L,58905L,0L,36052387482172425L,0L,4280561376L,0L,41648951840265L,0L,BigInteger.Parse("164307576757973059488"),0L,916312070471295267L,0L,25827165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078504Inst Instance=new A078504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078505
{
public static readonly long[] Value={ 4L,9L,15L,21L,25L,27L,28L,33L,35L,39L,45L,49L,51L,55L,57L,63L,65L,66L,69L,75L,76L,77L,81L,85L,87L,91L,93L,95L,99L,105L,111L,112L,115L,117L,119L,121L,123L,124L,125L,129L,133L,135L,141L,143L,145L,147L,148L,153L,155L,159L,161L,165L,169L,171L,172L,175L,177L,183L,185L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078505Inst : IEnumerable<long>
{
public static readonly long[] Value=A078505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078505.Bytes);
public long this[int i]=>Value[i];

public static A078505Inst Instance=new A078505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078506
{
public static readonly long[] Value={ 2L,5L,1L,0L,5L,9L,7L,4L,8L,3L,8L,8L,6L,2L,9L,3L,9L,5L,3L,2L,3L,6L,8L,3L,4L,7L,2L,7L,4L,1L,5L,4L,6L,5L,4L,5L,1L,6L,8L,3L,5L,3L,1L,9L,4L,4L,9L,5L,5L,1L,4L,7L,6L,8L,1L,9L,0L,8L,0L,6L,2L,9L,9L,6L,5L,0L,8L,3L,8L,4L,5L,3L,2L,9L,0L,4L,4L,6L,1L,8L,4L,2L,3L,8L,1L,9L,2L,5L,8L,7L,1L,4L,6L,2L,8L,2L,7L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078506Inst : IEnumerable<long>
{
public static readonly long[] Value=A078506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078506.Bytes);
public long this[int i]=>Value[i];

public static A078506Inst Instance=new A078506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078507
{
public static readonly long[] Value={ 0L,4L,5L,9L,12L,17L,21L,29L,32L,39L,49L,52L,58L,73L,76L,88L,92L,109L,117L,125L,140L,151L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078507Inst : IEnumerable<long>
{
public static readonly long[] Value=A078507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078507.Bytes);
public long this[int i]=>Value[i];

public static A078507Inst Instance=new A078507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078508
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,0L,2L,2L,1L,0L,2L,2L,0L,2L,2L,1L,2L,0L,3L,1L,1L,1L,3L,2L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,3L,2L,3L,1L,2L,2L,2L,2L,0L,2L,1L,3L,1L,2L,3L,3L,1L,3L,3L,1L,2L,2L,1L,2L,2L,2L,2L,1L,1L,1L,2L,2L,0L,3L,2L,2L,1L,1L,2L,3L,1L,3L,2L,2L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078508Inst : IEnumerable<long>
{
public static readonly long[] Value=A078508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078508.Bytes);
public long this[int i]=>Value[i];

public static A078508Inst Instance=new A078508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078509
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,5L,23L,131L,883L,6859L,60301L,591605L,6405317L,75843233L,974763571L,13512607303L,200949508327L,3190881283415L,53880906258521L,964039575154409L,18217997734199113L,362584510633666621L,7580578211464070863L,BigInteger.Parse("166099466140519353035"),BigInteger.Parse("3806162403831340850651") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078509Inst Instance=new A078509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078510
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,21L,24L,27L,31L,36L,42L,48L,54L,61L,69L,78L,88L,98L,108L,119L,131L,144L,158L,172L,186L,201L,217L,235L,256L,280L,304L,328L,355L,386L,422L,464L,512L,560L,608L,662L,723L,792L,870L,958L,1056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078510Inst : IEnumerable<long>
{
public static readonly long[] Value=A078510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078510.Bytes);
public long this[int i]=>Value[i];

public static A078510Inst Instance=new A078510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078511
{
public static readonly long[] Value={ 2L,60L,72L,168L,270L,450L,560L,990L,1056L,1188L,1470L,2496L,3200L,3402L,3520L,3672L,4788L,5700L,8320L,9856L,9936L,10164L,10395L,11000L,11160L,12180L,12740L,13056L,13720L,14616L,16524L,17400L,17940L,18522L,19380L,20000L,20475L,21252L,21528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078511Inst : IEnumerable<long>
{
public static readonly long[] Value=A078511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078511.Bytes);
public long this[int i]=>Value[i];

public static A078511Inst Instance=new A078511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078512
{
public static readonly long[] Value={ 7045248121L,7279379941L,24306384961L,43234580143L,52437986833L,60518537641L,80829302401L,118805562613L,144377609419L,165321688501L,167385219121L,254302215553L,364573433665L,575687567521L,588909469501L,652270080001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078512Inst : IEnumerable<long>
{
public static readonly long[] Value=A078512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078512.Bytes);
public long this[int i]=>Value[i];

public static A078512Inst Instance=new A078512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078513
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,11L,18L,36L,65L,101L,166L,332L,599L,931L,1530L,3060L,5521L,8581L,14102L,28204L,50887L,79091L,129978L,259956L,469025L,728981L,1198006L,2396012L,4322999L,6719011L,11042010L,22084020L,39845041L,61929061L,101774102L,203548204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078513Inst : IEnumerable<long>
{
public static readonly long[] Value=A078513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078513.Bytes);
public long this[int i]=>Value[i];

public static A078513Inst Instance=new A078513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078514
{
public static readonly long[] Value={ 4L,12L,18L,20L,27L,28L,36L,44L,50L,52L,60L,68L,76L,84L,90L,92L,98L,100L,116L,124L,126L,132L,135L,140L,148L,150L,156L,164L,172L,180L,188L,189L,196L,198L,204L,212L,220L,228L,234L,236L,242L,244L,252L,260L,268L,276L,284L,292L,294L,297L,300L,306L,308L,316L,332L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078514Inst : IEnumerable<long>
{
public static readonly long[] Value=A078514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078514.Bytes);
public long this[int i]=>Value[i];

public static A078514Inst Instance=new A078514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078515
{
public static readonly long[] Value={ 1L,7L,23L,30L,94L,219L,279L,773L,1856L,3724L,6999L,7000L,19205L,184163L,280103L,849876L,1870722L,3570761L,4114341L,11271072L,55282774L,68256040L,68256041L,104011359L,1009322491L,1311699253L,7889803997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078515Inst : IEnumerable<long>
{
public static readonly long[] Value=A078515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078515.Bytes);
public long this[int i]=>Value[i];

public static A078515Inst Instance=new A078515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078532
{
public static readonly BigInteger[] Value={ 1L,3L,27L,315L,4158L,59049L,880308L,13586859L,215233605L,3479417370L,57168561996L,951892141473L,16026585711660L,272383068872700L,4666865660812044L,80521573261807755L,1397858693681272230L,BigInteger.Parse("24398716826612190447"),BigInteger.Parse("427921056863230599900"),BigInteger.Parse("7537621933880388620010") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078532Inst Instance=new A078532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078533
{
public static readonly BigInteger[] Value={ 1L,4L,56L,1024L,21216L,473088L,11075328L,268435456L,6677665280L,169514369024L,4373549027328L,114349209288704L,3023068543631360L,80675644291153920L,2170389180446539776L,BigInteger.Parse("58798996734949195776"),BigInteger.Parse("1602737048880933109760"),BigInteger.Parse("43924199383151211970560") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078533Inst Instance=new A078533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078534
{
public static readonly BigInteger[] Value={ 1L,5L,100L,2625L,78125L,2502500L,84150000L,2929265625L,104646953125L,3814697265625L,141323284375000L,5305403695312500L,201382633183593750L,7715985752343750000L,BigInteger.Parse("298023223876953125000"),BigInteger.Parse("11591412585295166015625"),BigInteger.Parse("453601640704152832031250") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078534Inst Instance=new A078534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078535
{
public static readonly long[] Value={ 1L,6L,162L,5760L,232254L,10077696L,458960580L,21634449408L,1046465787510L,51644846702592L,2590092194793948L,131621703842267136L,6762649550214036780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078535Inst : IEnumerable<long>
{
public static readonly long[] Value=A078535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078535.Bytes);
public long this[int i]=>Value[i];

public static A078535Inst Instance=new A078535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078536
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,28L,16L,1L,1L,524L,496L,64L,1L,1L,29804L,41136L,8128L,256L,1L,1L,5423660L,10272816L,2755264L,130816L,1024L,1L,1L,3276048300L,8220685104L,2804672704L,178301696L,2096128L,4096L,1L,1L,6744720496300L,21934062166320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078536Inst : IEnumerable<long>
{
public static readonly long[] Value=A078536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078536.Bytes);
public long this[int i]=>Value[i];

public static A078536Inst Instance=new A078536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078537
{
public static readonly BigInteger[] Value={ 1L,2L,6L,46L,1086L,79326L,18583582L,14481808030L,38559135542174L,357934565638890910L,BigInteger.Parse("11766678027350761752990"),BigInteger.Parse("1387043469046575118555443614"),BigInteger.Parse("592264246356176268834689653440926"),BigInteger.Parse("923812464024548700407122072128655860126"),BigInteger.Parse("5301247577915139769925461060755690116740047262") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078537Inst Instance=new A078537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078538
{
public static readonly long[] Value={ 12L,22L,12L,249L,12L,22L,12L,19689L,12L,22L,12L,249L,12L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078538Inst : IEnumerable<long>
{
public static readonly long[] Value=A078538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078538.Bytes);
public long this[int i]=>Value[i];

public static A078538Inst Instance=new A078538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078539
{
public static readonly long[] Value={ 38L,46L,295L,38L,235L,749L,38L,3687L,6128L,38L,1415L,46L,38L,4254L,10451L,38L,46L,8351L,38L,334L,4511L,38L,3398L,295L,38L,1286L,46L,38L,148870L,11051L,38L,46L,35519L,38L,10239L,14072L,38L,235L,76088L,38L,5991L,46L,38L,718L,295L,38L,46L,11654L,38L,30761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078539Inst : IEnumerable<long>
{
public static readonly long[] Value=A078539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078539.Bytes);
public long this[int i]=>Value[i];

public static A078539Inst Instance=new A078539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078540
{
public static readonly long[] Value={ 22L,38L,46L,295L,235L,749L,3687L,6128L,1415L,4254L,10451L,8351L,334L,4511L,3398L,1286L,148870L,11051L,35519L,10239L,14072L,76088L,5991L,718L,11654L,30761L,7431L,20993L,700654L,22169L,5095L,4198L,27415L,26744L,14318L,48368L,180878L,16991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078540Inst : IEnumerable<long>
{
public static readonly long[] Value=A078540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078540.Bytes);
public long this[int i]=>Value[i];

public static A078540Inst Instance=new A078540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078541
{
public static readonly long[] Value={ 1L,2L,8L,12L,36L,80L,96L,128L,288L,448L,2560L,6144L,11264L,18432L,32768L,53248L,57344L,245760L,737280L,1114112L,2621440L,4980736L,22020096L,23068672L,25165824L,66060288L,75497472L,96468992L,436207616L,939524096L,1258291200L,1811939328L,2147483648L,3774873600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078541Inst : IEnumerable<long>
{
public static readonly long[] Value=A078541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078541.Bytes);
public long this[int i]=>Value[i];

public static A078541Inst Instance=new A078541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078542
{
public static readonly long[] Value={ 4L,8L,9L,10L,16L,18L,20L,21L,22L,24L,25L,26L,27L,28L,32L,33L,34L,36L,38L,39L,40L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,72L,74L,75L,76L,77L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,102L,104L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078542Inst : IEnumerable<long>
{
public static readonly long[] Value=A078542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078542.Bytes);
public long this[int i]=>Value[i];

public static A078542Inst Instance=new A078542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078543
{
public static readonly long[] Value={ 1L,2L,12L,56L,248L,12192L,28896L,60960L,61344L,66528L,86304L,94944L,129504L,133920L,140448L,182880L,201924L,207264L,242316L,282720L,408672L,416640L,426720L,429408L,604128L,664608L,671760L,776736L,792480L,854496L,862752L,906528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078543Inst : IEnumerable<long>
{
public static readonly long[] Value=A078543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078543.Bytes);
public long this[int i]=>Value[i];

public static A078543Inst Instance=new A078543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078544
{
public static readonly long[] Value={ 38L,54L,87L,95L,114L,126L,135L,147L,174L,182L,209L,215L,216L,222L,258L,285L,294L,297L,315L,430L,455L,456L,540L,546L,551L,609L,627L,632L,635L,645L,762L,783L,836L,899L,957L,1015L,1032L,1102L,1107L,1118L,1140L,1188L,1211L,1218L,1270L,1290L,1330L,1343L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078544Inst : IEnumerable<long>
{
public static readonly long[] Value=A078544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078544.Bytes);
public long this[int i]=>Value[i];

public static A078544Inst Instance=new A078544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078545
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,5L,2L,3L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,5L,3L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,7L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,5L,5L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078545Inst : IEnumerable<long>
{
public static readonly long[] Value=A078545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078545.Bytes);
public long this[int i]=>Value[i];

public static A078545Inst Instance=new A078545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078546
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,39L,28L,15L,48L,119L,72L,171L,20L,42L,22L,138L,24L,50L,78L,378L,56L,522L,30L,93L,96L,33L,204L,105L,36L,777L,456L,117L,40L,164L,84L,516L,44L,180L,276L,1316L,48L,1764L,50L,255L,260L,795L,540L,55L,840L,1995L,1160L,2655L,60L,366L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078546Inst : IEnumerable<long>
{
public static readonly long[] Value=A078546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078546.Bytes);
public long this[int i]=>Value[i];

public static A078546Inst Instance=new A078546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078547
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,26L,14L,0L,32L,102L,54L,152L,0L,21L,0L,115L,0L,25L,52L,351L,28L,493L,0L,62L,64L,0L,170L,70L,0L,740L,418L,78L,0L,123L,42L,473L,0L,135L,230L,1269L,0L,1715L,0L,204L,208L,742L,486L,0L,784L,1938L,1102L,2596L,0L,305L,124L,63L,128L,325L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078547Inst : IEnumerable<long>
{
public static readonly long[] Value=A078547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078547.Bytes);
public long this[int i]=>Value[i];

public static A078547Inst Instance=new A078547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078724
{
public static readonly long[] Value={ 5L,7L,13L,23L,41L,61L,89L,127L,167L,223L,271L,347L,419L,491L,593L,677L,797L,911L,1033L,1171L,1303L,1481L,1619L,1801L,1999L,2203L,2383L,2621L,2803L,3061L,3323L,3559L,3823L,4093L,4391L,4679L,4999L,5333L,5653L,5987L,6323L,6701L,7043L,7489L,7867L,8273L,8699L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078724Inst : IEnumerable<long>
{
public static readonly long[] Value=A078724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078724.Bytes);
public long this[int i]=>Value[i];

public static A078724Inst Instance=new A078724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078725
{
public static readonly long[] Value={ 7L,11L,17L,29L,43L,67L,97L,131L,173L,227L,277L,349L,421L,499L,599L,683L,809L,919L,1039L,1181L,1307L,1483L,1621L,1811L,2003L,2207L,2389L,2633L,2819L,3067L,3329L,3571L,3833L,4099L,4397L,4691L,5003L,5347L,5657L,6007L,6329L,6703L,7057L,7499L,7873L,8287L,8707L,9133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078725Inst : IEnumerable<long>
{
public static readonly long[] Value=A078725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078725.Bytes);
public long this[int i]=>Value[i];

public static A078725Inst Instance=new A078725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078726
{
public static readonly BigInteger[] Value={ 3L,5L,17L,257L,35567L,2244677999L,111344445566777789L,BigInteger.Parse("111222233333334444445666666777788899"),BigInteger.Parse("111111222223333333344444455555555566666666777777778888888999999999999") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078726Inst Instance=new A078726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078727
{
public static readonly BigInteger[] Value={ 2L,3L,29L,199L,2351L,24155233L,BigInteger.Parse("79757008057644623350300078764807923712509139103039448418553259155159833055572871"),BigInteger.Parse("36684474316080978061473613646275630451020829893137585191919942789652960137481051718801295569460987256072983944701335181") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078727Inst Instance=new A078727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078728
{
public static readonly long[] Value={ 3L,57L,297L,177L,237L,25111L,231339L,67419L,273817L,345111L,2001753L,912277L,5236153L,9228627L,10599391L,2835261L,60120003L,14054037L,27923629L,41783347L,24590943L,112161513L,230484021L,11446969L,205242589L,583389307L,873650007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078728Inst : IEnumerable<long>
{
public static readonly long[] Value=A078728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078728.Bytes);
public long this[int i]=>Value[i];

public static A078728Inst Instance=new A078728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078729
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,2L,3L,3L,5L,1L,2L,9L,4L,2L,8L,5L,5L,3L,4L,7L,5L,6L,18L,24L,10L,1L,11L,2L,8L,22L,6L,6L,38L,4L,6L,1L,13L,4L,77L,1L,2L,14L,18L,11L,16L,5L,2L,13L,7L,20L,22L,16L,13L,39L,15L,5L,7L,12L,14L,4L,14L,81L,45L,50L,38L,42L,5L,10L,60L,56L,15L,1L,45L,25L,53L,1L,23L,12L,3L,61L,30L,68L,26L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078729Inst : IEnumerable<long>
{
public static readonly long[] Value=A078729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078729.Bytes);
public long this[int i]=>Value[i];

public static A078729Inst Instance=new A078729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078730
{
public static readonly long[] Value={ 0L,2L,3L,10L,5L,26L,7L,42L,30L,62L,11L,116L,13L,114L,93L,170L,17L,242L,19L,280L,171L,266L,23L,476L,130L,366L,273L,528L,29L,713L,31L,682L,399L,614L,285L,1070L,37L,762L,549L,1150L,41L,1342L,43L,1264L,873L,1106L,47L,1916L,350L,1562L,921L,1752L,53L,2186L,665L,2166L,1143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078730Inst : IEnumerable<long>
{
public static readonly long[] Value=A078730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078730.Bytes);
public long this[int i]=>Value[i];

public static A078730Inst Instance=new A078730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078731
{
public static readonly long[] Value={ 0L,0L,0L,23L,37L,100L,67L,348L,0L,371L,0L,660L,0L,0L,434L,233L,771L,277L,600L,985L,3810L,0L,1788L,3435L,2208L,1757L,1220L,631L,1300L,13190L,0L,0L,1692L,1740L,16239L,0L,1039L,0L,2156L,6678L,10749L,3745L,1283L,1297L,1307L,11040L,4319L,2930L,0L,23259L,1613L,6584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078731Inst : IEnumerable<long>
{
public static readonly long[] Value=A078731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078731.Bytes);
public long this[int i]=>Value[i];

public static A078731Inst Instance=new A078731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078732
{
public static readonly long[] Value={ 2L,33L,34L,36L,40L,48L,2051L,2053L,2054L,2057L,2058L,2060L,2065L,2066L,2068L,2072L,2081L,2082L,2084L,2088L,2096L,2113L,2114L,2116L,2120L,2128L,2144L,2177L,2178L,2180L,2184L,2192L,2208L,2240L,2305L,2306L,2308L,2312L,2320L,2336L,2368L,2432L,2561L,2562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078732Inst : IEnumerable<long>
{
public static readonly long[] Value=A078732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078732.Bytes);
public long this[int i]=>Value[i];

public static A078732Inst Instance=new A078732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078733
{
public static readonly long[] Value={ 2L,39L,43L,45L,46L,51L,53L,54L,57L,58L,60L,2303L,2431L,2495L,2527L,2543L,2551L,2555L,2557L,2558L,2687L,2751L,2783L,2799L,2807L,2811L,2813L,2814L,2879L,2911L,2927L,2935L,2939L,2941L,2942L,2975L,2991L,2999L,3003L,3005L,3006L,3023L,3031L,3035L,3037L,3038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078733Inst : IEnumerable<long>
{
public static readonly long[] Value=A078733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078733.Bytes);
public long this[int i]=>Value[i];

public static A078733Inst Instance=new A078733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078734
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078734Inst : IEnumerable<long>
{
public static readonly long[] Value=A078734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078734.Bytes);
public long this[int i]=>Value[i];

public static A078734Inst Instance=new A078734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078735
{
public static readonly long[] Value={ 0L,3L,5L,9L,13L,18L,37L,384L,569L,2760L,3293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078735Inst : IEnumerable<long>
{
public static readonly long[] Value=A078735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078735.Bytes);
public long this[int i]=>Value[i];

public static A078735Inst Instance=new A078735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078736
{
public static readonly long[] Value={ 1L,2L,3L,5L,28L,33L,61L,582L,643L,1225L,16568L,17793L,34361L,601930L,636291L,1238221L,26638932L,27877153L,54516085L,1390779278L,1445295363L,2836074641L,83691459952L,86527534593L,170218994545L,5703754354578L,5873973349123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078736Inst : IEnumerable<long>
{
public static readonly long[] Value=A078736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078736.Bytes);
public long this[int i]=>Value[i];

public static A078736Inst Instance=new A078736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078737
{
public static readonly long[] Value={ 1L,1L,2L,3L,17L,20L,37L,353L,390L,743L,10049L,10792L,20841L,365089L,385930L,751019L,16157329L,16908348L,33065677L,843550273L,876615950L,1720166223L,50761436417L,52481602640L,103243039057L,3459501891521L,3562744930578L,7022246822099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078737Inst : IEnumerable<long>
{
public static readonly long[] Value=A078737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078737.Bytes);
public long this[int i]=>Value[i];

public static A078737Inst Instance=new A078737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078738
{
public static readonly BigInteger[] Value={ 1L,13L,355L,16333L,1121881L,106708921L,13354028563L,2118817455385L,414426460442833L,97746679844312581L,BigInteger.Parse("27311169061720393411"),BigInteger.Parse("8908525371578726747173"),BigInteger.Parse("3350963996380181114090665") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078738Inst Instance=new A078738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078739
{
public static readonly long[] Value={ 1L,2L,4L,1L,4L,32L,38L,12L,1L,8L,208L,652L,576L,188L,24L,1L,16L,1280L,9080L,16944L,12052L,3840L,580L,40L,1L,32L,7744L,116656L,412800L,540080L,322848L,98292L,16000L,1390L,60L,1L,64L,46592L,1446368L,9196992L,20447056L,20453376L,10564304L,3047520L,511392L,50400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078739Inst : IEnumerable<long>
{
public static readonly long[] Value=A078739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078739.Bytes);
public long this[int i]=>Value[i];

public static A078739Inst Instance=new A078739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078740
{
public static readonly long[] Value={ 1L,6L,6L,1L,72L,168L,96L,18L,1L,1440L,5760L,6120L,2520L,456L,36L,1L,43200L,259200L,424800L,285120L,92520L,15600L,1380L,60L,1L,1814400L,15120000L,34776000L,33566400L,16304400L,4379760L,682200L,62400L,3270L,90L,1L,101606400L,1117670400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078740Inst : IEnumerable<long>
{
public static readonly long[] Value=A078740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078740.Bytes);
public long this[int i]=>Value[i];

public static A078740Inst Instance=new A078740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078741
{
public static readonly long[] Value={ 1L,6L,18L,9L,1L,36L,540L,1242L,882L,243L,27L,1L,216L,13608L,94284L,186876L,149580L,56808L,11025L,1107L,54L,1L,1296L,330480L,6148872L,28245672L,49658508L,41392620L,18428400L,4691412L,706833L,63375L,3285L,90L,1L,7776L,7954848L,380841264L,3762380016L,13062960720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078741Inst : IEnumerable<long>
{
public static readonly long[] Value=A078741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078741.Bytes);
public long this[int i]=>Value[i];

public static A078741Inst Instance=new A078741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078742
{
public static readonly BigInteger[] Value={ 2L,3L,8L,34L,144L,46368L,8944394323791464L,BigInteger.Parse("16641027750620563662096"),BigInteger.Parse("298611126818977066918552"),BigInteger.Parse("146178119651438213260386312206974243796773058"),BigInteger.Parse("1065113236465588309403889415460645093083860991848425732542338227915288346612042420944981983005010603735148681490199640832") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078742Inst Instance=new A078742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078743
{
public static readonly long[] Value={ 3L,4L,6L,9L,12L,24L,78L,108L,114L,213L,576L,1674L,1773L,1920L,2916L,23439L,24606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078743Inst : IEnumerable<long>
{
public static readonly long[] Value=A078743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078743.Bytes);
public long this[int i]=>Value[i];

public static A078743Inst Instance=new A078743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078744
{
public static readonly long[] Value={ 1L,4L,6L,7L,8L,13L,17L,18L,21L,41L,86L,101L,144L,368L,1232L,1713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078744Inst : IEnumerable<long>
{
public static readonly long[] Value=A078744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078744.Bytes);
public long this[int i]=>Value[i];

public static A078744Inst Instance=new A078744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078745
{
public static readonly long[] Value={ 6L,7L,8L,15L,23L,36L,93L,117L,121L,131L,150L,310L,433L,896L,1226L,4439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078745Inst : IEnumerable<long>
{
public static readonly long[] Value=A078745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078745.Bytes);
public long this[int i]=>Value[i];

public static A078745Inst Instance=new A078745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078746
{
public static readonly long[] Value={ 2L,11L,41L,97L,179L,283L,439L,617L,829L,1087L,1381L,1697L,2081L,2467L,2909L,3433L,3929L,4517L,5119L,5801L,6481L,7237L,8059L,8863L,9739L,10663L,11701L,12659L,13729L,14867L,15973L,17239L,18443L,19843L,21179L,22549L,23971L,25541L,27043L,28657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078746Inst : IEnumerable<long>
{
public static readonly long[] Value=A078746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078746.Bytes);
public long this[int i]=>Value[i];

public static A078746Inst Instance=new A078746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}