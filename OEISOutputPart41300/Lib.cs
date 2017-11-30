using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A050266
{
public static readonly long[] Value={ 17L,19L,29L,53L,97L,167L,269L,409L,593L,827L,1117L,1889L,2383L,2957L,3617L,6173L,7237L,9719L,11149L,12713L,16267L,18269L,25247L,27917L,33809L,47969L,56333L,65617L,70619L,75869L,81373L,99469L,112913L,120067L,143329L,151703L,160397L,188459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050266Inst : IEnumerable<long>
{
public static readonly long[] Value=A050266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050266.Bytes);
public long this[int i]=>Value[i];

public static A050266Inst Instance=new A050266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050267
{
public static readonly long[] Value={ 10181L,8527L,6967L,5501L,4129L,2851L,1667L,577L,-419L,-1321L,-2129L,-2843L,-3463L,-3989L,-4421L,-4759L,-5003L,-5153L,-5209L,-5171L,-5039L,-4813L,-4493L,-4079L,-3571L,-2969L,-2273L,-1483L,-599L,379L,1451L,2617L,3877L,5231L,6679L,8221L,9857L,11587L,13411L,15329L,17341L,19447L,21647L,31387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050267Inst : IEnumerable<long>
{
public static readonly long[] Value=A050267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050267.Bytes);
public long this[int i]=>Value[i];

public static A050267Inst Instance=new A050267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050268
{
public static readonly long[] Value={ 2753L,1979L,1277L,647L,89L,359L,953L,1619L,2357L,3167L,4049L,5003L,6029L,7127L,8297L,9539L,10853L,12239L,13697L,15227L,16829L,18503L,20249L,22067L,23957L,25919L,27953L,30059L,32237L,34487L,36809L,41669L,44207L,46817L,49499L,52253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050268Inst : IEnumerable<long>
{
public static readonly long[] Value=A050268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050268.Bytes);
public long this[int i]=>Value[i];

public static A050268Inst Instance=new A050268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050269
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,3L,6L,7L,8L,9L,2L,4L,10L,11L,12L,1L,8L,13L,3L,5L,14L,15L,16L,17L,4L,6L,18L,3L,8L,19L,20L,21L,1L,2L,5L,7L,12L,15L,22L,23L,24L,25L,6L,8L,26L,27L,4L,12L,28L,29L,7L,9L,30L,3L,16L,31L,32L,1L,24L,33L,8L,10L,34L,35L,36L,5L,16L,37L,2L,3L,9L,11L,21L,24L,38L,39L,4L,20L,40L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050269Inst : IEnumerable<long>
{
public static readonly long[] Value=A050269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050269.Bytes);
public long this[int i]=>Value[i];

public static A050269Inst Instance=new A050269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050270
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,8L,8L,9L,10L,11L,12L,12L,12L,13L,14L,15L,15L,15L,16L,16L,16L,17L,18L,19L,20L,20L,20L,21L,21L,21L,22L,23L,24L,24L,24L,24L,24L,24L,24L,25L,26L,27L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,32L,33L,33L,33L,34L,35L,35L,35L,36L,36L,36L,37L,38L,39L,39L,39L,40L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050270Inst : IEnumerable<long>
{
public static readonly long[] Value=A050270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050270.Bytes);
public long this[int i]=>Value[i];

public static A050270Inst Instance=new A050270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050271
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,9L,14L,15L,16L,23L,24L,25L,34L,35L,36L,47L,48L,49L,62L,63L,64L,79L,80L,81L,98L,99L,100L,119L,120L,121L,142L,143L,144L,167L,168L,169L,194L,195L,196L,223L,224L,225L,254L,255L,256L,287L,288L,289L,322L,323L,324L,359L,360L,361L,398L,399L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050271Inst : IEnumerable<long>
{
public static readonly long[] Value=A050271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050271.Bytes);
public long this[int i]=>Value[i];

public static A050271Inst Instance=new A050271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050272
{
public static readonly long[] Value={ 44L,79L,459L,705L,747L,762L,763L,764L,765L,766L,777L,1063L,1073L,1385L,1395L,1428L,1477L,1532L,1730L,1981L,2000L,2071L,2114L,2218L,2241L,2285L,2335L,2436L,2644L,2796L,2910L,2949L,2950L,3089L,3217L,3294L,3508L,3564L,3570L,3673L,3678L,3710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050272Inst : IEnumerable<long>
{
public static readonly long[] Value=A050272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050272.Bytes);
public long this[int i]=>Value[i];

public static A050272Inst Instance=new A050272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050273
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,3L,1L,2L,5L,6L,4L,7L,3L,1L,8L,5L,2L,3L,9L,4L,10L,8L,1L,6L,11L,5L,12L,8L,3L,4L,13L,7L,2L,6L,14L,1L,15L,3L,8L,16L,7L,12L,4L,5L,17L,9L,18L,15L,8L,1L,12L,19L,2L,10L,20L,3L,9L,5L,6L,21L,4L,8L,22L,11L,16L,3L,10L,23L,1L,24L,12L,6L,7L,25L,8L,11L,16L,26L,4L,13L,2L,15L,27L,12L,5L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050273Inst : IEnumerable<long>
{
public static readonly long[] Value=A050273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050273.Bytes);
public long this[int i]=>Value[i];

public static A050273Inst Instance=new A050273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050274
{
public static readonly long[] Value={ 3L,4L,8L,5L,6L,8L,15L,12L,7L,8L,12L,9L,16L,24L,10L,16L,24L,21L,11L,20L,12L,15L,35L,20L,13L,24L,14L,21L,33L,30L,15L,24L,40L,28L,16L,48L,17L,40L,28L,18L,32L,24L,42L,39L,19L,32L,20L,24L,36L,63L,30L,21L,60L,36L,22L,56L,40L,51L,48L,23L,56L,45L,24L,40L,33L,65L,44L,25L,80L,26L,44L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050274Inst : IEnumerable<long>
{
public static readonly long[] Value=A050274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050274.Bytes);
public long this[int i]=>Value[i];

public static A050274Inst Instance=new A050274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050275
{
public static readonly long[] Value={ 8L,12L,15L,16L,20L,21L,24L,24L,24L,28L,30L,32L,33L,35L,36L,39L,40L,40L,40L,42L,44L,45L,48L,48L,48L,51L,52L,55L,56L,56L,56L,57L,60L,60L,60L,63L,64L,65L,66L,68L,69L,70L,72L,72L,72L,75L,76L,77L,78L,80L,80L,80L,84L,84L,84L,85L,87L,88L,88L,88L,90L,91L,92L,93L,95L,96L,96L,96L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050275Inst : IEnumerable<long>
{
public static readonly long[] Value=A050275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050275.Bytes);
public long this[int i]=>Value[i];

public static A050275Inst Instance=new A050275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050276
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,-1L,-1L,1L,19L,11L,1L,-5L,-901L,-7L,-1L,5L,367L,18889L,17L,1L,-5L,-407L,-6649L,-2131L,-1L,-1L,41L,427L,26405L,88651L,11153L,23L,1L,-2603L,-3781L,-21543701L,-66727L,-8503L,-13L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050276Inst : IEnumerable<long>
{
public static readonly long[] Value=A050276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050276.Bytes);
public long this[int i]=>Value[i];

public static A050276Inst Instance=new A050276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050277
{
public static readonly long[] Value={ 1L,96L,64L,18432L,64L,3840L,5308416L,128L,24576L,5898240L,2038431744L,3072L,82575360L,849346560L,978447237120L,2048L,7864320L,237817036800L,652298158080L,563585608581120L,2048L,2621440L,11890851840L,5707608883200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050277Inst : IEnumerable<long>
{
public static readonly long[] Value=A050277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050277.Bytes);
public long this[int i]=>Value[i];

public static A050277Inst Instance=new A050277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050278
{
public static readonly long[] Value={ 1023456789L,1023456798L,1023456879L,1023456897L,1023456978L,1023456987L,1023457689L,1023457698L,1023457869L,1023457896L,1023457968L,1023457986L,1023458679L,1023458697L,1023458769L,1023458796L,1023458967L,1023458976L,1023459678L,1023459687L,1023459768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050278Inst : IEnumerable<long>
{
public static readonly long[] Value=A050278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050278.Bytes);
public long this[int i]=>Value[i];

public static A050278Inst Instance=new A050278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050279
{
public static readonly long[] Value={ 32L,307L,601L,13390L,17534L,1699927L,3794572L,172330850L,2542542102L,8324296435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050279Inst : IEnumerable<long>
{
public static readonly long[] Value=A050279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050279.Bytes);
public long this[int i]=>Value[i];

public static A050279Inst Instance=new A050279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050280
{
public static readonly long[] Value={ 3L,5L,23L,1000003L,6000023L,8000023L,20000003L,20000023L,26000003L,1003000001L,1006000001L,1023000023L,1028000023L,3001000001L,3003000001L,3010000001L,3018000001L,3018000023L,3023000023L,5005000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050280Inst : IEnumerable<long>
{
public static readonly long[] Value=A050280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050280.Bytes);
public long this[int i]=>Value[i];

public static A050280Inst Instance=new A050280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050281
{
public static readonly long[] Value={ 6L,135L,1735L,4902L,65260L,963024L,82599811L,175820910L,1270311937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050281Inst : IEnumerable<long>
{
public static readonly long[] Value=A050281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050281.Bytes);
public long this[int i]=>Value[i];

public static A050281Inst Instance=new A050281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050282
{
public static readonly long[] Value={ 9L,24L,1698L,28467L,28467L,710100L,710100L,36488176L,2011485307L,4663739959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050282Inst : IEnumerable<long>
{
public static readonly long[] Value=A050282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050282.Bytes);
public long this[int i]=>Value[i];

public static A050282Inst Instance=new A050282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050283
{
public static readonly long[] Value={ 2L,59L,2707L,54525L,808650L,828499L,17893953L,22931745L,1346808619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050283Inst : IEnumerable<long>
{
public static readonly long[] Value=A050283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050283.Bytes);
public long this[int i]=>Value[i];

public static A050283Inst Instance=new A050283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050284
{
public static readonly long[] Value={ 4L,130L,177L,24466L,24466L,244453L,3517236L,168743355L,5050944965L,6644991298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050284Inst : IEnumerable<long>
{
public static readonly long[] Value=A050284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050284.Bytes);
public long this[int i]=>Value[i];

public static A050284Inst Instance=new A050284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050285
{
public static readonly long[] Value={ 7L,117L,2440L,21880L,48439L,252499L,8209165L,45681781L,45681781L,386980412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050285Inst : IEnumerable<long>
{
public static readonly long[] Value=A050285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050285.Bytes);
public long this[int i]=>Value[i];

public static A050285Inst Instance=new A050285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050286
{
public static readonly long[] Value={ 13L,559L,1589L,1589L,162248L,399579L,3346228L,24658601L,24658601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050286Inst : IEnumerable<long>
{
public static readonly long[] Value=A050286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050286.Bytes);
public long this[int i]=>Value[i];

public static A050286Inst Instance=new A050286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050287
{
public static readonly long[] Value={ 11L,34L,4751L,4751L,213245L,222299L,4722613L,46663520L,46663520L,3040319543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050287Inst : IEnumerable<long>
{
public static readonly long[] Value=A050287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050287.Bytes);
public long this[int i]=>Value[i];

public static A050287Inst Instance=new A050287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050288
{
public static readonly long[] Value={ 10123457689L,10123465789L,10123465897L,10123485679L,10123485769L,10123496857L,10123547869L,10123548679L,10123568947L,10123578649L,10123586947L,10123598467L,10123654789L,10123684759L,10123685749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050288Inst : IEnumerable<long>
{
public static readonly long[] Value=A050288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050288.Bytes);
public long this[int i]=>Value[i];

public static A050288Inst Instance=new A050288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050289
{
public static readonly long[] Value={ 123456789L,123456798L,123456879L,123456897L,123456978L,123456987L,123457689L,123457698L,123457869L,123457896L,123457968L,123457986L,123458679L,123458697L,123458769L,123458796L,123458967L,123458976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050289Inst : IEnumerable<long>
{
public static readonly long[] Value=A050289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050289.Bytes);
public long this[int i]=>Value[i];

public static A050289Inst Instance=new A050289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050290
{
public static readonly long[] Value={ 1123465789L,1123465879L,1123468597L,1123469587L,1123478659L,1123485967L,1123496587L,1123564879L,1123564987L,1123568497L,1123576849L,1123586479L,1123645987L,1123649587L,1123654879L,1123657489L,1123658479L,1123658749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050290Inst : IEnumerable<long>
{
public static readonly long[] Value=A050290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050290.Bytes);
public long this[int i]=>Value[i];

public static A050290Inst Instance=new A050290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050291
{
public static readonly long[] Value={ 2L,3L,6L,10L,20L,30L,60L,96L,192L,288L,576L,960L,1920L,2880L,5760L,9360L,18720L,28080L,56160L,93600L,187200L,280800L,561600L,898560L,1797120L,2695680L,5391360L,8985600L,17971200L,26956800L,53913600L,87091200L,174182400L,261273600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050291Inst : IEnumerable<long>
{
public static readonly long[] Value=A050291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050291.Bytes);
public long this[int i]=>Value[i];

public static A050291Inst Instance=new A050291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050292
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,20L,20L,21L,21L,22L,22L,23L,24L,25L,25L,26L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,36L,36L,37L,37L,38L,38L,39L,40L,41L,41L,42L,43L,44L,44L,45L,46L,47L,47L,48L,48L,49L,49L,50L,51L,52L,52L,53L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050292Inst : IEnumerable<long>
{
public static readonly long[] Value=A050292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050292.Bytes);
public long this[int i]=>Value[i];

public static A050292Inst Instance=new A050292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050293
{
public static readonly long[] Value={ 2L,4L,6L,12L,24L,36L,72L,144L,240L,480L,960L,1440L,2880L,5760L,8640L,17280L,34560L,57600L,115200L,230400L,345600L,691200L,1382400L,2073600L,4147200L,8294400L,13271040L,26542080L,53084160L,79626240L,159252480L,318504960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050293Inst : IEnumerable<long>
{
public static readonly long[] Value=A050293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050293.Bytes);
public long this[int i]=>Value[i];

public static A050293Inst Instance=new A050293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050294
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L,47L,48L,49L,49L,50L,51L,51L,52L,53L,54L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050294Inst : IEnumerable<long>
{
public static readonly long[] Value=A050294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050294.Bytes);
public long this[int i]=>Value[i];

public static A050294Inst Instance=new A050294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050295
{
public static readonly long[] Value={ 2L,3L,5L,8L,16L,24L,48L,76L,132L,198L,396L,588L,1176L,1764L,2940L,4680L,9360L,13680L,27360L,43776L,72960L,109440L,218880L,330240L,660480L,990720L,1693440L,2709504L,5419008L,8128512L,16257024L,25823232L,43038720L,64558080L,129116160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050295Inst : IEnumerable<long>
{
public static readonly long[] Value=A050295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050295.Bytes);
public long this[int i]=>Value[i];

public static A050295Inst Instance=new A050295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050296
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,11L,11L,12L,12L,13L,13L,14L,15L,16L,16L,16L,16L,17L,18L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,27L,27L,28L,28L,29L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,39L,40L,41L,42L,42L,43L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050296Inst : IEnumerable<long>
{
public static readonly long[] Value=A050296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050296.Bytes);
public long this[int i]=>Value[i];

public static A050296Inst Instance=new A050296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050297
{
public static readonly long[] Value={ 0L,1L,3L,14L,40L,90L,175L,308L,504L,780L,1155L,1650L,2288L,3094L,4095L,5320L,6800L,8568L,10659L,13110L,15960L,19250L,23023L,27324L,32200L,37700L,43875L,50778L,58464L,66990L,76415L,86800L,98208L,110704L,124355L,139230L,155400L,172938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050297Inst : IEnumerable<long>
{
public static readonly long[] Value=A050297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050297.Bytes);
public long this[int i]=>Value[i];

public static A050297Inst Instance=new A050297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050298
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,13L,19L,31L,47L,29L,23L,59L,83L,127L,37L,41L,67L,149L,211L,307L,53L,43L,101L,167L,353L,499L,709L,61L,71L,103L,241L,401L,823L,1153L,1613L,79L,73L,109L,257L,587L,937L,1873L,2647L,3659L,107L,89L,179L,277L,607L,1319L,2113L,4201L,5843L,8147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050298Inst : IEnumerable<long>
{
public static readonly long[] Value=A050298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050298.Bytes);
public long this[int i]=>Value[i];

public static A050298Inst Instance=new A050298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050299
{
public static readonly long[] Value={ 1L,5L,7L,11L,29L,773L,1321L,2621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050299Inst : IEnumerable<long>
{
public static readonly long[] Value=A050299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050299.Bytes);
public long this[int i]=>Value[i];

public static A050299Inst Instance=new A050299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050300
{
public static readonly long[] Value={ 1L,6L,1L,21L,6L,1L,71L,27L,6L,1L,196L,92L,27L,6L,1L,532L,288L,98L,27L,6L,1L,1301L,799L,309L,98L,27L,6L,1L,3101L,2100L,891L,315L,98L,27L,6L,1L,6956L,5145L,2373L,912L,315L,98L,27L,6L,1L,15217L,12121L,5980L,2465L,918L,315L,98L,27L,6L,1L,31951L,27247L,14292L,6253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050300Inst : IEnumerable<long>
{
public static readonly long[] Value=A050300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050300.Bytes);
public long this[int i]=>Value[i];

public static A050300Inst Instance=new A050300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050301
{
public static readonly long[] Value={ 1L,7L,1L,28L,7L,1L,105L,35L,7L,1L,322L,133L,35L,7L,1L,952L,455L,140L,35L,7L,1L,2541L,1379L,483L,140L,35L,7L,1L,6539L,3920L,1512L,490L,140L,35L,7L,1L,15833L,10375L,4354L,1540L,490L,140L,35L,7L,1L,37148L,26243L,11803L,4487L,1547L,490L,140L,35L,7L,1L,83594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050301Inst : IEnumerable<long>
{
public static readonly long[] Value=A050301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050301.Bytes);
public long this[int i]=>Value[i];

public static A050301Inst Instance=new A050301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050302
{
public static readonly long[] Value={ 1L,8L,1L,36L,8L,1L,148L,44L,8L,1L,498L,184L,44L,8L,1L,1590L,682L,192L,44L,8L,1L,4586L,2236L,718L,192L,44L,8L,1L,12644L,6822L,2420L,726L,192L,44L,8L,1L,32775L,19346L,7476L,2456L,726L,192L,44L,8L,1L,81901L,52177L,21646L,7660L,2464L,726L,192L,44L,8L,1L,196085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050302Inst : IEnumerable<long>
{
public static readonly long[] Value=A050302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050302.Bytes);
public long this[int i]=>Value[i];

public static A050302Inst Instance=new A050302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050303
{
public static readonly long[] Value={ 1L,9L,1L,45L,9L,1L,201L,54L,9L,1L,735L,246L,54L,9L,1L,2517L,981L,255L,54L,9L,1L,7785L,3453L,1026L,255L,54L,9L,1L,22857L,11238L,3699L,1035L,255L,54L,9L,1L,63024L,33930L,12183L,3744L,1035L,255L,54L,9L,1L,166819L,97038L,37464L,12429L,3753L,1035L,255L,54L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050303Inst : IEnumerable<long>
{
public static readonly long[] Value=A050303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050303.Bytes);
public long this[int i]=>Value[i];

public static A050303Inst Instance=new A050303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050304
{
public static readonly long[] Value={ 1L,10L,1L,55L,10L,1L,265L,65L,10L,1L,1045L,320L,65L,10L,1L,3817L,1365L,330L,65L,10L,1L,12583L,5127L,1420L,330L,65L,10L,1L,39148L,17710L,5447L,1430L,330L,65L,10L,1L,114235L,56638L,19030L,5502L,1430L,330L,65L,10L,1L,318857L,170993L,61865L,19350L,5512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050304Inst : IEnumerable<long>
{
public static readonly long[] Value=A050304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050304.Bytes);
public long this[int i]=>Value[i];

public static A050304Inst Instance=new A050304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050305
{
public static readonly long[] Value={ 1L,-2L,1L,1L,-2L,1L,3L,-1L,-2L,1L,-2L,4L,-1L,-2L,1L,-2L,2L,2L,-1L,-2L,1L,-3L,-1L,3L,2L,-1L,-2L,1L,-1L,-4L,3L,1L,2L,-1L,-2L,1L,5L,-5L,-5L,4L,1L,2L,-1L,-2L,1L,4L,-4L,-2L,-1L,2L,1L,2L,-1L,-2L,1L,5L,1L,-5L,-3L,0L,2L,1L,2L,-1L,-2L,1L,1L,7L,-5L,-4L,1L,-2L,2L,1L,2L,-1L,-2L,1L,1L,6L,2L,-5L,-5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050305Inst : IEnumerable<long>
{
public static readonly long[] Value=A050305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050305.Bytes);
public long this[int i]=>Value[i];

public static A050305Inst Instance=new A050305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050306
{
public static readonly long[] Value={ 1L,-3L,1L,3L,-3L,1L,5L,0L,-3L,1L,-8L,8L,0L,-3L,1L,-5L,0L,5L,0L,-3L,1L,-1L,-8L,3L,5L,0L,-3L,1L,5L,-9L,0L,0L,5L,0L,-3L,1L,17L,-3L,-15L,3L,0L,5L,0L,-3L,1L,6L,4L,-2L,-7L,0L,0L,5L,0L,-3L,1L,-1L,15L,0L,-8L,-4L,0L,0L,5L,0L,-3L,1L,-14L,20L,1L,-2L,0L,-7L,0L,0L,5L,0L,-3L,1L,-11L,2L,19L,0L,-8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050306Inst : IEnumerable<long>
{
public static readonly long[] Value=A050306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050306.Bytes);
public long this[int i]=>Value[i];

public static A050306Inst Instance=new A050306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050307
{
public static readonly long[] Value={ 1L,-4L,1L,6L,-4L,1L,6L,2L,-4L,1L,-19L,12L,2L,-4L,1L,-5L,-7L,8L,2L,-4L,1L,11L,-18L,-1L,8L,2L,-4L,1L,16L,-7L,-6L,-5L,8L,2L,-4L,1L,26L,13L,-24L,0L,-5L,8L,2L,-4L,1L,-10L,19L,11L,-12L,-4L,-5L,8L,2L,-4L,1L,-28L,23L,18L,-6L,-6L,-4L,-5L,8L,2L,-4L,1L,-38L,14L,4L,12L,6L,-10L,-4L,-5L,8L,2L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050307Inst : IEnumerable<long>
{
public static readonly long[] Value=A050307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050307.Bytes);
public long this[int i]=>Value[i];

public static A050307Inst Instance=new A050307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050308
{
public static readonly long[] Value={ 1L,-5L,1L,10L,-5L,1L,5L,5L,-5L,1L,-35L,15L,5L,-5L,1L,4L,-20L,10L,5L,-5L,1L,36L,-26L,-10L,10L,5L,-5L,1L,21L,10L,-11L,-15L,10L,5L,-5L,1L,15L,41L,-25L,-1L,-15L,10L,5L,-5L,1L,-51L,21L,40L,-10L,-6L,-15L,10L,5L,-5L,1L,-59L,0L,36L,5L,0L,-6L,-15L,10L,5L,-5L,1L,-34L,-15L,-24L,30L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050308Inst : IEnumerable<long>
{
public static readonly long[] Value=A050308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050308.Bytes);
public long this[int i]=>Value[i];

public static A050308Inst Instance=new A050308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050309
{
public static readonly long[] Value={ 1L,-6L,1L,15L,-6L,1L,1L,9L,-6L,1L,-55L,16L,9L,-6L,1L,29L,-39L,10L,9L,-6L,1L,71L,-25L,-24L,10L,9L,-6L,1L,0L,46L,-9L,-30L,10L,9L,-6L,1L,-27L,66L,-14L,6L,-30L,10L,9L,-6L,1L,-97L,-17L,77L,2L,0L,-30L,10L,9L,-6L,1L,-48L,-59L,30L,17L,17L,0L,-30L,10L,9L,-6L,1L,28L,-23L,-102L,35L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050309Inst : IEnumerable<long>
{
public static readonly long[] Value=A050309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050309.Bytes);
public long this[int i]=>Value[i];

public static A050309Inst Instance=new A050309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050310
{
public static readonly long[] Value={ 1L,-7L,1L,21L,-7L,1L,-7L,14L,-7L,1L,-77L,14L,14L,-7L,1L,77L,-63L,7L,14L,-7L,1L,105L,-7L,-42L,7L,14L,-7L,1L,-71L,98L,7L,-49L,7L,14L,-7L,1L,-90L,62L,7L,28L,-49L,7L,14L,-7L,1L,-97L,-112L,104L,21L,21L,-49L,7L,14L,-7L,1L,49L,-118L,-21L,13L,42L,21L,-49L,7L,14L,-7L,1L,111L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050310Inst : IEnumerable<long>
{
public static readonly long[] Value=A050310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050310.Bytes);
public long this[int i]=>Value[i];

public static A050310Inst Instance=new A050310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050311
{
public static readonly long[] Value={ 1L,-8L,1L,28L,-8L,1L,-20L,20L,-8L,1L,-98L,8L,20L,-8L,1L,154L,-90L,0L,20L,-8L,1L,118L,36L,-62L,0L,20L,-8L,1L,-212L,154L,44L,-70L,0L,20L,-8L,1L,-131L,-2L,28L,72L,-70L,0L,20L,-8L,1L,15L,-253L,98L,36L,64L,-70L,0L,20L,-8L,1L,223L,-98L,-119L,-28L,64L,64L,-70L,0L,20L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050311Inst : IEnumerable<long>
{
public static readonly long[] Value=A050311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050311.Bytes);
public long this[int i]=>Value[i];

public static A050311Inst Instance=new A050311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050312
{
public static readonly long[] Value={ 1L,-9L,1L,36L,-9L,1L,-39L,27L,-9L,1L,-114L,-3L,27L,-9L,1L,264L,-117L,-12L,27L,-9L,1L,81L,111L,-81L,-12L,27L,-9L,1L,-429L,192L,108L,-90L,-12L,27L,-9L,1L,-69L,-153L,30L,144L,-90L,-12L,27L,-9L,1L,284L,-387L,39L,27L,135L,-90L,-12L,27L,-9L,1L,364L,101L,-234L,-123L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050312Inst : IEnumerable<long>
{
public static readonly long[] Value=A050312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050312.Bytes);
public long this[int i]=>Value[i];

public static A050312Inst Instance=new A050312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050313
{
public static readonly long[] Value={ 1L,-10L,1L,45L,-10L,1L,-65L,35L,-10L,1L,-120L,-20L,35L,-10L,1L,408L,-140L,-30L,35L,-10L,1L,-43L,223L,-95L,-30L,35L,-10L,1L,-703L,180L,203L,-105L,-30L,35L,-10L,1L,210L,-403L,-15L,248L,-105L,-30L,35L,-10L,1L,683L,-413L,-80L,-35L,238L,-105L,-30L,35L,-10L,1L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050313Inst : IEnumerable<long>
{
public static readonly long[] Value=A050313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050313.Bytes);
public long this[int i]=>Value[i];

public static A050313Inst Instance=new A050313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050314
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,2L,2L,0L,2L,0L,1L,0L,3L,0L,2L,0L,2L,4L,0L,3L,0L,2L,0L,2L,0L,4L,0L,4L,0L,2L,0L,5L,6L,0L,5L,0L,4L,0L,6L,0L,1L,0L,8L,0L,6L,0L,8L,0L,6L,0L,2L,10L,0L,9L,0L,11L,0L,8L,0L,2L,0L,2L,0L,11L,0L,14L,0L,12L,0L,12L,0L,2L,0L,5L,16L,0L,18L,0L,15L,0L,16L,0L,4L,0L,6L,0L,2L,0L,23L,0L,20L,0L,20L,0L,19L,0L,8L,0L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050314Inst : IEnumerable<long>
{
public static readonly long[] Value=A050314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050314.Bytes);
public long this[int i]=>Value[i];

public static A050314Inst Instance=new A050314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050315
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,5L,1L,2L,2L,5L,2L,5L,5L,15L,1L,2L,2L,5L,2L,5L,5L,15L,2L,5L,5L,15L,5L,15L,15L,52L,1L,2L,2L,5L,2L,5L,5L,15L,2L,5L,5L,15L,5L,15L,15L,52L,2L,5L,5L,15L,5L,15L,15L,52L,5L,15L,15L,52L,15L,52L,52L,203L,1L,2L,2L,5L,2L,5L,5L,15L,2L,5L,5L,15L,5L,15L,15L,52L,2L,5L,5L,15L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050315Inst : IEnumerable<long>
{
public static readonly long[] Value=A050315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050315.Bytes);
public long this[int i]=>Value[i];

public static A050315Inst Instance=new A050315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050316
{
public static readonly long[] Value={ 1L,1L,3L,4L,8L,11L,23L,35L,54L,79L,123L,177L,260L,368L,557L,831L,1160L,1677L,2346L,3310L,4545L,6326L,8611L,11799L,15805L,21344L,28352L,37835L,49701L,65730L,86123L,113520L,147322L,193012L,249649L,324677L,418017L,541731L,695399L,894747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050316Inst : IEnumerable<long>
{
public static readonly long[] Value=A050316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050316.Bytes);
public long this[int i]=>Value[i];

public static A050316Inst Instance=new A050316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050317
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,2L,1L,0L,1L,0L,1L,1L,2L,0L,1L,1L,0L,1L,1L,0L,3L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,2L,0L,2L,2L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,2L,0L,0L,0L,3L,0L,0L,1L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,2L,0L,2L,0L,0L,1L,1L,0L,0L,2L,0L,0L,0L,2L,0L,3L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050317Inst : IEnumerable<long>
{
public static readonly long[] Value=A050317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050317.Bytes);
public long this[int i]=>Value[i];

public static A050317Inst Instance=new A050317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050318
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,5L,6L,8L,8L,12L,12L,15L,17L,23L,23L,31L,31L,41L,44L,52L,52L,69L,72L,84L,90L,108L,108L,135L,135L,161L,169L,192L,198L,246L,246L,277L,289L,342L,342L,404L,404L,464L,491L,543L,543L,644L,650L,734L,757L,853L,853L,978L,994L,1123L,1154L,1262L,1262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050318Inst : IEnumerable<long>
{
public static readonly long[] Value=A050318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050318.Bytes);
public long this[int i]=>Value[i];

public static A050318Inst Instance=new A050318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050319
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,1L,2L,0L,4L,0L,3L,2L,6L,0L,8L,0L,10L,3L,8L,0L,17L,3L,12L,6L,18L,0L,27L,0L,26L,8L,23L,6L,48L,0L,31L,12L,53L,0L,62L,0L,60L,27L,52L,0L,101L,6L,84L,23L,96L,0L,125L,16L,129L,31L,108L,0L,211L,0L,135L,59L,185L,24L,229L,0L,215L,52L,240L,0L,357L,0L,246L,102L,308L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050319Inst : IEnumerable<long>
{
public static readonly long[] Value=A050319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050319.Bytes);
public long this[int i]=>Value[i];

public static A050319Inst Instance=new A050319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050320
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,5L,1L,1L,2L,2L,2L,3L,1L,2L,2L,2L,1L,5L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,6L,1L,2L,2L,1L,2L,5L,1L,2L,2L,5L,1L,3L,1L,2L,2L,2L,2L,5L,1L,2L,1L,2L,1L,6L,2L,2L,2L,2L,1L,6L,2L,2L,2L,2L,2L,2L,1L,2L,2L,3L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050320Inst : IEnumerable<long>
{
public static readonly long[] Value=A050320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050320.Bytes);
public long this[int i]=>Value[i];

public static A050320Inst Instance=new A050320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050321
{
public static readonly long[] Value={ 5L,10L,17L,20L,21L,23L,29L,34L,40L,42L,43L,46L,53L,58L,65L,68L,69L,71L,77L,80L,81L,83L,84L,85L,86L,87L,89L,92L,93L,95L,101L,106L,113L,116L,117L,119L,125L,130L,136L,138L,139L,142L,149L,154L,160L,162L,163L,166L,168L,169L,170L,171L,172L,174L,175L,178L,184L,186L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050321Inst : IEnumerable<long>
{
public static readonly long[] Value=A050321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050321.Bytes);
public long this[int i]=>Value[i];

public static A050321Inst Instance=new A050321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050322
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,7L,5L,7L,9L,12L,11L,11L,16L,19L,21L,15L,29L,26L,30L,15L,31L,38L,22L,47L,52L,45L,36L,57L,64L,30L,77L,98L,67L,74L,97L,66L,105L,42L,109L,118L,92L,109L,171L,97L,141L,162L,137L,165L,56L,212L,181L,52L,198L,189L,289L,139L,250L,257L,269L,254L,77L,382L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050322Inst : IEnumerable<long>
{
public static readonly long[] Value=A050322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050322.Bytes);
public long this[int i]=>Value[i];

public static A050322Inst Instance=new A050322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050323
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,2L,5L,5L,3L,5L,7L,9L,4L,9L,10L,16L,5L,14L,18L,14L,15L,17L,25L,6L,21L,34L,19L,31L,27L,38L,8L,31L,57L,25L,59L,42L,40L,56L,10L,67L,44L,70L,46L,91L,33L,100L,64L,80L,80L,12L,117L,61L,52L,141L,74L,140L,43L,161L,93L,143L,111L,15L,193L,83L,120L,253L,116L,167L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050323Inst : IEnumerable<long>
{
public static readonly long[] Value=A050323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050323.Bytes);
public long this[int i]=>Value[i];

public static A050323Inst Instance=new A050323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050324
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,8L,8L,20L,13L,16L,26L,48L,44L,32L,76L,112L,132L,64L,208L,176L,256L,75L,252L,368L,128L,544L,604L,576L,308L,768L,976L,256L,1376L,1888L,1280L,1076L,2208L,818L,2496L,512L,2316L,3392L,1460L,2568L,5536L,2816L,3408L,6080L,3172L,6208L,1024L,7968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050324Inst : IEnumerable<long>
{
public static readonly long[] Value=A050324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050324.Bytes);
public long this[int i]=>Value[i];

public static A050324Inst Instance=new A050324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050325
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,5L,1L,3L,2L,6L,1L,3L,2L,6L,1L,3L,9L,2L,15L,4L,6L,1L,3L,10L,2L,21L,4L,6L,1L,3L,10L,2L,22L,4L,16L,6L,1L,13L,3L,35L,5L,10L,2L,22L,4L,19L,6L,1L,14L,3L,52L,41L,5L,10L,2L,22L,4L,20L,6L,1L,14L,3L,83L,42L,5L,26L,10L,2L,66L,17L,22L,4L,20L,55L,6L,6L,1L,14L,3L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050325Inst : IEnumerable<long>
{
public static readonly long[] Value=A050325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050325.Bytes);
public long this[int i]=>Value[i];

public static A050325Inst Instance=new A050325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050326
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,0L,0L,2L,1L,1L,1L,2L,2L,0L,1L,1L,1L,1L,2L,2L,1L,0L,0L,2L,0L,1L,1L,5L,1L,0L,2L,2L,2L,1L,1L,2L,2L,0L,1L,5L,1L,1L,1L,2L,1L,0L,0L,1L,2L,1L,1L,0L,2L,0L,2L,2L,1L,4L,1L,2L,1L,0L,2L,5L,1L,1L,2L,5L,1L,0L,1L,2L,1L,1L,2L,5L,1L,0L,0L,2L,1L,4L,2L,2L,2L,0L,1L,4L,2L,1L,2L,2L,2L,0L,1L,1L,1L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050326Inst : IEnumerable<long>
{
public static readonly long[] Value=A050326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050326.Bytes);
public long this[int i]=>Value[i];

public static A050326Inst Instance=new A050326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050327
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,1L,0L,0L,5L,0L,1L,0L,4L,0L,0L,0L,1L,0L,0L,5L,0L,15L,0L,0L,0L,0L,2L,0L,16L,0L,0L,0L,0L,0L,0L,7L,0L,8L,0L,0L,1L,0L,23L,0L,0L,0L,1L,0L,5L,0L,0L,0L,0L,52L,14L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,68L,3L,0L,4L,0L,0L,40L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050327Inst : IEnumerable<long>
{
public static readonly long[] Value=A050327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050327.Bytes);
public long this[int i]=>Value[i];

public static A050327Inst Instance=new A050327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050328
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,5L,1L,3L,3L,1L,1L,5L,1L,5L,3L,3L,1L,7L,1L,3L,1L,5L,1L,13L,1L,1L,3L,3L,3L,13L,1L,3L,3L,7L,1L,13L,1L,5L,5L,3L,1L,9L,1L,5L,3L,5L,1L,7L,3L,7L,3L,3L,1L,31L,1L,3L,5L,1L,3L,13L,1L,5L,3L,13L,1L,25L,1L,3L,5L,5L,3L,13L,1L,9L,1L,3L,1L,31L,3L,3L,3L,7L,1L,31L,3L,5L,3L,3L,3L,11L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050328Inst : IEnumerable<long>
{
public static readonly long[] Value=A050328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050328.Bytes);
public long this[int i]=>Value[i];

public static A050328Inst Instance=new A050328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050329
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,1L,7L,13L,1L,13L,9L,31L,1L,25L,11L,57L,1L,41L,101L,13L,75L,63L,91L,1L,61L,239L,15L,233L,129L,133L,1L,85L,469L,17L,535L,231L,409L,183L,1L,705L,113L,919L,321L,815L,19L,1029L,377L,1177L,241L,1L,1671L,145L,541L,2593L,681L,1301L,21L,1763L,575L,2741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050329Inst : IEnumerable<long>
{
public static readonly long[] Value=A050329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050329.Bytes);
public long this[int i]=>Value[i];

public static A050329Inst Instance=new A050329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050330
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,2L,1L,2L,2L,1L,1L,4L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,4L,1L,1L,2L,4L,1L,2L,1L,2L,1L,2L,1L,5L,1L,1L,2L,2L,1L,2L,1L,4L,2L,1L,1L,4L,1L,1L,1L,3L,1L,4L,1L,2L,1L,1L,1L,6L,1L,2L,2L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050330Inst : IEnumerable<long>
{
public static readonly long[] Value=A050330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050330.Bytes);
public long this[int i]=>Value[i];

public static A050330Inst Instance=new A050330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050331
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,2L,3L,3L,4L,4L,4L,5L,6L,6L,5L,8L,7L,8L,5L,9L,10L,6L,11L,13L,11L,9L,13L,14L,8L,16L,20L,14L,17L,20L,15L,21L,10L,22L,22L,20L,21L,31L,19L,27L,29L,26L,29L,12L,37L,30L,12L,36L,32L,46L,24L,42L,41L,44L,40L,15L,58L,40L,27L,61L,48L,49L,66L,31L,43L,63L,64L,56L,70L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050331Inst : IEnumerable<long>
{
public static readonly long[] Value=A050331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050331.Bytes);
public long this[int i]=>Value[i];

public static A050331Inst Instance=new A050331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050332
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050332Inst : IEnumerable<long>
{
public static readonly long[] Value=A050332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050332.Bytes);
public long this[int i]=>Value[i];

public static A050332Inst Instance=new A050332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050333
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,2L,1L,2L,2L,3L,1L,2L,3L,4L,1L,3L,4L,3L,5L,4L,6L,2L,4L,7L,4L,7L,5L,8L,2L,6L,10L,5L,12L,7L,7L,10L,2L,12L,7L,13L,8L,14L,6L,18L,10L,13L,13L,2L,17L,8L,12L,23L,11L,20L,7L,25L,12L,20L,16L,3L,26L,11L,22L,34L,14L,22L,25L,8L,26L,28L,35L,16L,30L,39L,21L,15L,3L,35L,14L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050333Inst : IEnumerable<long>
{
public static readonly long[] Value=A050333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050333.Bytes);
public long this[int i]=>Value[i];

public static A050333Inst Instance=new A050333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050334
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,2L,3L,1L,4L,1L,4L,2L,2L,1L,8L,1L,2L,2L,4L,1L,7L,1L,5L,2L,2L,2L,10L,1L,2L,2L,8L,1L,7L,1L,4L,4L,2L,1L,15L,1L,4L,2L,4L,1L,8L,2L,8L,2L,2L,1L,18L,1L,2L,4L,8L,2L,7L,1L,4L,2L,7L,1L,23L,1L,2L,4L,4L,2L,7L,1L,15L,3L,2L,1L,18L,2L,2L,2L,8L,1L,18L,2L,4L,2L,2L,2L,28L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050334Inst : IEnumerable<long>
{
public static readonly long[] Value=A050334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050334.Bytes);
public long this[int i]=>Value[i];

public static A050334Inst Instance=new A050334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050335
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,3L,8L,7L,5L,10L,15L,18L,8L,23L,28L,42L,13L,50L,55L,51L,32L,60L,92L,21L,104L,148L,92L,100L,144L,193L,34L,210L,364L,164L,272L,328L,199L,392L,55L,443L,414L,366L,378L,844L,290L,675L,718L,605L,777L,89L,1196L,801L,181L,1123L,931L,1874L,509L,1576L,1524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050335Inst : IEnumerable<long>
{
public static readonly long[] Value=A050335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050335.Bytes);
public long this[int i]=>Value[i];

public static A050335Inst Instance=new A050335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050336
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,3L,1L,6L,3L,3L,1L,9L,1L,3L,3L,14L,1L,9L,1L,9L,3L,3L,1L,23L,3L,3L,6L,9L,1L,12L,1L,27L,3L,3L,3L,31L,1L,3L,3L,23L,1L,12L,1L,9L,9L,3L,1L,57L,3L,9L,3L,9L,1L,23L,3L,23L,3L,3L,1L,41L,1L,3L,9L,58L,3L,12L,1L,9L,3L,12L,1L,83L,1L,3L,9L,9L,3L,12L,1L,57L,14L,3L,1L,41L,3L,3L,3L,23L,1L,41L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050336Inst : IEnumerable<long>
{
public static readonly long[] Value=A050336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050336.Bytes);
public long this[int i]=>Value[i];

public static A050336Inst Instance=new A050336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050337
{
public static readonly long[] Value={ 1L,1L,3L,3L,6L,9L,14L,23L,12L,27L,31L,57L,41L,58L,83L,131L,119L,111L,222L,154L,295L,60L,249L,322L,223L,537L,482L,637L,231L,698L,810L,424L,1280L,1390L,1350L,745L,1811L,634L,1955L,817L,1619L,2895L,969L,2066L,3705L,2789L,2185L,4513L,2122L,4525L,1527L,4934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050337Inst : IEnumerable<long>
{
public static readonly long[] Value=A050337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050337.Bytes);
public long this[int i]=>Value[i];

public static A050337Inst Instance=new A050337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050338
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,4L,1L,10L,4L,4L,1L,16L,1L,4L,4L,30L,1L,16L,1L,16L,4L,4L,1L,54L,4L,4L,10L,16L,1L,22L,1L,75L,4L,4L,4L,74L,1L,4L,4L,54L,1L,22L,1L,16L,16L,4L,1L,176L,4L,16L,4L,16L,1L,54L,4L,54L,4L,4L,1L,102L,1L,4L,16L,206L,4L,22L,1L,16L,4L,22L,1L,267L,1L,4L,16L,16L,4L,22L,1L,176L,30L,4L,1L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050338Inst : IEnumerable<long>
{
public static readonly long[] Value=A050338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050338.Bytes);
public long this[int i]=>Value[i];

public static A050338Inst Instance=new A050338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050339
{
public static readonly long[] Value={ 1L,1L,4L,4L,10L,16L,30L,54L,22L,75L,74L,176L,102L,206L,267L,535L,399L,518L,950L,526L,1585L,154L,1094L,1446L,1344L,3091L,2252L,4527L,817L,4158L,4879L,3357L,9809L,8811L,12664L,3605L,14653L,3005L,15738L,8429L,10479L,29762L,4777L,16863L,31883L,34631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050339Inst : IEnumerable<long>
{
public static readonly long[] Value=A050339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050339.Bytes);
public long this[int i]=>Value[i];

public static A050339Inst Instance=new A050339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050340
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,5L,1L,15L,5L,5L,1L,25L,1L,5L,5L,55L,1L,25L,1L,25L,5L,5L,1L,105L,5L,5L,15L,25L,1L,35L,1L,170L,5L,5L,5L,145L,1L,5L,5L,105L,1L,35L,1L,25L,25L,5L,1L,425L,5L,25L,5L,25L,1L,105L,5L,105L,5L,5L,1L,205L,1L,5L,25L,571L,5L,35L,1L,25L,5L,35L,1L,660L,1L,5L,25L,25L,5L,35L,1L,425L,55L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050340Inst : IEnumerable<long>
{
public static readonly long[] Value=A050340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050340.Bytes);
public long this[int i]=>Value[i];

public static A050340Inst Instance=new A050340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050341
{
public static readonly long[] Value={ 1L,1L,5L,5L,15L,25L,55L,105L,35L,170L,145L,425L,205L,571L,660L,1611L,1010L,1789L,2938L,1345L,5941L,315L,3437L,4596L,5727L,12047L,7317L,21190L,2130L,16533L,19496L,17836L,47949L,36232L,74020L,11940L,73831L,9841L,78981L,55627L,43590L,183208L,15982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050341Inst : IEnumerable<long>
{
public static readonly long[] Value=A050341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050341.Bytes);
public long this[int i]=>Value[i];

public static A050341Inst Instance=new A050341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050342
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,7L,12L,19L,30L,49L,77L,119L,186L,286L,438L,670L,1014L,1528L,2300L,3437L,5119L,7603L,11241L,16564L,24343L,35650L,52058L,75820L,110115L,159510L,230522L,332324L,477994L,686044L,982519L,1404243L,2003063L,2851720L,4052429L,5748440L,8140007L,11507125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050342Inst : IEnumerable<long>
{
public static readonly long[] Value=A050342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050342.Bytes);
public long this[int i]=>Value[i];

public static A050342Inst Instance=new A050342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050343
{
public static readonly long[] Value={ 1L,1L,1L,4L,7L,14L,29L,57L,110L,217L,417L,794L,1513L,2860L,5373L,10063L,18740L,34750L,64221L,118199L,216775L,396297L,722136L,1311888L,2376575L,4293407L,7735941L,13903985L,24929763L,44595606L,79598328L,141770576L,251984463L,446991405L,791391545L,1398551523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050343Inst : IEnumerable<long>
{
public static readonly long[] Value=A050343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050343.Bytes);
public long this[int i]=>Value[i];

public static A050343Inst Instance=new A050343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050344
{
public static readonly long[] Value={ 1L,1L,1L,5L,11L,25L,60L,141L,321L,742L,1688L,3810L,8580L,19225L,42844L,95156L,210480L,463866L,1018957L,2231114L,4870400L,10601805L,23015117L,49833471L,107636878L,231940988L,498671281L,1069826434L,2290402343L,4893782240L,10436263572L,22214850439L,47202869437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050344Inst : IEnumerable<long>
{
public static readonly long[] Value=A050344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050344.Bytes);
public long this[int i]=>Value[i];

public static A050344Inst Instance=new A050344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050345
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,3L,1L,3L,1L,6L,1L,3L,3L,4L,1L,6L,1L,6L,3L,3L,1L,13L,1L,3L,3L,6L,1L,12L,1L,7L,3L,3L,3L,15L,1L,3L,3L,13L,1L,12L,1L,6L,6L,3L,1L,25L,1L,6L,3L,6L,1L,13L,3L,13L,3L,3L,1L,31L,1L,3L,6L,12L,3L,12L,1L,6L,3L,12L,1L,37L,1L,3L,6L,6L,3L,12L,1L,25L,4L,3L,1L,31L,3L,3L,3L,13L,1L,31L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050345Inst : IEnumerable<long>
{
public static readonly long[] Value=A050345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050345.Bytes);
public long this[int i]=>Value[i];

public static A050345Inst Instance=new A050345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050346
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,6L,4L,13L,12L,7L,15L,25L,31L,12L,37L,46L,75L,19L,82L,96L,84L,60L,99L,164L,30L,168L,259L,148L,187L,234L,336L,49L,333L,628L,255L,506L,515L,346L,664L,77L,759L,636L,673L,598L,1406L,434L,1227L,1088L,1033L,1265L,119L,1979L,1178L,358L,2011L,1403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050346Inst : IEnumerable<long>
{
public static readonly long[] Value=A050346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050346.Bytes);
public long this[int i]=>Value[i];

public static A050346Inst Instance=new A050346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050347
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,4L,1L,4L,1L,10L,1L,4L,4L,7L,1L,10L,1L,10L,4L,4L,1L,26L,1L,4L,4L,10L,1L,22L,1L,14L,4L,4L,4L,34L,1L,4L,4L,26L,1L,22L,1L,10L,10L,4L,1L,63L,1L,10L,4L,10L,1L,26L,4L,26L,4L,4L,1L,74L,1L,4L,10L,29L,4L,22L,1L,10L,4L,22L,1L,105L,1L,4L,10L,10L,4L,22L,1L,63L,7L,4L,1L,74L,4L,4L,4L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050347Inst : IEnumerable<long>
{
public static readonly long[] Value=A050347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050347.Bytes);
public long this[int i]=>Value[i];

public static A050347Inst Instance=new A050347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050348
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,10L,7L,26L,22L,14L,34L,63L,74L,29L,105L,143L,223L,57L,296L,312L,320L,154L,366L,617L,110L,769L,1087L,697L,641L,1136L,1589L,217L,1906L,3394L,1483L,2224L,3246L,1562L,3919L,417L,4251L,4561L,3175L,3858L,9736L,3111L,6910L,8772L,6183L,9327L,794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050348Inst : IEnumerable<long>
{
public static readonly long[] Value=A050348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050348.Bytes);
public long this[int i]=>Value[i];

public static A050348Inst Instance=new A050348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050349
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,1L,5L,1L,5L,1L,15L,1L,5L,5L,11L,1L,15L,1L,15L,5L,5L,1L,45L,1L,5L,5L,15L,1L,35L,1L,25L,5L,5L,5L,65L,1L,5L,5L,45L,1L,35L,1L,15L,15L,5L,1L,130L,1L,15L,5L,15L,1L,45L,5L,45L,5L,5L,1L,145L,1L,5L,15L,60L,5L,35L,1L,15L,5L,35L,1L,240L,1L,5L,15L,15L,5L,35L,1L,130L,11L,5L,1L,145L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050349Inst : IEnumerable<long>
{
public static readonly long[] Value=A050349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050349.Bytes);
public long this[int i]=>Value[i];

public static A050349Inst Instance=new A050349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050350
{
public static readonly long[] Value={ 1L,1L,1L,5L,5L,15L,11L,45L,35L,25L,65L,130L,145L,60L,240L,351L,520L,141L,810L,775L,926L,315L,1037L,1721L,321L,2532L,3302L,2392L,1640L,3951L,5310L,742L,7500L,12498L,6043L,6915L,13795L,4970L,15624L,1688L,16198L,21435L,10352L,16733L,43404L,15035L,25967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050350Inst : IEnumerable<long>
{
public static readonly long[] Value=A050350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050350.Bytes);
public long this[int i]=>Value[i];

public static A050350Inst Instance=new A050350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050351
{
public static readonly BigInteger[] Value={ 1L,1L,5L,37L,365L,4501L,66605L,1149877L,22687565L,503589781L,12420052205L,336947795317L,9972186170765L,319727684645461L,11039636939221805L,408406422098722357L,16116066766061589965UL,BigInteger.Parse("675700891505466507541") };
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
public class A050351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A050351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A050351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A050351Inst Instance=new A050351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050352
{
public static readonly BigInteger[] Value={ 1L,1L,7L,73L,1015L,17641L,367927L,8952553L,248956855L,7788499561L,270732878647L,10351919533033L,431806658432695L,19512813265643881L,949587798053709367L,BigInteger.Parse("49512355251796513513"),BigInteger.Parse("2753726282896986372535"),BigInteger.Parse("162725978752448205162601") };
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
public class A050352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A050352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A050352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A050352Inst Instance=new A050352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050353
{
public static readonly BigInteger[] Value={ 1L,1L,9L,121L,2169L,48601L,1306809L,40994521L,1469709369L,59277466201L,2656472295609L,130952452264921L,7042235448544569L,410269802967187801L,BigInteger.Parse("25740278881968596409"),BigInteger.Parse("1730295054262416751321"),BigInteger.Parse("124066865052334175027769") };
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
public class A050353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A050353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A050353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A050353Inst Instance=new A050353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050354
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,1L,9L,3L,5L,1L,21L,1L,5L,5L,27L,1L,21L,1L,21L,5L,5L,1L,81L,3L,5L,9L,21L,1L,37L,1L,81L,5L,5L,5L,111L,1L,5L,5L,81L,1L,37L,1L,21L,21L,5L,1L,297L,3L,21L,5L,21L,1L,81L,5L,81L,5L,5L,1L,201L,1L,5L,21L,243L,5L,37L,1L,21L,5L,37L,1L,513L,1L,5L,21L,21L,5L,37L,1L,297L,27L,5L,1L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050354Inst : IEnumerable<long>
{
public static readonly long[] Value=A050354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050354.Bytes);
public long this[int i]=>Value[i];

public static A050354Inst Instance=new A050354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050355
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,21L,27L,81L,37L,81L,111L,297L,201L,243L,513L,1053L,945L,729L,2187L,1317L,3645L,365L,2745L,4077L,2187L,8829L,7209L,12393L,2433L,13257L,16605L,6561L,34263L,35397L,41553L,13473L,59697L,10155L,64881L,19683L,44793L,129033L,18993L,71307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050355Inst : IEnumerable<long>
{
public static readonly long[] Value=A050355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050355.Bytes);
public long this[int i]=>Value[i];

public static A050355Inst Instance=new A050355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050356
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,7L,1L,16L,4L,7L,1L,40L,1L,7L,7L,64L,1L,40L,1L,40L,7L,7L,1L,208L,4L,7L,16L,40L,1L,73L,1L,256L,7L,7L,7L,292L,1L,7L,7L,208L,1L,73L,1L,40L,40L,7L,1L,1024L,4L,40L,7L,40L,1L,208L,7L,208L,7L,7L,1L,544L,1L,7L,40L,1024L,7L,73L,1L,40L,7L,73L,1L,1840L,1L,7L,40L,40L,7L,73L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050356Inst : IEnumerable<long>
{
public static readonly long[] Value=A050356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050356.Bytes);
public long this[int i]=>Value[i];

public static A050356Inst Instance=new A050356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050357
{
public static readonly long[] Value={ 1L,1L,4L,7L,16L,40L,64L,208L,73L,256L,292L,1024L,544L,1024L,1840L,4864L,3472L,4096L,10624L,4936L,22528L,1015L,13552L,20224L,16384L,57856L,36976L,102400L,9328L,89344L,110848L,65536L,302080L,246784L,458752L,70480L,546304L,52996L,581632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050357Inst : IEnumerable<long>
{
public static readonly long[] Value=A050357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050357.Bytes);
public long this[int i]=>Value[i];

public static A050357Inst Instance=new A050357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050358
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,9L,1L,25L,5L,9L,1L,65L,1L,9L,9L,125L,1L,65L,1L,65L,9L,9L,1L,425L,5L,9L,25L,65L,1L,121L,1L,625L,9L,9L,9L,605L,1L,9L,9L,425L,1L,121L,1L,65L,65L,9L,1L,2625L,5L,65L,9L,65L,1L,425L,9L,425L,9L,9L,1L,1145L,1L,9L,65L,3125L,9L,121L,1L,65L,9L,121L,1L,4825L,1L,9L,65L,65L,9L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050358Inst : IEnumerable<long>
{
public static readonly long[] Value=A050358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050358.Bytes);
public long this[int i]=>Value[i];

public static A050358Inst Instance=new A050358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050359
{
public static readonly long[] Value={ 1L,1L,5L,9L,25L,65L,125L,425L,121L,625L,605L,2625L,1145L,3125L,4825L,15625L,9225L,15625L,35125L,13265L,90625L,2169L,45225L,67625L,78125L,240625L,126025L,515625L,25385L,377625L,465625L,390625L,1578125L,1062625L,2890625L,242825L,2915625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050359Inst : IEnumerable<long>
{
public static readonly long[] Value=A050359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050359.Bytes);
public long this[int i]=>Value[i];

public static A050359Inst Instance=new A050359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050360
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,5L,3L,1L,7L,4L,5L,2L,11L,6L,7L,3L,15L,10L,4L,11L,1L,9L,5L,22L,14L,6L,15L,2L,15L,7L,30L,22L,10L,22L,3L,21L,8L,11L,42L,9L,30L,4L,25L,14L,30L,5L,33L,12L,15L,56L,15L,44L,1L,6L,35L,22L,42L,7L,45L,20L,22L,77L,21L,60L,2L,10L,55L,18L,30L,56L,8L,25L,11L,66L,28L,9L,30L,49L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050360Inst : IEnumerable<long>
{
public static readonly long[] Value=A050360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050360.Bytes);
public long this[int i]=>Value[i];

public static A050360Inst Instance=new A050360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050361
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050361Inst : IEnumerable<long>
{
public static readonly long[] Value=A050361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050361.Bytes);
public long this[int i]=>Value[i];

public static A050361Inst Instance=new A050361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050362
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,1L,2L,1L,4L,2L,3L,2L,5L,2L,1L,4L,1L,4L,2L,6L,3L,2L,5L,1L,4L,3L,8L,4L,2L,6L,2L,6L,1L,4L,10L,4L,5L,1L,4L,3L,8L,2L,8L,2L,5L,12L,4L,6L,1L,2L,6L,4L,10L,3L,10L,2L,6L,15L,6L,8L,1L,2L,8L,4L,5L,12L,1L,4L,4L,12L,3L,4L,8L,9L,18L,8L,10L,2L,3L,10L,4L,6L,15L,2L,6L,5L,16L,1L,4L,4L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050362Inst : IEnumerable<long>
{
public static readonly long[] Value=A050362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050362.Bytes);
public long this[int i]=>Value[i];

public static A050362Inst Instance=new A050362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050363
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,2L,2L,1L,5L,1L,2L,2L,8L,1L,5L,1L,5L,2L,2L,1L,12L,2L,2L,4L,5L,1L,6L,1L,16L,2L,2L,2L,14L,1L,2L,2L,12L,1L,6L,1L,5L,5L,2L,1L,28L,2L,5L,2L,5L,1L,12L,2L,12L,2L,2L,1L,18L,1L,2L,5L,32L,2L,6L,1L,5L,2L,6L,1L,37L,1L,2L,5L,5L,2L,6L,1L,28L,8L,2L,1L,18L,2L,2L,2L,12L,1L,18L,2L,5L,2L,2L,2L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050363Inst : IEnumerable<long>
{
public static readonly long[] Value=A050363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050363.Bytes);
public long this[int i]=>Value[i];

public static A050363Inst Instance=new A050363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050364
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,8L,12L,6L,16L,14L,28L,18L,32L,37L,64L,50L,64L,94L,60L,144L,24L,106L,132L,128L,232L,182L,320L,84L,289L,336L,256L,560L,519L,704L,264L,760L,222L,832L,512L,594L,1328L,324L,838L,1416L,1536L,774L,1944L,734L,2016L,1024L,1806L,3104L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050364Inst : IEnumerable<long>
{
public static readonly long[] Value=A050364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050364.Bytes);
public long this[int i]=>Value[i];

public static A050364Inst Instance=new A050364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050365
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,6L,6L,8L,9L,11L,11L,15L,15L,19L,21L,25L,25L,33L,33L,39L,42L,50L,50L,63L,63L,74L,78L,89L,91L,110L,110L,125L,131L,152L,152L,181L,181L,206L,217L,242L,242L,285L,286L,322L,333L,372L,372L,428L,432L,486L,501L,551L,551L,636L,636L,699L,724L,799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050365Inst : IEnumerable<long>
{
public static readonly long[] Value=A050365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050365.Bytes);
public long this[int i]=>Value[i];

public static A050365Inst Instance=new A050365Inst();

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