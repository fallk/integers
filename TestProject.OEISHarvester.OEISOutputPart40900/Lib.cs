using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A000152
{
public static readonly long[] Value={ 1L,32L,480L,4480L,29152L,140736L,525952L,1580800L,3994080L,8945824L,18626112L,36714624L,67978880L,118156480L,197120256L,321692928L,509145568L,772845120L,1143441760L,1681379200L,2428524096L,3392205824L,4658843520L,6411152640L };
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
public class A000152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000152Inst : IEnumerable<long>
{
public static readonly long[] Value=A000152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000152.Bytes);
public long this[int i]=>Value[i];

public static A000152Inst Instance=new A000152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000151
{
public static readonly BigInteger[] Value={ 1L,2L,7L,26L,107L,458L,2058L,9498L,44947L,216598L,1059952L,5251806L,26297238L,132856766L,676398395L,3466799104L,17873508798L,92630098886L,482292684506L,2521610175006L,13233573019372L,69687684810980L,368114512431638L,1950037285256658L,10357028326495097L,55140508518522726L,294219119815868952L,1573132563600386854L,8427354035116949486L,BigInteger.Parse("45226421721391554194") };
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
public class A000151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000151Inst Instance=new A000151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000150
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,20L,66L,212L,715L,2424L,8398L,29372L,104006L,371384L,1337220L,4847208L,17678835L,64821680L,238819350L,883629164L,3282060210L,12233125112L,45741281820L,171529777432L,644952073662L,2430973096720L,9183676536076L };
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
public class A000150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000150Inst : IEnumerable<long>
{
public static readonly long[] Value=A000150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000150.Bytes);
public long this[int i]=>Value[i];

public static A000150Inst Instance=new A000150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000149
{
public static readonly long[] Value={ 1L,2L,7L,20L,54L,148L,403L,1096L,2980L,8103L,22026L,59874L,162754L,442413L,1202604L,3269017L,8886110L,24154952L,65659969L,178482300L,485165195L,1318815734L,3584912846L,9744803446L,26489122129L,72004899337L,195729609428L,532048240601L,1446257064291L };
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
public class A000149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000149Inst : IEnumerable<long>
{
public static readonly long[] Value=A000149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000149.Bytes);
public long this[int i]=>Value[i];

public static A000149Inst Instance=new A000149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000148
{
public static readonly long[] Value={ 1L,2L,7L,15L,28L,45L,70L,100L,138L,183L,242L,310L,388L,481L,583L,701L,838L,984L,1152L,1337L,1535L,1757L,2001L,2262L,2545L,2855L,3183L,3540L,3926L,4335L,4770L,5233L,5728L,6248L,6801L,7388L,8005L,8658L,9345L,10064L,10824L,11620L,12452L,13324L,14236L };
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
public class A000148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000148Inst : IEnumerable<long>
{
public static readonly long[] Value=A000148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000148.Bytes);
public long this[int i]=>Value[i];

public static A000148Inst Instance=new A000148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000147
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,7L,14L,32L,58L,110L,187L,322L,519L,839L,1302L,2015L,3032L,4542L,6668L,9738L,14006L,20036L,28324L,39830L,55473L,76875L,105692L,144629L,196585L,266038L,357952L,479664L,639519L,849425L,1123191L,1479972L,1942284L,2540674L,3311415L };
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
public class A000147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000147Inst : IEnumerable<long>
{
public static readonly long[] Value=A000147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000147.Bytes);
public long this[int i]=>Value[i];

public static A000147Inst Instance=new A000147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000146
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,2L,-6L,56L,-528L,6193L,-86579L,1425518L,-27298230L,601580875L,-15116315766L,429614643062L,-13711655205087L,488332318973594L,-19296579341940067L,841693047573682616L,BigInteger.Parse("-40338071854059455412") };
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
public class A000146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000146Inst Instance=new A000146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000145
{
public static readonly long[] Value={ 1L,24L,264L,1760L,7944L,25872L,64416L,133056L,253704L,472760L,825264L,1297056L,1938336L,2963664L,4437312L,6091584L,8118024L,11368368L,15653352L,19822176L,24832944L,32826112L,42517728L,51425088L,61903776L,78146664L,98021616L };
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
public class A000145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000145Inst : IEnumerable<long>
{
public static readonly long[] Value=A000145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000145.Bytes);
public long this[int i]=>Value[i];

public static A000145Inst Instance=new A000145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000144
{
public static readonly long[] Value={ 1L,20L,180L,960L,3380L,8424L,16320L,28800L,52020L,88660L,129064L,175680L,262080L,386920L,489600L,600960L,840500L,1137960L,1330420L,1563840L,2050344L,2611200L,2986560L,3358080L,4194240L,5318268L,5878440L,6299520L,7862400L,9619560L };
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
public class A000144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000144Inst : IEnumerable<long>
{
public static readonly long[] Value=A000144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000144.Bytes);
public long this[int i]=>Value[i];

public static A000144Inst Instance=new A000144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000143
{
public static readonly long[] Value={ 1L,16L,112L,448L,1136L,2016L,3136L,5504L,9328L,12112L,14112L,21312L,31808L,35168L,38528L,56448L,74864L,78624L,84784L,109760L,143136L,154112L,149184L,194688L,261184L,252016L,246176L,327040L,390784L,390240L,395136L,476672L,599152L,596736L,550368L,693504L,859952L };
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
public class A000143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000143Inst : IEnumerable<long>
{
public static readonly long[] Value=A000143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000143.Bytes);
public long this[int i]=>Value[i];

public static A000143Inst Instance=new A000143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000142
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628800L,39916800L,479001600L,6227020800L,87178291200L,1307674368000L,20922789888000L,355687428096000L,6402373705728000L,121645100408832000L,2432902008176640000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("1124000727777607680000") };
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
public class A000142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000142Inst Instance=new A000142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000141
{
public static readonly long[] Value={ 1L,12L,60L,160L,252L,312L,544L,960L,1020L,876L,1560L,2400L,2080L,2040L,3264L,4160L,4092L,3480L,4380L,7200L,6552L,4608L,8160L,10560L,8224L,7812L,10200L,13120L,12480L,10104L,14144L,19200L,16380L,11520L,17400L,24960L,18396L,16440L,24480L,27200L };
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
public class A000141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000141Inst : IEnumerable<long>
{
public static readonly long[] Value=A000141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000141.Bytes);
public long this[int i]=>Value[i];

public static A000141Inst Instance=new A000141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000140
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,101L,573L,3836L,29228L,250749L,2409581L,25598186L,296643390L,3727542188L,50626553988L,738680521142L,11501573822788L,190418421447330L,3344822488498265L,62119523114983224L,1214967840930909302L };
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
public class A000140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000140Inst : IEnumerable<long>
{
public static readonly long[] Value=A000140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000140.Bytes);
public long this[int i]=>Value[i];

public static A000140Inst Instance=new A000140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000139
{
public static readonly long[] Value={ 2L,1L,2L,6L,22L,91L,408L,1938L,9614L,49335L,260130L,1402440L,7702632L,42975796L,243035536L,1390594458L,8038677054L,46892282815L,275750636070L,1633292229030L,9737153323590L,58392041019795L,352044769046880L,2132866978427640L };
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
public class A000139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000139Inst : IEnumerable<long>
{
public static readonly long[] Value=A000139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000139.Bytes);
public long this[int i]=>Value[i];

public static A000139Inst Instance=new A000139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000138
{
public static readonly long[] Value={ 1L,1L,2L,6L,18L,90L,540L,3780L,31500L,283500L,2835000L,31185000L,372972600L,4848643800L,67881013200L,1018215198000L,16294848570000L,277012425690000L,4986223662420000L,94738249585980000L,1894745192712372000L };
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
public class A000138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000138Inst : IEnumerable<long>
{
public static readonly long[] Value=A000138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000138.Bytes);
public long this[int i]=>Value[i];

public static A000138Inst Instance=new A000138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000137
{
public static readonly long[] Value={ 1L,2L,6L,18L,58L,186L,614L,2034L,6818L,22970L,77858L,264970L,905294L,3102434L,10661370L,36722642L,126752218L,438294018L,1518032598L,5265341314L,18286911130L,63586988434L,221342104842L,771235606050L,2689688538646L,9388096331642L };
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
public class A000137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000137Inst : IEnumerable<long>
{
public static readonly long[] Value=A000137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000137.Bytes);
public long this[int i]=>Value[i];

public static A000137Inst Instance=new A000137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000136
{
public static readonly long[] Value={ 1L,2L,6L,16L,50L,144L,462L,1392L,4536L,14060L,46310L,146376L,485914L,1557892L,5202690L,16861984L,56579196L,184940388L,622945970L,2050228360L,6927964218L,22930109884L,77692142980L,258360586368L,877395996200L,2929432171328L,9968202968958L,33396290888520L,113837957337750L };
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
public class A000136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000136Inst : IEnumerable<long>
{
public static readonly long[] Value=A000136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000136.Bytes);
public long this[int i]=>Value[i];

public static A000136Inst Instance=new A000136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000135
{
public static readonly long[] Value={ 1L,2L,6L,13L,24L,42L,73L,125L,204L,324L,511L,801L,1228L,1856L,2780L,4135L,6084L,8873L,12847L,18481L,26416L,37473L,52871L,74216L,103596L,143841L,198839L,273654L,374987L,511735L,695559L,941932L,1271139L,1709474L,2291195L,3061385L,4078152L,5416322L };
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
public class A000135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000135Inst : IEnumerable<long>
{
public static readonly long[] Value=A000135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000135.Bytes);
public long this[int i]=>Value[i];

public static A000135Inst Instance=new A000135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000134
{
public static readonly long[] Value={ 2L,6L,9L,12L,15L,18L,21L,24L,27L,31L,34L,37L,40L,43L,46L,49L,53L,56L,59L,62L,65L,68L,71L,75L,78L,81L,84L,87L,90L,93L,97L,100L,103L,106L,109L,112L,115L,119L,122L,125L,128L,131L,134L,137L,141L,144L,147L,150L,153L,156L,159L,163L,166L,169L,172L,175L,178L,181L,185L,188L };
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
public class A000134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000134Inst : IEnumerable<long>
{
public static readonly long[] Value=A000134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000134.Bytes);
public long this[int i]=>Value[i];

public static A000134Inst Instance=new A000134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000133
{
public static readonly BigInteger[] Value={ 2L,5L,30L,2288L,67172352L,144115192303714304L,BigInteger.Parse("1329227995784915891206435945914040320"),BigInteger.Parse("226156424291633194186662080095093570364871077725232774230036394136943198208") };
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
public class A000133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000133Inst Instance=new A000133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000132
{
public static readonly long[] Value={ 1L,10L,40L,80L,90L,112L,240L,320L,200L,250L,560L,560L,400L,560L,800L,960L,730L,480L,1240L,1520L,752L,1120L,1840L,1600L,1200L,1210L,2000L,2240L,1600L,1680L,2720L,3200L,1480L,1440L,3680L,3040L,2250L,2800L,3280L,4160L,2800L,1920L,4320L,5040L,2800L,3472L,5920L };
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
public class A000132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000132Inst : IEnumerable<long>
{
public static readonly long[] Value=A000132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000132.Bytes);
public long this[int i]=>Value[i];

public static A000132Inst Instance=new A000132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000131
{
public static readonly long[] Value={ 2L,5L,21L,61L,214L,669L,2240L,7330L,24695L,83257L,284928L,981079L,3410990L,11937328L,42075242L,149171958L,531866972L,1905842605L,6861162880L,24805692978L,90035940227L,327987890608L,1198853954688L,4395797189206L,16165195705544L,59609156824273L,220373268471398L,816677398144221L };
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
public class A000131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000131Inst : IEnumerable<long>
{
public static readonly long[] Value=A000131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000131.Bytes);
public long this[int i]=>Value[i];

public static A000131Inst Instance=new A000131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000130
{
public static readonly BigInteger[] Value={ 0L,0L,1L,2L,5L,20L,115L,790L,6217L,55160L,545135L,5938490L,70686805L,912660508L,12702694075L,189579135710L,3019908731105L,51139445487680L,917345570926087L,17376071107513090L,346563420097249645L,7259714390232227300L,BigInteger.Parse("159352909727731210835"),BigInteger.Parse("3657569576966074846118") };
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
public class A000130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000130Inst Instance=new A000130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000129
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,29L,70L,169L,408L,985L,2378L,5741L,13860L,33461L,80782L,195025L,470832L,1136689L,2744210L,6625109L,15994428L,38613965L,93222358L,225058681L,543339720L,1311738121L,3166815962L,7645370045L,18457556052L,44560482149L,107578520350L,259717522849L };
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
public class A000129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000129Inst : IEnumerable<long>
{
public static readonly long[] Value=A000129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000129.Bytes);
public long this[int i]=>Value[i];

public static A000129Inst Instance=new A000129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000128
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,58L,105L,185L,319L,541L,906L,1503L,2476L,4058L,6626L,10790L,17537L,28464L,46155L,74791L,121137L,196139L,317508L,513901L,831686L,1345888L,2177900L,3524140L,5702419L,9226966L,14929821L,24157253L,39087571L,63245353L,102333486L };
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
public class A000128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000128Inst : IEnumerable<long>
{
public static readonly long[] Value=A000128.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000128.Bytes);
public long this[int i]=>Value[i];

public static A000128Inst Instance=new A000128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000127
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,57L,99L,163L,256L,386L,562L,794L,1093L,1471L,1941L,2517L,3214L,4048L,5036L,6196L,7547L,9109L,10903L,12951L,15276L,17902L,20854L,24158L,27841L,31931L,36457L,41449L,46938L,52956L,59536L,66712L,74519L,82993L,92171L,102091L,112792L,124314L,136698L };
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
public class A000127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000127Inst : IEnumerable<long>
{
public static readonly long[] Value=A000127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000127.Bytes);
public long this[int i]=>Value[i];

public static A000127Inst Instance=new A000127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000126
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,27L,47L,80L,134L,222L,365L,597L,973L,1582L,2568L,4164L,6747L,10927L,17691L,28636L,46346L,75002L,121369L,196393L,317785L,514202L,832012L,1346240L,2178279L,3524547L,5702855L,9227432L,14930318L,24157782L,39088133L,63245949L };
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
public class A000126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000126Inst : IEnumerable<long>
{
public static readonly long[] Value=A000126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000126.Bytes);
public long this[int i]=>Value[i];

public static A000126Inst Instance=new A000126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000125
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,26L,42L,64L,93L,130L,176L,232L,299L,378L,470L,576L,697L,834L,988L,1160L,1351L,1562L,1794L,2048L,2325L,2626L,2952L,3304L,3683L,4090L,4526L,4992L,5489L,6018L,6580L,7176L,7807L,8474L,9178L,9920L,10701L,11522L,12384L,13288L,14235L,15226L };
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
public class A000125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000125Inst : IEnumerable<long>
{
public static readonly long[] Value=A000125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000125.Bytes);
public long this[int i]=>Value[i];

public static A000125Inst Instance=new A000125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000124
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,46L,56L,67L,79L,92L,106L,121L,137L,154L,172L,191L,211L,232L,254L,277L,301L,326L,352L,379L,407L,436L,466L,497L,529L,562L,596L,631L,667L,704L,742L,781L,821L,862L,904L,947L,991L,1036L,1082L,1129L,1177L,1226L,1276L,1327L,1379L };
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
public class A000124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000124Inst : IEnumerable<long>
{
public static readonly long[] Value=A000124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000124.Bytes);
public long this[int i]=>Value[i];

public static A000124Inst Instance=new A000124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000123
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,26L,36L,46L,60L,74L,94L,114L,140L,166L,202L,238L,284L,330L,390L,450L,524L,598L,692L,786L,900L,1014L,1154L,1294L,1460L,1626L,1828L,2030L,2268L,2506L,2790L,3074L,3404L,3734L,4124L,4514L,4964L,5414L,5938L,6462L,7060L,7658L,8350L,9042L };
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
public class A000123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000123Inst : IEnumerable<long>
{
public static readonly long[] Value=A000123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000123.Bytes);
public long this[int i]=>Value[i];

public static A000123Inst Instance=new A000123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000122
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L };
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
public class A000122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000122Inst : IEnumerable<long>
{
public static readonly long[] Value=A000122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000122.Bytes);
public long this[int i]=>Value[i];

public static A000122Inst Instance=new A000122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000121
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,3L,4L,5L,4L,5L,4L,4L,6L,5L,6L,6L,5L,6L,4L,5L,7L,6L,8L,7L,6L,8L,6L,7L,8L,6L,7L,5L,5L,8L,7L,9L,9L,8L,10L,7L,8L,10L,8L,10L,8L,7L,10L,8L,9L,9L,7L,8L,5L,6L,9L,8L,11L,10L,9L,12L,9L,11L,13L,10L,12L,9L,8L,12L,10L,12L,12L,10L,12L,8L,9L,12L,10L,13L,11L,9L,12L,9L,10L,11L,8L,9L,6L,6L,10L,9L };
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
public class A000121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000121Inst : IEnumerable<long>
{
public static readonly long[] Value=A000121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000121.Bytes);
public long this[int i]=>Value[i];

public static A000121Inst Instance=new A000121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000120
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,4L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,6L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,6L,2L,3L,3L,4L,3L,4L,4L,5L,3L };
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
public class A000120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000120Inst : IEnumerable<long>
{
public static readonly long[] Value=A000120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000120.Bytes);
public long this[int i]=>Value[i];

public static A000120Inst Instance=new A000120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000119
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,2L,3L,1L,3L,3L,2L,4L,2L,3L,3L,1L,4L,3L,3L,5L,2L,4L,4L,2L,5L,3L,3L,4L,1L,4L,4L,3L,6L,3L,5L,5L,2L,6L,4L,4L,6L,2L,5L,5L,3L,6L,3L,4L,4L,1L,5L,4L,4L,7L,3L,6L,6L,3L,8L,5L,5L,7L,2L,6L,6L,4L,8L,4L,6L,6L,2L,7L,5L,5L,8L,3L,6L,6L,3L,7L,4L,4L,5L,1L,5L,5L,4L,8L,4L,7L,7L,3L,9L,6L,6L,9L,3L,8L,8L,5L };
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
public class A000119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000119Inst : IEnumerable<long>
{
public static readonly long[] Value=A000119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000119.Bytes);
public long this[int i]=>Value[i];

public static A000119Inst Instance=new A000119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000118
{
public static readonly long[] Value={ 1L,8L,24L,32L,24L,48L,96L,64L,24L,104L,144L,96L,96L,112L,192L,192L,24L,144L,312L,160L,144L,256L,288L,192L,96L,248L,336L,320L,192L,240L,576L,256L,24L,384L,432L,384L,312L,304L,480L,448L,144L,336L,768L,352L,288L,624L,576L,384L,96L,456L,744L,576L,336L,432L,960L,576L,192L };
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
public class A000118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000118Inst : IEnumerable<long>
{
public static readonly long[] Value=A000118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000118.Bytes);
public long this[int i]=>Value[i];

public static A000118Inst Instance=new A000118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000117
{
public static readonly long[] Value={ 1L,2L,4L,8L,18L,44L,122L,362L,1162L,3914L,13648L,48734L,176906L,649532L,2405236L,8964800L,33588234L,126390032L,477353376L,1808676326L,6872485104L,26179922024L,99957747388L,382443112538L,1466024067850L,5629516646996L,21651955485304L,83400061453514L };
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
public class A000117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000117Inst : IEnumerable<long>
{
public static readonly long[] Value=A000117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000117.Bytes);
public long this[int i]=>Value[i];

public static A000117Inst Instance=new A000117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000116
{
public static readonly long[] Value={ 1L,2L,4L,8L,20L,56L,180L,596L,2068L,7316L,26272L,95420L,349716L,1290872L,4794088L,17896832L,67110932L,252648992L,954444608L,3616828364L,13743921632L,52357746896L,199911300472L,764877836468L,2932031358484L,11258999739560L,43303843861744L,166799988689300L };
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
public class A000116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000116Inst : IEnumerable<long>
{
public static readonly long[] Value=A000116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000116.Bytes);
public long this[int i]=>Value[i];

public static A000116Inst Instance=new A000116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000115
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,16L,18L,20L,22L,24L,26L,29L,31L,34L,36L,39L,42L,45L,48L,51L,54L,58L,61L,65L,68L,72L,76L,80L,84L,88L,92L,97L,101L,106L,110L,115L,120L,125L,130L,135L,140L,146L,151L,157L,162L,168L,174L,180L,186L,192L,198L,205L,211L,218L,224L,231L,238L };
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
public class A000115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000115Inst : IEnumerable<long>
{
public static readonly long[] Value=A000115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000115.Bytes);
public long this[int i]=>Value[i];

public static A000115Inst Instance=new A000115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000114
{
public static readonly long[] Value={ 3L,4L,6L,12L,12L,24L,24L,36L,36L,60L,48L,84L,72L,96L,96L,144L,108L,180L,144L,192L,180L,264L,192L,300L,252L,324L,288L,420L,288L,480L,384L,480L,432L,576L,432L,684L,540L,672L,576L,840L,576L,924L,720L,864L,792L,1104L,768L };
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
public class A000114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000114Inst : IEnumerable<long>
{
public static readonly long[] Value=A000114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000114.Bytes);
public long this[int i]=>Value[i];

public static A000114Inst Instance=new A000114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000113
{
public static readonly long[] Value={ 1L,3L,4L,3L,6L,12L,8L,6L,4L,18L,12L,12L,14L,24L,24L,6L,18L,12L,20L,18L,32L,36L,24L,24L,30L,42L,12L,24L,30L,72L,32L,12L,48L,54L,48L,12L,38L,60L,56L,36L,42L,96L,44L,36L,24L,72L,48L,24L,56L,90L,72L,42L,54L,36L,72L,48L,80L,90L,60L,72L,62L,96L,32L,12L,84L,144L,68L };
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
public class A000113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000113Inst : IEnumerable<long>
{
public static readonly long[] Value=A000113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000113.Bytes);
public long this[int i]=>Value[i];

public static A000113Inst Instance=new A000113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000112
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,63L,318L,2045L,16999L,183231L,2567284L,46749427L,1104891746L,33823827452L,1338193159771L,68275077901156L,4483130665195087L };
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
public class A000112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000112Inst : IEnumerable<long>
{
public static readonly long[] Value=A000112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000112.Bytes);
public long this[int i]=>Value[i];

public static A000112Inst Instance=new A000112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000111
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,16L,61L,272L,1385L,7936L,50521L,353792L,2702765L,22368256L,199360981L,1903757312L,19391512145L,209865342976L,2404879675441L,29088885112832L,370371188237525L,4951498053124096L,69348874393137901L,1015423886506852352L,15514534163557086905UL,BigInteger.Parse("246921480190207983616"),BigInteger.Parse("4087072509293123892361") };
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
public class A000111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000111Inst Instance=new A000111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000110
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,21147L,115975L,678570L,4213597L,27644437L,190899322L,1382958545L,10480142147L,82864869804L,682076806159L,5832742205057L,51724158235372L,474869816156751L,4506715738447323L,44152005855084346L,445958869294805289L,4638590332229999353L,BigInteger.Parse("49631246523618756274") };
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
public class A000110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000110Inst Instance=new A000110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000109
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,14L,50L,233L,1249L,7595L,49566L,339722L,2406841L,17490241L,129664753L,977526957L,7475907149L,57896349553L,453382272049L,3585853662949L,28615703421545L };
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
public class A000109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000109Inst : IEnumerable<long>
{
public static readonly long[] Value=A000109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000109.Bytes);
public long this[int i]=>Value[i];

public static A000109Inst Instance=new A000109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000108
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,42L,132L,429L,1430L,4862L,16796L,58786L,208012L,742900L,2674440L,9694845L,35357670L,129644790L,477638700L,1767263190L,6564120420L,24466267020L,91482563640L,343059613650L,1289904147324L,4861946401452L,18367353072152L,69533550916004L,263747951750360L,1002242216651368L,3814986502092304L };
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
public class A000108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000108Inst : IEnumerable<long>
{
public static readonly long[] Value=A000108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000108.Bytes);
public long this[int i]=>Value[i];

public static A000108Inst Instance=new A000108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000107
{
public static readonly long[] Value={ 0L,1L,2L,5L,13L,35L,95L,262L,727L,2033L,5714L,16136L,45733L,130046L,370803L,1059838L,3035591L,8710736L,25036934L,72069134L,207727501L,599461094L,1731818878L,5008149658L,14496034714L,41993925955L,121747732406L,353221737526L,1025471857282L,2978995353959L,8658997820084L };
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
public class A000107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000107Inst : IEnumerable<long>
{
public static readonly long[] Value=A000107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000107.Bytes);
public long this[int i]=>Value[i];

public static A000107Inst Instance=new A000107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000106
{
public static readonly long[] Value={ 1L,2L,5L,12L,30L,74L,188L,478L,1235L,3214L,8450L,22370L,59676L,160140L,432237L,1172436L,3194870L,8741442L,24007045L,66154654L,182864692L,506909562L,1408854940L,3925075510L,10959698606L,30665337738L,85967279447L,241433975446L,679192039401L,1913681367936L,5399924120339L };
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
public class A000106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000106Inst : IEnumerable<long>
{
public static readonly long[] Value=A000106.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000106.Bytes);
public long this[int i]=>Value[i];

public static A000106Inst Instance=new A000106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000105
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,12L,35L,108L,369L,1285L,4655L,17073L,63600L,238591L,901971L,3426576L,13079255L,50107909L,192622052L,742624232L,2870671950L,11123060678L,43191857688L,168047007728L,654999700403L,2557227044764L,9999088822075L,39153010938487L,153511100594603L };
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
public class A000105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000105Inst : IEnumerable<long>
{
public static readonly long[] Value=A000105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000105.Bytes);
public long this[int i]=>Value[i];

public static A000105Inst Instance=new A000105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000104
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,12L,35L,107L,363L,1248L,4460L,16094L,58937L,217117L,805475L,3001127L,11230003L,42161529L,158781106L,599563893L,2269506062L,8609442688L,32725637373L,124621833354L,475368834568L,1816103345752L,6948228104703L };
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
public class A000104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000104Inst : IEnumerable<long>
{
public static readonly long[] Value=A000104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000104.Bytes);
public long this[int i]=>Value[i];

public static A000104Inst Instance=new A000104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000103
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,5L,12L,34L,130L,525L,2472L,12400L,65619L,357504L,1992985L,11284042L,64719885L,375126827L,2194439398L,12941995397L,76890024027L,459873914230L,2767364341936L,16747182732792L };
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
public class A000103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000103Inst : IEnumerable<long>
{
public static readonly long[] Value=A000103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000103.Bytes);
public long this[int i]=>Value[i];

