using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176805
{
public static readonly long[] Value={ 2L,7L,16L,37L,94L,259L,748L,2209L,6586L,19711L,59080L,177181L,531478L,1594363L,4783012L,14348953L,43046770L,129140215L,387420544L,1162261525L,3486784462L,10460353267L,31381059676L,94143178897L,282429536554L,847288609519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176805Inst : IEnumerable<long>
{
public static readonly long[] Value=A176805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176805.Bytes);
public long this[int i]=>Value[i];

public static A176805Inst Instance=new A176805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176806
{
public static readonly long[] Value={ 1L,0L,2L,3L,6L,20L,35L,105L,238L,588L,1512L,3630L,9339L,23166L,58487L,148148L,373230L,949416L,2406248L,6122142L,15591856L,39729000L,101432982L,259049230L,662421643L,1695149220L,4341026900L,11125755615L,28530984915L,73213888650L,187980163110L,482906682675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176806Inst : IEnumerable<long>
{
public static readonly long[] Value=A176806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176806.Bytes);
public long this[int i]=>Value[i];

public static A176806Inst Instance=new A176806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176807
{
public static readonly long[] Value={ 3L,107L,137L,179L,239L,419L,461L,659L,1049L,1091L,1697L,1787L,1871L,2027L,2111L,2381L,2687L,2711L,3167L,3299L,3329L,3359L,3371L,3467L,3851L,4259L,4721L,4967L,5279L,5501L,5639L,5651L,5867L,6269L,6449L,7487L,8819L,8969L,9011L,9431L,9629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176807Inst : IEnumerable<long>
{
public static readonly long[] Value=A176807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176807.Bytes);
public long this[int i]=>Value[i];

public static A176807Inst Instance=new A176807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176808
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,1L,1L,0L,4L,2L,1L,1L,0L,5L,2L,1L,1L,1L,0L,6L,3L,2L,1L,1L,1L,0L,7L,3L,2L,1L,1L,1L,1L,0L,8L,4L,2L,2L,1L,1L,1L,1L,0L,9L,4L,3L,2L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176808Inst : IEnumerable<long>
{
public static readonly long[] Value=A176808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176808.Bytes);
public long this[int i]=>Value[i];

public static A176808Inst Instance=new A176808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176809
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,2L,3L,1L,1L,3L,3L,3L,3L,1L,1L,4L,4L,4L,4L,4L,1L,1L,4L,4L,5L,5L,4L,4L,1L,1L,5L,5L,6L,6L,6L,5L,5L,1L,1L,5L,6L,6L,7L,7L,6L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176809Inst : IEnumerable<long>
{
public static readonly long[] Value=A176809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176809.Bytes);
public long this[int i]=>Value[i];

public static A176809Inst Instance=new A176809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176810
{
public static readonly long[] Value={ 10L,14L,26L,38L,62L,86L,122L,146L,206L,218L,278L,302L,362L,386L,398L,458L,482L,542L,566L,626L,698L,842L,866L,926L,1046L,1142L,1202L,1238L,1286L,1322L,1622L,1646L,1658L,1718L,1766L,2042L,2066L,2102L,2126L,2186L,2306L,2462L,2558L,2582L,2606L,2642L,2858L,2906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176810Inst : IEnumerable<long>
{
public static readonly long[] Value=A176810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176810.Bytes);
public long this[int i]=>Value[i];

public static A176810Inst Instance=new A176810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176811
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,2L,2L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,2L,1L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,2L,1L,0L,2L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176811Inst : IEnumerable<long>
{
public static readonly long[] Value=A176811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176811.Bytes);
public long this[int i]=>Value[i];

public static A176811Inst Instance=new A176811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176812
{
public static readonly long[] Value={ 3L,9L,33L,111L,387L,1329L,4593L,15831L,54627L,188409L,649953L,2241951L,7733667L,26677089L,92022513L,317430471L,1094973507L,3777099369L,13029066273L,44943629391L,155032590147L,534783327249L,1844729605233L,6363375846711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176812Inst : IEnumerable<long>
{
public static readonly long[] Value=A176812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176812.Bytes);
public long this[int i]=>Value[i];

public static A176812Inst Instance=new A176812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176813
{
public static readonly long[] Value={ 1L,2L,7L,18L,60L,82L,149L,228L,229L,268L,325L,340L,372L,479L,508L,510L,515L,518L,619L,622L,710L,743L,790L,892L,910L,955L,998L,1020L,1158L,1184L,1215L,1266L,1310L,1363L,1431L,1478L,1567L,1885L,1921L,1979L,2066L,2316L,2476L,2541L,2688L,2704L,2781L,2798L,2809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176813Inst : IEnumerable<long>
{
public static readonly long[] Value=A176813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176813.Bytes);
public long this[int i]=>Value[i];

public static A176813Inst Instance=new A176813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176814
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,7L,8L,9L,10L,9L,11L,10L,11L,10L,12L,11L,11L,13L,14L,12L,13L,12L,14L,13L,15L,13L,14L,14L,15L,14L,15L,16L,17L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,20L,22L,21L,23L,22L,23L,22L,23L,23L,23L,23L,24L,24L,25L,25L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176814Inst : IEnumerable<long>
{
public static readonly long[] Value=A176814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176814.Bytes);
public long this[int i]=>Value[i];

public static A176814Inst Instance=new A176814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176815
{
public static readonly long[] Value={ 0L,0L,0L,0L,8L,10L,12L,0L,18L,18L,28L,24L,18L,30L,24L,30L,30L,42L,30L,18L,30L,48L,30L,42L,54L,30L,24L,24L,42L,54L,30L,42L,36L,42L,42L,42L,54L,60L,60L,24L,48L,30L,60L,36L,60L,72L,18L,84L,36L,78L,36L,42L,42L,18L,24L,30L,42L,60L,36L,30L,84L,54L,30L,48L,84L,66L,48L,60L,54L,72L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176815Inst : IEnumerable<long>
{
public static readonly long[] Value=A176815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176815.Bytes);
public long this[int i]=>Value[i];

public static A176815Inst Instance=new A176815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176816
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,3L,3L,3L,3L,2L,4L,2L,3L,3L,4L,3L,5L,3L,4L,5L,4L,3L,5L,4L,6L,4L,5L,4L,6L,5L,5L,5L,6L,6L,6L,5L,7L,5L,6L,5L,7L,6L,7L,6L,7L,6L,8L,7L,8L,7L,8L,6L,8L,6L,8L,7L,8L,7L,9L,8L,9L,9L,9L,9L,10L,7L,9L,9L,9L,10L,10L,10L,10L,10L,10L,9L,10L,11L,10L,10L,10L,11L,11L,11L,10L,10L,11L,10L,11L,11L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176816Inst : IEnumerable<long>
{
public static readonly long[] Value=A176816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176816.Bytes);
public long this[int i]=>Value[i];

public static A176816Inst Instance=new A176816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176817
{
public static readonly long[] Value={ 1L,4L,8L,16L,28L,32L,64L,112L,128L,256L,341L,448L,496L,512L,561L,645L,1016L,1024L,1105L,1288L,1387L,1729L,1792L,1905L,2044L,2047L,2048L,2416L,2465L,2701L,2821L,3277L,4033L,4096L,4369L,4371L,4672L,4681L,4984L,5461L,6601L,7168L,7936L,7957L,8128L,8192L,8321L,8481L,8911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176817Inst : IEnumerable<long>
{
public static readonly long[] Value=A176817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176817.Bytes);
public long this[int i]=>Value[i];

public static A176817Inst Instance=new A176817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176818
{
public static readonly long[] Value={ 1L,5L,37L,317L,2821L,25325L,227797L,2049917L,18448741L,166037645L,1494336757L,13449026717L,121041232261L,1089371073965L,9804339632917L,88239056630717L,794151509545381L,7147363585646285L,64326272270292277L,578936450431581917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176818Inst : IEnumerable<long>
{
public static readonly long[] Value=A176818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176818.Bytes);
public long this[int i]=>Value[i];

public static A176818Inst Instance=new A176818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176819
{
public static readonly long[] Value={ 64L,96L,29L,216L,43L,192L,413L,67L,69L,219L,77L,595L,485L,424L,224L,115L,480L,381L,536L,715L,453L,795L,501L,171L,173L,712L,368L,187L,189L,2211L,1085L,904L,699L,237L,723L,245L,1512L,1048L,267L,1925L,283L,285L,576L,291L,2709L,939L,317L,640L,1635L,3773L,355L,1805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176819Inst : IEnumerable<long>
{
public static readonly long[] Value=A176819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176819.Bytes);
public long this[int i]=>Value[i];

public static A176819Inst Instance=new A176819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176820
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,2L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,2L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,2L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176820Inst : IEnumerable<long>
{
public static readonly long[] Value=A176820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176820.Bytes);
public long this[int i]=>Value[i];

public static A176820Inst Instance=new A176820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176821
{
public static readonly long[] Value={ 5L,11L,13L,7L,29L,59L,61L,31L,659L,1319L,1321L,661L,809L,1619L,1621L,811L,2129L,4259L,4261L,2131L,2549L,5099L,5101L,2551L,3329L,6659L,6661L,3331L,3389L,6779L,6781L,3391L,5849L,11699L,11701L,5851L,6269L,12539L,12541L,6271L,10529L,21059L,21061L,10531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176821Inst : IEnumerable<long>
{
public static readonly long[] Value=A176821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176821.Bytes);
public long this[int i]=>Value[i];

public static A176821Inst Instance=new A176821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176822
{
public static readonly long[] Value={ 23L,127L,211L,223L,227L,241L,271L,283L,421L,523L,823L,829L,1021L,1123L,1201L,1213L,1223L,1229L,1231L,1237L,1249L,1279L,1291L,1297L,1321L,1327L,1429L,1627L,1723L,2003L,2011L,2017L,2027L,2053L,2083L,2089L,2113L,2129L,2131L,2137L,2179L,2203L,2207L,2213L,2237L,2243L,2267L,2273L,2297L,2311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176822Inst : IEnumerable<long>
{
public static readonly long[] Value=A176822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176822.Bytes);
public long this[int i]=>Value[i];

public static A176822Inst Instance=new A176822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176823
{
public static readonly BigInteger[] Value={ 0L,1L,8L,17L,399L,73L,44638L,1570497L,5077565L,486784401L,22187726197L,166394893969L,13800864889148L,762517292682713L,9603465430859099L,803800832678655745L,3180753925351614970L,BigInteger.Parse("947615093635545799201") };
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
public class A176823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176823Inst Instance=new A176823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176824
{
public static readonly BigInteger[] Value={ 0L,1L,10L,113L,1526L,24337L,450066L,9492289L,225159022L,5937424601L,172385029466L,5465884225969L,187964560069638L,6968912374274593L,277133723845128226L,11767703728247765249UL,BigInteger.Parse("531431035966023003614"),BigInteger.Parse("25434534147318166381993"),BigInteger.Parse("1286040688679372821752042") };
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
public class A176824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176824Inst Instance=new A176824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176825
{
public static readonly long[] Value={ 113L,24337L,9492289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176825Inst : IEnumerable<long>
{
public static readonly long[] Value=A176825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176825.Bytes);
public long this[int i]=>Value[i];

public static A176825Inst Instance=new A176825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176826
{
public static readonly long[] Value={ 1L,1L,3L,9L,27L,85L,283L,985L,3539L,13013L,48707L,184921L,710347L,2755669L,10780139L,42477977L,168439619L,671641685L,2691362195L,10832277401L,43771088315L,177504638933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176826Inst : IEnumerable<long>
{
public static readonly long[] Value=A176826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176826.Bytes);
public long this[int i]=>Value[i];

public static A176826Inst Instance=new A176826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176827
{
public static readonly BigInteger[] Value={ 1L,1L,4L,43L,1288L,111874L,28513474L,21447796411L,47864888436352L,318138497623694374L,BigInteger.Parse("6313455845922307358476"),BigInteger.Parse("374710369870861989860068222"),BigInteger.Parse("66586966437639051221223067992430") };
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
public class A176827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176827Inst Instance=new A176827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176828
{
public static readonly long[] Value={ 1L,2L,5L,16L,55L,203L,791L,3206L,13373L,57009L,247221L,1087029L,4834785L,21712543L,98317921L,448393292L,2057777663L,9495751679L,44033646503L,205087784247L,958968100635L,4500021108229L,21185081246875L,100029600031767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176828Inst : IEnumerable<long>
{
public static readonly long[] Value=A176828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176828.Bytes);
public long this[int i]=>Value[i];

public static A176828Inst Instance=new A176828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176829
{
public static readonly long[] Value={ 1L,3L,7L,25L,95L,393L,1711L,7741L,36007L,171097L,826839L,4050957L,20074303L,100438233L,506677279L,2574292749L,13161031191L,67656253081L,349499197799L,1813347470669L,9445448148975L,49375113712089L,258938850241327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176829Inst : IEnumerable<long>
{
public static readonly long[] Value=A176829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176829.Bytes);
public long this[int i]=>Value[i];

public static A176829Inst Instance=new A176829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176830
{
public static readonly long[] Value={ 1L,4L,9L,36L,147L,667L,3163L,15610L,79121L,409697L,2157185L,11514865L,62167261L,338870851L,1862411885L,10308811304L,57417591755L,321563019095L,1809699812171L,10229230730987L,58047787492463L,330576576766193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176830Inst : IEnumerable<long>
{
public static readonly long[] Value=A176830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176830.Bytes);
public long this[int i]=>Value[i];

public static A176830Inst Instance=new A176830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176831
{
public static readonly long[] Value={ 5L,7L,11L,13L,23L,37L,59L,61L,83L,277L,359L,383L,397L,457L,479L,541L,563L,839L,863L,1201L,1237L,1283L,1319L,1321L,1619L,1621L,1657L,2039L,2063L,2099L,2459L,2557L,2579L,2857L,2903L,2963L,3217L,3863L,4057L,4177L,4259L,4261L,4283L,4621L,4679L,5099L,5101L,5581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176831Inst : IEnumerable<long>
{
public static readonly long[] Value=A176831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176831.Bytes);
public long this[int i]=>Value[i];

public static A176831Inst Instance=new A176831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176832
{
public static readonly long[] Value={ 1L,5L,11L,49L,211L,1037L,5267L,27953L,152075L,845709L,4780923L,27402033L,158842179L,929655949L,5485858531L,32603081969L,194973609467L,1172405681165L,7084340575307L,42994921155441L,261963852143283L,1601804565028621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176832Inst : IEnumerable<long>
{
public static readonly long[] Value=A176832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176832.Bytes);
public long this[int i]=>Value[i];

public static A176832Inst Instance=new A176832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176833
{
public static readonly long[] Value={ 7L,3L,3L,3L,151L,61L,7L,3L,19L,3L,109L,109L,19L,19L,37L,409L,109L,97L,61L,19L,73L,109L,139L,139L,619L,31L,127L,31L,193L,3L,43L,19L,337L,7L,73L,367L,109L,373L,139L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176833Inst : IEnumerable<long>
{
public static readonly long[] Value=A176833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176833.Bytes);
public long this[int i]=>Value[i];

public static A176833Inst Instance=new A176833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176834
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,37L,53L,89L,127L,179L,181L,307L,449L,541L,577L,593L,683L,719L,809L,811L,937L,1259L,1297L,1567L,1709L,1801L,1979L,2467L,2647L,3061L,3187L,3457L,3691L,3833L,3907L,4283L,4357L,4447L,4463L,4861L,5003L,5167L,5849L,5851L,6247L,6263L,6337L,6389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176834Inst : IEnumerable<long>
{
public static readonly long[] Value=A176834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176834.Bytes);
public long this[int i]=>Value[i];

public static A176834Inst Instance=new A176834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176835
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,5L,3L,2L,3L,2L,2L,5L,2L,2L,5L,3L,2L,4L,2L,2L,5L,2L,4L,5L,2L,5L,3L,2L,2L,5L,5L,2L,5L,2L,2L,8L,2L,2L,8L,3L,3L,5L,2L,2L,4L,5L,5L,5L,2L,2L,5L,2L,2L,8L,5L,5L,5L,2L,2L,5L,5L,2L,8L,2L,2L,8L,2L,5L,5L,2L,8L,5L,2L,2L,5L,5L,2L,5L,5L,2L,8L,5L,2L,5L,2L,5L,11L,2L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176835Inst : IEnumerable<long>
{
public static readonly long[] Value=A176835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176835.Bytes);
public long this[int i]=>Value[i];

public static A176835Inst Instance=new A176835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176836
{
public static readonly long[] Value={ 1L,1L,4L,2L,6L,4L,8L,7L,12L,6L,10L,15L,14L,8L,26L,21L,16L,12L,16L,30L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176836Inst : IEnumerable<long>
{
public static readonly long[] Value=A176836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176836.Bytes);
public long this[int i]=>Value[i];

public static A176836Inst Instance=new A176836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176837
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,2L,6L,5L,9L,4L,8L,13L,12L,6L,21L,18L,14L,9L,14L,28L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176837Inst : IEnumerable<long>
{
public static readonly long[] Value=A176837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176837.Bytes);
public long this[int i]=>Value[i];

public static A176837Inst Instance=new A176837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176838
{
public static readonly long[] Value={ 17L,157L,257L,277L,397L,677L,877L,997L,1217L,1697L,1997L,2417L,2777L,3257L,3517L,3697L,4157L,4177L,5077L,5197L,5897L,6277L,7417L,7517L,8377L,9397L,9497L,9677L,9857L,11197L,11597L,12157L,12457L,12697L,13397L,13477L,13877L,14057L,14197L,15017L,16477L,17597L,18097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176838Inst : IEnumerable<long>
{
public static readonly long[] Value=A176838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176838.Bytes);
public long this[int i]=>Value[i];

public static A176838Inst Instance=new A176838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176839
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,4L,4L,5L,5L,5L,4L,6L,5L,6L,5L,7L,5L,7L,6L,7L,6L,8L,6L,7L,7L,7L,7L,9L,8L,8L,7L,8L,8L,10L,8L,9L,9L,11L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,10L,11L,11L,12L,11L,12L,12L,12L,12L,12L,12L,13L,11L,12L,13L,13L,12L,13L,13L,13L,12L,13L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176839Inst : IEnumerable<long>
{
public static readonly long[] Value=A176839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176839.Bytes);
public long this[int i]=>Value[i];

public static A176839Inst Instance=new A176839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176840
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-1L,5L,-691L,7L,-3617L,43867L,-174611L,854513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176840Inst : IEnumerable<long>
{
public static readonly long[] Value=A176840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176840.Bytes);
public long this[int i]=>Value[i];

public static A176840Inst Instance=new A176840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176841
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,7L,8L,8L,9L,9L,10L,10L,11L,10L,12L,11L,13L,12L,13L,12L,13L,13L,14L,14L,15L,13L,14L,14L,15L,14L,15L,15L,16L,16L,17L,17L,18L,17L,19L,18L,20L,19L,20L,19L,21L,20L,22L,21L,22L,21L,22L,22L,23L,22L,24L,23L,24L,24L,25L,24L,25L,25L,26L,26L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176841Inst : IEnumerable<long>
{
public static readonly long[] Value=A176841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176841.Bytes);
public long this[int i]=>Value[i];

public static A176841Inst Instance=new A176841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176842
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,21L,22L,23L,24L,24L,25L,26L,27L,27L,28L,28L,29L,29L,30L,31L,32L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,42L,43L,43L,44L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176842Inst : IEnumerable<long>
{
public static readonly long[] Value=A176842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176842.Bytes);
public long this[int i]=>Value[i];

public static A176842Inst Instance=new A176842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176843
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,21L,20L,21L,22L,22L,22L,21L,23L,23L,23L,24L,24L,24L,24L,24L,25L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176843Inst : IEnumerable<long>
{
public static readonly long[] Value=A176843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176843.Bytes);
public long this[int i]=>Value[i];

public static A176843Inst Instance=new A176843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176844
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,10L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,16L,15L,16L,16L,16L,17L,16L,17L,17L,18L,18L,19L,17L,19L,20L,20L,19L,21L,21L,20L,21L,20L,21L,21L,21L,22L,22L,21L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176844Inst : IEnumerable<long>
{
public static readonly long[] Value=A176844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176844.Bytes);
public long this[int i]=>Value[i];

public static A176844Inst Instance=new A176844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176845
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,18L,19L,20L,22L,24L,25L,26L,28L,30L,32L,33L,34L,36L,38L,39L,40L,42L,44L,46L,48L,50L,51L,52L,54L,55L,56L,58L,60L,62L,64L,65L,66L,68L,69L,70L,72L,74L,76L,78L,80L,81L,82L,84L,85L,86L,88L,89L,90L,92L,94L,96L,97L,98L,100L,102L,103L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176845Inst : IEnumerable<long>
{
public static readonly long[] Value=A176845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176845.Bytes);
public long this[int i]=>Value[i];

public static A176845Inst Instance=new A176845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176846
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,4L,2L,4L,5L,6L,3L,4L,7L,4L,5L,6L,8L,9L,6L,9L,10L,11L,7L,11L,12L,12L,8L,9L,13L,14L,13L,14L,15L,14L,10L,11L,15L,11L,15L,16L,16L,17L,16L,17L,18L,19L,17L,19L,19L,18L,18L,19L,20L,19L,20L,21L,20L,21L,20L,21L,22L,22L,19L,23L,23L,24L,20L,24L,24L,25L,24L,25L,26L,26L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176846Inst : IEnumerable<long>
{
public static readonly long[] Value=A176846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176846.Bytes);
public long this[int i]=>Value[i];

public static A176846Inst Instance=new A176846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176847
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,27L,29L,31L,37L,41L,43L,45L,47L,53L,59L,61L,63L,67L,71L,73L,75L,79L,81L,83L,89L,97L,99L,101L,103L,105L,107L,109L,113L,117L,125L,127L,131L,135L,137L,139L,147L,149L,151L,153L,157L,163L,165L,167L,171L,173L,175L,179L,181L,189L,191L,193L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176847Inst : IEnumerable<long>
{
public static readonly long[] Value=A176847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176847.Bytes);
public long this[int i]=>Value[i];

public static A176847Inst Instance=new A176847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176848
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,3L,4L,5L,10L,15L,21L,36L,56L,83L,134L,210L,320L,505L,791L,1221L,1911L,2988L,4639L,7240L,11305L,17595L,27436L,42806L,66691L,103968L,162144L,252720L,393965L,614285L,957581L,1492791L,2327396L,3628273L,5656274L,8818275L,13747425L,21431700L,33411976L,52088551L,81204526L,126596778L,197361904L,307682405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176848Inst : IEnumerable<long>
{
public static readonly long[] Value=A176848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176848.Bytes);
public long this[int i]=>Value[i];

public static A176848Inst Instance=new A176848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176849
{
public static readonly long[] Value={ 1L,1L,6L,15L,20L,15L,6L,1L,1L,12L,66L,220L,495L,792L,924L,792L,495L,220L,66L,12L,1L,1L,18L,153L,816L,3060L,8568L,18564L,31824L,43758L,48620L,43758L,31824L,18564L,8568L,3060L,816L,153L,18L,1L,1L,24L,276L,2024L,10626L,42504L,134596L,346104L,735471L,1307504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176849Inst : IEnumerable<long>
{
public static readonly long[] Value=A176849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176849.Bytes);
public long this[int i]=>Value[i];

public static A176849Inst Instance=new A176849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176850
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,6L,6L,3L,1L,4L,9L,11L,10L,6L,3L,1L,5L,12L,16L,17L,15L,10L,6L,3L,1L,6L,15L,21L,24L,24L,21L,15L,10L,6L,3L,1L,7L,18L,26L,31L,33L,32L,28L,21L,15L,10L,6L,3L,1L,8L,21L,31L,38L,42L,43L,41L,36L,28L,21L,15L,10L,6L,3L,1L,9L,24L,36L,45L,51L,54L,54L,51L,45L,36L,28L,21L,15L,10L,6L,3L,1L,10L,27L,41L,52L,60L,65L,67L,66L,62L,55L,45L,36L,28L,21L,15L,10L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176850Inst : IEnumerable<long>
{
public static readonly long[] Value=A176850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176850.Bytes);
public long this[int i]=>Value[i];

public static A176850Inst Instance=new A176850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176851
{
public static readonly long[] Value={ 0L,3L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176851Inst : IEnumerable<long>
{
public static readonly long[] Value=A176851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176851.Bytes);
public long this[int i]=>Value[i];

public static A176851Inst Instance=new A176851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176852
{
public static readonly long[] Value={ 7L,11L,15L,17L,21L,23L,27L,29L,31L,35L,37L,41L,43L,45L,47L,49L,53L,57L,59L,61L,63L,67L,71L,73L,75L,77L,79L,83L,87L,91L,93L,95L,99L,101L,105L,107L,109L,111L,115L,117L,121L,123L,125L,129L,131L,133L,135L,139L,141L,143L,145L,147L,149L,151L,153L,155L,157L,159L,163L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176852Inst : IEnumerable<long>
{
public static readonly long[] Value=A176852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176852.Bytes);
public long this[int i]=>Value[i];

public static A176852Inst Instance=new A176852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176853
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,20L,21L,11L,12L,21L,22L,10L,11L,11L,12L,20L,21L,21L,22L,11L,12L,12L,13L,21L,22L,22L,23L,10L,11L,20L,21L,11L,12L,21L,22L,20L,21L,30L,31L,21L,22L,31L,32L,11L,12L,21L,22L,12L,13L,22L,23L,21L,22L,31L,32L,22L,23L,32L,33L,10L,11L,11L,12L,20L,21L,21L,22L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176853Inst : IEnumerable<long>
{
public static readonly long[] Value=A176853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176853.Bytes);
public long this[int i]=>Value[i];

public static A176853Inst Instance=new A176853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176854
{
public static readonly long[] Value={ 1L,0L,-2L,-7L,-18L,-37L,-52L,10L,412L,1865L,5740L,12922L,16092L,-29767L,-290264L,-1213217L,-3608342L,-7564363L,-6023704L,38816098L,259037300L,991747431L,2756105680L,5061761997L,284694486L,-47403203725L,-254747436848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176854Inst : IEnumerable<long>
{
public static readonly long[] Value=A176854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176854.Bytes);
public long this[int i]=>Value[i];

public static A176854Inst Instance=new A176854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176855
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-8L,-25L,-72L,-197L,-514L,-1267L,-2884L,-5748L,-8468L,-119L,68688L,382434L,1557232L,5481369L,17494220L,51382510L,138541696L,335629309L,685402744L,919210879L,-913800290L,-13689355373L,-71111254588L,-287636394436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176855Inst : IEnumerable<long>
{
public static readonly long[] Value=A176855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176855.Bytes);
public long this[int i]=>Value[i];

public static A176855Inst Instance=new A176855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176856
{
public static readonly long[] Value={ 1L,2L,2L,5L,14L,47L,164L,590L,2156L,7985L,29900L,113054L,431132L,1656641L,6408776L,24942227L,97596698L,383740409L,1515431648L,6008307998L,23907184340L,95439446687L,382146649616L,1534364232089L,6176307411014L,24919973908607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176856Inst : IEnumerable<long>
{
public static readonly long[] Value=A176856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176856.Bytes);
public long this[int i]=>Value[i];

public static A176856Inst Instance=new A176856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176857
{
public static readonly long[] Value={ 1L,3L,4L,14L,48L,191L,776L,3271L,14062L,61601L,273796L,1232248L,5604252L,25718825L,118949392L,553888342L,2594626912L,12218698001L,57812767484L,274701432034L,1310257145600L,6271273757973L,30110943889096L,144992416476339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176857Inst : IEnumerable<long>
{
public static readonly long[] Value=A176857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176857.Bytes);
public long this[int i]=>Value[i];

public static A176857Inst Instance=new A176857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176858
{
public static readonly long[] Value={ 1L,4L,6L,25L,94L,419L,1884L,8866L,42524L,208361L,1036268L,5222754L,26607772L,136824505L,709211688L,3701711655L,19438809610L,102629612589L,544446273752L,2900686264810L,15514063940500L,83266691903815L,448333365133264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176858Inst : IEnumerable<long>
{
public static readonly long[] Value=A176858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176858.Bytes);
public long this[int i]=>Value[i];

public static A176858Inst Instance=new A176858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176859
{
public static readonly long[] Value={ 1L,5L,8L,38L,152L,743L,3608L,18515L,96542L,515525L,2792780L,15341492L,85186412L,477531833L,2698428176L,15355638218L,87919098128L,506118923897L,2927616746156L,17007899032118L,99191713057280L,580535666936861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176859Inst : IEnumerable<long>
{
public static readonly long[] Value=A176859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176859.Bytes);
public long this[int i]=>Value[i];

public static A176859Inst Instance=new A176859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176860
{
public static readonly long[] Value={ 1L,8L,-2L,81L,-48L,3L,1024L,-972L,192L,-4L,15625L,-20480L,7290L,-640L,5L,279936L,-468750L,245760L,-43740L,1920L,-6L,5764801L,-11757312L,8203125L,-2293760L,229635L,-5376L,7L,134217728L,-322828856L,282175488L,-109375000L,18350080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176860Inst : IEnumerable<long>
{
public static readonly long[] Value=A176860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176860.Bytes);
public long this[int i]=>Value[i];

public static A176860Inst Instance=new A176860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176861
{
public static readonly long[] Value={ 1L,-6L,-6L,36L,64L,36L,-240L,-600L,-600L,-240L,1800L,5760L,8100L,5760L,1800L,-15120L,-58800L,-105840L,-105840L,-58800L,-15120L,141120L,645120L,1411200L,1806336L,1411200L,645120L,141120L,-1451520L,-7620480L,-19595520L,-30481920L,-30481920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176861Inst : IEnumerable<long>
{
public static readonly long[] Value=A176861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176861.Bytes);
public long this[int i]=>Value[i];

public static A176861Inst Instance=new A176861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176862
{
public static readonly long[] Value={ 2L,5L,5L,37L,-16L,37L,239L,-50L,-50L,239L,1801L,-492L,180L,-492L,1801L,15119L,-4186L,714L,714L,-4186L,15119L,141121L,-40336L,8568L,-2688L,8568L,-40336L,141121L,1451519L,-423342L,90504L,-13104L,-13104L,90504L,-423342L,1451519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176862Inst : IEnumerable<long>
{
public static readonly long[] Value=A176862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176862.Bytes);
public long this[int i]=>Value[i];

public static A176862Inst Instance=new A176862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176863
{
public static readonly long[] Value={ 1L,0L,-1L,4L,-3L,1L,64L,-36L,9L,-1L,1296L,-650L,147L,-18L,1L,32768L,-15440L,3330L,-415L,30L,-1L,1000000L,-452984L,95070L,-11915L,945L,-45L,1L,35831808L,-15796032L,3257240L,-409290L,33985L,-1869L,63L,-1L,1475789056L,-637771728L,129899980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176863Inst : IEnumerable<long>
{
public static readonly long[] Value=A176863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176863.Bytes);
public long this[int i]=>Value[i];

public static A176863Inst Instance=new A176863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176864
{
public static readonly long[] Value={ 3L,6L,7L,11L,12L,14L,18L,19L,21L,23L,27L,28L,30L,32L,38L,39L,41L,43L,47L,51L,52L,54L,56L,60L,62L,66L,67L,69L,71L,75L,77L,83L,84L,86L,88L,92L,94L,98L,102L,103L,105L,107L,111L,113L,117L,119L,123L,124L,126L,128L,132L,134L,138L,140L,146L,147L,149L,151L,155L,157L,161L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176864Inst : IEnumerable<long>
{
public static readonly long[] Value=A176864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176864.Bytes);
public long this[int i]=>Value[i];

public static A176864Inst Instance=new A176864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176865
{
public static readonly long[] Value={ 3L,4L,6L,10L,11L,13L,15L,19L,21L,25L,29L,30L,32L,34L,38L,40L,44L,46L,50L,56L,58L,66L,67L,69L,71L,75L,77L,81L,83L,87L,93L,95L,101L,105L,107L,111L,117L,123L,127L,128L,130L,132L,136L,138L,142L,144L,148L,154L,156L,162L,166L,168L,172L,178L,184L,186L,192L,196L,198L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176865Inst : IEnumerable<long>
{
public static readonly long[] Value=A176865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176865.Bytes);
public long this[int i]=>Value[i];

public static A176865Inst Instance=new A176865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176866
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,2L,2L,4L,4L,6L,5L,7L,8L,14L,14L,19L,22L,30L,36L,48L,60L,79L,94L,118L,154L,194L,248L,315L,390L,486L,623L,792L,1008L,1261L,1579L,2007L,2555L,3219L,4043L,5109L,6464L,8204L,10351L,13100L,16575L,20889L,26398L,33388L,42155L,53370L,67414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176866Inst : IEnumerable<long>
{
public static readonly long[] Value=A176866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176866.Bytes);
public long this[int i]=>Value[i];

public static A176866Inst Instance=new A176866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176867
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,5L,0L,3L,0L,13L,0L,53L,17L,35L,11L,23L,7L,15L,29L,9L,19L,37L,77L,25L,49L,99L,33L,65L,131L,43L,87L,173L,57L,115L,39L,79L,153L,305L,105L,203L,407L,135L,271L,541L,185L,361L,123L,247L,481L,169L,329L,641L,219L,427L,159L,295L,569L,1139L,379L,759L,283L,505L,1011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176867Inst : IEnumerable<long>
{
public static readonly long[] Value=A176867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176867.Bytes);
public long this[int i]=>Value[i];

public static A176867Inst Instance=new A176867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176868
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,5L,0L,21L,0L,85L,0L,341L,113L,1365L,453L,5461L,1813L,21845L,7281L,87381L,29125L,349525L,116501L,1398101L,466033L,5592405L,1864133L,22369621L,7456533L,89478485L,29826161L,357913941L,119304645L,1431655765L,477218581L,5726623061L,1908874353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176868Inst : IEnumerable<long>
{
public static readonly long[] Value=A176868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176868.Bytes);
public long this[int i]=>Value[i];

public static A176868Inst Instance=new A176868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176869
{
public static readonly long[] Value={ 1L,16L,40L,52L,64L,88L,100L,112L,136L,148L,160L,184L,196L,208L,232L,244L,256L,280L,304L,340L,352L,400L,424L,448L,472L,520L,532L,544L,592L,616L,628L,640L,688L,712L,724L,736L,784L,808L,820L,832L,868L,904L,916L,928L,952L,964L,976L,1024L,1048L,1072L,1108L,1120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176869Inst : IEnumerable<long>
{
public static readonly long[] Value=A176869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176869.Bytes);
public long this[int i]=>Value[i];

public static A176869Inst Instance=new A176869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176870
{
public static readonly long[] Value={ 3L,11L,13L,19L,29L,67L,71L,83L,101L,107L,127L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L,313L,317L,523L,541L,571L,601L,613L,619L,643L,661L,691L,709L,1013L,1019L,1031L,1061L,1097L,1103L,1109L,1151L,1163L,1181L,1193L,1223L,1229L,1277L,1283L,1307L,1733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176870Inst : IEnumerable<long>
{
public static readonly long[] Value=A176870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176870.Bytes);
public long this[int i]=>Value[i];

public static A176870Inst Instance=new A176870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176871
{
public static readonly long[] Value={ 11L,13L,19L,29L,127L,24391L,357913L,571789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176871Inst : IEnumerable<long>
{
public static readonly long[] Value=A176871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176871.Bytes);
public long this[int i]=>Value[i];

public static A176871Inst Instance=new A176871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176872
{
public static readonly long[] Value={ 3L,11L,19L,67L,71L,83L,107L,227L,263L,269L,613L,619L,1031L,1061L,1163L,1193L,1223L,1307L,1787L,1801L,1811L,1831L,1979L,1997L,2129L,4099L,4127L,4133L,4139L,4157L,4373L,4409L,4463L,4637L,4643L,4703L,5843L,5849L,5879L,5903L,6089L,6101L,6113L,6143L,6163L,6211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176872Inst : IEnumerable<long>
{
public static readonly long[] Value=A176872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176872.Bytes);
public long this[int i]=>Value[i];

public static A176872Inst Instance=new A176872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176873
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,3L,5L,3L,3L,4L,3L,3L,3L,3L,3L,4L,5L,3L,4L,3L,3L,3L,3L,4L,4L,3L,3L,4L,3L,3L,5L,3L,3L,4L,3L,4L,4L,4L,3L,3L,3L,3L,4L,3L,3L,7L,5L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,5L,3L,3L,4L,3L,3L,3L,3L,3L,4L,4L,3L,4L,3L,3L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176873Inst : IEnumerable<long>
{
public static readonly long[] Value=A176873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176873.Bytes);
public long this[int i]=>Value[i];

public static A176873Inst Instance=new A176873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176874
{
public static readonly long[] Value={ 0L,5L,23L,62L,62L,723L,1578L,1578L,8139L,39644L,94323L,94323L,1317783L,1680515L,2025699L,3205598L,23003999L,113333163L,170717819L,1710518799L,3608109348L,16655876439L,24090452279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176874Inst : IEnumerable<long>
{
public static readonly long[] Value=A176874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176874.Bytes);
public long this[int i]=>Value[i];

public static A176874Inst Instance=new A176874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176875
{
public static readonly long[] Value={ 35L,65L,77L,161L,185L,209L,221L,335L,341L,371L,377L,437L,485L,515L,611L,671L,707L,731L,767L,779L,851L,899L,917L,965L,1007L,1067L,1115L,1157L,1211L,1247L,1271L,1337L,1385L,1397L,1529L,1535L,1577L,1631L,1691L,1781L,1817L,1841L,1991L,2117L,2171L,2201L,2285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176875Inst : IEnumerable<long>
{
public static readonly long[] Value=A176875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176875.Bytes);
public long this[int i]=>Value[i];

public static A176875Inst Instance=new A176875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176876
{
public static readonly long[] Value={ 143L,215L,341L,485L,515L,551L,713L,1133L,1241L,1271L,1541L,1865L,2183L,2315L,2501L,3173L,3215L,3503L,3713L,4031L,4661L,5465L,5633L,6431L,6485L,7313L,7361L,7571L,8201L,8471L,9353L,9599L,9713L,9893L,12083L,12371L,12443L,12449L,13361L,13631L,14711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176876Inst : IEnumerable<long>
{
public static readonly long[] Value=A176876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176876.Bytes);
public long this[int i]=>Value[i];

public static A176876Inst Instance=new A176876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176877
{
public static readonly long[] Value={ 165L,273L,345L,385L,399L,435L,561L,595L,651L,665L,715L,759L,777L,795L,885L,903L,957L,1001L,1015L,1065L,1085L,1173L,1209L,1235L,1281L,1335L,1435L,1443L,1463L,1495L,1515L,1533L,1547L,1551L,1615L,1645L,1659L,1677L,1705L,1749L,1767L,1771L,1885L,1947L,1965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176877Inst : IEnumerable<long>
{
public static readonly long[] Value=A176877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176877.Bytes);
public long this[int i]=>Value[i];

public static A176877Inst Instance=new A176877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176878
{
public static readonly long[] Value={ 105L,231L,273L,345L,357L,399L,483L,561L,627L,651L,663L,705L,759L,777L,795L,903L,957L,969L,987L,1005L,1023L,1131L,1173L,1221L,1239L,1281L,1353L,1407L,1419L,1491L,1533L,1551L,1581L,1605L,1659L,1677L,1743L,1749L,1887L,2013L,2037L,2055L,2091L,2121L,2139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176878Inst : IEnumerable<long>
{
public static readonly long[] Value=A176878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176878.Bytes);
public long this[int i]=>Value[i];

public static A176878Inst Instance=new A176878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176879
{
public static readonly long[] Value={ 110L,130L,430L,442L,470L,670L,782L,790L,890L,970L,1222L,1310L,1358L,1462L,1582L,1670L,1898L,1978L,2338L,2410L,2510L,3082L,3170L,3478L,3970L,4090L,4430L,4718L,4982L,5402L,5410L,5542L,5678L,6298L,7390L,7582L,7918L,7922L,8570L,8878L,9062L,9178L,9682L,9698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176879Inst : IEnumerable<long>
{
public static readonly long[] Value=A176879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176879.Bytes);
public long this[int i]=>Value[i];

public static A176879Inst Instance=new A176879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176880
{
public static readonly long[] Value={ 1L,3L,8L,23L,65L,182L,511L,1435L,4028L,11307L,31741L,89102L,250123L,702135L,1971004L,5532919L,15531777L,43600150L,122392503L,343575075L,964469468L,2707418035L,7600149781L,21334820094L,59890207635L,168121266303L,471942931900L,1324818304479L,3718974098873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176880Inst : IEnumerable<long>
{
public static readonly long[] Value=A176880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176880.Bytes);
public long this[int i]=>Value[i];

public static A176880Inst Instance=new A176880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176881
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,9L,11L,8L,15L,2L,17L,10L,21L,14L,6L,16L,27L,29L,8L,20L,35L,4L,39L,12L,41L,26L,6L,28L,45L,14L,51L,34L,18L,57L,10L,59L,38L,40L,12L,65L,44L,69L,2L,24L,71L,26L,77L,50L,16L,81L,56L,87L,58L,32L,6L,95L,64L,99L,22L,36L,101L,8L,68L,105L,38L,24L,107L,70L,4L,111L,42L,76L,6L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176881Inst : IEnumerable<long>
{
public static readonly long[] Value=A176881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176881.Bytes);
public long this[int i]=>Value[i];

public static A176881Inst Instance=new A176881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176882
{
public static readonly long[] Value={ 13L,17L,31L,71L,103L,107L,113L,131L,137L,151L,167L,173L,179L,197L,211L,311L,317L,431L,617L,719L,971L,1013L,1021L,1031L,1051L,1097L,1103L,1117L,1123L,1129L,1151L,1153L,1171L,1213L,1223L,1229L,1231L,1277L,1283L,1291L,1307L,1367L,1373L,1409L,1433L,1439L,1471L,1487L,1499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176882Inst : IEnumerable<long>
{
public static readonly long[] Value=A176882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176882.Bytes);
public long this[int i]=>Value[i];

public static A176882Inst Instance=new A176882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176883
{
public static readonly long[] Value={ 1L,6L,19L,55L,151L,359L,849L,1956L,4416L,9861L,21776L,47659L,103501L,223362L,479527L,1024599L,2180237L,4622633L,9769597L,20587721L,43272599L,90739538L,189867698L,396512548L,826579593L,1720267980L,3574753738L,7417943000L,15372756795L,31819255488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176883Inst : IEnumerable<long>
{
public static readonly long[] Value=A176883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176883.Bytes);
public long this[int i]=>Value[i];

public static A176883Inst Instance=new A176883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176884
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,2L,0L,3L,1L,4L,4L,2L,4L,1L,0L,4L,6L,2L,2L,6L,1L,4L,8L,3L,1L,7L,1L,6L,2L,2L,0L,7L,1L,1L,12L,6L,3L,1L,4L,4L,12L,2L,2L,1L,7L,4L,16L,3L,5L,2L,2L,6L,14L,4L,2L,2L,1L,6L,4L,2L,4L,11L,0L,3L,3L,6L,2L,4L,2L,4L,24L,2L,5L,5L,1L,3L,2L,6L,8L,21L,5L,4L,3L,3L,1L,1L,4L,6L,2L,4L,14L,2L,1L,1L,32L,8L,6L,1L,10L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176884Inst : IEnumerable<long>
{
public static readonly long[] Value=A176884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176884.Bytes);
public long this[int i]=>Value[i];

public static A176884Inst Instance=new A176884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176885
{
public static readonly long[] Value={ 1L,3L,9L,2L,32L,21L,51L,122L,111L,282L,237L,560L,489L,1898L,1794L,6200L,995L,2017L,13428L,19154L,4059L,2166L,8151L,73212L,16341L,58208L,89088L,176186L,32721L,383766L,65483L,530072L,1940958L,131013L,740022L,262083L,1592642L,4781120L,5634480L,524221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176885Inst : IEnumerable<long>
{
public static readonly long[] Value=A176885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176885.Bytes);
public long this[int i]=>Value[i];

public static A176885Inst Instance=new A176885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176886
{
public static readonly long[] Value={ 0L,0L,0L,16L,1960L,53744L,692320L,5599888L,33001664L,154215760L,603563504L,2052729728L,6229649352L,17202203680L,43870041520L,104531112928L,234870173248L,501360888160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176886Inst : IEnumerable<long>
{
public static readonly long[] Value=A176886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176886.Bytes);
public long this[int i]=>Value[i];

public static A176886Inst Instance=new A176886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176887
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,2L,1L,0L,1L,7L,3L,1L,3L,8L,5L,0L,13L,8L,14L,9L,9L,9L,19L,13L,9L,15L,16L,15L,28L,10L,29L,17L,17L,21L,38L,24L,25L,19L,0L,25L,43L,44L,20L,29L,49L,31L,1L,37L,31L,38L,35L,58L,29L,37L,0L,67L,41L,68L,51L,8L,47L,77L,49L,46L,58L,49L,7L,82L,51L,59L,47L,51L,83L,11L,53L,66L,92L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176887Inst : IEnumerable<long>
{
public static readonly long[] Value=A176887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176887.Bytes);
public long this[int i]=>Value[i];

public static A176887Inst Instance=new A176887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176888
{
public static readonly long[] Value={ 1L,2L,12L,16L,18L,28L,30L,36L,40L,42L,52L,60L,66L,70L,72L,78L,88L,96L,100L,102L,108L,112L,126L,130L,136L,138L,148L,150L,156L,162L,172L,180L,190L,192L,196L,198L,210L,222L,228L,232L,238L,240L,250L,256L,268L,270L,276L,280L,282L,292L,306L,310L,312L,316L,330L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176888Inst : IEnumerable<long>
{
public static readonly long[] Value=A176888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176888.Bytes);
public long this[int i]=>Value[i];

public static A176888Inst Instance=new A176888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176889
{
public static readonly long[] Value={ 1L,2L,1L,8L,1L,18L,1L,32L,1L,50L,1L,72L,1L,98L,1L,128L,1L,162L,1L,200L,1L,242L,1L,288L,1L,338L,1L,392L,1L,450L,1L,512L,1L,578L,1L,648L,1L,722L,1L,800L,1L,882L,1L,968L,1L,1058L,1L,1152L,1L,1250L,1L,1352L,1L,1458L,1L,1568L,1L,1682L,1L,1800L,1L,1922L,1L,2048L,1L,2178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176889Inst : IEnumerable<long>
{
public static readonly long[] Value=A176889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176889.Bytes);
public long this[int i]=>Value[i];

public static A176889Inst Instance=new A176889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176890
{
public static readonly long[] Value={ -1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176890Inst : IEnumerable<long>
{
public static readonly long[] Value=A176890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176890.Bytes);
public long this[int i]=>Value[i];

public static A176890Inst Instance=new A176890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176891
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,1L,2L,3L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,0L,4L,0L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,5L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,0L,6L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176891Inst : IEnumerable<long>
{
public static readonly long[] Value=A176891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176891.Bytes);
public long this[int i]=>Value[i];

public static A176891Inst Instance=new A176891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176892
{
public static readonly long[] Value={ 2L,3L,23L,33L,223L,323L,233L,333L,2223L,3223L,2323L,3323L,2233L,3233L,2333L,3333L,22223L,32223L,23223L,33223L,22323L,32323L,23323L,33323L,22233L,32233L,23233L,33233L,22333L,32333L,23333L,33333L,222223L,322223L,232223L,332223L,223223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176892Inst : IEnumerable<long>
{
public static readonly long[] Value=A176892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176892.Bytes);
public long this[int i]=>Value[i];

public static A176892Inst Instance=new A176892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176893
{
public static readonly long[] Value={ 2L,3L,6L,9L,12L,18L,18L,27L,24L,36L,36L,54L,36L,54L,54L,81L,48L,72L,72L,108L,72L,108L,108L,162L,72L,108L,108L,162L,108L,162L,162L,243L,96L,144L,144L,216L,144L,216L,216L,324L,144L,216L,216L,324L,216L,324L,324L,486L,144L,216L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176893Inst : IEnumerable<long>
{
public static readonly long[] Value=A176893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176893.Bytes);
public long this[int i]=>Value[i];

public static A176893Inst Instance=new A176893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176894
{
public static readonly long[] Value={ 2L,3L,32L,33L,322L,323L,332L,333L,3222L,3223L,3232L,3233L,3322L,3323L,3332L,3333L,32222L,32223L,32232L,32233L,32322L,32323L,32332L,32333L,33222L,33223L,33232L,33233L,33322L,33323L,33332L,33333L,322222L,322223L,322232L,322233L,322322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176894Inst : IEnumerable<long>
{
public static readonly long[] Value=A176894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176894.Bytes);
public long this[int i]=>Value[i];

public static A176894Inst Instance=new A176894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176895
{
public static readonly long[] Value={ 1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L,4L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176895Inst : IEnumerable<long>
{
public static readonly long[] Value=A176895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176895.Bytes);
public long this[int i]=>Value[i];

public static A176895Inst Instance=new A176895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176896
{
public static readonly long[] Value={ 9L,21L,51L,69L,77L,93L,111L,115L,155L,183L,187L,213L,237L,247L,259L,267L,287L,291L,319L,323L,339L,355L,371L,403L,407L,411L,413L,427L,437L,453L,471L,519L,535L,579L,583L,591L,597L,611L,629L,655L,669L,671L,679L,717L,723L,731L,755L,763L,789L,791L,807L,815L,831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176896Inst : IEnumerable<long>
{
public static readonly long[] Value=A176896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176896.Bytes);
public long this[int i]=>Value[i];

public static A176896Inst Instance=new A176896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176897
{
public static readonly long[] Value={ 2L,7L,11L,17L,19L,23L,29L,31L,41L,43L,47L,53L,59L,67L,71L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,163L,167L,173L,179L,181L,191L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,281L,283L,293L,307L,311L,317L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176897Inst : IEnumerable<long>
{
public static readonly long[] Value=A176897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176897.Bytes);
public long this[int i]=>Value[i];

public static A176897Inst Instance=new A176897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176898
{
public static readonly BigInteger[] Value={ 5L,231L,14586L,1062347L,84021990L,7012604550L,607892634420L,54200780036595L,4938927219474990L,457909109348466930L,BigInteger.Parse("43057935618181929900"),BigInteger.Parse("4096531994713828810686"),BigInteger.Parse("393617202432246696493436"),BigInteger.Parse("38142088615983865845923052"),BigInteger.Parse("3723160004902167033863327592") };
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
public class A176898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176898Inst Instance=new A176898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176899
{
public static readonly long[] Value={ 361L,1225L,11025L,15129L,15625L,21025L,23104L,36100L,105625L,119025L,122500L,171396L,251001L,262144L,311364L,1010025L,1050625L,1071225L,1102500L,1113025L,1134225L,1151329L,1311025L,1512900L,1562500L,2102500L,2111209L,2175625L,2310400L,3610000L,4515625L,5116644L,6155361L,9150625L,10017225L,10562500L,11015761L,11390625L,11902500L,12250000L,13097161L,15405625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176899Inst : IEnumerable<long>
{
public static readonly long[] Value=A176899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176899.Bytes);
public long this[int i]=>Value[i];

public static A176899Inst Instance=new A176899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176900
{
public static readonly long[] Value={ 1L,-4L,-24L,-32L,80L,384L,448L,-1024L,-4608L,-5120L,11264L,49152L,53248L,-114688L,-491520L,-524288L,1114112L,4718592L,4980736L,-10485760L,-44040192L,-46137344L,96468992L,402653184L,419430400L,-872415232L,-3623878656L,-3758096384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176900Inst : IEnumerable<long>
{
public static readonly long[] Value=A176900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176900.Bytes);
public long this[int i]=>Value[i];

public static A176900Inst Instance=new A176900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176901
{
public static readonly long[] Value={ 4L,72L,1584L,70720L,3948480L,284570496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176901Inst : IEnumerable<long>
{
public static readonly long[] Value=A176901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176901.Bytes);
public long this[int i]=>Value[i];

public static A176901Inst Instance=new A176901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176902
{
public static readonly long[] Value={ 2L,17L,19L,29L,31L,41L,43L,53L,67L,71L,79L,89L,97L,101L,103L,109L,113L,127L,131L,137L,139L,149L,151L,163L,173L,181L,191L,197L,199L,211L,223L,229L,233L,239L,241L,251L,257L,269L,271L,281L,283L,293L,307L,311L,317L,331L,337L,349L,353L,367L,373L,379L,389L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176902Inst : IEnumerable<long>
{
public static readonly long[] Value=A176902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176902.Bytes);
public long this[int i]=>Value[i];

public static A176902Inst Instance=new A176902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176903
{
public static readonly BigInteger[] Value={ 3L,7L,13L,61L,2521L,55441L,4324321L,367567201L,6064949221531201L,9200527969062830401L,BigInteger.Parse("37188534050951960476801"),BigInteger.Parse("8201519488959040182625924708238885435575055666675808001") };
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
public class A176903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176903Inst Instance=new A176903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176904
{
public static readonly long[] Value={ 3L,8L,24L,64L,7776L,20736L,13824L,36864L,45349632L,120932352L,80621568L,214990848L,322486272L,859963392L,573308928L,1528823808L,1028294561267712L,2742118830047232L,1828079220031488L,4874877920083968L,7312316880125952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176904Inst : IEnumerable<long>
{
public static readonly long[] Value=A176904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176904.Bytes);
public long this[int i]=>Value[i];

public static A176904Inst Instance=new A176904Inst();

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