using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274092
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,-1L,4L,1L,-4L,9L,-1L,-9L,15L,-7L,-15L,20L,-15L,-20L,23L,-28L,-23L,23L,-43L,-23L,20L,-61L,-20L,11L,-80L,-11L,-2L,-100L,2L,-21L,-119L,21L,-46L,-137L,46L,-76L,-151L,76L,-111L,-162L,111L,-150L,-167L,150L,-194L,-167L,194L,-240L,-161L,240L,-289L,-147L,289L,-339L,-125L,339L,-389L,-95L,389L };
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
public class A274092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274092Inst : IEnumerable<long>
{
public static readonly long[] Value=A274092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274092.Bytes);
public long this[int i]=>Value[i];

public static A274092Inst Instance=new A274092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274093
{
public static readonly long[] Value={ 0L,-1L,2L,2L,-3L,-3L,-3L,4L,4L,4L,4L,-5L,-5L,-5L,-5L,-5L,6L,6L,6L,6L,6L,6L,-7L,-7L,-7L,-7L,-7L,-7L,-7L,8L,8L,8L,8L,8L,8L,8L,8L,-9L,-9L,-9L,-9L,-9L,-9L,-9L,-9L,-9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
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
public class A274093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274093Inst : IEnumerable<long>
{
public static readonly long[] Value=A274093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274093.Bytes);
public long this[int i]=>Value[i];

public static A274093Inst Instance=new A274093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274094
{
public static readonly long[] Value={ 0L,1L,-2L,-2L,3L,3L,3L,-4L,-4L,-4L,-4L,5L,5L,5L,5L,5L,-6L,-6L,-6L,-6L,-6L,-6L,7L,7L,7L,7L,7L,7L,7L,-8L,-8L,-8L,-8L,-8L,-8L,-8L,-8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,-12L,-12L,-12L,-12L,-12L,-12L,-12L,-12L,-12L,-12L };
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
public class A274094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274094Inst : IEnumerable<long>
{
public static readonly long[] Value=A274094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274094.Bytes);
public long this[int i]=>Value[i];

public static A274094Inst Instance=new A274094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274095
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,4L,3L,2L,1L,0L,-2L,-4L,-6L,-8L,-10L,-12L,-14L,-16L,-18L,-19L,-21L,-22L,-23L,-24L,-24L,-24L,-24L,-23L,-23L,-22L,-20L,-19L,-17L,-15L,-13L,-10L,-7L,-5L,-1L,2L,5L,8L,12L,15L,19L,22L,25L,29L,32L,35L,39L,42L,45L,47L,50L,52L,54L,56L,58L,60L,61L,62L,63L,63L,64L,64L,63L,63L,62L,61L,60L,58L,56L };
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
public class A274095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274095Inst : IEnumerable<long>
{
public static readonly long[] Value=A274095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274095.Bytes);
public long this[int i]=>Value[i];

public static A274095Inst Instance=new A274095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274096
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,0L,3L,0L,4L,-2L,4L,-3L,4L,-5L,3L,-6L,2L,-8L,1L,-9L,0L,-10L,-2L,-11L,-4L,-11L,-6L,-12L,-8L,-12L,-10L,-11L,-12L,-10L,-14L,-9L,-16L,-8L,-18L,-7L,-19L,-5L,-21L,-3L,-22L,0L,-23L,2L,-24L,4L,-24L,7L,-24L,10L,-24L,13L,-23L,15L,-23L,18L,-22L,21L,-20L,23L,-19L,26L,-17L,28L,-15L,31L,-13L,33L };
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
public class A274096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274096Inst : IEnumerable<long>
{
public static readonly long[] Value=A274096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274096.Bytes);
public long this[int i]=>Value[i];

public static A274096Inst Instance=new A274096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274097
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,-1L,2L,0L,-2L,3L,0L,-3L,4L,-2L,-4L,4L,-3L,-4L,4L,-5L,-4L,3L,-6L,-3L,2L,-8L,-2L,1L,-9L,-1L,0L,-10L,0L,-2L,-11L,2L,-4L,-11L,4L,-6L,-12L,6L,-8L,-12L,8L,-10L,-11L,10L,-12L,-10L,12L,-14L,-9L,14L,-16L,-8L,16L,-18L,-7L,18L,-19L,-5L,19L,-21L,-3L,21L,-22L,0L,22L,-23L,2L,23L,-24L,4L,24L,-24L,7L };
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
public class A274097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274097Inst : IEnumerable<long>
{
public static readonly long[] Value=A274097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274097.Bytes);
public long this[int i]=>Value[i];

