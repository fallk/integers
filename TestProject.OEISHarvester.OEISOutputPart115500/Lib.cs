using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A285805
{
public static readonly long[] Value={ 31L,41L,71L,79L,89L,97L,139L,149L,167L,179L,191L,193L,211L,223L,251L,281L,307L,337L,349L,353L,401L,409L,419L,421L,431L,433L,479L,487L,491L,499L,509L,521L,541L,547L,563L,571L,587L,619L,631L,643L,659L,673L,677L,691L,701L,719L,739L,757L,769L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285805Inst : IEnumerable<long>
{
public static readonly long[] Value=A285805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285805.Bytes);
public long this[int i]=>Value[i];

public static A285805Inst Instance=new A285805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285806
{
public static readonly long[] Value={ 6L,27L,11L,220L,92L,28L,1765L,741L,229L,37L,14126L,5934L,1838L,302L,46L,113015L,47479L,14711L,2423L,375L,55L,1808248L,759672L,235384L,38776L,6008L,888L,120L,28931977L,12154761L,3766153L,620425L,96137L,14217L,1929L,137L,462911642L,194476186L,60258458L,9926810L,1538202L,227482L,30874L,2202L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285806Inst : IEnumerable<long>
{
public static readonly long[] Value=A285806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285806.Bytes);
public long this[int i]=>Value[i];

public static A285806Inst Instance=new A285806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285807
{
public static readonly long[] Value={ 12L,123L,23L,1234L,234L,34L,12345L,2345L,345L,45L,123456L,23456L,3456L,456L,56L,1234567L,234567L,34567L,4567L,567L,67L,12345678L,2345678L,345678L,45678L,5678L,678L,78L,123456789L,23456789L,3456789L,456789L,56789L,6789L,789L,89L,12345678910L,2345678910L,345678910L,45678910L,5678910L,678910L,78910L,8910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285807Inst : IEnumerable<long>
{
public static readonly long[] Value=A285807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285807.Bytes);
public long this[int i]=>Value[i];

public static A285807Inst Instance=new A285807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285808
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,8L,3L,1L,15L,2L,3L,2L,8L,3L,1L,9L,10L,2L,6L,12L,7L,10L,10L,4L,5L,8L,36L,3L,10L,25L,1L,6L,8L,4L,1L,11L,20L,3L,6L,1L,10L,28L,6L,36L,20L,12L,15L,4L,31L,25L,8L,1L,6L,9L,19L,8L,16L,12L,10L,2L,1L,17L,11L,19L,11L,9L,5L,21L,22L,3L,4L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285808Inst : IEnumerable<long>
{
public static readonly long[] Value=A285808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285808.Bytes);
public long this[int i]=>Value[i];

public static A285808Inst Instance=new A285808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285809
{
public static readonly long[] Value={ 2L,5L,11L,47L,137L,167L,317L,461L,761L,977L,1307L,1787L,2111L,2711L,3677L,4457L,5861L,7247L,7457L,9011L,10211L,13397L,15761L,17987L,22511L,23627L,43607L,45677L,54437L,56747L,58511L,61511L,63347L,65837L,66467L,79697L,82487L,88211L,90407L,93377L,97157L,108947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285809Inst : IEnumerable<long>
{
public static readonly long[] Value=A285809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285809.Bytes);
public long this[int i]=>Value[i];

public static A285809Inst Instance=new A285809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285810
{
public static readonly long[] Value={ 2L,7L,17L,107L,227L,277L,457L,857L,1627L,3517L,4517L,5407L,9767L,11057L,13877L,15017L,16607L,20477L,23767L,26267L,27827L,35107L,37517L,41927L,42577L,50767L,53657L,58907L,62017L,68477L,79657L,83267L,86027L,93607L,98507L,110777L,113957L,128257L,137477L,145807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285810Inst : IEnumerable<long>
{
public static readonly long[] Value=A285810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285810.Bytes);
public long this[int i]=>Value[i];

public static A285810Inst Instance=new A285810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285811
{
public static readonly long[] Value={ 2L,23L,107L,149L,317L,1619L,2459L,3257L,3929L,5189L,6029L,6323L,7247L,15017L,19427L,21023L,21569L,26189L,42737L,45887L,55127L,56009L,63317L,66173L,67139L,70079L,82469L,101747L,105359L,110273L,125687L,136523L,137909L,149249L,155087L,159539L,167099L,171719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285811Inst : IEnumerable<long>
{
public static readonly long[] Value=A285811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285811.Bytes);
public long this[int i]=>Value[i];

public static A285811Inst Instance=new A285811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285812
{
public static readonly long[] Value={ 2L,11L,29L,137L,191L,821L,947L,2081L,2927L,3917L,5051L,6329L,11027L,13367L,14879L,15401L,17021L,17579L,21737L,22367L,24977L,36857L,39341L,43661L,47279L,50087L,58997L,62129L,66431L,70877L,95267L,96581L,106031L,113051L,117371L,129287L,130817L,135461L,156521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285812Inst : IEnumerable<long>
{
public static readonly long[] Value=A285812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285812.Bytes);
public long this[int i]=>Value[i];

public static A285812Inst Instance=new A285812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286407
{
public static readonly long[] Value={ 1L,1L,10L,10L,110L,110L,1110L,1110L,11110L,11100L,111100L,111100L,1111100L,1111110L,11111100L,11111110L,111111100L,111111110L,1111111100L,1111111100L,11111111110L,11111111100L,111111111100L,111111111110L,1111111111110L,1111111111110L,11111111111110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286407Inst : IEnumerable<long>
{
public static readonly long[] Value=A286407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286407.Bytes);
public long this[int i]=>Value[i];

public static A286407Inst Instance=new A286407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286408
{
public static readonly ulong[] Value={ 1L,10L,10L,100L,1100L,11000L,111000L,1110000L,11110000L,11100000L,111100000L,1111000000L,11111000000L,1111110000000L,1111110000000L,111111100000000L,111111100000000L,11111111000000000L,11111111000000000L,111111110000000000L,11111111110000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286408Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286408.Bytes);
public ulong this[int i]=>Value[i];

public static A286408Inst Instance=new A286408Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286409
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,14L,14L,30L,28L,60L,60L,124L,126L,252L,254L,508L,510L,1020L,1020L,2046L,2044L,4092L,4094L,8190L,8190L,16382L,16382L,32766L,32766L,65534L,65534L,131070L,131070L,262142L,262142L,524286L,518142L,1047550L,1032702L,2081278L,2095102L,4178430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286409Inst : IEnumerable<long>
{
public static readonly long[] Value=A286409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286409.Bytes);
public long this[int i]=>Value[i];

public static A286409Inst Instance=new A286409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286410
{
public static readonly long[] Value={ 1L,2L,2L,4L,12L,24L,56L,112L,240L,224L,480L,960L,1984L,8064L,8064L,32512L,32512L,130560L,130560L,261120L,1047552L,1046528L,2095104L,8384512L,16773120L,33546240L,67100672L,134201344L,268419072L,536838144L,1073709056L,2147418112L,4294901760L,8589803520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286410Inst : IEnumerable<long>
{
public static readonly long[] Value=A286410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286410.Bytes);
public long this[int i]=>Value[i];

public static A286410Inst Instance=new A286410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286411
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,11L,111100L,1111L,11110110L,1001L,1111111110L,11L,111111101100L,111011L,11111111101100L,10011000L,1111111101100011L,1111110L,111111111101101010L,111100110L,11111111111111100110UL,100111110L,BigInteger.Parse("1111111111111011100110"),111100110L };
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
public class A286411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286411Inst Instance=new A286411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286412
{
public static readonly ulong[] Value={ 1L,1L,110L,11L,11000L,1111L,1111000L,1101111L,100100000L,111111111L,11000000000L,1101111111L,1101110000000L,110111111111L,110010000000L,1100011011111111L,1111110000000000L,10101101111111111L,110011110000000000L,1100111111111111111L,11111001000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286412Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286412.Bytes);
public ulong this[int i]=>Value[i];

public static A286412Inst Instance=new A286412Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286413
{
public static readonly long[] Value={ 1L,2L,3L,12L,3L,60L,15L,246L,9L,1022L,3L,4076L,59L,16364L,152L,65379L,126L,261994L,486L,1048550L,318L,4194022L,486L,16775486L,3558L,67108838L,1854L,268434662L,14310L,1073730494L,45670L,4294931366L,15742L,17179824806L,126310L,68719366334L,110822L,274877865894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286413Inst : IEnumerable<long>
{
public static readonly long[] Value=A286413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286413.Bytes);
public long this[int i]=>Value[i];

public static A286413Inst Instance=new A286413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286414
{
public static readonly long[] Value={ 1L,1L,6L,3L,24L,15L,120L,111L,288L,511L,1536L,895L,7040L,3583L,3200L,50943L,64512L,89087L,211968L,425983L,1019904L,1695743L,3391488L,8167423L,13590528L,27262975L,65470464L,108265471L,217939968L,527630335L,858161152L,1708064767L,4252499968L,6797656063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286414Inst : IEnumerable<long>
{
public static readonly long[] Value=A286414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286414.Bytes);
public long this[int i]=>Value[i];

public static A286414Inst Instance=new A286414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286415
{
public static readonly long[] Value={ 19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,173L,271L,277L,313L,379L,397L,419L,479L,491L,571L,577L,593L,617L,631L,673L,811L,839L,877L,911L,977L,1777L,1913L,2131L,2311L,2377L,2399L,2713L,2791L,2939L,2971L,4177L,4339L,4919L,4993L,5119L,5791L,6133L,6737L,6997L,7193L,7333L,7919L,8111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286415Inst : IEnumerable<long>
{
public static readonly long[] Value=A286415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286415.Bytes);
public long this[int i]=>Value[i];

public static A286415Inst Instance=new A286415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286416
{
public static readonly long[] Value={ 1L,3L,1L,8L,6L,1L,24L,25L,10L,1L,83L,98L,63L,15L,1L,324L,399L,338L,135L,21L,1L,1400L,1746L,1727L,980L,257L,28L,1L,6609L,8271L,8874L,6426L,2455L,448L,36L,1L,33758L,42284L,47191L,40334L,20506L,5474L,730L,45L,1L,185136L,231939L,263458L,250839L,158827L,57239L,11128L,1128L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286416Inst : IEnumerable<long>
{
public static readonly long[] Value=A286416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286416.Bytes);
public long this[int i]=>Value[i];

public static A286416Inst Instance=new A286416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286417
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,6L,4L,9L,11L,13L,15L,18L,10L,21L,23L,26L,14L,29L,8L,17L,36L,19L,20L,12L,16L,25L,39L,43L,22L,24L,31L,32L,34L,69L,37L,75L,78L,35L,41L,45L,44L,53L,47L,48L,49L,71L,52L,27L,28L,50L,58L,55L,30L,59L,64L,65L,33L,67L,138L,70L,141L,73L,38L,77L,57L,61L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286417Inst : IEnumerable<long>
{
public static readonly long[] Value=A286417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286417.Bytes);
public long this[int i]=>Value[i];

public static A286417Inst Instance=new A286417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286418
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,7L,14L,14L,7L,37L,170L,312L,170L,37L,197L,2904L,13945L,13945L,2904L,197L,1172L,74779L,1241696L,3228524L,1241696L,74779L,1172L,8018L,2751790L,196846257L,1723178763L,1723178763L,196846257L,2751790L,8018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286418Inst : IEnumerable<long>
{
public static readonly long[] Value=A286418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286418.Bytes);
public long this[int i]=>Value[i];

public static A286418Inst Instance=new A286418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286419
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286419Inst : IEnumerable<long>
{
public static readonly long[] Value=A286419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286419.Bytes);
public long this[int i]=>Value[i];

public static A286419Inst Instance=new A286419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286420
{
public static readonly long[] Value={ 1L,7L,8L,10L,15L,18L,19L,25L,26L,28L,31L,32L,37L,43L,44L,46L,51L,54L,55L,60L,66L,67L,69L,72L,73L,79L,80L,82L,87L,90L,91L,97L,98L,100L,103L,104L,109L,115L,116L,118L,121L,122L,128L,129L,131L,136L,139L,140L,145L,151L,152L,154L,159L,162L,163L,169L,170L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286420Inst : IEnumerable<long>
{
public static readonly long[] Value=A286420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286420.Bytes);
public long this[int i]=>Value[i];

public static A286420Inst Instance=new A286420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286421
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,11L,12L,13L,14L,16L,17L,20L,21L,22L,23L,24L,27L,29L,30L,33L,34L,35L,36L,38L,39L,40L,41L,42L,45L,47L,48L,49L,50L,52L,53L,56L,57L,58L,59L,61L,62L,63L,64L,65L,68L,70L,71L,74L,75L,76L,77L,78L,81L,83L,84L,85L,86L,88L,89L,92L,93L,94L,95L,96L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286421Inst : IEnumerable<long>
{
public static readonly long[] Value=A286421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286421.Bytes);
public long this[int i]=>Value[i];

public static A286421Inst Instance=new A286421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286422
{
public static readonly BigInteger[] Value={ 2L,12L,130L,9492L,1166928L,1431128744L,2907639077764L,76670800431934272L,BigInteger.Parse("3341096345926174809912"),BigInteger.Parse("2311650738313947870105792416"),BigInteger.Parse("2645105778378736719464340469683304"),BigInteger.Parse("56641723029988800376624313271476598959936") };
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
public class A286422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286422Inst Instance=new A286422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286471
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,1L,1L,3L,0L,1L,0L,4L,2L,1L,0L,2L,0L,1L,3L,5L,0L,1L,1L,6L,1L,1L,0L,2L,0L,1L,4L,7L,2L,1L,0L,8L,5L,1L,0L,2L,0L,1L,1L,9L,0L,1L,1L,3L,6L,1L,0L,2L,3L,1L,7L,10L,0L,1L,0L,11L,1L,1L,4L,2L,0L,1L,8L,3L,0L,1L,0L,12L,2L,1L,2L,2L,0L,1L,1L,13L,0L,1L,5L,14L,9L,1L,0L,2L,3L,1L,10L,15L,6L,1L,0L,4L,1L,1L,0L,2L,0L,1L,2L,16L,0L,1L,0L,3L,11L,1L,0L,2L,7L,1L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286471Inst : IEnumerable<long>
{
public static readonly long[] Value=A286471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286471.Bytes);
public long this[int i]=>Value[i];

public static A286471Inst Instance=new A286471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286472
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,6L,11L,2L,12L,2L,15L,10L,16L,2L,18L,2L,20L,15L,23L,2L,24L,10L,27L,18L,28L,2L,30L,2L,32L,23L,35L,14L,36L,2L,39L,27L,40L,2L,42L,2L,44L,30L,47L,2L,48L,14L,51L,35L,52L,2L,54L,23L,56L,39L,59L,2L,60L,2L,63L,42L,64L,27L,66L,2L,68L,47L,71L,2L,72L,2L,75L,50L,76L,22L,78L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286472Inst : IEnumerable<long>
{
public static readonly long[] Value=A286472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286472.Bytes);
public long this[int i]=>Value[i];

public static A286472Inst Instance=new A286472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286473
{
public static readonly long[] Value={ 1L,6L,7L,10L,5L,14L,7L,18L,15L,22L,7L,26L,5L,30L,23L,34L,5L,38L,7L,42L,31L,46L,7L,50L,21L,54L,39L,58L,5L,62L,7L,66L,47L,70L,29L,74L,5L,78L,55L,82L,5L,86L,7L,90L,63L,94L,7L,98L,31L,102L,71L,106L,5L,110L,45L,114L,79L,118L,7L,122L,5L,126L,87L,130L,53L,134L,7L,138L,95L,142L,7L,146L,5L,150L,103L,154L,47L,158L,7L,162L,111L,166L,7L,170L,69L,174L,119L,178L,5L,182L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286473Inst : IEnumerable<long>
{
public static readonly long[] Value=A286473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286473.Bytes);
public long this[int i]=>Value[i];

public static A286473Inst Instance=new A286473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286474
{
public static readonly long[] Value={ 1L,6L,7L,8L,5L,14L,7L,16L,13L,22L,7L,24L,5L,30L,23L,32L,5L,38L,7L,40L,29L,46L,7L,48L,21L,54L,39L,56L,5L,62L,7L,64L,45L,70L,31L,72L,5L,78L,55L,80L,5L,86L,7L,88L,61L,94L,7L,96L,29L,102L,71L,104L,5L,110L,47L,112L,77L,118L,7L,120L,5L,126L,87L,128L,53L,134L,7L,136L,93L,142L,7L,144L,5L,150L,103L,152L,45L,158L,7L,160L,109L,166L,7L,168L,69L,174L,119L,176L,5L,182L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286474Inst : IEnumerable<long>
{
public static readonly long[] Value=A286474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286474.Bytes);
public long this[int i]=>Value[i];

public static A286474Inst Instance=new A286474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286475
{
public static readonly long[] Value={ 1L,8L,9L,14L,11L,20L,7L,26L,21L,32L,11L,38L,7L,44L,33L,50L,11L,56L,7L,62L,45L,68L,11L,74L,35L,80L,57L,86L,11L,92L,7L,98L,69L,104L,47L,110L,7L,116L,81L,122L,11L,128L,7L,134L,93L,140L,11L,146L,43L,152L,105L,158L,11L,164L,71L,170L,117L,176L,11L,182L,7L,188L,129L,194L,83L,200L,7L,206L,141L,212L,11L,218L,7L,224L,153L,230L,67L,236L,7L,242L,165L,248L,11L,254L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286475Inst : IEnumerable<long>
{
public static readonly long[] Value=A286475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286475.Bytes);
public long this[int i]=>Value[i];

public static A286475Inst Instance=new A286475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286476
{
public static readonly long[] Value={ 1L,8L,9L,16L,11L,18L,7L,26L,21L,34L,11L,36L,7L,44L,33L,52L,11L,54L,7L,62L,45L,70L,11L,72L,31L,80L,57L,88L,11L,90L,7L,98L,69L,106L,47L,108L,7L,116L,81L,124L,11L,126L,7L,134L,93L,142L,11L,144L,43L,152L,105L,160L,11L,162L,67L,170L,117L,178L,11L,180L,7L,188L,129L,196L,83L,198L,7L,206L,141L,214L,11L,216L,7L,224L,153L,232L,71L,234L,7L,242L,165L,250L,11L,252L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286476Inst : IEnumerable<long>
{
public static readonly long[] Value=A286476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286476.Bytes);
public long this[int i]=>Value[i];

public static A286476Inst Instance=new A286476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286477
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,5L,1L,2L,1L,6L,1L,7L,1L,2L,1L,8L,1L,9L,1L,2L,1L,10L,1L,3L,1L,2L,1L,11L,1L,12L,1L,2L,1L,3L,1L,13L,1L,2L,1L,14L,1L,15L,1L,2L,1L,16L,1L,4L,1L,2L,1L,17L,1L,3L,1L,2L,1L,18L,1L,19L,1L,2L,1L,3L,1L,20L,1L,2L,1L,21L,1L,22L,1L,2L,1L,4L,1L,23L,1L,2L,1L,24L,1L,3L,1L,2L,1L,25L,1L,4L,1L,2L,1L,3L,1L,26L,1L,2L,1L,27L,1L,28L,1L,2L,1L,29L,1L,30L,1L,2L,1L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286477Inst : IEnumerable<long>
{
public static readonly long[] Value=A286477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286477.Bytes);
public long this[int i]=>Value[i];

public static A286477Inst Instance=new A286477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286478
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,3L,4L,2L,3L,1L,5L,4L,5L,2L,3L,1L,6L,4L,5L,2L,3L,1L,4L,6L,7L,7L,8L,6L,8L,9L,10L,7L,8L,4L,11L,9L,10L,5L,6L,2L,11L,7L,8L,3L,4L,1L,9L,12L,13L,12L,13L,9L,14L,14L,15L,10L,11L,5L,16L,12L,13L,6L,7L,2L,14L,8L,9L,3L,4L,1L,15L,17L,18L,15L,16L,10L,19L,17L,18L,11L,12L,5L,19L,13L,14L,6L,7L,2L,15L,8L,9L,3L,4L,1L,20L,20L,21L,16L,17L,10L,22L,18L,19L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286478Inst : IEnumerable<long>
{
public static readonly long[] Value=A286478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286478.Bytes);
public long this[int i]=>Value[i];

public static A286478Inst Instance=new A286478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286479
{
public static readonly long[] Value={ 2L,4L,2L,2L,2L,6L,4L,12L,12L,6L,2L,12L,6L,12L,2L,6L,2L,24L,6L,6L,4L,6L,4L,32L,12L,30L,2L,6L,2L,6L,6L,6L,2L,6L,6L,12L,6L,30L,2L,48L,2L,12L,12L,12L,6L,12L,4L,6L,12L,24L,6L,6L,6L,6L,2L,64L,2L,6L,2L,72L,12L,30L,6L,2L,6L,6L,6L,6L,2L,30L,2L,60L,12L,30L,16L,6L,16L,6L,16L,60L,6L,6L,6L,96L,2L,60L,6L,96L,6L,30L,6L,12L,2L,12L,12L,72L,12L,24L,30L,2L,2L,30L,30L,48L,2L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286479Inst : IEnumerable<long>
{
public static readonly long[] Value=A286479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286479.Bytes);
public long this[int i]=>Value[i];

public static A286479Inst Instance=new A286479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286480
{
public static readonly long[] Value={ 2L,12L,5L,14L,5L,61L,12L,179L,109L,61L,5L,265L,23L,142L,27L,226L,5L,607L,23L,148L,42L,61L,12L,1509L,109L,601L,44L,148L,5L,625L,23L,698L,27L,61L,61L,1117L,23L,601L,27L,2509L,5L,850L,80L,265L,148L,142L,12L,1426L,109L,607L,61L,148L,23L,430L,27L,3765L,27L,61L,5L,8575L,80L,601L,148L,2144L,61L,625L,23L,148L,27L,1741L,5L,8587L,80L,601L,363L,148L,216L,625L,138L,5719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286480Inst : IEnumerable<long>
{
public static readonly long[] Value=A286480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286480.Bytes);
public long this[int i]=>Value[i];

public static A286480Inst Instance=new A286480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286481
{
public static readonly long[] Value={ 1003062289999939142L,1003062299899939142L,1003062389989939142L,1003062399889939142L,1003062489979939142L,1003062499879939142L,1003062589969939142L,1003062599869939142L,1003062689959939142L,1003062699859939142L,1003062789949939142L,1003062799849939142L,1003062889939939142L,1003062899839939142L,1003062989929939142L,1003062999829939142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286481Inst : IEnumerable<long>
{
public static readonly long[] Value=A286481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286481.Bytes);
public long this[int i]=>Value[i];

public static A286481Inst Instance=new A286481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286482
{
public static readonly long[] Value={ 1L,1L,6L,6L,26L,12L,42L,6L,24L,2L,48L,2L,64L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286482Inst : IEnumerable<long>
{
public static readonly long[] Value=A286482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286482.Bytes);
public long this[int i]=>Value[i];

public static A286482Inst Instance=new A286482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286483
{
public static readonly BigInteger[] Value={ 1L,0L,5L,0L,238L,0L,51508L,0L,35028576L,0L,59053389408L,0L,209726098354368L,0L,1397532391623302400L,0L,BigInteger.Parse("16043549794523492290560"),0L,BigInteger.Parse("297285345537576037788672000"),0L,BigInteger.Parse("8447414796960536731803240038400") };
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
public class A286483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286483.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286483Inst Instance=new A286483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286484
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286484Inst : IEnumerable<long>
{
public static readonly long[] Value=A286484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286484.Bytes);
public long this[int i]=>Value[i];

public static A286484Inst Instance=new A286484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286485
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,13L,15L,18L,19L,22L,24L,25L,28L,31L,32L,35L,37L,40L,42L,43L,46L,49L,51L,54L,55L,58L,60L,63L,65L,66L,69L,72L,73L,76L,78L,79L,82L,85L,87L,90L,91L,94L,96L,97L,100L,103L,104L,107L,109L,112L,114L,115L,118L,121L,122L,125L,127L,128L,131L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286485Inst : IEnumerable<long>
{
public static readonly long[] Value=A286485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286485.Bytes);
public long this[int i]=>Value[i];

public static A286485Inst Instance=new A286485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286486
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,11L,12L,14L,16L,17L,20L,21L,23L,26L,27L,29L,30L,33L,34L,36L,38L,39L,41L,44L,45L,47L,48L,50L,52L,53L,56L,57L,59L,61L,62L,64L,67L,68L,70L,71L,74L,75L,77L,80L,81L,83L,84L,86L,88L,89L,92L,93L,95L,98L,99L,101L,102L,105L,106L,108L,110L,111L,113L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286486Inst : IEnumerable<long>
{
public static readonly long[] Value=A286486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286486.Bytes);
public long this[int i]=>Value[i];

public static A286486Inst Instance=new A286486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286535
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,5L,2L,3L,4L,5L,4L,6L,6L,7L,2L,3L,4L,5L,4L,6L,6L,7L,4L,6L,8L,9L,6L,10L,9L,11L,2L,3L,4L,5L,4L,6L,6L,7L,4L,6L,8L,9L,6L,10L,9L,11L,4L,6L,8L,9L,8L,12L,12L,13L,6L,10L,12L,14L,9L,14L,13L,15L,2L,3L,4L,5L,4L,6L,6L,7L,4L,6L,8L,9L,6L,10L,9L,11L,4L,6L,8L,9L,8L,12L,12L,13L,6L,10L,12L,14L,9L,14L,13L,15L,4L,6L,8L,9L,8L,12L,12L,13L,8L,12L,16L,17L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286535Inst : IEnumerable<long>
{
public static readonly long[] Value=A286535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286535.Bytes);
public long this[int i]=>Value[i];

public static A286535Inst Instance=new A286535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286536
{
public static readonly long[] Value={ 2L,4L,2L,4L,8L,2L,6L,4L,12L,8L,2L,16L,12L,6L,6L,4L,12L,12L,8L,2L,36L,32L,12L,24L,12L,6L,16L,30L,24L,6L,6L,4L,12L,12L,12L,8L,2L,36L,72L,32L,12L,60L,72L,12L,24L,12L,6L,36L,48L,30L,64L,48L,60L,24L,30L,24L,6L,16L,30L,60L,24L,6L,6L,4L,12L,12L,12L,12L,8L,2L,36L,72L,72L,32L,12L,60L,180L,72L,12L,60L,72L,12L,24L,12L,6L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286536Inst : IEnumerable<long>
{
public static readonly long[] Value=A286536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286536.Bytes);
public long this[int i]=>Value[i];

public static A286536Inst Instance=new A286536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286537
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,4L,2L,5L,3L,1L,6L,5L,4L,4L,2L,5L,5L,3L,1L,7L,8L,5L,9L,5L,4L,6L,10L,9L,4L,4L,2L,5L,5L,5L,3L,1L,7L,11L,8L,5L,12L,11L,5L,9L,5L,4L,7L,13L,10L,14L,13L,12L,9L,10L,9L,4L,6L,10L,12L,9L,4L,4L,2L,5L,5L,5L,5L,3L,1L,7L,11L,11L,8L,5L,12L,15L,11L,5L,12L,11L,5L,9L,5L,4L,7L,15L,13L,10L,16L,17L,13L,18L,15L,12L,12L,19L,10L,20L,13L,12L,9L,10L,9L,4L,7L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286537Inst : IEnumerable<long>
{
public static readonly long[] Value=A286537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286537.Bytes);
public long this[int i]=>Value[i];

public static A286537Inst Instance=new A286537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286538
{
public static readonly long[] Value={ 2L,2L,4L,2L,6L,8L,4L,2L,6L,12L,16L,6L,12L,8L,4L,2L,6L,12L,24L,32L,6L,30L,36L,12L,24L,16L,6L,12L,12L,8L,4L,2L,6L,12L,24L,48L,64L,6L,30L,60L,72L,12L,60L,72L,24L,48L,32L,6L,30L,36L,30L,60L,36L,12L,24L,24L,16L,6L,12L,12L,12L,8L,4L,2L,6L,12L,24L,48L,96L,128L,6L,30L,60L,120L,144L,12L,60L,180L,216L,24L,120L,144L,48L,96L,64L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286538Inst : IEnumerable<long>
{
public static readonly long[] Value=A286538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286538.Bytes);
public long this[int i]=>Value[i];

public static A286538Inst Instance=new A286538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286539
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,2L,1L,3L,5L,6L,3L,5L,4L,2L,1L,3L,5L,7L,8L,3L,9L,10L,5L,7L,6L,3L,5L,5L,4L,2L,1L,3L,5L,7L,11L,12L,3L,9L,13L,14L,5L,13L,14L,7L,11L,8L,3L,9L,10L,9L,13L,10L,5L,7L,7L,6L,3L,5L,5L,5L,4L,2L,1L,3L,5L,7L,11L,15L,16L,3L,9L,13L,17L,18L,5L,13L,19L,20L,7L,17L,18L,11L,15L,12L,3L,9L,13L,14L,9L,21L,19L,13L,19L,14L,5L,13L,14L,13L,17L,14L,7L,11L,11L,8L,3L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286539Inst : IEnumerable<long>
{
public static readonly long[] Value=A286539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286539.Bytes);
public long this[int i]=>Value[i];

public static A286539Inst Instance=new A286539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286540
{
public static readonly long[] Value={ 2L,2L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,1L,1L,1L,3L,8L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,6L,2L,2L,6L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,8L,8L,24L,18L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286540Inst : IEnumerable<long>
{
public static readonly long[] Value=A286540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286540.Bytes);
public long this[int i]=>Value[i];

public static A286540Inst Instance=new A286540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286541
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,5L,5L,5L,8L,13L,19L,19L,25L,25L,25L,25L,32L,41L,51L,62L,62L,73L,86L,86L,99L,99L,99L,113L,113L,113L,113L,113L,128L,145L,163L,182L,202L,202L,222L,244L,267L,267L,290L,315L,315L,340L,340L,340L,366L,394L,394L,422L,422L,422L,451L,451L,451L,451L,481L,481L,481L,481L,481L,481L,512L,545L,579L,614L,650L,687L,687L,724L,763L,803L,844L,844L,885L,928L,972L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286541Inst : IEnumerable<long>
{
public static readonly long[] Value=A286541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286541.Bytes);
public long this[int i]=>Value[i];

public static A286541Inst Instance=new A286541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286542
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,2L,8L,6L,12L,6L,8L,6L,4L,2L,16L,210L,12L,6L,12L,30L,12L,210L,16L,6L,12L,30L,8L,30L,4L,2L,32L,210L,420L,210L,12L,30L,12L,6L,24L,210L,60L,30L,24L,30030L,420L,30L,32L,30L,12L,6L,24L,210L,60L,30030L,16L,210L,60L,30L,8L,30L,4L,2L,64L,510510L,420L,210L,420L,30030L,420L,210L,24L,210L,60L,30030L,12L,6L,12L,6L,36L,2310L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286542Inst : IEnumerable<long>
{
public static readonly long[] Value=A286542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286542.Bytes);
public long this[int i]=>Value[i];

public static A286542Inst Instance=new A286542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286543
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,2L,5L,4L,6L,4L,5L,4L,3L,2L,7L,8L,6L,4L,6L,9L,6L,8L,7L,4L,6L,9L,5L,9L,3L,2L,10L,8L,11L,8L,6L,9L,6L,4L,12L,8L,13L,9L,12L,14L,11L,9L,10L,9L,6L,4L,12L,8L,13L,14L,7L,8L,13L,9L,5L,9L,3L,2L,15L,16L,11L,8L,11L,14L,11L,8L,12L,8L,13L,14L,6L,4L,6L,4L,17L,18L,11L,14L,13L,9L,13L,9L,6L,19L,20L,14L,11L,14L,13L,14L,15L,18L,13L,14L,6L,18L,6L,4L,6L,18L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286543Inst : IEnumerable<long>
{
public static readonly long[] Value=A286543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286543.Bytes);
public long this[int i]=>Value[i];

public static A286543Inst Instance=new A286543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286544
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,4L,6L,5L,7L,6L,8L,9L,9L,5L,10L,9L,11L,8L,12L,13L,14L,9L,13L,6L,15L,11L,16L,17L,17L,8L,18L,17L,19L,13L,20L,17L,21L,8L,22L,17L,23L,24L,25L,23L,26L,13L,27L,11L,28L,16L,29L,30L,31L,17L,32L,9L,33L,34L,24L,35L,35L,6L,36L,37L,38L,39L,40L,41L,42L,13L,43L,44L,45L,28L,46L,28L,34L,6L,47L,48L,49L,21L,50L,35L,51L,39L,52L,53L,54L,55L,56L,57L,58L,11L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286544Inst : IEnumerable<long>
{
public static readonly long[] Value=A286544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286544.Bytes);
public long this[int i]=>Value[i];

public static A286544Inst Instance=new A286544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286545
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,4L,4L,4L,2L,5L,2L,4L,6L,6L,2L,7L,4L,8L,6L,4L,2L,9L,10L,4L,8L,8L,2L,11L,4L,8L,6L,4L,6L,12L,6L,6L,6L,13L,4L,11L,2L,14L,14L,6L,2L,15L,6L,16L,6L,8L,4L,17L,8L,18L,14L,6L,4L,19L,4L,6L,14L,13L,6L,11L,6L,14L,14L,20L,4L,21L,4L,8L,16L,14L,8L,17L,4L,22L,20L,6L,2L,23L,8L,6L,8L,22L,4L,24L,25L,13L,8L,4L,13L,26L,8L,14L,13L,27L,4L,17L,6L,20L,20L,6L,4L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286545Inst : IEnumerable<long>
{
public static readonly long[] Value=A286545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286545.Bytes);
public long this[int i]=>Value[i];

public static A286545Inst Instance=new A286545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286546
{
public static readonly long[] Value={ 0L,0L,1L,-1L,3L,1L,-2L,-2L,7L,5L,2L,2L,-4L,-4L,-3L,-5L,15L,13L,10L,10L,4L,4L,5L,3L,-8L,-8L,-7L,-9L,-5L,-7L,-10L,-10L,31L,29L,26L,26L,20L,20L,21L,19L,8L,8L,9L,7L,11L,9L,6L,6L,-16L,-16L,-15L,-17L,-13L,-15L,-18L,-18L,-9L,-11L,-14L,-14L,-20L,-20L,-19L,-21L,63L,61L,58L,58L,52L,52L,53L,51L,40L,40L,41L,39L,43L,41L,38L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286546Inst : IEnumerable<long>
{
public static readonly long[] Value=A286546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286546.Bytes);
public long this[int i]=>Value[i];

public static A286546Inst Instance=new A286546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286547
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,2L,5L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,13L,14L,14L,15L,15L,7L,4L,16L,16L,17L,18L,11L,17L,19L,19L,20L,21L,22L,22L,23L,23L,24L,25L,26L,26L,27L,6L,28L,27L,29L,29L,30L,30L,31L,32L,33L,31L,34L,34L,18L,35L,36L,36L,37L,37L,38L,39L,40L,41L,42L,42L,43L,43L,44L,45L,46L,46L,47L,48L,49L,47L,50L,50L,51L,51L,52L,12L,25L,52L,53L,53L,54L,24L,55L,55L,56L,56L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286547Inst : IEnumerable<long>
{
public static readonly long[] Value=A286547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286547.Bytes);
public long this[int i]=>Value[i];

public static A286547Inst Instance=new A286547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286548
{
public static readonly long[] Value={ 0L,0L,1L,-1L,2L,2L,-1L,-3L,4L,4L,5L,3L,-2L,-2L,-5L,-7L,8L,8L,9L,7L,10L,10L,7L,5L,-4L,-4L,-3L,-5L,-10L,-10L,-13L,-15L,16L,16L,17L,15L,18L,18L,15L,13L,20L,20L,21L,19L,14L,14L,11L,9L,-8L,-8L,-7L,-9L,-6L,-6L,-9L,-11L,-20L,-20L,-19L,-21L,-26L,-26L,-29L,-31L,32L,32L,33L,31L,34L,34L,31L,29L,36L,36L,37L,35L,30L,30L,27L,25L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286548Inst : IEnumerable<long>
{
public static readonly long[] Value=A286548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286548.Bytes);
public long this[int i]=>Value[i];

public static A286548Inst Instance=new A286548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286549
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,3L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,14L,7L,16L,16L,5L,10L,17L,17L,18L,19L,20L,20L,21L,22L,23L,23L,22L,24L,25L,25L,26L,27L,28L,28L,29L,13L,30L,30L,11L,31L,32L,32L,31L,33L,34L,34L,35L,36L,37L,37L,38L,39L,40L,40L,41L,42L,43L,43L,42L,44L,45L,45L,46L,47L,48L,48L,49L,50L,51L,51L,52L,53L,54L,54L,53L,46L,55L,55L,44L,49L,56L,56L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286549Inst : IEnumerable<long>
{
public static readonly long[] Value=A286549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286549.Bytes);
public long this[int i]=>Value[i];

public static A286549Inst Instance=new A286549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286550
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,4L,0L,-2L,8L,12L,8L,14L,0L,2L,-4L,-8L,16L,28L,24L,36L,16L,30L,28L,26L,0L,8L,4L,8L,-8L,-2L,-16L,-20L,32L,60L,56L,80L,48L,86L,72L,52L,32L,64L,60L,82L,56L,102L,52L,74L,0L,20L,16L,34L,8L,34L,16L,22L,-16L,0L,-4L,6L,-32L,-22L,-40L,-50L,64L,124L,120L,168L,112L,198L,160L,132L,96L,176L,172L,230L,144L,250L,104L,108L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286550Inst : IEnumerable<long>
{
public static readonly long[] Value=A286550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286550.Bytes);
public long this[int i]=>Value[i];

public static A286550Inst Instance=new A286550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286583
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,3L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,5L,2L,2L,0L,2L,0L,1L,0L,1L,4L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,3L,0L,3L,2L,0L,0L,0L,1L,4L,0L,1L,2L,1L,0L,1L,0L,0L,1L,1L,3L,1L,0L,2L,1L,2L,1L,0L,2L,0L,1L,3L,1L,0L,3L,3L,7L,1L,2L,0L,0L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,0L,4L,0L,5L,0L,1L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286583Inst : IEnumerable<long>
{
public static readonly long[] Value=A286583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286583.Bytes);
public long this[int i]=>Value[i];

public static A286583Inst Instance=new A286583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286584
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,0L,2L,2L,1L,3L,3L,3L,1L,1L,2L,1L,2L,2L,0L,0L,0L,0L,3L,0L,1L,2L,3L,2L,0L,1L,3L,2L,1L,1L,3L,1L,1L,3L,3L,3L,2L,3L,0L,3L,0L,0L,3L,3L,1L,2L,0L,1L,2L,0L,2L,1L,2L,3L,3L,2L,2L,0L,2L,1L,0L,2L,0L,2L,1L,0L,1L,2L,0L,2L,3L,0L,0L,0L,2L,0L,1L,1L,1L,0L,3L,3L,2L,0L,1L,3L,2L,3L,1L,0L,1L,0L,3L,2L,3L,1L,0L,3L,2L,2L,1L,1L,3L,3L,1L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286584Inst : IEnumerable<long>
{
public static readonly long[] Value=A286584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286584.Bytes);
public long this[int i]=>Value[i];

public static A286584Inst Instance=new A286584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286585
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,2L,4L,3L,3L,3L,5L,1L,5L,2L,5L,2L,4L,2L,4L,2L,4L,3L,6L,5L,6L,3L,6L,4L,7L,3L,6L,3L,3L,3L,5L,3L,5L,5L,5L,4L,3L,4L,5L,4L,6L,1L,7L,5L,6L,4L,7L,2L,8L,4L,7L,4L,5L,3L,8L,4L,4L,4L,7L,4L,6L,2L,4L,5L,6L,3L,6L,4L,6L,5L,6L,4L,6L,4L,6L,7L,5L,3L,4L,5L,7L,6L,6L,5L,5L,4L,7L,3L,8L,1L,8L,5L,6L,3L,7L,6L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286585Inst : IEnumerable<long>
{
public static readonly long[] Value=A286585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286585.Bytes);
public long this[int i]=>Value[i];

public static A286585Inst Instance=new A286585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286586
{
public static readonly long[] Value={ 2L,3L,2L,6L,4L,9L,3L,12L,8L,6L,6L,18L,2L,18L,3L,24L,4L,12L,4L,12L,4L,9L,6L,36L,18L,27L,6L,36L,12L,54L,6L,48L,6L,6L,8L,24L,6L,18L,24L,24L,12L,6L,9L,18L,12L,36L,2L,72L,18L,27L,12L,54L,4L,81L,12L,72L,12L,18L,8L,108L,12L,9L,12L,96L,9L,36L,4L,12L,18L,36L,8L,48L,16L,27L,24L,36L,9L,36L,12L,48L,72L,18L,6L,12L,24L,54L,27L,36L,24L,18L,16L,72L,8L,81L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286586Inst : IEnumerable<long>
{
public static readonly long[] Value=A286586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286586.Bytes);
public long this[int i]=>Value[i];

public static A286586Inst Instance=new A286586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286587
{
public static readonly long[] Value={ 2L,3L,2L,6L,4L,9L,8L,12L,3L,6L,3L,18L,18L,12L,6L,24L,6L,18L,4L,12L,8L,54L,12L,36L,18L,27L,24L,24L,12L,81L,72L,48L,2L,9L,6L,36L,12L,6L,12L,24L,9L,36L,24L,108L,4L,18L,36L,72L,8L,27L,18L,54L,36L,144L,72L,48L,27L,18L,48L,162L,288L,108L,54L,96L,4L,27L,24L,18L,9L,36L,6L,72L,16L,18L,36L,12L,72L,54L,144L,48L,8L,162L,48L,72L,18L,36L,54L,216L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286587Inst : IEnumerable<long>
{
public static readonly long[] Value=A286587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286587.Bytes);
public long this[int i]=>Value[i];

public static A286587Inst Instance=new A286587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286588
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,6L,6L,12L,4L,12L,8L,16L,2L,6L,6L,12L,6L,30L,12L,36L,4L,12L,12L,24L,8L,24L,16L,32L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,36L,72L,4L,12L,12L,36L,12L,60L,24L,72L,8L,24L,24L,48L,16L,48L,32L,64L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,6L,30L,30L,60L,30L,210L,60L,180L,12L,60L,60L,180L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286588Inst : IEnumerable<long>
{
public static readonly long[] Value=A286588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286588.Bytes);
public long this[int i]=>Value[i];

public static A286588Inst Instance=new A286588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286589
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,5L,7L,2L,4L,4L,6L,4L,8L,6L,9L,3L,6L,6L,10L,5L,10L,7L,11L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,9L,13L,3L,6L,6L,9L,6L,12L,10L,13L,5L,10L,10L,14L,7L,14L,11L,15L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,10L,14L,4L,8L,8L,12L,8L,16L,12L,17L,6L,12L,12L,17L,9L,17L,13L,18L,3L,6L,6L,9L,6L,12L,9L,13L,6L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286589Inst : IEnumerable<long>
{
public static readonly long[] Value=A286589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286589.Bytes);
public long this[int i]=>Value[i];

public static A286589Inst Instance=new A286589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286590
{
public static readonly long[] Value={ 1L,3L,9L,21L,33L,45L,81L,153L,165L,201L,393L,405L,441L,645L,873L,885L,921L,1113L,1125L,1161L,1365L,2313L,2565L,3765L,4005L,5913L,5925L,5961L,6153L,6165L,6201L,6405L,7353L,7641L,8805L,9045L,15993L,16281L,17433L,26085L,26325L,36393L,36645L,46233L,46245L,46281L,46473L,46485L,46521L,46725L,47673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286590Inst : IEnumerable<long>
{
public static readonly long[] Value=A286590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286590.Bytes);
public long this[int i]=>Value[i];

public static A286590Inst Instance=new A286590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286591
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,23L,1L,10L,6L,5L,1L,42L,1L,5L,4L,1L,1L,34L,1L,5L,1L,5L,1L,179L,1L,5L,1L,408L,1L,23L,1L,3L,4L,5L,1L,45L,1L,5L,1L,144L,1L,23L,1L,12L,13L,5L,1L,12L,1L,3L,4L,5L,1L,23L,1L,113L,1L,5L,1L,265L,1L,5L,6L,1L,1L,23L,1L,5L,4L,5L,1L,103L,1L,5L,6L,12L,1L,23L,1L,65L,1L,5L,1L,753L,1L,5L,4L,63L,1L,259L,22L,12L,1L,5L,11L,265L,1L,3L,13L,1L,1L,23L,1L,44L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286591Inst : IEnumerable<long>
{
public static readonly long[] Value=A286591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286591.Bytes);
public long this[int i]=>Value[i];

public static A286591Inst Instance=new A286591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286592
{
public static readonly long[] Value={ 1L,3L,5L,10L,8L,42L,17L,36L,40L,27L,30L,183L,47L,34L,51L,136L,57L,243L,80L,288L,72L,177L,122L,765L,194L,72L,308L,117L,192L,1020L,212L,528L,142L,259L,196L,1576L,255L,111L,196L,1059L,302L,1020L,327L,103L,202L,471L,380L,2823L,500L,832L,306L,132L,498L,765L,672L,1564L,747L,786L,668L,4620L,743L,282L,337L,2080L,502L,1020L,782L,165L,441L,696L,822L,6288L,905L,747L,1047L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286592Inst : IEnumerable<long>
{
public static readonly long[] Value=A286592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286592.Bytes);
public long this[int i]=>Value[i];

public static A286592Inst Instance=new A286592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286593
{
public static readonly long[] Value={ 1L,1L,5L,1L,4L,12L,24L,1L,16L,2L,30L,38L,37L,13L,32L,1L,46L,56L,80L,79L,22L,107L,139L,138L,137L,22L,173L,18L,172L,175L,281L,1L,67L,154L,122L,211L,232L,57L,139L,254L,277L,121L,327L,8L,37L,381L,439L,408L,407L,436L,212L,11L,466L,138L,564L,598L,562L,596L,668L,784L,704L,258L,196L,1L,352L,121L,782L,22L,301L,38L,864L,821L,862L,562L,632L,47L,631L,156L,1039L,947L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286593Inst : IEnumerable<long>
{
public static readonly long[] Value=A286593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286593.Bytes);
public long this[int i]=>Value[i];

public static A286593Inst Instance=new A286593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286594
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,1L,7L,8L,6L,5L,11L,4L,13L,5L,4L,16L,17L,7L,19L,11L,12L,6L,23L,3L,10L,6L,15L,1L,29L,5L,31L,32L,7L,7L,9L,13L,37L,7L,9L,5L,41L,6L,43L,11L,7L,8L,47L,7L,14L,14L,7L,11L,53L,7L,11L,8L,15L,9L,59L,6L,61L,9L,12L,64L,10L,8L,67L,11L,8L,20L,71L,9L,73L,10L,13L,9L,23L,9L,79L,17L,42L,11L,83L,4L,11L,11L,8L,23L,89L,5L,7L,9L,16L,12L,8L,6L,97L,17L,9L,16L,101L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286594Inst : IEnumerable<long>
{
public static readonly long[] Value=A286594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286594.Bytes);
public long this[int i]=>Value[i];

public static A286594Inst Instance=new A286594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286595
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,12L,11L,10L,16L,5L,22L,48L,37L,8L,11L,15L,46L,68L,67L,108L,22L,107L,106L,175L,137L,30L,154L,18L,172L,138L,191L,21L,67L,173L,106L,256L,232L,57L,106L,329L,277L,138L,301L,13L,37L,353L,352L,501L,407L,467L,191L,24L,466L,138L,497L,634L,562L,632L,631L,744L,704L,192L,106L,28L,352L,138L,742L,39L,301L,38L,781L,950L,862L,597L,596L,58L,631L,138L,904L,1133L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286595Inst : IEnumerable<long>
{
public static readonly long[] Value=A286595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286595.Bytes);
public long this[int i]=>Value[i];

public static A286595Inst Instance=new A286595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286596
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,2L,6L,16L,8L,4L,12L,2L,6L,6L,12L,32L,16L,8L,24L,4L,12L,12L,36L,2L,6L,6L,12L,6L,30L,12L,24L,64L,32L,16L,48L,8L,24L,24L,72L,4L,12L,12L,36L,12L,60L,36L,72L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,128L,64L,32L,96L,16L,48L,48L,144L,8L,24L,24L,72L,24L,120L,72L,216L,4L,12L,12L,36L,12L,60L,36L,72L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286596Inst : IEnumerable<long>
{
public static readonly long[] Value=A286596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286596.Bytes);
public long this[int i]=>Value[i];

public static A286596Inst Instance=new A286596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286597
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,2L,5L,6L,4L,3L,7L,2L,5L,5L,7L,8L,6L,4L,9L,3L,7L,7L,10L,2L,5L,5L,7L,5L,11L,7L,9L,12L,8L,6L,13L,4L,9L,9L,14L,3L,7L,7L,10L,7L,15L,10L,14L,2L,5L,5L,7L,5L,11L,7L,9L,5L,11L,11L,15L,7L,15L,9L,13L,16L,12L,8L,17L,6L,13L,13L,18L,4L,9L,9L,14L,9L,19L,14L,20L,3L,7L,7L,10L,7L,15L,10L,14L,7L,15L,15L,21L,10L,21L,14L,18L,2L,5L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286597Inst : IEnumerable<long>
{
public static readonly long[] Value=A286597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286597.Bytes);
public long this[int i]=>Value[i];

public static A286597Inst Instance=new A286597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286598
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,8L,16L,6L,12L,6L,2L,4L,12L,12L,36L,8L,24L,16L,32L,6L,30L,12L,24L,6L,12L,6L,2L,4L,12L,12L,36L,12L,60L,36L,72L,8L,24L,24L,72L,16L,48L,32L,64L,6L,30L,30L,60L,12L,60L,24L,48L,6L,30L,12L,24L,6L,12L,6L,2L,4L,12L,12L,36L,12L,60L,36L,72L,12L,60L,60L,180L,36L,180L,72L,144L,8L,24L,24L,72L,24L,120L,72L,216L,16L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286598Inst : IEnumerable<long>
{
public static readonly long[] Value=A286598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286598.Bytes);
public long this[int i]=>Value[i];

public static A286598Inst Instance=new A286598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286615
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,3L,29L,35L,11L,4L,209L,239L,59L,13L,6L,2309L,2519L,419L,65L,31L,8L,30029L,32339L,4619L,449L,215L,37L,9L,510509L,540539L,60059L,4829L,2339L,245L,41L,10L,9699689L,10210199L,1021019L,62369L,30239L,2549L,269L,43L,12L,223092869L,232792559L,19399379L,1051049L,512819L,32549L,2729L,275L,61L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286615Inst : IEnumerable<long>
{
public static readonly long[] Value=A286615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286615.Bytes);
public long this[int i]=>Value[i];

public static A286615Inst Instance=new A286615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286616
{
public static readonly long[] Value={ 0L,2L,1L,3L,7L,5L,4L,11L,35L,29L,6L,13L,59L,239L,209L,8L,31L,65L,419L,2519L,2309L,9L,37L,215L,449L,4619L,32339L,30029L,10L,41L,245L,2339L,4829L,60059L,540539L,510509L,12L,43L,269L,2549L,30239L,62369L,1021019L,10210199L,9699689L,14L,61L,275L,2729L,32549L,512819L,1051049L,19399379L,232792559L,223092869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286616Inst : IEnumerable<long>
{
public static readonly long[] Value=A286616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286616.Bytes);
public long this[int i]=>Value[i];

public static A286616Inst Instance=new A286616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286617
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,2L,3L,5L,6L,4L,2L,4L,6L,3L,5L,7L,8L,6L,4L,9L,4L,2L,4L,6L,10L,6L,3L,6L,8L,5L,7L,11L,12L,8L,6L,13L,9L,4L,9L,13L,6L,4L,2L,4L,9L,4L,6L,8L,14L,10L,6L,13L,6L,3L,6L,10L,14L,8L,5L,8L,12L,7L,11L,15L,16L,12L,8L,17L,13L,6L,13L,18L,13L,9L,4L,9L,19L,9L,13L,17L,8L,6L,4L,9L,4L,2L,4L,6L,13L,9L,4L,9L,13L,6L,8L,12L,20L,14L,10L,18L,13L,6L,13L,18L,10L,6L,3L,6L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286617Inst : IEnumerable<long>
{
public static readonly long[] Value=A286617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286617.Bytes);
public long this[int i]=>Value[i];

public static A286617Inst Instance=new A286617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286618
{
public static readonly long[] Value={ 1L,1L,11L,11L,101L,101L,1011L,1011L,11001L,11001L,100111L,100111L,1111011L,1111011L,10101001L,10101001L,110101001L,110101001L,1000101001L,1000101001L,11101101001L,11101101001L,101000001001L,101000001001L,1101000001001L,1101000001001L,10001000001001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286618Inst : IEnumerable<long>
{
public static readonly long[] Value=A286618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286618.Bytes);
public long this[int i]=>Value[i];

public static A286618Inst Instance=new A286618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286619
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,2L,3L,6L,7L,4L,5L,6L,5L,2L,3L,6L,8L,6L,7L,9L,10L,4L,5L,11L,10L,6L,5L,6L,5L,2L,3L,6L,8L,6L,8L,12L,13L,6L,7L,14L,15L,9L,10L,12L,10L,4L,5L,11L,13L,11L,10L,14L,13L,6L,5L,11L,10L,6L,5L,6L,5L,2L,3L,6L,8L,6L,8L,12L,13L,6L,8L,16L,17L,12L,13L,16L,13L,6L,7L,14L,17L,14L,15L,18L,19L,9L,10L,20L,21L,12L,10L,12L,10L,4L,5L,11L,13L,11L,13L,20L,22L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286619Inst : IEnumerable<long>
{
public static readonly long[] Value=A286619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286619.Bytes);
public long this[int i]=>Value[i];

public static A286619Inst Instance=new A286619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286620
{
public static readonly ulong[] Value={ 1L,10L,110L,1100L,10100L,101000L,1101000L,11010000L,100110000L,1001100000L,11100100000L,111001000000L,1101111000000L,11011110000000L,100101010000000L,1001010100000000L,10010101100000000L,100101011000000000L,1001010001000000000L,10010100010000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286620Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286620.Bytes);
public ulong this[int i]=>Value[i];

public static A286620Inst Instance=new A286620Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286621
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,5L,6L,2L,3L,7L,8L,5L,9L,10L,7L,2L,11L,5L,12L,7L,13L,14L,15L,5L,4L,16L,3L,10L,17L,18L,19L,2L,20L,21L,10L,5L,22L,23L,24L,7L,25L,26L,27L,14L,7L,28L,29L,5L,6L,7L,30L,16L,31L,5L,20L,10L,32L,33L,34L,18L,35L,36L,13L,2L,37L,38L,39L,21L,40L,26L,41L,5L,42L,43L,7L,23L,14L,44L,45L,7L,3L,46L,47L,26L,48L,49L,50L,14L,51L,18L,24L,28L,52L,53L,54L,5L,55L,10L,20L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286621Inst : IEnumerable<long>
{
public static readonly long[] Value=A286621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286621.Bytes);
public long this[int i]=>Value[i];

public static A286621Inst Instance=new A286621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286622
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,5L,7L,2L,4L,4L,6L,4L,8L,6L,9L,3L,6L,6L,10L,5L,9L,7L,11L,2L,4L,4L,6L,4L,8L,6L,9L,4L,8L,8L,12L,6L,12L,9L,13L,3L,6L,6L,10L,6L,12L,10L,14L,5L,9L,9L,14L,7L,13L,11L,15L,2L,4L,4L,6L,4L,8L,6L,9L,4L,8L,8L,12L,6L,12L,9L,13L,4L,8L,8L,12L,8L,16L,12L,17L,6L,12L,12L,18L,9L,17L,13L,19L,3L,6L,6L,10L,6L,12L,10L,14L,6L,12L,12L,18L,10L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286622Inst : IEnumerable<long>
{
public static readonly long[] Value=A286622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286622.Bytes);
public long this[int i]=>Value[i];

public static A286622Inst Instance=new A286622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286623
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,1L,5L,6L,6L,1L,7L,7L,10L,8L,1L,9L,16L,11L,14L,12L,1L,10L,19L,36L,15L,22L,14L,1L,11L,21L,41L,78L,23L,26L,18L,1L,13L,22L,45L,85L,144L,27L,34L,20L,1L,15L,31L,46L,91L,155L,222L,35L,38L,24L,1L,16L,34L,71L,92L,165L,235L,324L,39L,46L,30L,1L,17L,36L,76L,155L,166L,247L,341L,438L,47L,58L,32L,1L,18L,37L,80L,162L,287L,248L,357L,457L,668L,59L,62L,38L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286623Inst : IEnumerable<long>
{
public static readonly long[] Value=A286623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286623.Bytes);
public long this[int i]=>Value[i];

public static A286623Inst Instance=new A286623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286624
{
public static readonly long[] Value={ 9L,19L,41L,85L,155L,235L,341L,457L,691L,929L,1179L,1555L,1805L,2065L,2539L,3181L,3659L,4149L,4825L,5255L,5841L,6637L,7471L,8723L,9895L,10505L,11125L,11771L,12427L,14465L,16765L,18079L,19181L,20851L,22649L,23859L,25749L,27385L,29059L,31141L,32579L,34753L,37055L,38215L,39401L,42189L,47265L,50845L,52211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286624Inst : IEnumerable<long>
{
public static readonly long[] Value=A286624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286624.Bytes);
public long this[int i]=>Value[i];

public static A286624Inst Instance=new A286624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286625
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,4L,1L,6L,6L,5L,1L,8L,10L,7L,7L,1L,12L,14L,11L,16L,9L,1L,14L,22L,15L,36L,19L,10L,1L,18L,26L,23L,78L,41L,21L,11L,1L,20L,34L,27L,144L,85L,45L,22L,13L,1L,24L,38L,35L,222L,155L,91L,46L,31L,15L,1L,30L,46L,39L,324L,235L,165L,92L,71L,34L,16L,1L,32L,58L,47L,438L,341L,247L,166L,155L,76L,36L,17L,1L,38L,62L,59L,668L,457L,357L,248L,287L,162L,80L,37L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286625Inst : IEnumerable<long>
{
public static readonly long[] Value=A286625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286625.Bytes);
public long this[int i]=>Value[i];

public static A286625Inst Instance=new A286625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286626
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,2L,3L,3L,6L,5L,7L,4L,5L,5L,7L,8L,9L,10L,11L,11L,12L,13L,14L,15L,16L,16L,17L,18L,19L,2L,3L,3L,6L,5L,7L,3L,6L,6L,20L,7L,21L,5L,7L,7L,21L,9L,22L,11L,12L,12L,23L,14L,24L,16L,17L,17L,25L,19L,26L,4L,5L,5L,7L,8L,9L,5L,7L,7L,21L,9L,22L,8L,9L,9L,22L,27L,28L,13L,14L,14L,24L,29L,30L,18L,19L,19L,26L,31L,32L,10L,11L,11L,12L,13L,14L,11L,12L,12L,23L,14L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286626Inst : IEnumerable<long>
{
public static readonly long[] Value=A286626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286626.Bytes);
public long this[int i]=>Value[i];

public static A286626Inst Instance=new A286626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286627
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,1L,1L,1L,1L,1L,0L,2L,0L,1L,0L,4L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,2L,1L,1L,0L,1L,2L,1L,0L,2L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,0L,1L,1L,1L,1L,1L,0L,2L,0L,2L,0L,2L,0L,1L,0L,1L,1L,1L,1L,3L,1L,0L,2L,1L,1L,1L,0L,0L,1L,1L,1L,3L,0L,1L,1L,3L,1L,1L,0L,1L,0L,1L,0L,5L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,0L,4L,0L,1L,0L,2L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286627Inst : IEnumerable<long>
{
public static readonly long[] Value=A286627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286627.Bytes);
public long this[int i]=>Value[i];

public static A286627Inst Instance=new A286627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286628
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,1L,3L,0L,0L,0L,2L,0L,1L,1L,1L,0L,1L,0L,2L,1L,2L,1L,3L,0L,0L,0L,1L,0L,1L,1L,5L,0L,2L,0L,2L,0L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,4L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,0L,2L,1L,1L,2L,0L,0L,1L,1L,2L,1L,2L,1L,3L,0L,1L,0L,0L,0L,2L,1L,4L,0L,0L,0L,2L,0L,1L,1L,1L,0L,1L,0L,2L,1L,3L,2L,1L,1L,1L,0L,1L,0L,1L,1L,3L,0L,2L,0L,2L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286628Inst : IEnumerable<long>
{
public static readonly long[] Value=A286628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286628.Bytes);
public long this[int i]=>Value[i];

public static A286628Inst Instance=new A286628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286629
{
public static readonly BigInteger[] Value={ 2L,12L,120L,1260L,23100L,360360L,8168160L,174594420L,4908043140L,181151410440L,6016814703900L,267146572853160L,12170010541088400L,549475975930141260L,BigInteger.Parse("28284929999070604860"),BigInteger.Parse("1694636240813882325960"),BigInteger.Parse("111520100308944333066060"),BigInteger.Parse("7037302881564418258996200"),BigInteger.Parse("518649222371297625688019940"),BigInteger.Parse("39055858108868927267719077300") };
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
public class A286629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286629Inst Instance=new A286629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286630
{
public static readonly BigInteger[] Value={ 1L,4L,18L,150L,1470L,25410L,390390L,8678670L,184294110L,5131136010L,187621103670L,6217375194030L,274567310987970L,12474260804615610L,562558737261811290L,BigInteger.Parse("28899819781659096270"),BigInteger.Parse("1727225399291072370690"),BigInteger.Parse("113442860659098545705130"),BigInteger.Parse("7154591262923825229979470"),BigInteger.Parse("526507543922377892743899030"),BigInteger.Parse("39613798938995626228686492690") };
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
public class A286630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286630Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286630.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286630Inst Instance=new A286630Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286647
{
public static readonly ulong[] Value={ 1L,1L,0L,11L,10000L,111L,1100000L,1111L,1000000L,1000011111L,0L,100100111111L,10100000000L,10000001111111L,0L,1111110011111111L,10000000000L,110010000111111111L,1000000000000000L,11000011001111111111UL,110001000000000000L,1000011111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286647Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286647.Bytes);
public ulong this[int i]=>Value[i];

public static A286647Inst Instance=new A286647Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286648
{
public static readonly long[] Value={ 1L,2L,0L,12L,1L,56L,3L,240L,4L,993L,0L,4041L,20L,16257L,0L,65343L,64L,261651L,8L,1047747L,280L,4192320L,25L,16774112L,1025L,67100736L,161L,268422656L,4129L,1073710976L,33L,4294917196L,16643L,17179738176L,2463L,68719272448L,65561L,274877411520L,1561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286648Inst : IEnumerable<long>
{
public static readonly long[] Value=A286648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286648.Bytes);
public long this[int i]=>Value[i];

public static A286648Inst Instance=new A286648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286649
{
public static readonly long[] Value={ 1L,1L,0L,3L,16L,7L,96L,15L,64L,543L,0L,2367L,1280L,8319L,0L,64767L,1024L,205311L,32768L,799743L,200704L,34815L,4980736L,511999L,16793600L,532479L,69730304L,475135L,276889600L,7897087L,1107296256L,842858495L,6459490304L,134348799L,33495711744L,74711039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286649Inst : IEnumerable<long>
{
public static readonly long[] Value=A286649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286649.Bytes);
public long this[int i]=>Value[i];

public static A286649Inst Instance=new A286649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286650
{
public static readonly long[] Value={ 0L,1L,11L,1434L,1269681358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286650Inst : IEnumerable<long>
{
public static readonly long[] Value=A286650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286650.Bytes);
public long this[int i]=>Value[i];

public static A286650Inst Instance=new A286650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286651
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,2L,6L,5L,9L,6L,2L,9L,4L,0L,8L,6L,6L,6L,9L,5L,6L,7L,5L,1L,1L,5L,3L,8L,2L,5L,7L,1L,7L,3L,2L,5L,7L,7L,9L,2L,2L,0L,5L,2L,8L,7L,9L,1L,0L,5L,3L,1L,5L,3L,9L,2L,8L,8L,7L,6L,8L,4L,7L,0L,8L,9L,3L,3L,3L,8L,6L,5L,7L,5L,7L,5L,3L,0L,9L,3L,0L,0L,1L,8L,8L,2L,7L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286651Inst : IEnumerable<long>
{
public static readonly long[] Value=A286651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286651.Bytes);
public long this[int i]=>Value[i];

public static A286651Inst Instance=new A286651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286652
{
public static readonly long[] Value={ 1L,2L,6L,30L,42L,66L,78L,210L,330L,390L,462L,510L,546L,570L,690L,714L,798L,858L,870L,930L,966L,1050L,1110L,1122L,1218L,1230L,1254L,1290L,1302L,1326L,1410L,1470L,1482L,1518L,1554L,1590L,1650L,1722L,1770L,1794L,1806L,1830L,1914L,1950L,1974L,2010L,2046L,2130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286652Inst : IEnumerable<long>
{
public static readonly long[] Value=A286652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286652.Bytes);
public long this[int i]=>Value[i];

public static A286652Inst Instance=new A286652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286653
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,2L,0L,1L,1L,2L,2L,2L,0L,1L,1L,2L,3L,4L,3L,0L,1L,1L,2L,3L,4L,5L,4L,0L,1L,1L,2L,3L,5L,6L,7L,5L,0L,1L,1L,2L,3L,5L,6L,9L,9L,6L,0L,1L,1L,2L,3L,5L,7L,10L,12L,13L,8L,0L,1L,1L,2L,3L,5L,7L,10L,13L,16L,16L,10L,0L,1L,1L,2L,3L,5L,7L,11L,14L,19L,22L,22L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286653Inst : IEnumerable<long>
{
public static readonly long[] Value=A286653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286653.Bytes);
public long this[int i]=>Value[i];

public static A286653Inst Instance=new A286653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286654
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286654Inst : IEnumerable<long>
{
public static readonly long[] Value=A286654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286654.Bytes);
public long this[int i]=>Value[i];

public static A286654Inst Instance=new A286654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286655
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286655Inst : IEnumerable<long>
{
public static readonly long[] Value=A286655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286655.Bytes);
public long this[int i]=>Value[i];

public static A286655Inst Instance=new A286655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286656
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,-1L,-1L,0L,1L,-1L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,-1L,0L,1L,-1L,-1L,0L,1L,0L,1L,0L,1L,-1L,-1L,0L,0L,0L,2L,-1L,0L,1L,-1L,-1L,0L,0L,2L,-1L,-1L,2L,0L,1L,-1L,-1L,0L,0L,1L,-1L,1L,-1L,-2L,0L,1L,-1L,-1L,0L,0L,1L,1L,0L,2L,3L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286656Inst : IEnumerable<long>
{
public static readonly long[] Value=A286656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286656.Bytes);
public long this[int i]=>Value[i];

public static A286656Inst Instance=new A286656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286657
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,2L,1L,4L,6L,6L,3L,2L,2L,4L,6L,1L,2L,4L,2L,4L,2L,5L,4L,2L,4L,8L,4L,14L,3L,10L,4L,2L,4L,6L,12L,6L,1L,10L,6L,6L,4L,14L,6L,8L,6L,5L,4L,2L,4L,2L,4L,24L,18L,14L,8L,3L,10L,2L,6L,6L,10L,6L,4L,2L,6L,10L,1L,4L,6L,20L,6L,14L,4L,2L,6L,4L,2L,6L,9L,8L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286657Inst : IEnumerable<long>
{
public static readonly long[] Value=A286657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286657.Bytes);
public long this[int i]=>Value[i];

public static A286657Inst Instance=new A286657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286658
{
public static readonly long[] Value={ 13L,29L,53L,149L,173L,269L,293L,317L,389L,509L,557L,653L,769L,773L,797L,1109L,1229L,1493L,1637L,1733L,1949L,1997L,2309L,2477L,2693L,2837L,2909L,2957L,3329L,3413L,3533L,3677L,3989L,4133L,4157L,4253L,4349L,4373L,4493L,4517L,5189L,5309L,5693L,5717L,5813L,6173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286658Inst : IEnumerable<long>
{
public static readonly long[] Value=A286658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286658.Bytes);
public long this[int i]=>Value[i];

public static A286658Inst Instance=new A286658Inst();

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