public static A000103Inst Instance=new A000103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000102
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,5L,12L,27L,59L,127L,269L,563L,1167L,2400L,4903L,9960L,20135L,40534L,81300L,162538L,324020L,644282L,1278152L,2530407L,5000178L,9863763L,19427976L,38211861L,75059535L,147263905L,288609341L,565047233L,1105229439L,2159947998L };
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
public class A000102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000102Inst : IEnumerable<long>
{
public static readonly long[] Value=A000102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000102.Bytes);
public long this[int i]=>Value[i];

public static A000102Inst Instance=new A000102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000101
{
public static readonly long[] Value={ 3L,5L,11L,29L,97L,127L,541L,907L,1151L,1361L,9587L,15727L,19661L,31469L,156007L,360749L,370373L,492227L,1349651L,1357333L,2010881L,4652507L,17051887L,20831533L,47326913L,122164969L,189695893L,191913031L,387096383L,436273291L,1294268779L };
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
public class A000101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000101Inst : IEnumerable<long>
{
public static readonly long[] Value=A000101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000101.Bytes);
public long this[int i]=>Value[i];

public static A000101Inst Instance=new A000101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000100
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,5L,11L,23L,47L,94L,185L,360L,694L,1328L,2526L,4781L,9012L,16929L,31709L,59247L,110469L,205606L,382087L,709108L,1314512L,2434364L,4504352L,8328253L,15388362L,28417385L,52451811L,96771787L,178473023L,329042890L,606466009L,1117506500L };
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
public class A000100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000100Inst : IEnumerable<long>
{
public static readonly long[] Value=A000100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000100.Bytes);
public long this[int i]=>Value[i];