public static A274097Inst Instance=new A274097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274098
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,280L,8640L,233520L,23157120L,5329376640L,1314169920000L,1016970317932800L,1772428331094220800L,BigInteger.Parse("3441650619022551936000"),BigInteger.Parse("22088285526822118789785600"),BigInteger.Parse("291368298787833283829100288000") };
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
public class A274098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274098Inst Instance=new A274098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274099
{
public static readonly long[] Value={ 1L,1L,3L,9L,23L,54L,120L,249L,478L,864L,1495L,2484L,3969L,6136L,9234L,13561L,19464L,27378L,37845L,51488L,69012L,91260L,119239L,154078L,197026L,249535L,313290L,390144L,482120L,591519L,720954L,873264L,1051513L,1259130L,1499950L,1778097L,2097984L,2464489L };
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
public class A274099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274099Inst : IEnumerable<long>
{
public static readonly long[] Value=A274099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274099.Bytes);
public long this[int i]=>Value[i];

public static A274099Inst Instance=new A274099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274132
{
public static readonly long[] Value={ 134L,153L,216L,225L,244L,251L,288L,342L,368L,405L,408L,415L,528L,532L,540L,577L,645L,729L,750L,755L,764L,855L,863L,882L,918L,919L,946L,972L,980L,1065L,1072L,1080L,1126L,1224L,1250L,1333L,1351L,1422L,1457L,1464L,1466L,1520L,1539L,1548L,1581L,1611L,1701L,1728L };
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
public class A274132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274132Inst : IEnumerable<long>
{
public static readonly long[] Value=A274132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274132.Bytes);
public long this[int i]=>Value[i];

public static A274132Inst Instance=new A274132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274133
{
public static readonly long[] Value={ 2L,9L,14L,15L,20L,27L,32L,37L,42L,47L,52L,57L,62L,129L,134L,139L,144L,149L,154L,159L,164L,169L,174L,179L,184L,189L,194L,195L,199L,200L,204L,205L,209L,210L,214L,215L,219L,220L,224L,225L,229L,230L,234L,235L,239L,240L,244L,245L,249L,250L,254L,255L,260L,265L,270L,275L };
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
public class A274133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274133Inst : IEnumerable<long>
{
public static readonly long[] Value=A274133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274133.Bytes);
public long this[int i]=>Value[i];

public static A274133Inst Instance=new A274133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274134
{
public static readonly long[] Value={ 3L,7L,11L,31L,43L,67L,79L,127L,131L,139L,167L,191L,211L,223L,227L,307L,331L,367L,487L,523L,631L,691L,743L,751L,883L,971L,1039L,1087L,1399L,2063L,2083L,2143L,2179L,2239L,2267L,2287L,2347L,2411L,2423L,2503L,2531L,2543L,2591L,2687L,2731L,2803L,2819L,2927L,2939L,2963L };
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
public class A274134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274134Inst : IEnumerable<long>
{
public static readonly long[] Value=A274134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274134.Bytes);
public long this[int i]=>Value[i];

public static A274134Inst Instance=new A274134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274135
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,15L,18L,21L,34L,36L,75L,102L,231L,256L,309L,513L,748L,3789L,12378L,36378L };
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
public class A274135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274135Inst : IEnumerable<long>
{
public static readonly long[] Value=A274135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274135.Bytes);
public long this[int i]=>Value[i];

public static A274135Inst Instance=new A274135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274136
{
public static readonly BigInteger[] Value={ 1L,16L,540L,32256L,3024000L,410572800L,76281004800L,18598035456000L,5762136335155200L,2211729098342400000L,BigInteger.Parse("1030334000462807040000"),BigInteger.Parse("572721601599913328640000"),BigInteger.Parse("374484928188990947328000000"),BigInteger.Parse("284562454970932936468070400000") };
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
public class A274136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274136Inst Instance=new A274136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274137
{
public static readonly long[] Value={ 6L,7L,8L,2L,3L,1L,5L,4L,3L,2L,0L,9L,10L,40L,100L,0L,15L,6L,6L,6L,0L,0L,7L,0L,2L,0L,3L,4L };
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
public class A274137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274137Inst : IEnumerable<long>
{
public static readonly long[] Value=A274137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274137.Bytes);
public long this[int i]=>Value[i];

public static A274137Inst Instance=new A274137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274138
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,3L,1L,2L,2L,3L,3L,3L,1L,2L,3L,3L,3L,4L,4L,1L,2L,3L,3L,4L,4L,5L,5L,1L,2L,3L,4L,4L,4L,5L,5L,5L,1L,2L,3L,4L,4L,4L,5L,5L,5L,5L,1L,2L,3L,4L,4L,5L,5L,6L,5L,5L,5L,1L,2L,3L,4L,4L,5L,5L,6L,6L,6L,6L,6L,1L,2L,3L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,1L,2L,3L,4L,5L,6L,6L,6L,6L,7L,7L,8L,8L,8L };
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
public class A274138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274138Inst : IEnumerable<long>
{
public static readonly long[] Value=A274138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274138.Bytes);
public long this[int i]=>Value[i];

public static A274138Inst Instance=new A274138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274139
{
public static readonly long[] Value={ 2L,2L,8L,2L,32L,8L,128L,2L,512L,32L,2048L,8L,8192L,128L,32768L,2L,131072L,512L,524288L,32L,2097152L,2048L,8388608L,8L,33554432L,8192L,134217728L,128L,536870912L,32768L,2147483648L,2L,8589934592L,131072L,34359738368L,512L,137438953472L,524288L,549755813888L,32L };
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
public class A274139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274139Inst : IEnumerable<long>
{
public static readonly long[] Value=A274139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274139.Bytes);
public long this[int i]=>Value[i];

public static A274139Inst Instance=new A274139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274140
{
public static readonly long[] Value={ 0L,3L,5L,7L,8L,10L,11L,10L,11L,16L,16L,18L,20L,15L,14L,23L,23L,25L,26L,17L,21L,34L,30L,17L,23L,22L,18L,38L,37L,39L,39L,22L,31L,29L,20L,45L,56L,35L,25L,50L,51L,53L,56L,24L,34L,70L,56L,23L,24L,30L,35L,68L,62L,25L,27L,33L,51L,88L,69L,71L,92L,44L,23L,28L,32L,81L,86L,45L,38L,83L,81L,83L,110L,50L,34L,39L,34L,95L,90L };
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
public class A274140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274140Inst : IEnumerable<long>
{
public static readonly long[] Value=A274140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274140.Bytes);
public long this[int i]=>Value[i];

public static A274140Inst Instance=new A274140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274141
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,24L,25L,27L,28L,32L,36L,40L,44L,48L,49L,50L,52L,54L,56L,60L,64L,68L,72L,75L,76L,80L,81L,84L,88L,92L,96L,98L,100L,104L,108L,112L,116L,120L,121L,124L,125L,128L,132L,135L,136L,140L,144L,147L,148L,150L,152L,156L,160L,162L,164L,168L,169L,172L,175L,176L };
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
public class A274141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274141Inst : IEnumerable<long>
{
public static readonly long[] Value=A274141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274141.Bytes);
public long this[int i]=>Value[i];

public static A274141Inst Instance=new A274141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274142
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,8L,11L,17L,25L,37L,54L,81L,119L,177L,261L,388L,574L,851L,1260L,1868L,2767L,4101L,6077L,9006L,13347L,19781L,29315L,43448L,64392L,95436L,141444L,209636L,310705L,460501L,682519L,1011581L,1499295L,2222155L,3293534L,4881472L,7235018L,10723311L,15893460L,23556367L,34913897L,51747400L };
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
public class A274142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274142Inst : IEnumerable<long>
{
public static readonly long[] Value=A274142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274142.Bytes);
public long this[int i]=>Value[i];

public static A274142Inst Instance=new A274142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274143
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,4L,4L,5L,8L,9L,12L,16L,20L,26L,34L,44L,57L,74L,97L,125L,162L,212L,272L,356L,462L,597L,780L,1010L,1311L,1706L,2210L,2873L,3732L,4841L,6294L,8168L,10608L,13781L,17886L,23237L,30172L,39177L,50891L,66072L,85813L,111446L,144706L,187947L,244059L,316937L,411618L,534503L,694153L,901461L };
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
public class A274143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274143Inst : IEnumerable<long>
{
public static readonly long[] Value=A274143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274143.Bytes);
public long this[int i]=>Value[i];

public static A274143Inst Instance=new A274143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274144
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,5L,8L,8L,9L,12L,16L,17L,21L,27L,32L,37L,47L,57L,67L,82L,102L,121L,145L,180L,219L,260L,317L,391L,470L,564L,691L,843L,1012L,1225L,1500L,1816L,2188L,2663L,3245L,3918L,4744L,5778L,7010L,8473L,10291L,12511L,15148L };
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
public class A274144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274144Inst : IEnumerable<long>
{
public static readonly long[] Value=A274144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274144.Bytes);
public long this[int i]=>Value[i];

public static A274144Inst Instance=new A274144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274145
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,9L,11L,14L,19L,25L,32L,43L,56L,73L,97L,128L,167L,222L,292L,384L,507L,670L,882L,1165L,1539L,2030L,2680L,3541L,4675L,6173L,8155L,10772L,14227L,18798L,24834L,32808L,43350L,57279L,75681L,100006L,132152L,174627L,230766L,304963L,403012L,532600L,703874L,930227L,1229386L };
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
public class A274145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274145Inst : IEnumerable<long>
{
public static readonly long[] Value=A274145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274145.Bytes);
public long this[int i]=>Value[i];

public static A274145Inst Instance=new A274145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274146
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,5L,5L,7L,8L,11L,12L,16L,18L,24L,28L,35L,41L,53L,63L,79L,95L,119L,145L,181L,221L,275L,339L,421L,519L,645L,798L,991L,1228L,1525L,1890L,2350L,2915L,3622L,4495L,5588L,6939L,8626L,10712L,13315L,16545L,20567L,25556L,31766L,39483L,49081L,61007L,75836L,94270L,117194L,145688L };
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
public class A274146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274146Inst : IEnumerable<long>
{
public static readonly long[] Value=A274146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274146.Bytes);
public long this[int i]=>Value[i];

public static A274146Inst Instance=new A274146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274147
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,9L,13L,20L,31L,48L,70L,108L,165L,250L,379L,575L,875L,1332L,2017L,3066L,4661L,7076L,10751L,16328L,24801L,37684L,57229L,86931L,132062L,200588L,304701L,462844L,703043L,1067955L,1622207L,2464117L,3743047L,5685655L,8636525L,13118942L,19927624L,30270167L,45980452L,69844296L,106093768L };
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
public class A274147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274147Inst : IEnumerable<long>
{
public static readonly long[] Value=A274147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274147.Bytes);
public long this[int i]=>Value[i];

