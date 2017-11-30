using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159464
{
public static readonly long[] Value={ 1701L,51912L,377402L,388105L,1598877L,46208786L,212204419L,51398524L,91140956L,145796362L,133289691L,109954L,344895386L };
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
public class A159464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159464Inst : IEnumerable<long>
{
public static readonly long[] Value=A159464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159464.Bytes);
public long this[int i]=>Value[i];

public static A159464Inst Instance=new A159464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159465
{
public static readonly long[] Value={ 3L,8L,15L,26L,39L,54L,71L,90L,111L,134L,161L,190L,221L,254L,289L,326L,365L,406L,449L,494L,541L,592L,645L,700L,757L,816L,877L,940L,1005L,1072L,1141L,1212L,1285L,1360L,1437L,1516L,1599L,1684L,1771L,1860L,1951L,2044L,2139L,2236L,2335L,2436L,2539L,2644L,2751L };
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
public class A159465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159465Inst : IEnumerable<long>
{
public static readonly long[] Value=A159465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159465.Bytes);
public long this[int i]=>Value[i];

public static A159465Inst Instance=new A159465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159466
{
public static readonly long[] Value={ 113L,127L,145L,533L,635L,757L,3085L,3683L,4397L,17977L,21463L,25625L,104777L,125095L,149353L,610685L,729107L,870493L,3559333L,4249547L,5073605L,20745313L,24768175L,29571137L,120912545L,144359503L,172353217L,704729957L,841388843L,1004548165L };
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
public class A159466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159466Inst : IEnumerable<long>
{
public static readonly long[] Value=A159466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159466.Bytes);
public long this[int i]=>Value[i];

public static A159466Inst Instance=new A159466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159467
{
public static readonly long[] Value={ 1L,1L,9L,3L,9L,1L,6L,6L,6L,9L,2L,7L,5L,3L,5L,0L,5L,5L,7L,3L,2L,9L,3L,4L,6L,6L,1L,0L,9L,2L,4L,0L,5L,6L,4L,5L,0L,8L,4L,3L,4L,2L,3L,2L,2L,8L,3L,9L,3L,9L,4L,6L,2L,1L,3L,9L,4L,3L,5L,1L,8L,7L,0L,7L,1L,4L,8L,4L,3L,8L,7L,3L,7L,4L,4L,4L,0L,4L,4L,9L,8L,1L,2L,7L,2L,4L,8L,9L,7L,6L,8L,1L,0L,4L,2L,6L,9L,8L,0L,4L,4L,3L,9L,0L,5L };
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
public class A159467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159467Inst : IEnumerable<long>
{
public static readonly long[] Value=A159467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159467.Bytes);
public long this[int i]=>Value[i];

public static A159467Inst Instance=new A159467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159468
{
public static readonly long[] Value={ 4L,0L,8L,8L,8L,7L,0L,3L,4L,0L,0L,2L,9L,9L,4L,5L,4L,1L,8L,8L,0L,0L,3L,3L,6L,0L,5L,3L,8L,2L,3L,8L,5L,7L,7L,2L,6L,9L,7L,6L,5L,2L,3L,4L,5L,7L,8L,7L,1L,7L,4L,9L,9L,9L,4L,4L,3L,1L,0L,9L,7L,6L,0L,1L,6L,0L,1L,6L,3L,9L,1L,2L,1L,6L,3L,4L,7L,1L,4L,5L,2L,0L,7L,8L,1L,0L,8L,9L,6L,8L,4L,8L,8L,6L,2L,6L,4L,4L,0L,3L,0L,9L,3L,6L,1L };
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
public class A159468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159468Inst : IEnumerable<long>
{
public static readonly long[] Value=A159468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159468.Bytes);
public long this[int i]=>Value[i];

public static A159468Inst Instance=new A159468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159469
{
public static readonly long[] Value={ 6L,8L,20L,24L,42L,48L,72L,80L,110L,120L,156L,168L,210L,224L,272L,288L,342L,360L,420L,440L,506L,528L,600L,624L,702L,728L,812L,840L,930L,960L,1056L,1088L,1190L,1224L,1332L,1368L,1482L,1520L,1640L,1680L,1806L,1848L,1980L,2024L,2162L,2208L,2352L,2400L,2550L,2600L };
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
public class A159469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159469Inst : IEnumerable<long>
{
public static readonly long[] Value=A159469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159469.Bytes);
public long this[int i]=>Value[i];

public static A159469Inst Instance=new A159469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159470
{
public static readonly BigInteger[] Value={ 1L,20L,158L,-6520L,-245108L,1409200L,324764680L,4449135200L,-461168663920L,-17836899025600L,647687369505760L,56119043032067200L,-601762916982989120L,BigInteger.Parse("-175004959304782931200"),BigInteger.Parse("-1606953049267174852480"),BigInteger.Parse("560777741139261073856000"),BigInteger.Parse("17048794391625066191622400") };
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
public class A159470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159470Inst Instance=new A159470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159471
{
public static readonly long[] Value={ 3L,5L,7L,11L,131L,151L,191L,313L,353L,373L,757L,797L,919L,11311L,13331L,13931L,15551L,17971L,19391L,19991L,31513L,33533L,35153L,35353L,35753L,37573L,71317L,71917L,75557L,77377L,77977L,79397L,79997L,93139L,93739L,95959L,97379L,97579L,1117111L };
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
public class A159471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159471Inst : IEnumerable<long>
{
public static readonly long[] Value=A159471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159471.Bytes);
public long this[int i]=>Value[i];

public static A159471Inst Instance=new A159471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159472
{
public static readonly BigInteger[] Value={ 1L,1L,-71L,-215L,15121L,77041L,-5366519L,-38648231L,2666077345L,24927458401L,-1702690661159L,-19650460709879L,1328880542928049L,18306878596263505L,-1225525309584390359L,BigInteger.Parse("-19678858934618003399"),BigInteger.Parse("1303888475416523584321"),BigInteger.Parse("23973933968096463499969") };
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
public class A159472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159472Inst Instance=new A159472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159473
{
public static readonly long[] Value={ 9876543211L,9876542131L,9876541321L,9876541231L,9876534211L,9876532411L,9876524131L,9876521341L,9876521143L,9876514321L,9876511243L,9876453211L,9876435211L,9876432151L,9876425113L,9876421153L,9876325411L,9876324511L };
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
public class A159473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159473Inst : IEnumerable<long>
{
public static readonly long[] Value=A159473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159473.Bytes);
public long this[int i]=>Value[i];

public static A159473Inst Instance=new A159473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159474
{
public static readonly long[] Value={ 98765421103L,98765410231L,98765401321L,98765321401L,98765320411L,98765301241L,98765241103L,98765240131L,98765240113L,98765234011L,98765204311L,98765201341L,98765140231L,98765134021L,98765124103L };
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
public class A159474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159474Inst : IEnumerable<long>
{
public static readonly long[] Value=A159474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159474.Bytes);
public long this[int i]=>Value[i];

public static A159474Inst Instance=new A159474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159475
{
public static readonly long[] Value={ 1L,4L,6L,6L,10L,8L,14L,10L,12L,12L,22L,14L,26L,16L,18L,18L,34L,20L,38L,22L,24L,24L,46L,26L,30L,28L,30L,30L,58L,32L,62L,34L,36L,36L,40L,38L,74L,40L,42L,42L,82L,44L,86L,46L,48L,48L,94L,50L,56L,52L };
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
public class A159475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159475Inst : IEnumerable<long>
{
public static readonly long[] Value=A159475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159475.Bytes);
public long this[int i]=>Value[i];

public static A159475Inst Instance=new A159475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159476
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,62L,862L,19492L,656224L,30739676L,1906807004L,151002453464L,14846381034784L,1772922018732328L,252631570039665832L,BigInteger.Parse("42329528274029082608"),BigInteger.Parse("8237406877267427867648"),BigInteger.Parse("1842215469973381977889808") };
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
public class A159476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159476Inst Instance=new A159476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159477
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,7L,7L,11L,11L,11L,11L,13L,13L,17L,17L,17L,17L,19L,19L,23L,23L,23L,23L,29L,29L,29L,29L,29L,29L,31L,31L,37L,37L,37L,37L,37L,37L,41L,41L,41L,41L,43L,43L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,59L,59L,59L,59L };
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
public class A159477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159477Inst : IEnumerable<long>
{
public static readonly long[] Value=A159477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159477.Bytes);
public long this[int i]=>Value[i];

public static A159477Inst Instance=new A159477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159478
{
public static readonly BigInteger[] Value={ 1L,2L,-6L,140L,-14570L,6283452L,-11049839724L,78893138035608L,-2282580118745565210L,BigInteger.Parse("267227101453296251927660"),BigInteger.Parse("-126415241162450125116966673796"),BigInteger.Parse("241332381844862786094865482962203112") };
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
public class A159478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159478Inst Instance=new A159478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159479
{
public static readonly BigInteger[] Value={ 1L,-29L,1201L,-2610L,957359L,-364530L,164387161L,-40455870L,12538929119L,-4363782714L,260582566855L,-387500179350L,10408159409945789L,-56830633987218L,3452786092345807L,6808080496813650L,BigInteger.Parse("-50558539454655946337"),-9168876820065422442L,BigInteger.Parse("103952495666585167545907") };
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
public class A159479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159479Inst Instance=new A159479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159480
{
public static readonly BigInteger[] Value={ 1L,5L,-47L,-955L,5377L,301925L,-426095L,-132562075L,-448058495L,74115462725L,660919218385L,-50058537070075L,-773740706311295L,39381872496988325L,921130663592313745L,BigInteger.Parse("-35091274159002662875"),BigInteger.Parse("-1170277487474712158975"),BigInteger.Parse("34573760393797506837125") };
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
public class A159480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159480Inst Instance=new A159480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159481
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,4L,5L,6L,6L,7L,7L,7L,8L,8L,9L,10L,10L,11L,11L,11L,12L,13L,13L,13L,14L,14L,15L,16L,16L,16L,17L,18L,18L,19L,19L,19L,20L,21L,21L,21L,22L,22L,23L,24L,24L,25L,25L,25L,26L,26L,27L,28L,28L,28L,29L,30L,30L,31L,31L,31L,32L,32L,33L,34L,34L,35L,35L,35L,36L,37L,37L,37L };
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
public class A159481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159481Inst : IEnumerable<long>
{
public static readonly long[] Value=A159481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159481.Bytes);
public long this[int i]=>Value[i];

public static A159481Inst Instance=new A159481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159482
{
public static readonly long[] Value={ 0L,0L,0L,5L,7L,7L,11L,13L,13L,17L,19L,19L,23L,23L,23L,29L,31L,31L,31L,37L,37L,41L,43L,43L,47L,47L,47L,53L,53L,53L,59L,61L,61L,61L,67L,67L,71L,73L,73L,73L,79L,79L,83L,83L,83L,89L,89L,89L,79L,97L,97L,101L,103L,103L,107L,109L,109L,113L,113L,113L,109L,113L,113L,109L,127L,127L };
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
public class A159482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159482Inst : IEnumerable<long>
{
public static readonly long[] Value=A159482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159482.Bytes);
public long this[int i]=>Value[i];

public static A159482Inst Instance=new A159482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159483
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,4L,14L,71L,389L };
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
public class A159483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159483Inst : IEnumerable<long>
{
public static readonly long[] Value=A159483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159483.Bytes);
public long this[int i]=>Value[i];

public static A159483Inst Instance=new A159483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159484
{
public static readonly long[] Value={ 0L,0L,110L,1054L,7097L,41201L,220171L,1115862L,5451131L,25919515L,120721773L,553162595L,2501388936L,11188504443L,49589159037L,218081007181L,952654230982L,4137309942806L,17876235129762L,76889316253171L,329384246847644L,1405944884946771L,5981601330173431L };
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
public class A159484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159484Inst : IEnumerable<long>
{
public static readonly long[] Value=A159484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159484.Bytes);
public long this[int i]=>Value[i];

public static A159484Inst Instance=new A159484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159485
{
public static readonly BigInteger[] Value={ 1L,7L,-23L,-1169L,-3215L,314167L,3356569L,-112224161L,-2477279903L,47300157415L,1936378479049L,-20501463985457L,-1677122003305007L,5973410860299799L,1611600071115585145L,5260002350626898623L,BigInteger.Parse("-1703708060350443666239"),BigInteger.Parse("-17985479130375292877369") };
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
public class A159485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159485Inst Instance=new A159485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159486
{
public static readonly BigInteger[] Value={ 1L,11L,49L,-1045L,-22079L,58091L,8587441L,69366539L,-3565038335L,-79170548149L,1439268811441L,72834751593131L,-338718631136831L,-66655130318970325L,-416165794764599759L,BigInteger.Parse("62610547619111490251"),BigInteger.Parse("1138175082155994132481"),BigInteger.Parse("-59607424953500501311861") };
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
public class A159486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159486Inst Instance=new A159486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159487
{
public static readonly BigInteger[] Value={ 1L,-31L,1381L,-3255L,1308359L,-552265L,278675461L,-76721435L,26220063119L,-9960825357L,669913045555L,-1189545126175L,34211841785600789L,-152774070278609L,11476191574748467L,-10209965252448675L,BigInteger.Parse("-50055398850117166337"),-7113615137036531221L };
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
public class A159487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159487Inst Instance=new A159487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159488
{
public static readonly BigInteger[] Value={ 1L,2L,-334L,-2020L,334636L,3400312L,-558734216L,-8013301168L,1305938552720L,24279843463712L,-3924105390446816L,-89914081688240192L,14409995678304781504UL,BigInteger.Parse("393511506684111781760"),BigInteger.Parse("-62530497997102986365056"),BigInteger.Parse("-1987157445623422924018432"),BigInteger.Parse("313055309954065295022797056") };
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
public class A159488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159488.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159488Inst Instance=new A159488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159489
{
public static readonly BigInteger[] Value={ 1L,-5L,13L,55L,-2851L,-3245L,427363L,473935L,-61949131L,-123108821L,44665749215L,49265523175L,-889173917551201L,-28014998053757L,1297189933409461L,21455729885490175L,BigInteger.Parse("-96521711874559753547"),BigInteger.Parse("-21286177612465196453"),BigInteger.Parse("168569517408863607520801") };
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
public class A159489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159489Inst Instance=new A159489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159490
{
public static readonly ulong[] Value={ 1L,12L,144L,1728L,103680L,248832L,20901888L,35831808L,2149908480L,5159780352L,681091006464L,743008370688L,4056825703956480L,106993205379072L,1283918464548864L,15407021574586368L,15715162006078095360UL };
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
public class A159490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159490Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A159490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159490.Bytes);
public ulong this[int i]=>Value[i];

public static A159490Inst Instance=new A159490Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159491
{
public static readonly BigInteger[] Value={ 1L,-7L,37L,-91L,-2611L,3185L,427867L,-474019L,-61948651L,123108713L,44665750535L,-49265523307L,-889173917485681L,28014998053601L,1297189933409629L,-21455729885490355L,BigInteger.Parse("-96521711874559737227"),BigInteger.Parse("21286177612465196249"),BigInteger.Parse("168569517408863607549529") };
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
public class A159491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159491Inst Instance=new A159491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159492
{
public static readonly BigInteger[] Value={ 1L,4L,-322L,-3992L,310540L,6639344L,-498255224L,-15457610528L,1117041417872L,46265544539200L,-3212977815009824L,-169229451802535296L,11268933708996384448UL,BigInteger.Parse("731470391347068698368"),BigInteger.Parse("-46589813151941838471040"),BigInteger.Parse("-3647677144462096434561536"),BigInteger.Parse("221619644102496735309926656") };
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
public class A159492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159492Inst Instance=new A159492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159493
{
public static readonly BigInteger[] Value={ 1L,-1L,-11L,35L,2669L,-2905L,-419861L,461195L,61671509L,-122277169L,-44615461705L,49182223475L,888923348608559L,-28003152594313L,-1297098519768947L,21453461722720475L,BigInteger.Parse("96520011267489057013"),BigInteger.Parse("-21285615043272176737"),BigInteger.Parse("-168568774892764486508567") };
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
public class A159493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159493Inst Instance=new A159493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159494
{
public static readonly BigInteger[] Value={ 1L,6L,-302L,-5868L,271020L,9559656L,-400665864L,-21790977552L,817229568912L,63826180714080L,-2103055264345824L,-228350822399665344L,6449054538439781568L,BigInteger.Parse("964885262883681324672"),BigInteger.Parse("-22547834064602312261760"),BigInteger.Parse("-4701124068353193901918464"),BigInteger.Parse("86110774297414559755612416") };
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
public class A159494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159494Inst Instance=new A159494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159495
{
public static readonly BigInteger[] Value={ 1L,-11L,109L,-935L,32669L,-34595L,1155139L,-1773695L,99171509L,80089669L,-42037336705L,-50471285975L,892122567358559L,27965066656813L,-1296893441643947L,-21454560355532975L,BigInteger.Parse("96520509314364057013"),BigInteger.Parse("21285583915342489237"),BigInteger.Parse("-168568752975039877133567") };
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
public class A159495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159495Inst Instance=new A159495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159496
{
public static readonly BigInteger[] Value={ 1L,8L,-274L,-7600L,217036L,12011488L,-270698936L,-26524889152L,428274569360L,75149496821888L,-701615265418016L,-259618221381325568L,531659785773578944L,BigInteger.Parse("1057264784208845135360"),BigInteger.Parse("6122005174981655202944"),BigInteger.Parse("-4954000917476401938899968"),BigInteger.Parse("-70670573576968207390125824") };
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
public class A159496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159496Inst Instance=new A159496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159497
{
public static readonly BigInteger[] Value={ 1L,10L,-238L,-9140L,149932L,13856600L,-114819080L,-29249375600L,-20831812720L,78881993495200L,852190309246240L,-258099234921313600L,-5749435918990656320L,BigInteger.Parse("989356137650941398400"),BigInteger.Parse("35156582804554357854080"),BigInteger.Parse("-4330067415318711118688000"),BigInteger.Parse("-221544548972277705507065600") };
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
public class A159497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159497Inst Instance=new A159497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159498
{
public static readonly BigInteger[] Value={ 1L,12L,-194L,-10440L,71436L,14972112L,58938504L,-29656181088L,-495322673520L,74246441579712L,2397728871804384L,-222180226077773952L,BigInteger.Parse("-11580918658301987136"),BigInteger.Parse("762191973071827303680"),BigInteger.Parse("60032860261440859119744"),BigInteger.Parse("-2886298093438596491576832"),BigInteger.Parse("-339002178646768313636024064") };
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
public class A159498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159498Inst Instance=new A159498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159499
{
public static readonly BigInteger[] Value={ 1L,-13L,157L,-1729L,84989L,-146965L,8050867L,-9421321L,456972149L,-744875677L,8651299535L,11895490607L,1018477796809919L,-30162393397669L,-1280821166020571L,21331381569607655L,BigInteger.Parse("96597491471331326773"),BigInteger.Parse("-21292394561108375341"),BigInteger.Parse("-168562091883358662025871") };
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
public class A159499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159499Inst Instance=new A159499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159500
{
public static readonly BigInteger[] Value={ 1L,14L,-142L,-11452L,-16340L,15254344L,241175416L,-27559353808L,-956451987568L,61130164870880L,3765349254374176L,-153905067702335936L,BigInteger.Parse("-16154239475595889472"),BigInteger.Parse("398079601942332103808"),BigInteger.Parse("76554842682960987793280"),BigInteger.Parse("-811944878829661686113536"),BigInteger.Parse("-399500280706227471717519104") };
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
public class A159500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159500Inst Instance=new A159500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159501
{
public static readonly BigInteger[] Value={ 1L,16L,-82L,-12128L,-110900L,14622656L,421383496L,-22912610432L,-1363595118448L,40138176712960L,4790267177726176L,-59022762446185984L,BigInteger.Parse("-18754577565924898112"),BigInteger.Parse("-60676916573068018688"),BigInteger.Parse("81436783159504914005120"),BigInteger.Parse("1590111699775836488513536"),BigInteger.Parse("-387442703422276530189741824") };
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
public class A159501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159501Inst Instance=new A159501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159502
{
public static readonly BigInteger[] Value={ 1L,18L,-14L,-12420L,-209364L,13023288L,588244344L,-15822829872L,-1676597055600L,12606184973088L,5327119572650784L,53279247098676672L,BigInteger.Parse("-18847204123339434816"),BigInteger.Parse("-555350300452342408320"),BigInteger.Parse("72818309509811313231744"),BigInteger.Parse("3938647192917087914341632"),BigInteger.Parse("-298293179742235775626792704") };
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
public class A159502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159502Inst Instance=new A159502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159503
{
public static readonly BigInteger[] Value={ 1L,-17L,277L,-4301L,316589L,-881705L,81597067L,-148337189L,9291892949L,-23273867969L,3157156701335L,-3374474524157L,17804446740881519L,-517609824822233L,7097005573589869L,-46899240159493205L,BigInteger.Parse("-28349021749696329227"),BigInteger.Parse("-30659922504633917297") };
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
public class A159503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159503Inst Instance=new A159503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159504
{
public static readonly BigInteger[] Value={ 1L,20L,62L,-12280L,-308468L,10433200L,729974920L,-6559031200L,-1858301284720L,-19430405329600L,5264344401526240L,170961658044572800L,BigInteger.Parse("-16153599323983104320"),BigInteger.Parse("-1016492471508449363200"),BigInteger.Parse("50649065999412773118080"),BigInteger.Parse("5823023695166237849024000"),BigInteger.Parse("-140330290713698002728185600") };
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
public class A159504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159504Inst Instance=new A159504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159505
{
public static readonly BigInteger[] Value={ 1L,22L,146L,-11660L,-404564L,6863912L,834719224L,4443809392L,-1877181877360L,-53314061897888L,4537477909175584L,280026043216724288L,BigInteger.Parse("-10709769915546886976"),BigInteger.Parse("-1371400569429065225600"),BigInteger.Parse("16887916481473586409344"),BigInteger.Parse("6861001657130755548544768"),BigInteger.Parse("65320299895805538972610816") };
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
public class A159505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159505Inst Instance=new A159505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159506
{
public static readonly BigInteger[] Value={ 1L,24L,238L,-10512L,-493620L,2365344L,890986056L,16586747712L,-1709991063408L,-85890351335040L,3140424382846176L,365679572700743424L,-2899788110604240192L,BigInteger.Parse("-1552791261528717092352"),BigInteger.Parse("-24525321318694178812800"),BigInteger.Parse("6759200537905228989502464"),BigInteger.Parse("286564191995504982328955136") };
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
public class A159506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159506Inst Instance=new A159506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159507
{
public static readonly BigInteger[] Value={ 1L,1L,-97L,-293L,28225L,143081L,-13687169L,-97818797L,9291579137L,85981515985L,-8109191282849L,-92371076948149L,8649337125963073L,117277723616986297L,BigInteger.Parse("-10901977774859968705"),BigInteger.Parse("-171807014577365168189"),BigInteger.Parse("15854100314466788828161"),BigInteger.Parse("285247499171775372548513") };
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
public class A159507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159507Inst Instance=new A159507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159508
{
public static readonly BigInteger[] Value={ 1L,3L,-89L,-855L,23601L,405963L,-10346601L,-269746047L,6288530145L,230346491283L,-4855444114041L,-240305893799463L,4513251073537809L,296139484328781915L,-4861463414700822921L,BigInteger.Parse("-420887762743191256143"),BigInteger.Parse("5883687931380635925441"),BigInteger.Parse("677603075775465797408547") };
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
public class A159508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159508Inst Instance=new A159508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159509
{
public static readonly BigInteger[] Value={ 1L,5L,-73L,-1345L,14737L,600925L,-4216505L,-374426425L,1020390305L,298652268725L,593277094615L,-289712837877425L,-2088116897382095L,330261712856941325L,4311569491549495655L,BigInteger.Parse("-431561222581976019625"),BigInteger.Parse("-8495813265487638710975"),BigInteger.Parse("634208930681100205217125") };
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
public class A159509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159509Inst Instance=new A159509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159510
{
public static readonly BigInteger[] Value={ 1L,9L,-17L,-1917L,-12255L,641169L,11775471L,-271028133L,-10517226303L,117831019545L,10336672775151L,-22444344177741L,-11344932349212447L,-75709842389888607L,13772055231387660015UL,BigInteger.Parse("227822400841416108939"),BigInteger.Parse("-18194519582567115241599") };
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
public class A159510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159510Inst Instance=new A159510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159511
{
public static readonly BigInteger[] Value={ 1L,11L,23L,-1903L,-27695L,441331L,18425191L,-56825527L,-13264761823L,-101361166885L,10584547092151L,215763961560961L,-9036738188168207L,-353142538865540413L,7628236524205351175L,BigInteger.Parse("568422165089780309561"),BigInteger.Parse("-4960863874594282822079") };
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
public class A159511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159511Inst Instance=new A159511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159512
{
public static readonly BigInteger[] Value={ 1L,13L,71L,-1625L,-41999L,91013L,21762679L,229399183L,-11947008415L,-335160068867L,6180180526759L,408799214337527L,-1347844821458351L,-498269858739890315L,-4760353861080634921L,BigInteger.Parse("621741645997081258207"),BigInteger.Parse("15080361573750589690561") };
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
public class A159512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159512Inst Instance=new A159512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159513
{
public static readonly BigInteger[] Value={ 1L,2L,-446L,-2692L,596716L,6039032L,-1330532936L,-18966452272L,4153245843856L,76585719866912L,-16667474227882976L,-377970687856869952L,BigInteger.Parse("81748056052306991296"),BigInteger.Parse("2204537826531711723392"),BigInteger.Parse("-473817052252932475634816"),BigInteger.Parse("-14836222411655648808639232"),BigInteger.Parse("3168592657883982912917729536") };
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
public class A159513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159513Inst Instance=new A159513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159514
{
public static readonly BigInteger[] Value={ 1L,4L,-434L,-5336L,564556L,11863024L,-1222798904L,-36921360416L,3704131105936L,147733421921344L,-14410797291355424L,-722443587811469696L,BigInteger.Parse("68443672240963470016"),BigInteger.Parse("4174970063145790238464"),BigInteger.Parse("-383695602357053138639744"),BigInteger.Parse("-27837093807246691056882176"),BigInteger.Parse("2478596940681121921590743296") };
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
public class A159514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159514Inst Instance=new A159514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159515
{
public static readonly BigInteger[] Value={ 1L,8L,-386L,-10288L,438796L,22028768L,-811060856L,-65966160448L,2027112412816L,253695076915328L,-6180244656582176L,-1191069803371633408L,BigInteger.Parse("21063652623108703936"),BigInteger.Parse("6600286159191690034688"),BigInteger.Parse("-70420078571652397748096"),BigInteger.Parse("-42145163431480866400519168"),BigInteger.Parse("138174222906806753595494656") };
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
public class A159515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159515Inst Instance=new A159515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159516
{
public static readonly BigInteger[] Value={ 1L,14L,-254L,-16156L,116716L,30714824L,167396536L,-80586473296L,-1655509714544L,266934167861984L,10441892693970976L,-1055017257663334336L,BigInteger.Parse("-66457610442443011904"),BigInteger.Parse("4766686645187803247744"),BigInteger.Parse("455510634120920865106816"),BigInteger.Parse("-23652976986990268349291776") };
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
public class A159516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159516Inst Instance=new A159516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159517
{
public static readonly BigInteger[] Value={ 1L,16L,-194L,-17504L,-18164L,31216576L,540334216L,-75639407744L,-2912283304304L,225705335009536L,15406032742583776L,-769177483661571584L,BigInteger.Parse("-88566701814374836544"),BigInteger.Parse("2736491182742489168896"),BigInteger.Parse("561899064537972620484736"),BigInteger.Parse("-8249509418670119836289024") };
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
public class A159517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159517Inst Instance=new A159517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159518
{
public static readonly BigInteger[] Value={ 1L,22L,34L,-19052L,-465044L,24062632L,1575726904L,-30303114512L,-5630208266864L,-14773369627808L,22477329348987424L,560981409002859328L,BigInteger.Parse("-98921189279424843584"),BigInteger.Parse("-5205565772762786930048"),BigInteger.Parse("464166510283854022505344"),BigInteger.Parse("43006727594650346154419968") };
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
public class A159518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159518Inst Instance=new A159518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159519
{
public static readonly BigInteger[] Value={ 1L,26L,226L,-17524L,-760724L,11764376L,2017502776L,20691256976L,-5817161063024L,-225734712752224L,17690399773689376L,1475756601500931776L,BigInteger.Parse("-49197807240738185024"),BigInteger.Parse("-9248228636364224401024"),BigInteger.Parse("47353227812848547963776"),BigInteger.Parse("59495024332228675973509376") };
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
public class A159519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159519Inst Instance=new A159519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159520
{
public static readonly BigInteger[] Value={ 1L,28L,334L,-15848L,-894644L,3476368L,2110287304L,49701850912L,-5255753182064L,-326087752380992L,12155343320691424L,1807744498693823872L,BigInteger.Parse("-9552103473995480384"),BigInteger.Parse("-10029279190218522359552"),BigInteger.Parse("-224940012003245065821056"),BigInteger.Parse("56886138562285829022188032") };
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
public class A159520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159520Inst Instance=new A159520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159521
{
public static readonly BigInteger[] Value={ 1L,1L,-127L,-383L,48385L,244481L,-30721919L,-218483327L,27308356097L,251035282945L,-31208190940799L,-352533353110399L,43588599491534593L,585079829869107457L,BigInteger.Parse("-71946349724044455295"),BigInteger.Parse("-1120409404849485018239"),BigInteger.Parse("137016582065315869148161") };
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
public class A159521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159521Inst Instance=new A159521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159522
{
public static readonly BigInteger[] Value={ 1L,3L,-119L,-1125L,42321L,702963L,-24976551L,-614805237L,20534573985L,691164284643L,-21582336376791L,-949437293473413L,27539617738101489L,1540954535989466835L,BigInteger.Parse("-41203060308232477191"),BigInteger.Parse("-2884999709417821999893"),BigInteger.Parse("70454876663552890207041") };
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
public class A159522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159522Inst Instance=new A159522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159523
{
public static readonly BigInteger[] Value={ 1L,5L,-103L,-1795L,30577L,1071925L,-14209655L,-894286675L,8260417505L,957051642725L,-4730742752135L,-1248679816448675L,417486712762705L,1920059631628978325L,8905600268107750505L,BigInteger.Parse("-3396218858538590405875"),BigInteger.Parse("-34079846807459832998975") };
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
public class A159523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159523Inst Instance=new A159523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159524
{
public static readonly BigInteger[] Value={ 1L,7L,-79L,-2345L,13921L,1298087L,177169L,-995690633L,-7128577855L,969687163207L,14999931831409L,-1136200046085097L,-29073304341219551L,1541690140398172135L,BigInteger.Parse("59169809406576537809"),BigInteger.Parse("-2348520065747488701257"),BigInteger.Parse("-130045674520859373502079"),BigInteger.Parse("3899449373004841245659783") };
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
public class A159524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159524Inst Instance=new A159524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159525
{
public static readonly BigInteger[] Value={ 1L,9L,-47L,-2727L,-6495L,1337769L,16196721L,-881636103L,-22446986943L,700772486985L,32165881341201L,-607495851269991L,-50757023589840927L,476300415242137833L,BigInteger.Parse("88746390990674543025"),BigInteger.Parse("-54812825197840109511"),BigInteger.Parse("-170886386128875683593599") };
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
public class A159525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159525Inst Instance=new A159525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159526
{
public static readonly BigInteger[] Value={ 1L,11L,-7L,-2893L,-29135L,1160731L,31414441L,-545882557L,-34152047263L,183311218475L,41359581850201L,220317040704211L,-55810803797336687L,-952325816292371653L,BigInteger.Parse("82393593539552158985"),BigInteger.Parse("2612897391731003751011"),BigInteger.Parse("-129453828286899103990079") };
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
public class A159526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159526Inst Instance=new A159526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159527
{
public static readonly BigInteger[] Value={ 1L,13L,41L,-2795L,-52079L,754013L,43132729L,-18356507L,-38885559775L,-486715213907L,38468867080009L,1123090745841077L,-39563985152718671L,-2239399192597236995L,BigInteger.Parse("36722281790359787609"),BigInteger.Parse("4490393016408925933957"),BigInteger.Parse("-12131671824174755067839") };
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
public class A159527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159527Inst Instance=new A159527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159528
{
public static readonly BigInteger[] Value={ 1L,15L,97L,-2385L,-73023L,125775L,48621345L,632724975L,-34073850495L,-1159018131825L,21867803792865L,1811560265628975L,-3616463755919295L,-2836803524344895025L,BigInteger.Parse("-36534257175323718495"),BigInteger.Parse("4535538057996196107375"),BigInteger.Parse("138178844646564481121025") };
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
public class A159528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159528Inst Instance=new A159528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159529
{
public static readonly BigInteger[] Value={ 1L,2L,-574L,-3460L,988396L,9976312L,-2836511816L,-40270873648L,11395985060240L,209004489868832L,-58863905303630816L,-1325773762049110592L,BigInteger.Parse("371605162396386506944"),BigInteger.Parse("9938777138365404080000"),BigInteger.Parse("-2772363635969717405017216"),BigInteger.Parse("-85969311875592284625394432"),BigInteger.Parse("23864454100106265332248473856") };
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
public class A159529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159529Inst Instance=new A159529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159530
{
public static readonly BigInteger[] Value={ 1L,4L,-562L,-6872L,947020L,19676144L,-2658183224L,-78869600288L,10439530923152L,406451155424320L,-52680635240539424L,-2560010219314727296L,BigInteger.Parse("324703437982090748608"),BigInteger.Parse("19055044633095311519488"),BigInteger.Parse("-2363601454465048638962560"),BigInteger.Parse("-163647826988867455371547136") };
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
public class A159530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159530Inst Instance=new A159530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159531
{
public static readonly BigInteger[] Value={ 1L,6L,-542L,-10188L,878700L,28826856L,-2366481864L,-114170427792L,8889763054992L,581262636440160L,-42756971593427424L,-3616239868184689344L,BigInteger.Parse("250151386181903425728"),BigInteger.Parse("26583148042820425844352"),BigInteger.Parse("-1720138627513899785854080"),BigInteger.Parse("-225431665727586284647620864") };
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
public class A159531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159531Inst Instance=new A159531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159532
{
public static readonly BigInteger[] Value={ 1L,8L,-514L,-13360L,784396L,37163488L,-1969596536L,-144639748672L,6811869595280L,723309154621568L,-29648872397674016L,-4417917892894055168L,BigInteger.Parse("153164187561258952384"),BigInteger.Parse("31867992005603238264320"),BigInteger.Parse("-895931769290473862098816"),BigInteger.Parse("-265043245463665194931667968") };
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
public class A159532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159532Inst Instance=new A159532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159533
{
public static readonly BigInteger[] Value={ 1L,10L,-478L,-16340L,665452L,44432600L,-1478830280L,-168880559600L,4294541716880L,823849124759200L,-14101714763617760L,-4902865088744353600L,BigInteger.Parse("40630051579638182080"),BigInteger.Parse("34412572771327218390400"),BigInteger.Parse("38831520143870883754880"),BigInteger.Parse("-278078223664141142377568000") };
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
public class A159533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159533Inst Instance=new A159533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159534
{
public static readonly BigInteger[] Value={ 1L,12L,-434L,-19080L,523596L,50396112L,-908439096L,-185674985568L,1447444755600L,875930470333632L,2981558025372384L,-5027099422223924352L,BigInteger.Parse("-79281938992004709696"),BigInteger.Parse("33916578324641082789120"),BigInteger.Parse("1002723429481616382125184"),BigInteger.Parse("-262420270649216245344056832") };
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
public class A159534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159534Inst Instance=new A159534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159535
{
public static readonly BigInteger[] Value={ 1L,14L,-382L,-21532L,360940L,54835144L,-275424584L,-194024223568L,-1601971263088L,874740412095200L,20579820279916576L,-4767882097991423936L,BigInteger.Parse("-197596846711589525312"),BigInteger.Parse("30303674377706263065728"),BigInteger.Parse("1908994147478771376114560"),BigInteger.Parse("-218491414999696281462267136") };
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
public class A159535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159535Inst Instance=new A159535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159536
{
public static readonly BigInteger[] Value={ 1L,16L,-322L,-23648L,179980L,57553856L,400719496L,-193185260672L,-4712275251568L,817892241322240L,37599531719812576L,-4125824647325545984L,BigInteger.Parse("-305071017031777093952"),BigInteger.Parse("23735583481341553441792"),BigInteger.Parse("2672072957678237939024000"),BigInteger.Parse("-149315174208164043426596864") };
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
public class A159536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159536Inst Instance=new A159536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159537
{
public static readonly BigInteger[] Value={ 1L,18L,-254L,-25380L,-16404L,58383288L,1098306744L,-182703721392L,-7732416071280L,705638518433568L,52925521734602784L,-3125931245323172928L,BigInteger.Parse("-392767229604421613376"),BigInteger.Parse("14611648984681938387840"),BigInteger.Parse("3214262644971898893888384"),BigInteger.Parse("-60380735974552065344410368") };
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
public class A159537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159537Inst Instance=new A159537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159538
{
public static readonly BigInteger[] Value={ 1L,20L,-178L,-26680L,-224948L,57185200L,1793803720L,-162442199200L,-10506573835120L,541001252398400L,65475222138262240L,-1817482796097507200L,BigInteger.Parse("-452641118277021465920"),BigInteger.Parse("3553238308191880620800"),BigInteger.Parse("3472210128897376907338880"),BigInteger.Parse("40691398188058840163264000") };
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
public class A159538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159538Inst Instance=new A159538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159539
{
public static readonly BigInteger[] Value={ 1L,22L,-94L,-27500L,-442004L,53855912L,2462221624L,-132603427088L,-12879424086640L,329810916948832L,74254604271575584L,-272705805989586112L,BigInteger.Parse("-478110301690448457536"),BigInteger.Parse("-8626939166846096792960"),BigInteger.Parse("3402728145231415580480384"),BigInteger.Parse("144669210933209758019200768") };
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
public class A159539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159539Inst Instance=new A159539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159540
{
public static readonly BigInteger[] Value={ 1L,24L,-2L,-27792L,-663540L,48330144L,3077554056L,-93747642048L,-14701727119728L,80647645956480L,78413927979780576L,1415790877886279424L,BigInteger.Parse("-464576773026174196032"),BigInteger.Parse("-20969768081647414789632"),BigInteger.Parse("2987555438559134954033280"),BigInteger.Parse("241388693842110119374500864") };
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
public class A159540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159540Inst Instance=new A159540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159541
{
public static readonly BigInteger[] Value={ 1L,26L,98L,-27508L,-885140L,40584856L,3613260856L,-46803498352L,-15836144380528L,-195320377514080L,77301293252140576L,3138785406587037376L,BigInteger.Parse("-409873201925846810432"),BigInteger.Parse("-32427318830159708311168"),BigInteger.Parse("2236676949686660517495680"),BigInteger.Parse("320555464665505533108859136") };
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
public class A159541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159541Inst Instance=new A159541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159542
{
public static readonly BigInteger[] Value={ 1L,28L,206L,-26600L,-1102004L,30643088L,4042798024L,6928115488L,-16163173571440L,-484604466016832L,70511903870159584L,4775347121941757312L,BigInteger.Parse("-314604965392105430336"),BigInteger.Parse("-41930746668766980765440"),BigInteger.Parse("1189880803230804742112384"),BigInteger.Parse("372620264534124941133087232") };
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
public class A159542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159542Inst Instance=new A159542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159543
{
public static readonly BigInteger[] Value={ 1L,30L,322L,-25020L,-1308948L,18577800L,4340193720L,65778001200L,-15587083755120L,-771769990202400L,57930909988062240L,6198757843011739200L,BigInteger.Parse("-182361990413747545920"),BigInteger.Parse("-48465444111541849468800"),BigInteger.Parse("-83695327377356424021120"),BigInteger.Parse("389671513929275953180896000") };
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
public class A159543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159543Inst Instance=new A159543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159544
{
public static readonly BigInteger[] Value={ 1L,32L,446L,-22720L,-1500404L,4515712L,4480670344L,127720961792L,-14041721434480L,-1039916813229568L,39767696878818784L,7283285480589104128L,BigInteger.Parse("-19777881376678496576"),BigInteger.Parse("-51149760297419738122240"),BigInteger.Parse("-1488181328853069396639616"),BigInteger.Parse("366282057803422300192698368") };
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
public class A159544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159544Inst Instance=new A159544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159545
{
public static readonly BigInteger[] Value={ 1L,1L,-161L,-485L,77761L,392041L,-62594369L,-443658221L,70538356225L,645519410641L,-102199403965409L,-1147940849203829L,180971397017155009L,2412568407869398585L,BigInteger.Parse("-378713193710259050369"),BigInteger.Parse("-5850418342758055041149"),BigInteger.Parse("914422642373171437355521") };
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
public class A159545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159545Inst Instance=new A159545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159546
{
public static readonly BigInteger[] Value={ 1L,5L,-137L,-2305L,55057L,1768925L,-35751545L,-1898152825L,31051487905L,2615263500725L,-32196751861865L,-4397710630483825L,35386058665424305L,8726079758987677325L,BigInteger.Parse("-30892640754445199705"),BigInteger.Parse("-19945212097156278171625"),BigInteger.Parse("-24656943452479555574975") };
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
public class A159546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159546Inst Instance=new A159546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159547
{
public static readonly long[] Value={ 2L,5L,10L,17L,26L,37L,50L,65L,82L,2L,3L,5L,10L,17L };
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
public class A159547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159547Inst : IEnumerable<long>
{
public static readonly long[] Value=A159547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159547.Bytes);
public long this[int i]=>Value[i];

public static A159547Inst Instance=new A159547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159548
{
public static readonly long[] Value={ 181L,199L,221L,865L,995L,1145L,5009L,5771L,6649L,29189L,33631L,38749L,170125L,196015L,225845L,991561L,1142459L,1316321L,5779241L,6658739L,7672081L,33683885L,38809975L,44716165L,196324069L,226201111L,260624909L,1144260529L,1318396691L };
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
public class A159548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159548Inst : IEnumerable<long>
{
public static readonly long[] Value=A159548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159548.Bytes);
public long this[int i]=>Value[i];

public static A159548Inst Instance=new A159548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159549
{
public static readonly long[] Value={ 1L,1L,5L,2L,1L,8L,2L,2L,6L,7L,5L,7L,5L,1L,8L,5L,4L,3L,2L,0L,4L,0L,3L,7L,0L,7L,2L,6L,0L,5L,1L,2L,2L,5L,9L,3L,7L,5L,4L,4L,6L,9L,0L,6L,4L,0L,7L,4L,1L,4L,0L,1L,8L,1L,6L,3L,9L,9L,6L,6L,6L,3L,0L,5L,3L,2L,5L,7L,0L,1L,7L,5L,6L,6L,2L,9L,3L,5L,7L,4L,9L,1L,3L,4L,1L,7L,4L,7L,4L,9L,0L,8L,8L,7L,2L,0L,0L,1L,5L,8L,0L,6L,3L,8L,2L };
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
public class A159549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159549Inst : IEnumerable<long>
{
public static readonly long[] Value=A159549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159549.Bytes);
public long this[int i]=>Value[i];

public static A159549Inst Instance=new A159549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159550
{
public static readonly long[] Value={ 4L,3L,9L,0L,4L,4L,9L,6L,0L,5L,8L,7L,4L,3L,1L,4L,4L,2L,7L,2L,6L,8L,5L,0L,3L,8L,8L,1L,8L,3L,1L,0L,0L,4L,8L,5L,8L,8L,4L,6L,9L,3L,8L,6L,1L,8L,7L,3L,9L,9L,1L,2L,8L,2L,0L,4L,0L,5L,6L,2L,7L,3L,4L,5L,0L,0L,5L,8L,2L,9L,9L,1L,1L,1L,0L,6L,5L,0L,0L,4L,0L,2L,4L,7L,1L,6L,1L,1L,4L,8L,1L,4L,1L,9L,2L,4L,7L,1L,4L,3L,8L,1L,3L,0L,8L };
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
public class A159550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159550Inst : IEnumerable<long>
{
public static readonly long[] Value=A159550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159550.Bytes);
public long this[int i]=>Value[i];

public static A159550Inst Instance=new A159550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159551
{
public static readonly long[] Value={ 10L,111L,212L,313L,414L,515L,616L,717L,818L,919L,1020L,1121L,1222L,1323L,1424L,1525L,1626L,1727L,1828L,1929L,2030L,2131L,2232L,2333L,2434L,2535L,2636L,2737L,2838L,2939L,3040L,3141L,3242L,3343L,3444L,3545L,3646L,3747L,3848L,3949L,4050L,4151L,4252L,4353L };
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
public class A159551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159551Inst : IEnumerable<long>
{
public static readonly long[] Value=A159551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159551.Bytes);
public long this[int i]=>Value[i];

public static A159551Inst Instance=new A159551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159552
{
public static readonly BigInteger[] Value={ 1L,7L,-113L,-3059L,33505L,2216767L,-11621681L,-2236049291L,-2473358783L,2880606369655L,23770401693199L,-4500189506988707L,-73860182366201567L,8231347125022635439L,BigInteger.Parse("213168973938378948175"),BigInteger.Parse("-17176512461982684538427"),BigInteger.Parse("-638236193904139635834239") };
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
public class A159552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159552Inst Instance=new A159552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159553
{
public static readonly long[] Value={ 2L,6L,12L,28L,40L,144L,140L,536L,864L,2560L,2068L,12720L,8216L,45192L,78660L,182832L,131104L,933984L,524324L,3698240L,4890648L,13345816L,8388652L,67390464L,60129600L,225470544L,279938160L,1032462256L,536870968L,5018059200L };
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
public class A159553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159553Inst : IEnumerable<long>
{
public static readonly long[] Value=A159553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159553.Bytes);
public long this[int i]=>Value[i];

public static A159553Inst Instance=new A159553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159554
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,24L,20L,67L,96L,256L,188L,1060L,632L,3228L,5244L,11427L,7712L,51888L,27596L,184912L,232888L,606628L,364724L,2807936L,2405184L,8671944L,10368080L,36873652L,18512792L,167268640L,69273668L,496472227L,551130064L,1856103040L };
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
public class A159554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159554Inst : IEnumerable<long>
{
public static readonly long[] Value=A159554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159554.Bytes);
public long this[int i]=>Value[i];

public static A159554Inst Instance=new A159554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159555
{
public static readonly long[] Value={ 1L,6L,22L,72L,114L,148L,164L,260L,261L,780L,1078L,1184L,1266L,2952L,4674L };
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
public class A159555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159555Inst : IEnumerable<long>
{
public static readonly long[] Value=A159555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159555.Bytes);
public long this[int i]=>Value[i];

public static A159555Inst Instance=new A159555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159556
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,13L,15L,16L,18L,20L,21L,23L,89L,91L,92L,94L,96L,97L,99L,102L,104L,105L,107L,109L,110L,112L,233L,235L,236L,238L,240L,241L,243L,246L,248L,249L,251L,253L,254L,256L,322L,324L,325L,327L,329L,330L,332L,335L,337L,338L,340L,342L,343L,345L,1597L,1599L,1600L };
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
public class A159556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159556Inst : IEnumerable<long>
{
public static readonly long[] Value=A159556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159556.Bytes);
public long this[int i]=>Value[i];

public static A159556Inst Instance=new A159556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159557
{
public static readonly long[] Value={ 4L,6L,26L,80L,246L,810L,2704L,9252L,32066L,112720L,400024L,1432860L,5170604L,18784170L,68635478L,252088496L,930138522L,3446167860L,12815663844L,47820447028L,178987624514L,671825133648L,2528212128776L,9536895064400L };
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
public class A159557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159557Inst : IEnumerable<long>
{
public static readonly long[] Value=A159557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159557.Bytes);
public long this[int i]=>Value[i];

public static A159557Inst Instance=new A159557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159558
{
public static readonly BigInteger[] Value={ 1L,2L,10L,204L,18326L,7157436L,11867138452L,81971848887192L,2329289249771718630L,BigInteger.Parse("270079267572894401313900"),BigInteger.Parse("127115660247624311548253487740"),BigInteger.Parse("242023658005438716992830183038644712") };
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
public class A159558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159558Inst Instance=new A159558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159559
{
public static readonly long[] Value={ 3L,5L,6L,7L,8L,11L,12L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,29L,30L,32L,33L,37L,38L,39L,40L,42L,44L,47L,48L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,67L,68L,71L,72L,74L,75L,79L,80L,81L,82L,84L,85L,89L,90L,91L,92L,93L,94L,97L,98L,101L,102L,104L,105L,106L,108L,109L,110L,111L };
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
public class A159559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159559Inst : IEnumerable<long>
{
public static readonly long[] Value=A159559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159559.Bytes);
public long this[int i]=>Value[i];

public static A159559Inst Instance=new A159559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159560
{
public static readonly long[] Value={ 3L,4L,5L,7L,10L,11L,13L,16L,18L,19L,20L,23L,24L,26L,27L,29L,33L,37L,38L,39L,40L,41L,44L,47L,48L,49L,50L,53L,60L,61L,64L,65L,68L,69L,72L,73L,74L,75L,76L,79L,84L,89L,91L,92L,93L,97L,98L,101L,104L,106L,108L,109L,111L,112L,115L,116L,117L,121L,126L,127L,129L,133L,137L,141L,150L };
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
public class A159560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159560Inst : IEnumerable<long>
{
public static readonly long[] Value=A159560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159560.Bytes);
public long this[int i]=>Value[i];

public static A159560Inst Instance=new A159560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159561
{
public static readonly BigInteger[] Value={ 1L,11L,-41L,-4015L,-24239L,2335091L,45319591L,-1771192951L,-70875538655L,1515835139291L,120010721891191L,-1135534984848319L,-226349991243433871L,-282369893132640445L,BigInteger.Parse("473587012734212687431"),BigInteger.Parse("5849872057701168091001"),BigInteger.Parse("-1086467848309423981456319") };
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
public class A159561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159561Inst Instance=new A159561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159562
{
public static readonly BigInteger[] Value={ 1L,13L,7L,-4121L,-56975L,1929733L,71236279L,-949628849L,-93127115423L,20066487805L,136040198628199L,1736014871922487L,-219855440620458287L,-6232933639083272459L,BigInteger.Parse("381987420638602610455"),BigInteger.Parse("19102129961742695872927"),BigInteger.Parse("-679901742649149297057599") };
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
public class A159562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159562Inst Instance=new A159562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159563
{
public static readonly BigInteger[] Value={ 1L,17L,127L,-3349L,-118655L,153017L,98711839L,1529368739L,-85939956863L,-3443041152415L,66768757515199L,6712795544670683L,-4864401632683007L,BigInteger.Parse("-13132369366595418871"),BigInteger.Parse("-213005849393691708065"),BigInteger.Parse("26163114283745650962323"),BigInteger.Parse("962377156850346916957441") };
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
public class A159563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159563Inst Instance=new A159563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}