public static A000100Inst Instance=new A000100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000099
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,24L,26L,41L,53L,130L,149L,205L,234L,287L,340L,410L,425L,480L,586L,840L,850L,986L,1680L,1843L,2260L,2591L,3023L,3024L,3400L,3959L,3960L,5182L,5183L,7920L,9796L,11233L,14883L,15119L,15120L,19593L,21600L,21603L,21604L,22177L,28559L,28560L };
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
public class A000099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000099Inst : IEnumerable<long>
{
public static readonly long[] Value=A000099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000099.Bytes);
public long this[int i]=>Value[i];

public static A000099Inst Instance=new A000099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000098
{
public static readonly long[] Value={ 1L,2L,5L,10L,19L,33L,57L,92L,147L,227L,345L,512L,752L,1083L,1545L,2174L,3031L,4179L,5719L,7752L,10438L,13946L,18519L,24428L,32051L,41805L,54265L,70079L,90102L,115318L,147005L,186626L,236064L,297492L,373645L,467707L };
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
public class A000098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000098Inst : IEnumerable<long>
{
public static readonly long[] Value=A000098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000098.Bytes);
public long this[int i]=>Value[i];

public static A000098Inst Instance=new A000098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000097
{
public static readonly long[] Value={ 1L,2L,5L,9L,17L,28L,47L,73L,114L,170L,253L,365L,525L,738L,1033L,1422L,1948L,2634L,3545L,4721L,6259L,8227L,10767L,13990L,18105L,23286L,29837L,38028L,48297L,61053L,76926L,96524L,120746L,150487L,187019L,231643L,286152L,352413L,432937L,530383L,648245L };
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
public class A000097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000097Inst : IEnumerable<long>
{
public static readonly long[] Value=A000097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000097.Bytes);
public long this[int i]=>Value[i];

public static A000097Inst Instance=new A000097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000096
{
public static readonly long[] Value={ 0L,2L,5L,9L,14L,20L,27L,35L,44L,54L,65L,77L,90L,104L,119L,135L,152L,170L,189L,209L,230L,252L,275L,299L,324L,350L,377L,405L,434L,464L,495L,527L,560L,594L,629L,665L,702L,740L,779L,819L,860L,902L,945L,989L,1034L,1080L,1127L,1175L,1224L,1274L,1325L,1377L,1430L,1484L,1539L,1595L,1652L,1710L,1769L };
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
public class A000096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000096Inst : IEnumerable<long>
{
public static readonly long[] Value=A000096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000096.Bytes);
public long this[int i]=>Value[i];

public static A000096Inst Instance=new A000096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000095
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L };
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
public class A000095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000095Inst : IEnumerable<long>
{
public static readonly long[] Value=A000095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000095.Bytes);
public long this[int i]=>Value[i];

public static A000095Inst Instance=new A000095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000094
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,5L,8L,14L,21L,32L,45L,65L,88L,121L,161L,215L,280L,367L,471L,607L,771L,980L,1232L,1551L,1933L,2410L,2983L,3690L,4536L,5574L,6811L,8317L,10110L,12276L,14848L,17941L,21600L,25977L,31146L,37298L,44542L,53132L,63218L,75131L,89089L };
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
public class A000094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000094Inst : IEnumerable<long>
{
public static readonly long[] Value=A000094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000094.Bytes);
public long this[int i]=>Value[i];

public static A000094Inst Instance=new A000094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000093
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,11L,14L,18L,22L,27L,31L,36L,41L,46L,52L,58L,64L,70L,76L,82L,89L,96L,103L,110L,117L,125L,132L,140L,148L,156L,164L,172L,181L,189L,198L,207L,216L,225L,234L,243L,252L,262L,272L,281L,291L,301L,311L,322L,332L,343L,353L,364L,374L,385L,396L,407L,419L,430L };
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
public class A000093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000093Inst : IEnumerable<long>
{
public static readonly long[] Value=A000093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000093.Bytes);
public long this[int i]=>Value[i];