public static A274147Inst Instance=new A274147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274180
{
public static readonly BigInteger[] Value={ 1L,31L,341L,6483L,69905L,2027247L,21041413L,417263459L,4311810305L,133666119455L,1461703693397L,27806864656979L,299071474565137L,8708265758097903L,90161415181374469L,1785159701350222947L,BigInteger.Parse("18447025552981295105") };
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
public class A274180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274180Inst Instance=new A274180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274181
{
public static readonly long[] Value={ 3L,2L,8L,9L,6L,2L,1L,0L,5L,8L,6L,0L,0L,5L,0L,0L,2L,3L,6L,1L,0L,6L,2L,5L,2L,8L,0L,6L,3L,8L,7L,2L,0L,4L,3L,4L,9L,7L,6L,7L,9L,3L,8L,9L,9L,2L,2L,4L,5L,0L,5L,7L,0L,1L,7L,3L,7L,3L,8L,8L,1L,9L,1L,4L,9L,2L,6L,8L,4L,1L,7L,6L,2L,8L,6L,7L,3L,2L,8L,0L,3L,2L,6L,7L,3L,6L,1L,2L,7L,4L,3L,5L,1L,6L,6L,3L,4L,2L,8L,7L,4L };
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
public class A274181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274181Inst : IEnumerable<long>
{
public static readonly long[] Value=A274181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274181.Bytes);
public long this[int i]=>Value[i];

public static A274181Inst Instance=new A274181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274182
{
public static readonly long[] Value={ 15L,26L,39L,158L,326L,566L,789L,961L,1159L,1262L,1369L,1478L,1591L,1718L,1849L,2582L,3085L,3829L,4659L,5587L,7697L,8891L,10189L,13885L,14695L,16838L,17281L,18187L,19111L,20057L,22546L,24131L,25798L,26938L,27515L,28102L,35566L,36886L,38919L,41739L,43199L,50885L };
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
public class A274182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274182Inst : IEnumerable<long>
{
public static readonly long[] Value=A274182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274182.Bytes);
public long this[int i]=>Value[i];

public static A274182Inst Instance=new A274182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274183
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,1L,0L,4L,3L,2L,2L,1L,1L,0L,5L,4L,3L,3L,2L,2L,1L,2L,1L,1L,0L,6L,5L,4L,4L,3L,3L,2L,3L,2L,2L,1L,2L,1L,1L,1L,0L,7L,6L,5L,5L,4L,4L,3L,4L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,1L,1L,1L,1L,0L,8L,7L,6L,6L,5L,5L,4L,5L,4L,4L,3L,4L,3L,3L,3L,2L,4L };
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
public class A274183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274183Inst : IEnumerable<long>
{
public static readonly long[] Value=A274183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274183.Bytes);
public long this[int i]=>Value[i];

public static A274183Inst Instance=new A274183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274184
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,16L,24L,35L,52L,77L,114L,168L,249L,368L,545L,806L,1194L,1768L,2619L,3879L,5747L,8514L,12615L,18692L,27698L,41045L,60826L,90141L,133589L,197981L,293417L,434861L,644497L,955202L,1415703L,2098222L,3109803L,4609098L,6831253L,10124787L,15006259L };
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
public class A274184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274184Inst : IEnumerable<long>
{
public static readonly long[] Value=A274184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274184.Bytes);
public long this[int i]=>Value[i];

public static A274184Inst Instance=new A274184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274185
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,2L,1L,0L,5L,3L,2L,1L,0L,6L,4L,3L,2L,1L,2L,1L,0L,7L,5L,4L,3L,2L,3L,2L,1L,1L,0L,0L,8L,6L,5L,4L,3L,4L,3L,2L,2L,1L,1L,3L,2L,1L,1L,0L,0L,9L,7L,6L,5L,4L,5L,4L,3L,3L,2L,2L,4L,3L,2L,2L,1L,1L,2L,1L,1L,0L,0L,1L,0L,0L,10L,8L,7L,6L,5L,6L,5L,4L,4L,3L };
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
public class A274185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274185Inst : IEnumerable<long>
{
public static readonly long[] Value=A274185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274185.Bytes);
public long this[int i]=>Value[i];