public static A000093Inst Instance=new A000093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000092
{
public static readonly long[] Value={ 1L,2L,5L,6L,14L,21L,29L,30L,54L,90L,134L,155L,174L,230L,234L,251L,270L,342L,374L,461L,494L,550L,666L,750L,810L,990L,1890L,2070L,2486L,2757L,2966L,3150L,3566L,3630L,4554L,4829L,5670L,5750L,8154L,8382L,8774L,8910L,10350L,10710L,15734L,15750L,16302L,17550L };
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
public class A000092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000092Inst : IEnumerable<long>
{
public static readonly long[] Value=A000092.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000092.Bytes);
public long this[int i]=>Value[i];

public static A000092Inst Instance=new A000092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000091
{
public static readonly long[] Value={ 1L,2L,2L,2L,0L,4L,2L,2L,0L,0L,0L,4L,2L,4L,0L,2L,0L,0L,2L,0L,4L,0L,0L,4L,0L,4L,0L,4L,0L,0L,2L,2L,0L,0L,0L,0L,2L,4L,4L,0L,0L,8L,2L,0L,0L,0L,0L,4L,2L,0L,0L,4L,0L,0L,0L,4L,4L,0L,0L,0L,2L,4L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,2L,4L,0L,4L,0L,8L,2L,0L,0L,0L,0L,8L,0L,4L,0L,0L,0L,0L,4L,0L,4L,0L,0L,4L,2L,4L,0L,0L,0L,0L,2L,4L,0L };
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
public class A000091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000091Inst : IEnumerable<long>
{
public static readonly long[] Value=A000091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000091.Bytes);
public long this[int i]=>Value[i];

public static A000091Inst Instance=new A000091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000090
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,16L,80L,520L,3640L,29120L,259840L,2598400L,28582400L,343235200L,4462057600L,62468806400L,936987251200L,14991796019200L,254860532326400L,4587501779660800L,87162533813555200L,1743250676271104000L,BigInteger.Parse("36608259566534656000"),BigInteger.Parse("805381710463762432000") };
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
public class A000090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000090Inst Instance=new A000090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000089
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L };
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
public class A000089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000089Inst : IEnumerable<long>
{
public static readonly long[] Value=A000089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000089.Bytes);
public long this[int i]=>Value[i];

public static A000089Inst Instance=new A000089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000088
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,11L,34L,156L,1044L,12346L,274668L,12005168L,1018997864L,165091172592L,50502031367952L,29054155657235488L,BigInteger.Parse("31426485969804308768"),BigInteger.Parse("64001015704527557894928"),BigInteger.Parse("245935864153532932683719776"),BigInteger.Parse("1787577725145611700547878190848"),BigInteger.Parse("24637809253125004524383007491432768") };
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
public class A000088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000088Inst Instance=new A000088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000087
{
public static readonly long[] Value={ 2L,1L,2L,4L,10L,37L,138L,628L,2972L,14903L,76994L,409594L,2222628L,12281570L,68864086L,391120036L,2246122574L,13025721601L,76194378042L,449155863868L,2666126033850L,15925105028685L,95664343622234L,577651490729530L };
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
public class A000087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000087Inst : IEnumerable<long>
{
public static readonly long[] Value=A000087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000087.Bytes);
public long this[int i]=>Value[i];

public static A000087Inst Instance=new A000087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000086
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L };
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
public class A000086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000086Inst : IEnumerable<long>
{
public static readonly long[] Value=A000086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000086.Bytes);
public long this[int i]=>Value[i];

public static A000086Inst Instance=new A000086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000085
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,76L,232L,764L,2620L,9496L,35696L,140152L,568504L,2390480L,10349536L,46206736L,211799312L,997313824L,4809701440L,23758664096L,119952692896L,618884638912L,3257843882624L,17492190577600L,95680443760576L,532985208200576L,3020676745975552L };
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
public class A000085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000085Inst : IEnumerable<long>
{
public static readonly long[] Value=A000085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000085.Bytes);
public long this[int i]=>Value[i];