public static A274185Inst Instance=new A274185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274186
{
public static readonly long[] Value={ 0L,-1L,0L,1L,0L,-1L,0L,9L,0L,-1L,0L,1L,0L,-1L,0L,225L,0L,-1L,0L,1L,0L,-1L,0L,9L,0L,-1L,0L,1L,0L,-81L,0L,245025L,0L,-81L,0L,1L,0L,-1L,0L,9L,0L,-1L,0L,1L,0L,-1L,0L,225L,0L,-1L,0L,1L,0L,-1L,0L,9L,0L,-81L,0L,6561L,0L,-4100625L,0L,218813450625L,0L,-4100625L,0L,6561L,0L,-81L,0L,9L,0L,-1L,0L,1L,0L,-1L,0L,225L,0L,-1L,0L,1L,0L,-1L,0L,9L,0L,-1L,0L,1L,0L,-81L };
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
public class A274186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274186Inst : IEnumerable<long>
{
public static readonly long[] Value=A274186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274186.Bytes);
public long this[int i]=>Value[i];

public static A274186Inst Instance=new A274186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274187
{
public static readonly long[] Value={ 4L,12L,24L,24L,120L,5040L,5040L,362880L,362880L,3628800L,39916800L,6227020800L,6227020800L,3379030566912000L };
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
public class A274187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274187Inst : IEnumerable<long>
{
public static readonly long[] Value=A274187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274187.Bytes);
public long this[int i]=>Value[i];

public static A274187Inst Instance=new A274187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274188
{
public static readonly long[] Value={ 9L,16L,18L,20L,27L,32L,36L,40L,45L,48L,49L,54L,60L,63L,64L,72L,80L,81L,90L,96L,98L,99L,100L,108L,112L,117L,120L,121L,125L,126L,128L,135L,140L,144L,147L,153L,160L,162L,169L,171L,176L,180L,189L,192L,196L,198L,200L,207L,208L,216L,220L,224L,225L,234L,240L,242L,243L,245L,250L };
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
public class A274188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274188Inst : IEnumerable<long>
{
public static readonly long[] Value=A274188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274188.Bytes);
public long this[int i]=>Value[i];

public static A274188Inst Instance=new A274188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274189
{
public static readonly long[] Value={ 34L,46L,50L,66L,74L,78L,86L,138L,142L,160L,162L,168L,170L,174L,176L,178L,180L,184L,186L,194L,202L,204L,206L,234L,236L,238L,240L,242L,246L,252L,254L,264L,270L,276L,282L,284L,290L,294L,296L,298L,300L,310L,320L,324L,328L,334L,348L,354L,364L,366L,370L,372L,376L,378L,384L,386L,390L,392L,396L,400L };
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
public class A274189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274189Inst : IEnumerable<long>
{
public static readonly long[] Value=A274189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274189.Bytes);
public long this[int i]=>Value[i];

public static A274189Inst Instance=new A274189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274190
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,3L,3L,2L,1L,1L,1L,4L,4L,3L,2L,1L,1L,1L,5L,6L,5L,3L,2L,1L,1L,1L,7L,8L,7L,5L,3L,2L,1L,1L,1L,9L,12L,10L,8L,5L,3L,2L,1L,1L,1L,13L,17L,15L,11L,8L,5L,3L,2L,1L,1L,1L,18L,24L,22L,17L,12L,8L,5L,3L,2L,1L,1L,1L,25L,35L,32L };
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
public class A274190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274190Inst : IEnumerable<long>
{
public static readonly long[] Value=A274190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274190.Bytes);
public long this[int i]=>Value[i];

public static A274190Inst Instance=new A274190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274191
{
public static readonly long[] Value={ 3L,6L,9L,15L,18L,24L,27L,39L,45L,54L,63L,72L,90L,102L,117L,135L,144L,162L,165L,189L,216L,234L,267L,270L,306L,351L,360L,378L,405L,432L,495L,567L,585L,612L,648L,699L,702L,801L,810L,918L,936L,945L,990L,1053L,1080L,1131L,1134L,1296L,1485L,1512L,1530L,1602L,1701L };
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
public class A274191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274191Inst : IEnumerable<long>
{
public static readonly long[] Value=A274191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274191.Bytes);
public long this[int i]=>Value[i];

public static A274191Inst Instance=new A274191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274192
{
public static readonly long[] Value={ 1L,4L,8L,2L,1L,4L,6L,2L,2L,1L,0L,4L,5L,7L,9L,6L,4L,7L,3L,9L,5L,1L,0L,9L,4L,5L,0L,5L,0L,8L,9L,2L,9L,2L,1L,8L,8L,1L,0L,0L,7L,2L,2L,0L,9L,9L,2L,0L,0L,8L,2L,7L,9L,6L,3L,7L,8L,9L,8L,7L,8L,3L,7L,8L,8L,6L,2L,3L,2L,4L,8L,7L,2L,9L,2L,5L,0L,1L,6L,9L,3L,4L,8L,5L,8L,6L };
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
public class A274192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274192Inst : IEnumerable<long>
{
public static readonly long[] Value=A274192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274192.Bytes);
public long this[int i]=>Value[i];

public static A274192Inst Instance=new A274192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274193
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,3L,3L,2L,2L,1L,1L,1L,1L,3L,4L,3L,2L,2L,1L,1L,1L,1L,4L,4L,4L,3L,2L,2L,1L,1L,1L,1L,5L,6L,5L,4L,3L,2L,2L,1L,1L,1L,1L,6L,7L,7L,5L,4L,3L,2L,2L,1L,1L,1L,1L,8L,9L,8L,7L,5L,4L,3L };
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
public class A274193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274193Inst : IEnumerable<long>
{
public static readonly long[] Value=A274193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274193.Bytes);
public long this[int i]=>Value[i];

public static A274193Inst Instance=new A274193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274194
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,14L,18L,23L,31L,40L,52L,68L,88L,114L,148L,192L,249L,323L,420L,545L,707L,919L,1191L,1547L,2009L,2606L,3386L,4396L,5707L,7413L,9623L,12496L,16228L,21069L,27363L,35531L,46139L,59920L,77806L,101043L,131215L,170392L,221283L,287355L,373168L };
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
public class A274194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274194Inst : IEnumerable<long>
{
public static readonly long[] Value=A274194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274194.Bytes);
public long this[int i]=>Value[i];

public static A274194Inst Instance=new A274194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274195
{
public static readonly long[] Value={ 1L,2L,9L,8L,6L,4L,0L,6L,4L,0L,8L,6L,1L,7L,0L,4L,6L,4L,5L,6L,9L,3L,3L,4L,4L,1L,6L,1L,5L,8L,5L,2L,8L,1L,2L,2L,0L,4L,8L,5L,5L,3L,9L,7L,7L,9L,8L,6L,5L,3L,7L,4L,5L,6L,3L,3L,1L,4L,5L,5L,4L,9L,3L,9L,2L,7L,3L,5L,7L,5L,5L,6L,3L,1L,8L,8L,7L,7L,3L,1L,4L,3L,1L,1L,2L,8L };
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
public class A274195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274195Inst : IEnumerable<long>
{
public static readonly long[] Value=A274195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274195.Bytes);
public long this[int i]=>Value[i];

public static A274195Inst Instance=new A274195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274228
{
public static readonly long[] Value={ 2L,3L,2L,4L,4L,2L,5L,8L,5L,2L,6L,12L,12L,6L,2L,7L,18L,21L,16L,7L,2L,8L,24L,36L,32L,20L,8L,2L,9L,32L,54L,60L,45L,24L,9L,2L,10L,40L,80L,100L,90L,60L,28L,10L,2L,11L,50L,110L,160L,165L,126L,77L,32L,11L,2L,12L,60L,150L,240L,280L,252L,168L,96L,36L,12L,2L,13L,72L,195L,350L,455L,448L,364L,216L,117L,40L,13L,2L };
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
public class A274228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274228Inst : IEnumerable<long>
{
public static readonly long[] Value=A274228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274228.Bytes);
public long this[int i]=>Value[i];

public static A274228Inst Instance=new A274228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274229
{
public static readonly BigInteger[] Value={ 0L,13L,350314L,20907473410813L,BigInteger.Parse("15511088399276664432001386"),BigInteger.Parse("371993307691696427796897697438711091311473"),BigInteger.Parse("608281863896576961368925279207011528484342192328937893038299066"),BigInteger.Parse("126886932185793156284194444673402758686090686637743899818927901378528905462568315856855357") };
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
public class A274229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274229Inst Instance=new A274229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274230
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,21L,49L,105L,225L,465L,961L,1953L,3969L,8001L,16129L,32385L,65025L,130305L,261121L,522753L,1046529L,2094081L,4190209L,8382465L,16769025L,33542145L,67092481L,134193153L,268402689L,536821761L,1073676289L,2147385345L };
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
public class A274230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274230Inst : IEnumerable<long>
{
public static readonly long[] Value=A274230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274230.Bytes);
public long this[int i]=>Value[i];

public static A274230Inst Instance=new A274230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274231
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,8L,9L,10L,12L,13L,14L,15L,16L,17L,20L,24L,25L,27L,28L,29L,30L,31L,32L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,56L,60L,61L,65L,72L,73L,75L,76L,77L,80L,81L,82L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,101L,105L,106L,108L,109L,110L,111L,112L,113L };
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
public class A274231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274231Inst : IEnumerable<long>
{
public static readonly long[] Value=A274231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274231.Bytes);
public long this[int i]=>Value[i];

public static A274231Inst Instance=new A274231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274232
{
public static readonly long[] Value={ 1L,2L,4L,10L,30L,102L,374L,1430L,5590L,22102L,87894L,350550L,1400150L,5596502L,22377814L,89494870L,357946710L,1431721302L,5726754134L,22906754390L,91626493270L,366504924502L,1466017600854L,5864066209110L,23456256447830L,93825009014102L,375300002501974L };
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
public class A274232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274232Inst : IEnumerable<long>
{
public static readonly long[] Value=A274232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274232.Bytes);
public long this[int i]=>Value[i];

public static A274232Inst Instance=new A274232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274233
{
public static readonly long[] Value={ 1L,1L,3L,7L,14L,27L,48L,80L,127L,192L,280L,397L,547L,736L,972L,1261L,1610L,2028L,2523L,3104L,3781L,4563L,5461L,6487L,7651L,8965L,10443L,12097L,13940L,15987L,18252L,20750L,23497L,26508L,29800L,33391L,37297L,41536L,46128L,51091L,56444L,62208L,68403L,75050L };
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
public class A274233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274233Inst : IEnumerable<long>
{
public static readonly long[] Value=A274233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274233.Bytes);
public long this[int i]=>Value[i];

public static A274233Inst Instance=new A274233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274234
{
public static readonly long[] Value={ 1078L,2020L,2471L,3255L,4200L,5135L,5185L,6218L,6823L,7220L,8416L,9003L,9008L,9267L,9396L,9689L,10316L,11150L,11250L,11543L,11652L,12960L,14021L,14201L,16523L,16751L,17006L,17054L,17747L,17874L,18157L,18640L,18834L,20478L,20481L,20794L,21147L,22166L,22608L,22638L,24450L,24677L,24894L,25709L };
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
public class A274234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274234Inst : IEnumerable<long>
{
public static readonly long[] Value=A274234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274234.Bytes);
public long this[int i]=>Value[i];

public static A274234Inst Instance=new A274234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274235
{
public static readonly long[] Value={ 754L,1289L,1368L,1813L,3159L,3280L,3301L,4976L,6204L,6283L,6723L,6904L,7141L,10246L,11417L,13268L,15456L,19428L,19683L,19698L,20298L,21484L,22543L,23702L,23815L,24747L,27010L,32319L,34133L,36201L,37030L,39438L,41292L,44472L,47623L,50198L,51031L,51370L,51521L,52628L,53073L,53309L,53767L,55911L,56630L,59424L };
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
public class A274235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274235Inst : IEnumerable<long>
{
public static readonly long[] Value=A274235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274235.Bytes);
public long this[int i]=>Value[i];

public static A274235Inst Instance=new A274235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274236
{
public static readonly long[] Value={ 311L,2741L,3582L,5293L,6289L,12080L,14082L,16886L,17971L,19936L,21454L,21486L,26652L,26904L,28314L,34693L,35778L,36292L,40868L,43819L,46356L,46467L,49653L,53996L,57150L,58169L,64937L,67398L,77383L,82577L,86031L,86102L,87352L,87684L,89030L,93340L,95346L,97320L,98191L,111483L,113947L,118052L,125442L,125836L,126157L,127832L,130794L };
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
public class A274236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274236Inst : IEnumerable<long>
{
public static readonly long[] Value=A274236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274236.Bytes);
public long this[int i]=>Value[i];

public static A274236Inst Instance=new A274236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274237
{
public static readonly long[] Value={ 3508L,5209L,13428L,15347L,16339L,17779L,22548L,37726L,40408L };
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
public class A274237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274237Inst : IEnumerable<long>
{
public static readonly long[] Value=A274237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274237.Bytes);
public long this[int i]=>Value[i];

public static A274237Inst Instance=new A274237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274238
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,22L,25L,29L,59L,89L,221L,453L,535L,1708L,2242L,2413L,3581L,4234L,4848L,5380L,6548L,8654L,11035L,17308L,27634L,28807L,35481L,79678L,80875L };
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
public class A274238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274238Inst : IEnumerable<long>
{
public static readonly long[] Value=A274238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274238.Bytes);
public long this[int i]=>Value[i];

public static A274238Inst Instance=new A274238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274239
{
public static readonly long[] Value={ 1L,2L,5L,20L,53L,161L,380L,500L,530L,698L,832L,833L,6353L,25433L,53921L,73538L };
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
public class A274239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274239Inst : IEnumerable<long>
{
public static readonly long[] Value=A274239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274239.Bytes);
public long this[int i]=>Value[i];

public static A274239Inst Instance=new A274239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274240
{
public static readonly long[] Value={ 16L,25L,28L,32L,36L,48L,50L,56L,63L,64L,72L,75L,80L,81L,84L,96L,100L,108L,112L,121L,125L,126L,128L,140L,144L,150L,160L,162L,168L,169L,175L,176L,180L,189L,192L,196L,200L,208L,216L,224L,225L,240L,242L,243L,250L,252L,256L,272L,275L,280L,288L,289L,300L,304L,308L };
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
public class A274240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274240Inst : IEnumerable<long>
{
public static readonly long[] Value=A274240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274240.Bytes);
public long this[int i]=>Value[i];

public static A274240Inst Instance=new A274240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274241
{
public static readonly long[] Value={ 36L,44L,49L,64L,72L,81L,88L,98L,99L,100L,108L,128L,132L,144L,147L,162L,169L,176L,180L,192L,196L,198L,200L,216L,220L,225L,243L,245L,252L,256L,264L,275L,288L,289L,294L,297L,300L,308L,320L,324L,338L,343L,352L,360L,361L,384L,392L,396L,400L,405L,432L,440L,441L,448L };
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
public class A274241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274241Inst : IEnumerable<long>
{
public static readonly long[] Value=A274241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274241.Bytes);
public long this[int i]=>Value[i];

public static A274241Inst Instance=new A274241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274242
{
public static readonly long[] Value={ 1L,5L,7L,13L,19L,25L,31L,35L,43L,49L,61L,65L,73L,91L,95L,103L,109L,125L,133L,139L,151L,155L,169L,175L,181L,193L,199L,215L,217L,229L,241L,245L,247L,271L,283L,301L,305L,313L,325L,343L,349L,361L,365L,403L,421L,427L,433L,455L,463L,475L,511L,515L,523L,545L,559L,571L,589L,601L,619L,625L,637L,643L,661L,665L,695L,721L,755L,763L,775L,793L,811L,817L,823L,829L,845L,859L,875L,883L,905L,931L };
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
public class A274242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274242Inst : IEnumerable<long>
{
public static readonly long[] Value=A274242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274242.Bytes);
public long this[int i]=>Value[i];

public static A274242Inst Instance=new A274242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274243
{
public static readonly long[] Value={ 11L,13L,22L,26L,44L,52L,53L,67L,88L,104L,105L,106L,113L,121L,131L,134L,165L,176L,187L,208L,210L,211L,212L,226L,227L,231L,242L,243L,257L,261L,262L,268L,273L,289L,291L,293L,325L,329L,330L,352L,373L,374L,416L,419L,420L,422L,424L,431L,447L,452L,454L,461L,462L,473L };
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
public class A274243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274243Inst : IEnumerable<long>
{
public static readonly long[] Value=A274243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274243.Bytes);
public long this[int i]=>Value[i];

public static A274243Inst Instance=new A274243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274276
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,80L,776L,8992L,130768L,2252672L,43823872L,957193856L,23369928704L,629680631296L,18514472015872L,590350181439488L,20311856724176896L,749913022501879808L,BigInteger.Parse("29561045244530032640"),BigInteger.Parse("1239353203580700000256"),BigInteger.Parse("55077035791625925492736"),BigInteger.Parse("2586090541400666789543936"),BigInteger.Parse("127922890235433583945056256"),BigInteger.Parse("6649362432158408977810522112"),BigInteger.Parse("362360171399316029979428126720"),BigInteger.Parse("20658795751396952768159379619840") };
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
public class A274276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274276Inst Instance=new A274276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274277
{
public static readonly BigInteger[] Value={ 1L,-2L,6L,-40L,320L,-2976L,35392L,-538112L,9931392L,-211790080L,5059784576L,-132643057152L,3761875287040L,-114501941915648L,3725395402721280L,-129324055589257216L,4786638435256696832L,BigInteger.Parse("-188785468724361560064"),BigInteger.Parse("7922155381738193944576"),BigInteger.Parse("-352740315643746941665280"),BigInteger.Parse("16603695476218208847691776"),BigInteger.Parse("-822951583413551750366298112"),BigInteger.Parse("42792449844854211313594597376"),BigInteger.Parse("-2327246576567999111735900897280"),BigInteger.Parse("132052357036729088907927420928000") };
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
public class A274277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274277Inst Instance=new A274277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274278
{
public static readonly BigInteger[] Value={ 1L,0L,1L,6L,49L,520L,6841L,107744L,1979713L,41611392L,985263601L,25958682112L,753424361713L,23888905963520L,821659980883561L,30472793606184960L,1212264580564478209L,BigInteger.Parse("51496393511442350080"),BigInteger.Parse("2326573297949232710881"),BigInteger.Parse("111398795962351731212288"),BigInteger.Parse("5635038492335356268228401"),BigInteger.Parse("300285949343202022103973888"),BigInteger.Parse("16814498551154751682934232601"),BigInteger.Parse("987042812055984079330393194496") };
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
public class A274278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274278Inst Instance=new A274278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274279
{
public static readonly BigInteger[] Value={ 1L,2L,7L,40L,341L,3936L,57107L,992384L,20025385L,459466240L,11804134079L,335571265536L,10456512176189L,354362575314944L,12975301760361163L,510462668072058880L,BigInteger.Parse("21472710312090391889"),BigInteger.Parse("961728814178702327808"),BigInteger.Parse("45692671937666739799799"),BigInteger.Parse("2295278998002033651875840"),BigInteger.Parse("121545436687537993689631525"),BigInteger.Parse("6767130413049423041105231872"),BigInteger.Parse("395177438856180565803457658627"),BigInteger.Parse("24152146710231984411570685870080") };
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
public class A274279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274279Inst Instance=new A274279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274280
{
public static readonly long[] Value={ 1L,3L,4L,7L,11L,12L,18L,21L,28L,29L,33L,44L,47L,54L,72L,76L,77L,84L,87L,116L,123L,126L,132L,141L,188L,198L,199L,203L,216L,228L,231L,304L,308L,319L,322L,329L,348L,369L,378L,492L,504L,517L,521L,522L,532L,564L,594L,597L,609L,792L,796L,812L,836L,843L,846L,861L };
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
public class A274280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274280Inst : IEnumerable<long>
{
public static readonly long[] Value=A274280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274280.Bytes);
public long this[int i]=>Value[i];

public static A274280Inst Instance=new A274280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274281
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,11L,12L,14L,18L,21L,22L,24L,28L,29L,33L,36L,42L,44L,47L,54L,56L,58L,66L,72L,76L,77L,84L,87L,88L,94L,108L,116L,123L,126L,132L,141L,144L,152L,154L,168L,174L,188L,198L,199L,203L,216L,228L,231L,232L,246L,252L,264L,282L,304L,308L,319L,322L };
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
public class A274281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274281Inst : IEnumerable<long>
{
public static readonly long[] Value=A274281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274281.Bytes);
public long this[int i]=>Value[i];

public static A274281Inst Instance=new A274281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274282
{
public static readonly long[] Value={ 1L,4L,5L,9L,14L,20L,23L,36L,37L,45L,56L,60L,70L,92L,97L,115L,126L,148L,157L,180L,185L,207L,240L,254L,280L,300L,322L,333L,388L,411L,460L,485L,504L,518L,540L,628L,630L,665L,740L,785L,828L,840L,851L,873L,1016L,1035L,1076L,1200L,1270L,1288L,1332L,1358L,1380L };
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
public class A274282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274282Inst : IEnumerable<long>
{
public static readonly long[] Value=A274282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274282.Bytes);
public long this[int i]=>Value[i];

public static A274282Inst Instance=new A274282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274283
{
public static readonly long[] Value={ 1L,5L,6L,11L,17L,28L,30L,45L,55L,66L,73L,85L,102L,118L,140L,168L,187L,191L,225L,270L,308L,309L,330L,365L,438L,476L,495L,500L,510L,590L,708L,765L,803L,809L,840L,935L,955L,1122L,1146L,1241L,1260L,1298L,1309L,1350L,1540L,1545L,1848L,1854L,2006L,2044L,2101L,2118L };
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
public class A274283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274283Inst : IEnumerable<long>
{
public static readonly long[] Value=A274283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274283.Bytes);
public long this[int i]=>Value[i];

public static A274283Inst Instance=new A274283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274284
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,16L,20L,24L,26L,32L,40L,42L,48L,52L,60L,64L,68L,80L,84L,96L,104L,110L,120L,128L,136L,156L,160L,168L,178L,192L,208L,220L,240L,252L,260L,272L,288L,312L,320L,336L,356L,384L,408L,416L,420L,440L,466L,480L,504L,520L,544L,576L,624L,640L,660L,672L };
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
public class A274284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274284Inst : IEnumerable<long>
{
public static readonly long[] Value=A274284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274284.Bytes);
public long this[int i]=>Value[i];

public static A274284Inst Instance=new A274284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274285
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,14L,19L,24L,31L,35L,38L,50L,60L,62L,70L,81L,84L,95L,100L,120L,131L,133L,155L,162L,168L,190L,212L,217L,228L,250L,262L,266L,310L,343L,350L,372L,405L,420L,424L,434L,456L,500L,555L,567L,589L,600L,655L,665L,686L,700L,744L,810L,840L,898L,917L,950L };
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
public class A274285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274285Inst : IEnumerable<long>
{
public static readonly long[] Value=A274285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274285.Bytes);
public long this[int i]=>Value[i];

public static A274285Inst Instance=new A274285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274286
{
public static readonly long[] Value={ 4L,7L,11L,18L,28L,29L,44L,47L,72L,76L,77L,116L,123L,126L,188L,198L,199L,203L,304L,308L,319L,322L,329L,492L,504L,517L,521L,522L,532L,792L,796L,812L,836L,843L,846L,861L,1276L,1288L,1316L,1353L,1363L,1364L,1368L,1386L,1393L,2068L,2084L,2088L,2128L,2189L,2204L };
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
public class A274286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274286Inst : IEnumerable<long>
{
public static readonly long[] Value=A274286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274286.Bytes);
public long this[int i]=>Value[i];

public static A274286Inst Instance=new A274286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274287
{
public static readonly long[] Value={ 6L,10L,16L,26L,42L,60L,68L,96L,110L,156L,160L,178L,252L,260L,288L,408L,416L,420L,466L,660L,672L,680L,754L,960L,1068L,1088L,1092L,1100L,1220L,1560L,1728L,1760L,1768L,1780L,1974L,2496L,2520L,2796L,2848L,2856L,2860L,2880L,3194L,4032L,4080L,4160L,4524L,4608L };
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
public class A274287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274287Inst : IEnumerable<long>
{
public static readonly long[] Value=A274287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274287.Bytes);
public long this[int i]=>Value[i];

public static A274287Inst Instance=new A274287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274288
{
public static readonly long[] Value={ 9L,15L,24L,39L,63L,102L,135L,165L,216L,267L,351L,360L,432L,567L,585L,699L,918L,936L,945L,1131L,1485L,1512L,1530L,1830L,2403L,2448L,2457L,2475L,2961L,3240L,3888L,3960L,3978L,4005L,4791L,5265L,6291L,6408L,6426L,6435L,6480L,7752L,8424L,8505L,10179L,10368L,10395L };
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
public class A274288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274288Inst : IEnumerable<long>
{
public static readonly long[] Value=A274288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274288.Bytes);
public long this[int i]=>Value[i];

public static A274288Inst Instance=new A274288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274289
{
public static readonly long[] Value={ 1L,2L,4L,9L,22L,54L,134L,335L,843L,2132L,5409L,13761L,35088L,89638L,229361L,587678L,1507586L,3871589L,9952087L,25604573L,65927447L,169875992L,438016016L,1130103976L,2917412699L,7535482753L,19473430909L,50347508572L,130228143004L,336985674038L };
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
public class A274289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274289Inst : IEnumerable<long>
{
public static readonly long[] Value=A274289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274289.Bytes);
public long this[int i]=>Value[i];

public static A274289Inst Instance=new A274289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274290
{
public static readonly long[] Value={ 1L,8L,15L,21L,27L,34L,40L,46L };
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
public class A274290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274290Inst : IEnumerable<long>
{
public static readonly long[] Value=A274290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274290.Bytes);
public long this[int i]=>Value[i];

public static A274290Inst Instance=new A274290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274291
{
public static readonly long[] Value={ 1L,2L,3L,7L,17L,44L,118L,338L,1003L,3039L,9466L,30009L };
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
public class A274291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274291Inst : IEnumerable<long>
{
public static readonly long[] Value=A274291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274291.Bytes);
public long this[int i]=>Value[i];

public static A274291Inst Instance=new A274291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274340
{
public static readonly long[] Value={ 19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L,19L,20L,22L,36L };
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
public class A274340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274340Inst : IEnumerable<long>
{
public static readonly long[] Value=A274340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274340.Bytes);
public long this[int i]=>Value[i];

public static A274340Inst Instance=new A274340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274341
{
public static readonly long[] Value={ 1L,4L,7L,11L,12L,13L,16L,18L,21L,23L,26L,28L,31L,35L,36L,40L,41L,45L,46L,49L,50L,54L,55L,59L,60L,64L,69L,74L,79L,84L,89L,94L,97L,102L,107L,112L,117L,122L,127L,131L,132L,136L,137L,141L,142L,146L,147L,151L,152L,156L,157L,161L,162L,166L,167L,171L,172L,176L,177L,181L };
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
public class A274341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274341Inst : IEnumerable<long>
{
public static readonly long[] Value=A274341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274341.Bytes);
public long this[int i]=>Value[i];

public static A274341Inst Instance=new A274341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274342
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,2L,60L,5L,1L,29L,485L,2L,1722L,5446L,3L,8000L,10L,5300L,270L,181188L,955290L,4L,4L,15988040L,416012L,32420068L,2682744L,223L,25851L,8409205L,49871L,301L,1713301109422L,1066033105795L,4270L,57425882L,859704866L,11125766L,77746116L,39343318862281L,501010332520L,4762L };
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
public class A274342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274342Inst : IEnumerable<long>
{
public static readonly long[] Value=A274342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274342.Bytes);
public long this[int i]=>Value[i];

public static A274342Inst Instance=new A274342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274343
{
public static readonly BigInteger[] Value={ 1L,1L,3L,11L,13L,39L,33L,2431L,663L,247L,2717L,80223L,1989L,1062347L,3187041L,16055L,6605027L,77571L,11685817L,1062347L,2002524095L,4405553009L,247L,2717L,497705L,155409680283L,11559397707L,1123416017295L,74894401153L,114727509L,5643476995L,409716429837L,10158258591L,909705199L,233400836858808047L,190964321066297493L,18394643943L,34825896536145L,229850917138557L,17096349208653L,357856262339147L,BigInteger.Parse("24291640943843637507"),602272089516784401L,174041631153L };
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
public class A274343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274343Inst Instance=new A274343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274344
{
public static readonly long[] Value={ 1L,4L,34L,360L,4239L,53148L,694582L,9348664L,128625067L,1800131564L,25538105486L,366348201176L,5304067812296L,77394671803040L,1136872705730600L,16796605751564320L,249415741237963837L };
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
public class A274344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274344Inst : IEnumerable<long>
{
public static readonly long[] Value=A274344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274344.Bytes);
public long this[int i]=>Value[i];

public static A274344Inst Instance=new A274344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274345
{
public static readonly BigInteger[] Value={ 1L,13L,184L,2701L,40456L,306860L,9391936L,144644749L,2238445480L,17386135604L,541801226176L,2115779182678L,132472258939840L,1038616414507808L,32621327116946944L,512963507737401997L,8075477240446327528L,BigInteger.Parse("63629398756188443588"),BigInteger.Parse("2007225253307641799872"),BigInteger.Parse("7921211894405933627674"),BigInteger.Parse("500517296244244008379456") };
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
public class A274345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274345Inst Instance=new A274345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274346
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,8L,9L,5L,11L,3L,13L,7L,15L,16L,17L,9L,19L,5L,21L,11L,23L,3L,25L,1L,27L,7L,29L,3L,31L,32L,33L,17L,35L,9L,37L,19L,39L,5L,41L,21L,43L,11L,9L,23L,47L,6L,49L,25L,51L,13L,53L,27L,55L,7L,57L,29L,59L,15L,61L,31L,63L,64L,1L,33L,67L,17L,3L,35L,71L,9L,73L,37L,75L,19L,11L,39L,79L,10L };
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
public class A274346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274346Inst : IEnumerable<long>
{
public static readonly long[] Value=A274346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274346.Bytes);
public long this[int i]=>Value[i];

public static A274346Inst Instance=new A274346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274347
{
public static readonly long[] Value={ 12L,21L,28L,33L,44L,54L,72L,77L,87L,116L,126L,141L,188L,198L,203L,228L,304L,319L,329L,369L,492L,517L,522L,532L,597L,796L,836L,846L,861L,966L,1288L,1353L,1363L,1368L,1393L,1563L,2084L,2189L,2204L,2214L,2254L,2529L,3372L,3542L,3567L,3572L,3582L,3647L,4092L };
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
public class A274347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274347Inst : IEnumerable<long>
{
public static readonly long[] Value=A274347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274347.Bytes);
public long this[int i]=>Value[i];

public static A274347Inst Instance=new A274347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274348
{
public static readonly long[] Value={ 84L,132L,216L,231L,308L,348L,378L,504L,564L,594L,609L,792L,812L,912L,957L,987L,1276L,1316L,1386L,1476L,1551L,1566L,1596L,2068L,2088L,2128L,2233L,2388L,2508L,2538L,2583L,3344L,3384L,3444L,3619L,3654L,3864L,4059L,4089L,4104L,4179L,5412L,5452L,5472L,5572L,5742L };
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
public class A274348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274348Inst : IEnumerable<long>
{
public static readonly long[] Value=A274348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274348.Bytes);
public long this[int i]=>Value[i];

public static A274348Inst Instance=new A274348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274349
{
public static readonly long[] Value={ 6L,8L,12L,14L,21L,22L,28L,33L,36L,44L,54L,58L,72L,77L,87L,94L,116L,126L,141L,152L,188L,198L,203L,228L,246L,304L,319L,329L,369L,398L,492L,517L,522L,532L,597L,644L,796L,836L,846L,861L,966L,1042L,1288L,1353L,1363L,1368L,1393L,1563L,1686L,2084L,2189L,2204L,2214L };
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
public class A274349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274349Inst : IEnumerable<long>
{
public static readonly long[] Value=A274349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274349.Bytes);
public long this[int i]=>Value[i];

public static A274349Inst Instance=new A274349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274350
{
public static readonly long[] Value={ 24L,42L,56L,66L,84L,88L,108L,132L,144L,154L,174L,216L,231L,232L,252L,282L,308L,348L,376L,378L,396L,406L,456L,504L,564L,594L,608L,609L,638L,658L,738L,792L,812L,912L,957L,984L,987L,1034L,1044L,1064L,1194L,1276L,1316L,1386L,1476L,1551L,1566L,1592L,1596L,1672L };
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
public class A274350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274350Inst : IEnumerable<long>
{
public static readonly long[] Value=A274350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274350.Bytes);
public long this[int i]=>Value[i];

public static A274350Inst Instance=new A274350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274351
{
public static readonly long[] Value={ 274723L,13415557L,27103147L,127827253L,154689319L,162097909L,183192157L,196484569L,196484569L,246836983L,246948451L,279990229L,281840539L,338131501L,351159649L,392743807L,428156821L,435821443L,459898531L };
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
public class A274351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274351Inst : IEnumerable<long>
{
public static readonly long[] Value=A274351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274351.Bytes);
public long this[int i]=>Value[i];

public static A274351Inst Instance=new A274351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274352
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,10L,18L,26L,36L,53L,76L,104L,140L,190L,252L,336L,437L,564L,732L,936L,1186L,1504L,1894L,2366L,2950L,3659L,4520L,5564L,6822L,8330L,10152L,12326L,14906L,17996L,21662L,25996L,31135L,37190L,44314L,52704L,62532L,74036L,87504L,103212L,121496L,142798L };
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
public class A274352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274352Inst : IEnumerable<long>
{
public static readonly long[] Value=A274352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274352.Bytes);
public long this[int i]=>Value[i];

public static A274352Inst Instance=new A274352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274353
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,3L,2L,2L,1L,2L,3L,2L,2L,2L,1L,2L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,2L,1L,2L,2L,3L,3L,2L,3L,3L,2L,3L,2L,1L,2L,2L,3L,4L,3L,2L,3L,3L,2L,3L,2L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,1L,2L,3L,2L };
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
public class A274353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274353Inst : IEnumerable<long>
{
public static readonly long[] Value=A274353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274353.Bytes);
public long this[int i]=>Value[i];

public static A274353Inst Instance=new A274353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274354
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,4L,3L,2L,2L,1L,2L,3L,2L,3L,3L,2L,3L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,3L,3L,2L,3L,4L,3L,4L,2L,3L,2L,1L,2L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,4L,3L };
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
public class A274354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274354Inst : IEnumerable<long>
{
public static readonly long[] Value=A274354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274354.Bytes);
public long this[int i]=>Value[i];

public static A274354Inst Instance=new A274354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274355
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,15L,27L,42L,65L,99L,148L,214L,308L,435L,605L,839L,1145L,1548L,2080L,2769L,3659L,4812L,6278L,8145L,10518L,13506L,17257L,21961L,27821L,35095L,44117L,55243L,68928L,85735L,106285L,131357L,161893L,198944L,243817L,298060L,363446L };
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
public class A274355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274355Inst : IEnumerable<long>
{
public static readonly long[] Value=A274355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274355.Bytes);
public long this[int i]=>Value[i];

public static A274355Inst Instance=new A274355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274372
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,1L,1L,0L,3L,2L,3L,1L,3L,2L,2L,1L,1L,0L,1L,1L,0L,4L,3L,7L,4L,7L,5L,8L,6L,6L,3L,5L,4L,3L,2L,2L,1L,1L,0L,1L,1L,0L,5L,4L,12L,10L,17L,12L,20L,18L,22L,14L,19L,16L,18L,14L,14L,12L,12L,7L,8L,7L,5L,4L,3L,2L,2L,1L,1L,0L,1L };
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
public class A274372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274372Inst : IEnumerable<long>
{
public static readonly long[] Value=A274372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274372.Bytes);
public long this[int i]=>Value[i];

public static A274372Inst Instance=new A274372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274373
{
public static readonly long[] Value={ 0L,1L,6L,35L,188L,989L,5131L,26411L,135229L,689814L,3509014L,17811637L,90256685L,456719880L,2308440442L,11656409995L,58809893357L,296500180806L,1493924791698L,7523064390774L,37866103978109L,190510720248534L,958122016323881L,4816944544836927L,24209532464417585L };
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
public class A274373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274373Inst : IEnumerable<long>
{
public static readonly long[] Value=A274373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274373.Bytes);
public long this[int i]=>Value[i];

public static A274373Inst Instance=new A274373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274374
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,18L,21L,24L,26L,28L,29L,33L,34L,39L,40L,42L,44L,47L,54L,55L,63L,65L,68L,72L,76L,77L,87L,89L,102L,104L,105L,110L,116L,123L,126L,141L,144L,165L,168L,170L,178L,188L,198L,199L,203L,228L,233L,267L,272L,273L,275L,288L };
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
public class A274374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274374Inst : IEnumerable<long>
{
public static readonly long[] Value=A274374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274374.Bytes);
public long this[int i]=>Value[i];

public static A274374Inst Instance=new A274374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274375
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,16L,18L,21L,22L,24L,26L,28L,29L,33L,34L,36L,39L,40L,42L,44L,47L,54L,55L,58L,63L,65L,68L,72L,76L,77L,87L,89L,94L,102L,104L,105L,110L,116L,123L,126L,141L,144L,152L,165L,168L,170L,178L,188L,198L,199L,203L,228L,233L };
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
public class A274375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274375Inst : IEnumerable<long>
{
public static readonly long[] Value=A274375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274375.Bytes);
public long this[int i]=>Value[i];

public static A274375Inst Instance=new A274375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274376
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,8L,12L,20L,32L,52L,84L,135L,219L,353L,572L,924L,1495L,2419L,3912L,6331L,10240L,16570L,26807L,43374L,70178L,113546L,183721L,297258L,480974L,778220L,1259184L,2037389L,3296554L,5333923L,8630446L,13964340L,22594740L,36559034L,59153708L,95712668L };
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
public class A274376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274376Inst : IEnumerable<long>
{
public static readonly long[] Value=A274376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274376.Bytes);
public long this[int i]=>Value[i];

public static A274376Inst Instance=new A274376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274377
{
public static readonly BigInteger[] Value={ 1L,1L,0L,1L,0L,16L,0L,736L,0L,67096L,0L,10163176L,0L,2306198896L,0L,732199108096L,0L,309860700130816L,0L,168568765338224896L,0L,BigInteger.Parse("114619705107961862656"),0L,BigInteger.Parse("95251358122177791486976"),0L,BigInteger.Parse("94984793274454431691503616"),0L,BigInteger.Parse("111939507886837612683516276736"),0L,BigInteger.Parse("153907136552991217284274400567296"),0L,BigInteger.Parse("244164979570216285201628515234840576"),0L,BigInteger.Parse("442692827509235885935744380253757341696"),0L,BigInteger.Parse("909667081143908558901949811564629988048896") };
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
public class A274377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274377Inst Instance=new A274377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274378
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,111L,552L,2873L,15458L,85312L,480314L,2747845L,15928080L,93347153L,552181372L,3292571913L,19769887128L,119430685503L,725375643416L,4426786390959L,27131644746326L,166932630227613L,1030684209393288L,6383992918008611L,39657230694169284L,247008096338698523L,1542292860296588558L,9651791500807437834UL,BigInteger.Parse("60528789932966226468"),BigInteger.Parse("380333245334293851637"),BigInteger.Parse("2394179659042901060436"),BigInteger.Parse("15096873553004201457425") };
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
public class A274378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274378Inst Instance=new A274378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274379
{
public static readonly BigInteger[] Value={ 1L,3L,13L,70L,429L,2842L,19794L,142758L,1056655L,7980280L,61251261L,476387379L,3746317414L,29738316330L,237968639936L,1917578268288L,15546796822656L,126728260011920L,1037987924978125L,8538459191677170L,70509828893263474L,584310452973463242L,4857624566855734836L,BigInteger.Parse("40501472981905806550"),BigInteger.Parse("338594135314564168494"),BigInteger.Parse("2837641019938074131463"),BigInteger.Parse("23835438376045780734390"),BigInteger.Parse("200633658871150345742269"),BigInteger.Parse("1692132786239339256115050"),BigInteger.Parse("14297391426538004065333910"),BigInteger.Parse("121009206594941545408186768") };
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
public class A274379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274379Inst Instance=new A274379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274380
{
public static readonly long[] Value={ 34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L };
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
public class A274380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274380Inst : IEnumerable<long>
{
public static readonly long[] Value=A274380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274380.Bytes);
public long this[int i]=>Value[i];

public static A274380Inst Instance=new A274380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274381
{
public static readonly long[] Value={ 23L,59L,83L,359L,479L,563L,839L,863L,1283L,2039L,2879L,2999L,3779L,4259L,4679L,5483L,7703L,10079L,12203L,13103L,23603L,26903L,27803L,30323L,31583L,33623L,35339L,41519L,43403L,44519L,44939L,53759L,55079L,57119L,57899L,58043L,65123L,66359L,70139L,70199L,76379L,77723L,79943L };
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
public class A274381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274381Inst : IEnumerable<long>
{
public static readonly long[] Value=A274381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274381.Bytes);
public long this[int i]=>Value[i];

public static A274381Inst Instance=new A274381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274382
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,6L,1L,4L,1L,1L,1L,24L,1L,1L,1L,14L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,10L,1L,3L,1L,2L,3L,1L,1L,4L,1L,2L,3L,4L,1L,3L,1L,4L,1L,1L,1L,6L,1L,1L,1L,1L,1L,3L,1L,4L,3L,1L,1L,3L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,14L,1L,1L };
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
public class A274382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274382Inst : IEnumerable<long>
{
public static readonly long[] Value=A274382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274382.Bytes);
public long this[int i]=>Value[i];

public static A274382Inst Instance=new A274382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274383
{
public static readonly long[] Value={ 4L,7L,10L,15L,18L,23L,29L,35L,40L,47L,54L,60L,68L,75L,83L,90L,99L,107L,116L,125L,134L,143L,152L,162L,172L,182L,193L,203L,214L,225L,236L,248L,259L,271L,283L,295L,307L,320L,332L,345L,358L,372L,385L,398L,412L,426L,440L,454L,469L,483L,498L,513L,528L,543L,559L,574L,590L,606L,622L,638L,654L,671L,688L,704L };
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
public class A274383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274383Inst : IEnumerable<long>
{
public static readonly long[] Value=A274383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274383.Bytes);
public long this[int i]=>Value[i];

public static A274383Inst Instance=new A274383Inst();

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