public static A000085Inst Instance=new A000085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000084
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,66L,180L,522L,1532L,4624L,14136L,43930L,137908L,437502L,1399068L,4507352L,14611576L,47633486L,156047204L,513477502L,1696305728L,5623993944L,18706733128L,62408176762L,208769240140L,700129713630L,2353386723912L };
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
public class A000084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000084Inst : IEnumerable<long>
{
public static readonly long[] Value=A000084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000084.Bytes);
public long this[int i]=>Value[i];

public static A000084Inst Instance=new A000084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000083
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,23L,63L,188L,596L,1979L,6804L,24118L,87379L,322652L,1209808L,4596158L,17657037L,68497898L,268006183L,1056597059L,4193905901L,16748682185L,67258011248L,271452424286L,1100632738565L,4481533246014L };
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
public class A000083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000083Inst : IEnumerable<long>
{
public static readonly long[] Value=A000083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000083.Bytes);
public long this[int i]=>Value[i];

public static A000083Inst Instance=new A000083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000082
{
public static readonly long[] Value={ 1L,6L,12L,24L,30L,72L,56L,96L,108L,180L,132L,288L,182L,336L,360L,384L,306L,648L,380L,720L,672L,792L,552L,1152L,750L,1092L,972L,1344L,870L,2160L,992L,1536L,1584L,1836L,1680L,2592L,1406L,2280L,2184L,2880L,1722L,4032L,1892L,3168L,3240L,3312L,2256L };
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
public class A000082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000082Inst : IEnumerable<long>
{
public static readonly long[] Value=A000082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000082.Bytes);
public long this[int i]=>Value[i];

public static A000082Inst Instance=new A000082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000081
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,9L,20L,48L,115L,286L,719L,1842L,4766L,12486L,32973L,87811L,235381L,634847L,1721159L,4688676L,12826228L,35221832L,97055181L,268282855L,743724984L,2067174645L,5759636510L,16083734329L,45007066269L,126186554308L,354426847597L };
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
public class A000081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000081Inst : IEnumerable<long>
{
public static readonly long[] Value=A000081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000081.Bytes);
public long this[int i]=>Value[i];

public static A000081Inst Instance=new A000081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000080
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,19L,48L,117L,307L,821L,2277L,6437L,18634L,54775L,163703L,495529L,1518706L,4703848L,14714754L,46444979L,147832051L,474229588L,1532565644L };
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
public class A000080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000080Inst : IEnumerable<long>
{
public static readonly long[] Value=A000080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000080.Bytes);
public long this[int i]=>Value[i];

public static A000080Inst Instance=new A000080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000079
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L,8589934592L };
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
public class A000079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000079Inst : IEnumerable<long>
{
public static readonly long[] Value=A000079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000079.Bytes);
public long this[int i]=>Value[i];

public static A000079Inst Instance=new A000079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000078
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,8L,15L,29L,56L,108L,208L,401L,773L,1490L,2872L,5536L,10671L,20569L,39648L,76424L,147312L,283953L,547337L,1055026L,2033628L,3919944L,7555935L,14564533L,28074040L,54114452L,104308960L,201061985L,387559437L,747044834L,1439975216L,2775641472L };
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
public class A000078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000078Inst : IEnumerable<long>
{
public static readonly long[] Value=A000078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000078.Bytes);
public long this[int i]=>Value[i];

public static A000078Inst Instance=new A000078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000077
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,13L,24L,42L,76L,140L,257L,483L,907L,1717L,3272L,6261L,12027L,23172L,44769L,86708L,168245L,327073L,636849L,1241720L,2424290L,4738450L,9271396L,18157630L,35591729L,69820804L,137069245L,269270791L,529312776L,1041093937L,2048826229L,4034062310L };
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
public class A000077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000077Inst : IEnumerable<long>
{
public static readonly long[] Value=A000077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000077.Bytes);
public long this[int i]=>Value[i];

public static A000077Inst Instance=new A000077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000076
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,7L,14L,24L,43L,82L,149L,284L,534L,1015L,1937L,3713L,7136L,13759L,26597L,51537L,100045L,194586L,378987L,739161L,1443465L,2821923L,5522689L };
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
public class A000076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000076Inst : IEnumerable<long>
{
public static readonly long[] Value=A000076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000076.Bytes);
public long this[int i]=>Value[i];

public static A000076Inst Instance=new A000076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000075
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,14L,23L,42L,76L,139L,258L,482L,907L,1717L,3269L,6257L,12020L,23171L,44762L,86683L,168233L,327053L,636837L,1241723L,2424228L,4738426L,9271299L,18157441L,35591647L,69820626L,137068908L,269270450L,529312241L,1041093048L,2048825748L,4034059456L };
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
public class A000075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000075Inst : IEnumerable<long>
{
public static readonly long[] Value=A000075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000075.Bytes);
public long this[int i]=>Value[i];

public static A000075Inst Instance=new A000075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000074
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,25L,43L,83L,157L,296L,564L,1083L,2077L,4006L,7733L,14968L,29044L,56447L,109864L,214197L,418080L,816907L,1598040L,3129063L,6132106L,12027122L,23606527L,46366165L,91127332L,179207074L,352615528L,694182554L,1367278759L };
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
public class A000074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000074Inst : IEnumerable<long>
{
public static readonly long[] Value=A000074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000074.Bytes);
public long this[int i]=>Value[i];

public static A000074Inst Instance=new A000074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000073
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,7L,13L,24L,44L,81L,149L,274L,504L,927L,1705L,3136L,5768L,10609L,19513L,35890L,66012L,121415L,223317L,410744L,755476L,1389537L,2555757L,4700770L,8646064L,15902591L,29249425L,53798080L,98950096L,181997601L,334745777L,615693474L,1132436852L };
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
public class A000073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000073Inst : IEnumerable<long>
{
public static readonly long[] Value=A000073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000073.Bytes);
public long this[int i]=>Value[i];

public static A000073Inst Instance=new A000073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000072
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,22L,41L,72L,137L,254L,476L,901L,1716L,3274L,6286L,12090L,23331L,45140L,87511L,169972L,330752L,644499L,1257523L,2456736L,4804666L,9405749L,18429828L,36141339L,70928099L,139295793L,273741700L,538277486L,1059051586L,2084763319L,4105924366L };
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
public class A000072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000072Inst : IEnumerable<long>
{
public static readonly long[] Value=A000072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000072.Bytes);
public long this[int i]=>Value[i];

public static A000072Inst Instance=new A000072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000071
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,7L,12L,20L,33L,54L,88L,143L,232L,376L,609L,986L,1596L,2583L,4180L,6764L,10945L,17710L,28656L,46367L,75024L,121392L,196417L,317810L,514228L,832039L,1346268L,2178308L,3524577L,5702886L,9227464L,14930351L,24157816L,39088168L };
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
public class A000071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000071Inst : IEnumerable<long>
{
public static readonly long[] Value=A000071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000071.Bytes);
public long this[int i]=>Value[i];

public static A000071Inst Instance=new A000071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000070
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,30L,45L,67L,97L,139L,195L,272L,373L,508L,684L,915L,1212L,1597L,2087L,2714L,3506L,4508L,5763L,7338L,9296L,11732L,14742L,18460L,23025L,28629L,35471L,43820L,53963L,66273L,81156L,99133L,120770L,146785L,177970L,215308L,259891L,313065L,376326L,451501L };
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
public class A000070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000070Inst : IEnumerable<long>
{
public static readonly long[] Value=A000070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000070.Bytes);
public long this[int i]=>Value[i];

public static A000070Inst Instance=new A000070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000069
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,13L,14L,16L,19L,21L,22L,25L,26L,28L,31L,32L,35L,37L,38L,41L,42L,44L,47L,49L,50L,52L,55L,56L,59L,61L,62L,64L,67L,69L,70L,73L,74L,76L,79L,81L,82L,84L,87L,88L,91L,93L,94L,97L,98L,100L,103L,104L,107L,109L,110L,112L,115L,117L,118L,121L,122L,124L,127L,128L };
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
public class A000069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000069Inst : IEnumerable<long>
{
public static readonly long[] Value=A000069.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000069.Bytes);
public long this[int i]=>Value[i];

public static A000069Inst Instance=new A000069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000068
{
public static readonly long[] Value={ 1L,2L,4L,6L,16L,20L,24L,28L,34L,46L,48L,54L,56L,74L,80L,82L,88L,90L,106L,118L,132L,140L,142L,154L,160L,164L,174L,180L,194L,198L,204L,210L,220L,228L,238L,242L,248L,254L,266L,272L,276L,278L,288L,296L,312L,320L,328L,334L,340L,352L,364L,374L,414L,430L,436L,442L,466L };
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
public class A000068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000068Inst : IEnumerable<long>
{
public static readonly long[] Value=A000068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000068.Bytes);
public long this[int i]=>Value[i];

public static A000068Inst Instance=new A000068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000067
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,18L,33L,60L,111L,205L,385L,725L,1374L,2610L,4993L,9578L,18426L,35568L,68806L,133411L,259145L,504222L,982538L,1917190L,3745385L,7324822L,14339072L,28095711L,55095559L,108124461L,212342327L,417283564L,820520378L,1614331755L,3177789615L,6258525127L };
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
public class A000067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000067Inst : IEnumerable<long>
{
public static readonly long[] Value=A000067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000067.Bytes);
public long this[int i]=>Value[i];

public static A000067Inst Instance=new A000067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000066
{
public static readonly long[] Value={ 4L,6L,10L,14L,24L,30L,58L,70L,112L,126L };
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
public class A000066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000066Inst : IEnumerable<long>
{
public static readonly long[] Value=A000066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000066.Bytes);
public long this[int i]=>Value[i];

public static A000066Inst Instance=new A000066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000065
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,10L,14L,21L,29L,41L,55L,76L,100L,134L,175L,230L,296L,384L,489L,626L,791L,1001L,1254L,1574L,1957L,2435L,3009L,3717L,4564L,5603L,6841L,8348L,10142L,12309L,14882L,17976L,21636L,26014L,31184L,37337L,44582L,53173L,63260L,75174L,89133L,105557L,124753L };
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
public class A000065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000065Inst : IEnumerable<long>
{
public static readonly long[] Value=A000065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000065.Bytes);
public long this[int i]=>Value[i];

public static A000065Inst Instance=new A000065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000064
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,13L,18L,24L,31L,39L,50L,62L,77L,93L,112L,134L,159L,187L,218L,252L,292L,335L,384L,436L,494L,558L,628L,704L,786L,874L,972L,1076L,1190L,1310L,1440L,1580L,1730L,1890L,2060L,2240L,2435L,2640L,2860L,3090L,3335L,3595L,3870L,4160L,4465L,4785L,5126L };
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
public class A000064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000064Inst : IEnumerable<long>
{
public static readonly long[] Value=A000064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000064.Bytes);
public long this[int i]=>Value[i];

public static A000064Inst Instance=new A000064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000063
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,14L,14L,39L,42L,132L,132L,424L,429L,1428L,1430L,4848L,4862L,16796L,16796L,58739L,58786L,208012L,208012L,742768L,742900L,2674426L,2674440L,9694416L,9694845L,35357670L,35357670L,129643318L,129644790L,477638700L,477638700L,1767258328L,1767263190L,6564120288L };
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
public class A000063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000063Inst : IEnumerable<long>
{
public static readonly long[] Value=A000063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000063.Bytes);
public long this[int i]=>Value[i];

public static A000063Inst Instance=new A000063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000062
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,34L,36L,37L,38L,40L,41L,43L,44L,45L,47L,48L,50L,51L,52L,54L,55L,57L,58L,59L,61L,62L,64L,65L,66L,68L,69L,71L,72L,73L,75L,76L,77L,79L,80L,82L,83L,84L,86L,87L,89L,90L,91L,93L,94L,96L,97L,98L };
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
public class A000062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000062Inst : IEnumerable<long>
{
public static readonly long[] Value=A000062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000062.Bytes);
public long this[int i]=>Value[i];

public static A000062Inst Instance=new A000062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000061
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,6L,8L,8L,12L,14L,14L,16L,20L,20L,24L,32L,24L,30L,38L,32L,40L,46L,40L,48L,60L,50L,54L,64L,60L,68L,80L,64L,72L,92L,76L,96L,100L,82L,104L,112L,96L,108L,126L,112L,120L,148L,112L,128L,168L,130L,156L,160L,140L,162L,184L,160L,168L,198L,170L,192L,220L,168L,192L };
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
public class A000061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000061Inst : IEnumerable<long>
{
public static readonly long[] Value=A000061.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000061.Bytes);
public long this[int i]=>Value[i];

public static A000061Inst Instance=new A000061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000060
{
public static readonly long[] Value={ 1L,2L,3L,10L,27L,98L,350L,1402L,5743L,24742L,108968L,492638L,2266502L,10600510L,50235931L,240882152L,1166732814L,5702046382L,28088787314L,139355139206L,695808554300L,3494391117164L,17641695461662L,89495028762682L,456009893224285L,2332997356507678L,11980753878699716L,61739654456234062L,319188605907760846L };
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
public class A000060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000060Inst : IEnumerable<long>
{
public static readonly long[] Value=A000060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000060.Bytes);
public long this[int i]=>Value[i];

public static A000060Inst Instance=new A000060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000059
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,12L,14L,17L,23L,24L,27L,28L,37L,40L,41L,44L,45L,53L,59L,66L,70L,71L,77L,80L,82L,87L,90L,97L,99L,102L,105L,110L,114L,119L,121L,124L,127L,133L,136L,138L,139L,144L,148L,156L,160L,164L,167L,170L,176L,182L,187L,207L,215L,218L,221L,233L,236L,238L,244L,246L };
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
public class A000059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000059Inst : IEnumerable<long>
{
public static readonly long[] Value=A000059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000059.Bytes);
public long this[int i]=>Value[i];

public static A000059Inst Instance=new A000059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000058
{
public static readonly BigInteger[] Value={ 2L,3L,7L,43L,1807L,3263443L,10650056950807L,BigInteger.Parse("113423713055421844361000443"),BigInteger.Parse("12864938683278671740537145998360961546653259485195807") };
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
public class A000058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000058.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000058Inst Instance=new A000058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000057
{
public static readonly long[] Value={ 2L,3L,7L,23L,43L,67L,83L,103L,127L,163L,167L,223L,227L,283L,367L,383L,443L,463L,467L,487L,503L,523L,547L,587L,607L,643L,647L,683L,727L,787L,823L,827L,863L,883L,887L,907L,947L,983L,1063L,1123L,1163L,1187L,1283L,1303L,1327L,1367L,1423L,1447L,1487L,1543L };
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
public class A000057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000057Inst : IEnumerable<long>
{
public static readonly long[] Value=A000057.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000057.Bytes);
public long this[int i]=>Value[i];

public static A000057Inst Instance=new A000057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000056
{
public static readonly long[] Value={ 1L,6L,24L,48L,120L,144L,336L,384L,648L,720L,1320L,1152L,2184L,2016L,2880L,3072L,4896L,3888L,6840L,5760L,8064L,7920L,12144L,9216L,15000L,13104L,17496L,16128L,24360L,17280L,29760L,24576L,31680L,29376L,40320L,31104L };
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
public class A000056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000056Inst : IEnumerable<long>
{
public static readonly long[] Value=A000056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000056.Bytes);
public long this[int i]=>Value[i];

public static A000056Inst Instance=new A000056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000055
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,11L,23L,47L,106L,235L,551L,1301L,3159L,7741L,19320L,48629L,123867L,317955L,823065L,2144505L,5623756L,14828074L,39299897L,104636890L,279793450L,751065460L,2023443032L,5469566585L,14830871802L,40330829030L,109972410221L,300628862480L,823779631721L,2262366343746L,6226306037178L };
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
public class A000055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000055Inst : IEnumerable<long>
{
public static readonly long[] Value=A000055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000055.Bytes);
public long this[int i]=>Value[i];

public static A000055Inst Instance=new A000055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000054
{
public static readonly long[] Value={ 4L,14L,23L,34L,42L,50L,59L,72L,81L,86L,96L,103L,110L,116L,125L,135L,145L,155L,163L,168L,175L,181L,190L,200L,207L };
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
public class A000054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000054Inst : IEnumerable<long>
{
public static readonly long[] Value=A000054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000054.Bytes);
public long this[int i]=>Value[i];

public static A000054Inst Instance=new A000054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000053
{
public static readonly long[] Value={ 14L,18L,23L,28L,34L,42L,50L,59L,66L,72L,79L,86L,96L,103L,110L,116L,125L,137L,145L,157L,168L,181L,191L,207L,215L,225L,231L,238L,242L };
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
public class A000053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000053Inst : IEnumerable<long>
{
public static readonly long[] Value=A000053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A000053.Bytes);
public long this[int i]=>Value[i];

public static A000053Inst Instance=new A000053Inst();

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