using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A086729
{
public static readonly long[] Value={ 1L,3L,7L,0L,7L,7L,8L,3L,8L,9L,0L,4L,0L,1L,8L,8L,6L,9L,7L,0L,6L,0L,3L,4L,5L,9L,7L,2L,2L,0L,5L,0L,2L,0L,9L,9L,1L,0L,1L,5L,7L,9L,1L,5L,8L,4L,3L,3L,8L,9L,9L,8L,6L,9L,8L,1L,1L,2L,9L,6L,5L,1L,9L,1L,1L,4L,1L,6L,7L,2L,8L,9L,2L,0L,0L,2L,6L,6L,7L,3L,9L,4L,8L,6L,1L,3L,5L,7L,4L,1L,7L,1L,8L,3L,1L,3L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086729Inst : IEnumerable<long>
{
public static readonly long[] Value=A086729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086729.Bytes);
public long this[int i]=>Value[i];

public static A086729Inst Instance=new A086729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086730
{
public static readonly long[] Value={ 0L,8L,5L,1L,0L,7L,6L,5L,0L,2L,5L,9L,9L,6L,4L,3L,7L,2L,4L,9L,9L,6L,4L,7L,7L,0L,0L,9L,2L,4L,3L,2L,4L,5L,8L,7L,5L,8L,9L,7L,9L,7L,0L,8L,5L,8L,4L,3L,7L,0L,5L,8L,1L,5L,5L,5L,3L,9L,6L,6L,1L,8L,4L,2L,8L,1L,3L,6L,2L,1L,7L,9L,1L,8L,5L,5L,7L,0L,0L,4L,2L,0L,5L,3L,2L,3L,8L,9L,5L,9L,2L,7L,0L,3L,9L,1L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086730Inst : IEnumerable<long>
{
public static readonly long[] Value=A086730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086730.Bytes);
public long this[int i]=>Value[i];

public static A086730Inst Instance=new A086730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086731
{
public static readonly long[] Value={ 0L,5L,9L,9L,9L,7L,3L,4L,7L,5L,5L,5L,7L,7L,1L,5L,4L,3L,2L,8L,2L,1L,4L,6L,2L,4L,5L,3L,6L,6L,9L,5L,0L,6L,7L,3L,6L,7L,8L,1L,0L,7L,6L,7L,3L,3L,9L,4L,7L,9L,6L,0L,9L,1L,6L,0L,6L,3L,7L,3L,5L,3L,7L,1L,0L,2L,3L,6L,4L,7L,9L,1L,3L,9L,3L,8L,0L,5L,5L,7L,1L,6L,3L,6L,4L,9L,9L,4L,8L,5L,1L,0L,3L,1L,2L,1L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086731Inst : IEnumerable<long>
{
public static readonly long[] Value=A086731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086731.Bytes);
public long this[int i]=>Value[i];

public static A086731Inst Instance=new A086731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086732
{
public static readonly long[] Value={ 1L,5L,13L,29L,54L,97L,161L,257L,402L,604L,896L,1299L,1866L,2616L,3665L,5031L,6891L,9290L,12498L,16600L,22008L,28841L,37740L,48919L,63294L,81230L,104048L,132355L,168048L,212070L,267105L,334671L,418486L,520857L,647081L,800531L,988510L,1216159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086732Inst : IEnumerable<long>
{
public static readonly long[] Value=A086732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086732.Bytes);
public long this[int i]=>Value[i];

public static A086732Inst Instance=new A086732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086733
{
public static readonly long[] Value={ 1L,4L,9L,19L,31L,54L,74L,117L,148L,217L,252L,366L,408L,562L,612L,833L,853L,1171L,1203L,1566L,1606L,2104L,2030L,2718L,2655L,3347L,3332L,4262L,3954L,5226L,4984L,6161L,5971L,7566L,6874L,8961L,8361L,10194L,9732L,12210L,10912L,14122L,13012L,15654L,14858L,18494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086733Inst : IEnumerable<long>
{
public static readonly long[] Value=A086733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086733.Bytes);
public long this[int i]=>Value[i];

public static A086733Inst Instance=new A086733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086734
{
public static readonly long[] Value={ 2L,5L,12L,22L,42L,64L,104L,148L,214L,286L,394L,504L,662L,824L,1028L,1254L,1538L,1822L,2188L,2568L,3002L,3482L,4038L,4586L,5260L,5948L,6722L,7558L,8484L,9394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086734Inst : IEnumerable<long>
{
public static readonly long[] Value=A086734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086734.Bytes);
public long this[int i]=>Value[i];

public static A086734Inst Instance=new A086734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086735
{
public static readonly long[] Value={ 2L,11L,35L,92L,203L,416L,766L,1356L,2235L,3593L,5472L,8224L,11858L,16918L,23364L,32036L,42723L,56708L,73611L,95090L,120642L,152506L,189674L,235332L,288044L,351423L,424108L,510596L,608196L,723484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086735Inst : IEnumerable<long>
{
public static readonly long[] Value=A086735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086735.Bytes);
public long this[int i]=>Value[i];

public static A086735Inst Instance=new A086735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086736
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,13L,17L,22L,28L,35L,44L,55L,69L,86L,107L,132L,163L,200L,245L,299L,364L,442L,535L,646L,778L,935L,1121L,1341L,1601L,1908L,2270L,2695L,3194L,3778L,4462L,5261L,6194L,7281L,8547L,10018L,11726L,13706L,16000L,18654L,21722L,25263L,29347L,34051L,39466L,45691L,52842L,61047L,70454L,81228L,93559L,107657L,123764L,142149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086736Inst : IEnumerable<long>
{
public static readonly long[] Value=A086736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086736.Bytes);
public long this[int i]=>Value[i];

public static A086736Inst Instance=new A086736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086737
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,28L,66L,120L,253L,465L,903L,1596L,3003L,5151L,9180L,15576L,26796L,44253L,74305L,120295L,196878L,314028L,502503L,788140L,1241100L,1917861L,2968266L,4531555L,6913621L,10421895L,15705210L,23409903L,34857075L,51445296L,75774205L,110759286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086737Inst : IEnumerable<long>
{
public static readonly long[] Value=A086737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086737.Bytes);
public long this[int i]=>Value[i];

public static A086737Inst Instance=new A086737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086738
{
public static readonly long[] Value={ 0L,-1L,-1L,-2L,1L,-1L,7L,7L,17L,24L,44L,49L,87L,111L,152L,200L,279L,346L,470L,585L,760L,966L,1231L,1515L,1927L,2394L,2970L,3662L,4535L,5532L,6810L,8286L,10095L,12256L,14835L,17886L,21599L,25955L,31129L,37248L,44541L,53078L,63217L,75091L,89056L,105486L,124706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086738Inst : IEnumerable<long>
{
public static readonly long[] Value=A086738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086738.Bytes);
public long this[int i]=>Value[i];

public static A086738Inst Instance=new A086738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086739
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,9L,9L,18L,24L,38L,46L,73L,89L,129L,168L,223L,281L,379L,472L,619L,780L,992L,1233L,1567L,1938L,2424L,2992L,3706L,4537L,5596L,6812L,8333L,10123L,12294L,14859L,17965L,21601L,25997L,31161L,37322L,44543L,53162L,63219L,75155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086739Inst : IEnumerable<long>
{
public static readonly long[] Value=A086739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086739.Bytes);
public long this[int i]=>Value[i];

public static A086739Inst Instance=new A086739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086740
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,11L,14L,17L,21L,25L,31L,37L,45L,54L,65L,78L,93L,111L,132L,157L,186L,220L,260L,307L,362L,425L,499L,584L,684L,799L,933L,1087L,1266L,1471L,1708L,1980L,2294L,2654L,3068L,3541L,4084L,4704L,5415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086740Inst : IEnumerable<long>
{
public static readonly long[] Value=A086740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086740.Bytes);
public long this[int i]=>Value[i];

public static A086740Inst Instance=new A086740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086741
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,7L,18L,37L,64L,110L,174L,268L,401L,585L,829L,1155L,1584L,2144L,2865L,3794L,4970L,6462L,8331L,10670L,13579L,17194L,21652L,27147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086741Inst : IEnumerable<long>
{
public static readonly long[] Value=A086741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086741.Bytes);
public long this[int i]=>Value[i];

public static A086741Inst Instance=new A086741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086742
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086742Inst : IEnumerable<long>
{
public static readonly long[] Value=A086742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086742.Bytes);
public long this[int i]=>Value[i];

public static A086742Inst Instance=new A086742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086743
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,31L,32L,33L,34L,35L,37L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086743Inst : IEnumerable<long>
{
public static readonly long[] Value=A086743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086743.Bytes);
public long this[int i]=>Value[i];

public static A086743Inst Instance=new A086743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086744
{
public static readonly long[] Value={ 1L,6L,2L,8L,1L,6L,0L,1L,2L,9L,7L,1L,8L,9L,1L,7L,2L,4L,8L,8L,2L,1L,5L,3L,1L,2L,2L,5L,4L,0L,9L,9L,7L,3L,2L,3L,4L,9L,9L,5L,1L,5L,5L,7L,5L,9L,2L,6L,9L,7L,7L,7L,6L,5L,4L,1L,6L,1L,6L,2L,7L,9L,7L,4L,6L,8L,9L,9L,0L,7L,9L,1L,1L,3L,1L,5L,7L,6L,7L,9L,1L,6L,1L,6L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086744Inst : IEnumerable<long>
{
public static readonly long[] Value=A086744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086744.Bytes);
public long this[int i]=>Value[i];

public static A086744Inst Instance=new A086744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086745
{
public static readonly long[] Value={ 1L,1L,1L,5L,6L,1L,61L,75L,15L,1L,1385L,1708L,350L,28L,1L,50521L,62325L,12810L,1050L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086745Inst : IEnumerable<long>
{
public static readonly long[] Value=A086745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086745.Bytes);
public long this[int i]=>Value[i];

public static A086745Inst Instance=new A086745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086746
{
public static readonly long[] Value={ 3018L,6036L,9054L,12072L,15090L,18108L,21126L,24144L,27162L,30180L,33198L,36216L,39234L,42252L,45270L,48288L,51306L,54324L,57342L,60360L,63378L,66396L,69414L,72432L,75450L,78468L,81486L,84504L,87522L,90540L,93558L,96576L,99594L,102612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086746Inst : IEnumerable<long>
{
public static readonly long[] Value=A086746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086746.Bytes);
public long this[int i]=>Value[i];

public static A086746Inst Instance=new A086746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086747
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086747Inst : IEnumerable<long>
{
public static readonly long[] Value=A086747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086747.Bytes);
public long this[int i]=>Value[i];

public static A086747Inst Instance=new A086747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086748
{
public static readonly long[] Value={ 3L,5L,9L,13L,15L,21L,23L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086748Inst : IEnumerable<long>
{
public static readonly long[] Value=A086748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086748.Bytes);
public long this[int i]=>Value[i];

public static A086748Inst Instance=new A086748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086749
{
public static readonly long[] Value={ 5L,16L,47L,106L,233L,412L,689L,1020L,1451L,2050L,2759L,3678L,4741L,5894L,7191L,8714L,10501L,12348L,14569L,16950L,19427L,22176L,25177L,28436L,32073L,36016L,40107L,44380L,48777L,53326L,58707L,64330L,70199L,76312L,82973L,89796L,96989L,104596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086749Inst : IEnumerable<long>
{
public static readonly long[] Value=A086749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086749.Bytes);
public long this[int i]=>Value[i];

public static A086749Inst Instance=new A086749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086750
{
public static readonly long[] Value={ 5L,16L,47L,106L,233L,412L,689L,1020L,1451L,2050L,2759L,3678L,4741L,5894L,7191L,8714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086750Inst : IEnumerable<long>
{
public static readonly long[] Value=A086750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086750.Bytes);
public long this[int i]=>Value[i];

public static A086750Inst Instance=new A086750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086751
{
public static readonly long[] Value={ 4L,0L,3L,9L,7L,2L,7L,5L,3L,2L,9L,9L,5L,1L,7L,2L,0L,9L,3L,1L,8L,9L,6L,1L,7L,4L,0L,0L,6L,6L,3L,1L,5L,4L,4L,2L,9L,0L,2L,2L,3L,5L,9L,6L,4L,5L,7L,4L,0L,9L,8L,4L,2L,2L,2L,5L,0L,0L,9L,7L,6L,0L,1L,7L,3L,3L,8L,7L,0L,5L,4L,9L,9L,7L,1L,2L,9L,5L,3L,5L,3L,5L,0L,1L,2L,4L,3L,3L,9L,0L,1L,6L,5L,2L,2L,2L,7L,2L,8L,7L,0L,9L,4L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086751Inst : IEnumerable<long>
{
public static readonly long[] Value=A086751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086751.Bytes);
public long this[int i]=>Value[i];

public static A086751Inst Instance=new A086751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086752
{
public static readonly BigInteger[] Value={ 1L,32L,8112L,17971200L,355207057920L,63010655570903040L,BigInteger.Parse("100505356319291594711040"),BigInteger.Parse("1442361950110091891786121216000"),BigInteger.Parse("186276322602412236974585775503690956800") };
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
public class A086752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086752Inst Instance=new A086752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086753
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,9L,12L,13L,16L,19L,21L,24L,25L,30L,32L,37L,40L,43L,46L,51L,56L,59L,64L,67L,75L,79L,83L,91L,93L,102L,108L,111L,119L,125L,131L,139L,147L,154L,160L,167L,175L,183L,189L,199L,206L,214L,225L,233L,243L,250L,261L,268L,279L,289L,298L,309L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086753Inst : IEnumerable<long>
{
public static readonly long[] Value=A086753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086753.Bytes);
public long this[int i]=>Value[i];

public static A086753Inst Instance=new A086753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086754
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,2L,4L,2L,1L,2L,1L,1L,3L,3L,1L,3L,9L,9L,3L,3L,9L,9L,3L,1L,3L,3L,1L,1L,4L,6L,4L,1L,4L,16L,24L,16L,4L,6L,24L,36L,24L,6L,4L,16L,24L,16L,4L,1L,4L,6L,4L,1L,1L,5L,10L,10L,5L,1L,5L,25L,50L,50L,25L,5L,10L,50L,100L,100L,50L,10L,10L,50L,100L,100L,50L,10L,5L,25L,50L,50L,25L,5L,1L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086754Inst : IEnumerable<long>
{
public static readonly long[] Value=A086754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086754.Bytes);
public long this[int i]=>Value[i];

public static A086754Inst Instance=new A086754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086755
{
public static readonly long[] Value={ 2L,20L,92L,292L,742L,1624L,3192L,5784L,9834L,15884L,24596L,36764L,53326L,75376L,104176L,141168L,187986L,246468L,318668L,406868L,513590L,641608L,793960L,973960L,1185210L,1431612L,1717380L,2047052L,2425502L,2857952L,3349984L,3907552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086755Inst : IEnumerable<long>
{
public static readonly long[] Value=A086755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086755.Bytes);
public long this[int i]=>Value[i];

public static A086755Inst Instance=new A086755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086788
{
public static readonly long[] Value={ 7L,113L,265381L,842468587426513207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086788Inst : IEnumerable<long>
{
public static readonly long[] Value=A086788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086788.Bytes);
public long this[int i]=>Value[i];

public static A086788Inst Instance=new A086788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086789
{
public static readonly long[] Value={ 1L,1L,2L,8L,64L,1023L,32071L,1823707L,163947848L,20402420291L,3209997749284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086789Inst : IEnumerable<long>
{
public static readonly long[] Value=A086789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086789.Bytes);
public long this[int i]=>Value[i];

public static A086789Inst Instance=new A086789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086790
{
public static readonly long[] Value={ 1L,2L,4L,8L,11L,15L,19L,23L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,70L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086790Inst : IEnumerable<long>
{
public static readonly long[] Value=A086790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086790.Bytes);
public long this[int i]=>Value[i];

public static A086790Inst Instance=new A086790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086791
{
public static readonly BigInteger[] Value={ 2L,3L,11L,19L,193L,49171L,1084483L,563501581931L,BigInteger.Parse("332993721039856822081"),BigInteger.Parse("3883282200001578119609988529770479452142437123001916048102414513139044082579") };
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
public class A086791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086791Inst Instance=new A086791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086792
{
public static readonly long[] Value={ 6L,12L,28L,30L,56L,360L,364L,380L,496L,760L,792L,900L,992L,1224L,1656L,1680L,1980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086792Inst : IEnumerable<long>
{
public static readonly long[] Value=A086792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086792.Bytes);
public long this[int i]=>Value[i];

public static A086792Inst Instance=new A086792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086793
{
public static readonly long[] Value={ 0L,5L,4L,3L,9L,8L,2L,1L,11L,12L,5L,7L,10L,1L,0L,13L,12L,15L,6L,1L,2L,12L,9L,9L,11L,1L,13L,9L,8L,14L,10L,14L,8L,16L,3L,17L,6L,10L,2L,14L,9L,9L,2L,3L,9L,16L,8L,3L,3L,3L,16L,2L,12L,4L,16L,4L,2L,14L,1L,10L,2L,1L,15L,7L,3L,18L,2L,18L,10L,18L,12L,11L,6L,10L,17L,10L,10L,17L,13L,10L,11L,16L,8L,2L,14L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086793Inst : IEnumerable<long>
{
public static readonly long[] Value=A086793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086793.Bytes);
public long this[int i]=>Value[i];

public static A086793Inst Instance=new A086793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086794
{
public static readonly long[] Value={ 21L,42L,63L,84L,126L,147L,168L,189L,252L,294L,336L,378L,441L,504L,567L,588L,672L,756L,882L,1008L,1029L,1134L,1176L,1323L,1344L,1512L,1701L,1764L,2016L,2058L,2268L,2352L,2646L,2688L,3024L,3087L,3402L,3528L,3969L,4032L,4116L,4536L,4704L,5103L,5292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086794Inst : IEnumerable<long>
{
public static readonly long[] Value=A086794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086794.Bytes);
public long this[int i]=>Value[i];

public static A086794Inst Instance=new A086794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086795
{
public static readonly long[] Value={ 2L,4L,7L,11L,13L,21L,28L,35L,42L,53L,65L,74L,87L,102L,117L,133L,150L,168L,188L,207L,228L,251L,273L,298L,323L,348L,375L,404L,433L,463L,494L,526L,559L,592L,627L,664L,701L,739L,778L,817L,858L,901L,944L,988L,1032L,1079L,1126L,1174L,1222L,1273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086795Inst : IEnumerable<long>
{
public static readonly long[] Value=A086795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086795.Bytes);
public long this[int i]=>Value[i];

public static A086795Inst Instance=new A086795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086796
{
public static readonly long[] Value={ 3L,9L,24L,60L,130L,247L,429L,697L,1075L,1590L,2272L,3154L,4272L,5665L,7375L,9447L,11929L,14872L,18330L,22360L,27022L,32379L,38497L,45445L,53295L,62122L,72004L,83022L,95260L,108805L,123747L,140179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086796Inst : IEnumerable<long>
{
public static readonly long[] Value=A086796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086796.Bytes);
public long this[int i]=>Value[i];

public static A086796Inst Instance=new A086796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086797
{
public static readonly BigInteger[] Value={ 0L,5L,-23L,-283L,2869L,49781L,-776887L,-17600759L,370643273L,10387420489L,-275311670611L,-9201412118867L,293959006143997L,11414881932150269L,-426781883555301359L,BigInteger.Parse("-18884637964090410991"),BigInteger.Parse("808793517812627212561"),BigInteger.Parse("40173648337182874339601") };
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
public class A086797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086797Inst Instance=new A086797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086798
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,3L,4L,0L,0L,2L,0L,0L,2L,7L,0L,4L,0L,4L,4L,0L,0L,6L,16L,0L,16L,6L,0L,2L,0L,15L,6L,0L,8L,10L,0L,0L,8L,12L,0L,4L,0L,10L,18L,0L,0L,14L,36L,16L,10L,12L,0L,16L,24L,18L,12L,0L,0L,10L,0L,0L,28L,31L,18L,6L,0L,16L,14L,8L,0L,22L,0L,0L,34L,18L,30L,8L,0L,28L,52L,0L,0L,16L,24L,0L,18L,30L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086798Inst : IEnumerable<long>
{
public static readonly long[] Value=A086798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086798.Bytes);
public long this[int i]=>Value[i];

public static A086798Inst Instance=new A086798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086799
{
public static readonly long[] Value={ 1L,3L,3L,7L,5L,7L,7L,15L,9L,11L,11L,15L,13L,15L,15L,31L,17L,19L,19L,23L,21L,23L,23L,31L,25L,27L,27L,31L,29L,31L,31L,63L,33L,35L,35L,39L,37L,39L,39L,47L,41L,43L,43L,47L,45L,47L,47L,63L,49L,51L,51L,55L,53L,55L,55L,63L,57L,59L,59L,63L,61L,63L,63L,127L,65L,67L,67L,71L,69L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086799Inst : IEnumerable<long>
{
public static readonly long[] Value=A086799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086799.Bytes);
public long this[int i]=>Value[i];

public static A086799Inst Instance=new A086799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086800
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,0L,5L,4L,2L,0L,9L,8L,6L,4L,0L,11L,10L,8L,6L,2L,0L,15L,14L,12L,10L,6L,4L,0L,17L,16L,14L,12L,8L,6L,2L,0L,21L,20L,18L,16L,12L,10L,6L,4L,0L,27L,26L,24L,22L,18L,16L,12L,10L,6L,0L,29L,28L,26L,24L,20L,18L,14L,12L,8L,2L,0L,35L,34L,32L,30L,26L,24L,20L,18L,14L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086800Inst : IEnumerable<long>
{
public static readonly long[] Value=A086800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086800.Bytes);
public long this[int i]=>Value[i];

public static A086800Inst Instance=new A086800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086801
{
public static readonly long[] Value={ -1L,0L,2L,4L,8L,10L,14L,16L,20L,26L,28L,34L,38L,40L,44L,50L,56L,58L,64L,68L,70L,76L,80L,86L,94L,98L,100L,104L,106L,110L,124L,128L,134L,136L,146L,148L,154L,160L,164L,170L,176L,178L,188L,190L,194L,196L,208L,220L,224L,226L,230L,236L,238L,248L,254L,260L,266L,268L,274L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086801Inst : IEnumerable<long>
{
public static readonly long[] Value=A086801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086801.Bytes);
public long this[int i]=>Value[i];

public static A086801Inst Instance=new A086801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086802
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,4L,3L,2L,0L,5L,4L,3L,1L,0L,7L,6L,5L,3L,2L,0L,8L,7L,6L,4L,3L,1L,0L,10L,9L,8L,6L,5L,3L,2L,0L,13L,12L,11L,9L,8L,6L,5L,3L,0L,14L,13L,12L,10L,9L,7L,6L,4L,1L,0L,17L,16L,15L,13L,12L,10L,9L,7L,4L,3L,0L,19L,18L,17L,15L,14L,12L,11L,9L,6L,5L,2L,0L,20L,19L,18L,16L,15L,13L,12L,10L,7L,6L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086802Inst : IEnumerable<long>
{
public static readonly long[] Value=A086802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086802.Bytes);
public long this[int i]=>Value[i];

public static A086802Inst Instance=new A086802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086803
{
public static readonly BigInteger[] Value={ 1L,6L,40L,1728L,10560L,604800L,4386816L,348364800L,76859228160L,490311843840L,172454510592000L,6951148594790400L,54188395462656000L,5673488083845120000L,BigInteger.Parse("2112698895984230400000"),BigInteger.Parse("458667310457770160947200") };
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
public class A086803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086803Inst Instance=new A086803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086836
{
public static readonly long[] Value={ 3L,12L,66L,378L,1890L,7560L,22680L,45360L,45360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086836Inst : IEnumerable<long>
{
public static readonly long[] Value=A086836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086836.Bytes);
public long this[int i]=>Value[i];

public static A086836Inst Instance=new A086836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086837
{
public static readonly long[] Value={ 341L,1387L,2047L,2701L,31621L,42799L,49141L,49981L,60701L,83333L,88357L,90751L,104653L,129889L,130561L,150851L,162193L,164737L,219781L,226801L,241001L,249841L,282133L,1194649L,1678541L,2035153L,2134277L,2163001L,2284453L,2304167L,2491637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086837Inst : IEnumerable<long>
{
public static readonly long[] Value=A086837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086837.Bytes);
public long this[int i]=>Value[i];

public static A086837Inst Instance=new A086837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086838
{
public static readonly long[] Value={ 3L,6L,9L,13L,35L,66L,115L,145L,297L,402L,491L,521L,1217L,2166L,3397L,3591L,4641L,4829L,6810L,6829L,7978L,8705L,17676L,21165L,50722L,52884L,84763L,121344L,121482L,162070L,358839L,560596L,1463827L,1593475L,1668394L,2086707L,2164032L,2517791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086838Inst : IEnumerable<long>
{
public static readonly long[] Value=A086838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086838.Bytes);
public long this[int i]=>Value[i];

public static A086838Inst Instance=new A086838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086839
{
public static readonly long[] Value={ 1L,3L,7L,7L,31L,63L,15L,15L,511L,63L,2047L,1023L,511L,16383L,31L,31L,4095L,87381L,4095L,1023L,127L,4095L,8388607L,2097151L,255L,67108863L,1048575L,511L,536870911L,1073741823L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086839Inst : IEnumerable<long>
{
public static readonly long[] Value=A086839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086839.Bytes);
public long this[int i]=>Value[i];

public static A086839Inst Instance=new A086839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086840
{
public static readonly BigInteger[] Value={ 1L,1L,37L,289L,411701L,28976689L,1273783660297L,870606927590401L,BigInteger.Parse("1051623015879083528521"),BigInteger.Parse("7387282445437833999729601"),BigInteger.Parse("228573356812047967600677951727277") };
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
public class A086840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086840Inst Instance=new A086840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086841
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,4L,5L,6L,7L,7L,8L,8L,8L,8L,9L,10L,11L,12L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,16L,16L,17L,18L,19L,20L,21L,22L,23L,23L,24L,24L,25L,26L,27L,26L,27L,28L,28L,29L,30L,29L,30L,30L,31L,31L,31L,31L,32L,32L,32L,32L,32L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086841Inst : IEnumerable<long>
{
public static readonly long[] Value=A086841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086841.Bytes);
public long this[int i]=>Value[i];

public static A086841Inst Instance=new A086841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086842
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,3L,17L,94L,583L,4004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086842Inst : IEnumerable<long>
{
public static readonly long[] Value=A086842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086842.Bytes);
public long this[int i]=>Value[i];

public static A086842Inst Instance=new A086842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086843
{
public static readonly long[] Value={ 1L,7L,11L,13L,17L,21L,23L,27L,33L,37L,39L,43L,49L,53L,59L,63L,65L,69L,75L,79L,81L,85L,91L,95L,101L,105L,107L,111L,117L,121L,123L,127L,131L,133L,137L,143L,147L,149L,153L,159L,163L,169L,173L,175L,179L,185L,189L,191L,195L,199L,201L,205L,211L,215L,217L,221L,227L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086843Inst : IEnumerable<long>
{
public static readonly long[] Value=A086843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086843.Bytes);
public long this[int i]=>Value[i];

public static A086843Inst Instance=new A086843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086844
{
public static readonly long[] Value={ 5L,7L,13L,19L,21L,27L,29L,35L,37L,43L,49L,51L,57L,59L,65L,67L,71L,73L,79L,81L,87L,89L,95L,97L,101L,103L,109L,111L,117L,119L,125L,131L,133L,139L,141L,147L,149L,155L,161L,163L,169L,171L,177L,179L,183L,185L,191L,193L,199L,201L,207L,213L,215L,221L,223L,229L,231L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086844Inst : IEnumerable<long>
{
public static readonly long[] Value=A086844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086844.Bytes);
public long this[int i]=>Value[i];

public static A086844Inst Instance=new A086844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086845
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,12L,16L,19L,27L,32L,38L,42L,50L,55L,61L,65L,81L,90L,100L,106L,118L,125L,133L,138L,154L,163L,173L,179L,191L,198L,206L,211L,243L,260L,278L,288L,308L,319L,331L,338L,362L,375L,389L,397L,413L,422L,432L,438L,470L,487L,505L,515L,535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086845Inst : IEnumerable<long>
{
public static readonly long[] Value=A086845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086845.Bytes);
public long this[int i]=>Value[i];

public static A086845Inst Instance=new A086845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086846
{
public static readonly long[] Value={ 3L,10L,73L,241L,2504L,10537L,124363L,573928L,7407840L,35547994L,491316166L,2409600865L,34896253009L,174155363186L,2601913448896L,13163230391312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086846Inst : IEnumerable<long>
{
public static readonly long[] Value=A086846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086846.Bytes);
public long this[int i]=>Value[i];

public static A086846Inst Instance=new A086846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086847
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,1L,7L,2L,3L,1L,11L,1L,13L,1L,1L,2L,17L,2L,19L,1L,1L,2L,23L,1L,5L,1L,3L,1L,29L,10L,31L,2L,1L,1L,1L,2L,37L,1L,3L,5L,41L,3L,43L,2L,1L,2L,47L,3L,7L,2L,1L,1L,53L,1L,1L,1L,1L,2L,59L,2L,61L,1L,1L,2L,1L,3L,67L,1L,1L,1L,71L,2L,73L,2L,1L,1L,1L,6L,79L,5L,3L,1L,83L,1L,1L,2L,3L,2L,89L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086847Inst : IEnumerable<long>
{
public static readonly long[] Value=A086847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086847.Bytes);
public long this[int i]=>Value[i];

public static A086847Inst Instance=new A086847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086848
{
public static readonly long[] Value={ 42L,43L,98L,101L,145L,152L,185L,200L,222L,253L,264L,327L,327L,454L,443L,698L,676L,1187L,1154L,2177L,2133L,4180L,4125L,8220L,8154L,16345L,16268L,32651L,32563L,65330L,65231L,130766L,130656L,261727L,261606L,523749L,523617L,1047904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086848Inst : IEnumerable<long>
{
public static readonly long[] Value=A086848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086848.Bytes);
public long this[int i]=>Value[i];

public static A086848Inst Instance=new A086848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086849
{
public static readonly long[] Value={ 2L,5L,10L,16L,23L,31L,41L,52L,64L,77L,91L,106L,123L,141L,160L,180L,201L,223L,246L,270L,296L,323L,351L,380L,410L,441L,473L,506L,540L,575L,612L,650L,689L,729L,770L,812L,855L,899L,944L,990L,1037L,1085L,1135L,1186L,1238L,1291L,1345L,1400L,1456L,1513L,1571L,1630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086849Inst : IEnumerable<long>
{
public static readonly long[] Value=A086849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086849.Bytes);
public long this[int i]=>Value[i];

public static A086849Inst Instance=new A086849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086850
{
public static readonly long[] Value={ 1L,-1L,-3L,4L,8L,-4L,20L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086850Inst : IEnumerable<long>
{
public static readonly long[] Value=A086850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086850.Bytes);
public long this[int i]=>Value[i];

public static A086850Inst Instance=new A086850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086851
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-2L,1L,-3L,4L,10L,93L,8641L,74666872L,5575141774264374L,BigInteger.Parse("31082205803147712138788845611865"),BigInteger.Parse("966103517589229313003894215813508352493573272034098666228778213") };
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
public class A086851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086851Inst Instance=new A086851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087188
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,3L,4L,4L,5L,6L,6L,8L,9L,10L,13L,14L,16L,18L,20L,24L,27L,30L,35L,37L,42L,47L,51L,59L,64L,72L,81L,88L,98L,109L,120L,134L,147L,163L,179L,195L,216L,236L,258L,284L,310L,339L,371L,403L,441L,480L,523L,572L,621L,675L,734L,796L,865L,937L,1014L,1100L,1189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087188Inst : IEnumerable<long>
{
public static readonly long[] Value=A087188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087188.Bytes);
public long this[int i]=>Value[i];

public static A087188Inst Instance=new A087188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087189
{
public static readonly BigInteger[] Value={ 1L,83L,16907L,279021L,89444018L,1695011087L,658067703933L,5768410509553937L,122108313460051500L,BigInteger.Parse("1226978854222034501448"),BigInteger.Parse("593538703869555995238872"),BigInteger.Parse("13175226571428140572866093"),BigInteger.Parse("6594852118968926152838341468") };
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
public class A087189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087189Inst Instance=new A087189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087190
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,10L,12L,16L,17L,19L,25L,26L,28L,39L,55L,56L,58L,62L,67L,72L,75L,87L,91L,95L,96L,97L,102L,111L,114L,115L,116L,124L,126L,128L,132L,137L,152L,160L,161L,172L,181L,182L,184L,191L,198L,201L,205L,208L,209L,213L,214L,217L,220L,223L,227L,235L,237L,247L,248L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087190Inst : IEnumerable<long>
{
public static readonly long[] Value=A087190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087190.Bytes);
public long this[int i]=>Value[i];

public static A087190Inst Instance=new A087190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087191
{
public static readonly long[] Value={ 17L,131L,409L,953L,1889L,8669L,18539L,60623L,77689L,122321L,373049L,437293L,590267L,2249441L,8975009L,9649303L,11111117L,14526289L,19836689L,26484839L,31201649L,56608289L,67796273L,80565889L,84021983L,87588089L,107150489L,150402113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087191Inst : IEnumerable<long>
{
public static readonly long[] Value=A087191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087191.Bytes);
public long this[int i]=>Value[i];

public static A087191Inst Instance=new A087191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087192
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,15L,20L,27L,36L,48L,64L,86L,115L,154L,206L,275L,367L,490L,654L,872L,1163L,1551L,2068L,2758L,3678L,4904L,6539L,8719L,11626L,15502L,20670L,27560L,36747L,48996L,65328L,87104L,116139L,154852L,206470L,275294L,367059L,489412L,652550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087192Inst : IEnumerable<long>
{
public static readonly long[] Value=A087192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087192.Bytes);
public long this[int i]=>Value[i];

public static A087192Inst Instance=new A087192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087193
{
public static readonly BigInteger[] Value={ 3L,9L,156L,3431L,2280921L,64092034L,55747783602L,1700642242677L,1657887524047959L,BigInteger.Parse("54732141299289779730"),BigInteger.Parse("1783584256683646551447"),BigInteger.Parse("63884853139612229737722392") };
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
public class A087193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087193Inst Instance=new A087193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087194
{
public static readonly BigInteger[] Value={ 2L,29L,484398L,15667221L,19291710979L,716525463939L,1068605567805152L,BigInteger.Parse("70525663815429108660"),BigInteger.Parse("2926081151105727289330"),BigInteger.Parse("221376944251520543756333062") };
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
public class A087194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087194Inst Instance=new A087194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087195
{
public static readonly long[] Value={ 7L,13L,25L,31L,37L,49L,57L,97L,109L,133L,151L,183L,193L,307L,325L,381L,385L,393L,553L,751L,769L,871L,973L,993L,1407L,1453L,1537L,1723L,1893L,2257L,2367L,2745L,2863L,2917L,3073L,3541L,3751L,3783L,4557L,5113L,5203L,5403L,6145L,6321L,6973L,7221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087195Inst : IEnumerable<long>
{
public static readonly long[] Value=A087195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087195.Bytes);
public long this[int i]=>Value[i];

public static A087195Inst Instance=new A087195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087196
{
public static readonly long[] Value={ 7L,13L,31L,37L,97L,109L,151L,193L,307L,751L,769L,1453L,1723L,2917L,3541L,5113L,8011L,10303L,12289L,12697L,15973L,17293L,28057L,30103L,86143L,106033L,147073L,151687L,362953L,459007L,492103L,552793L,579883L,598303L,684757L,704761L,712891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087196Inst : IEnumerable<long>
{
public static readonly long[] Value=A087196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087196.Bytes);
public long this[int i]=>Value[i];

public static A087196Inst Instance=new A087196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087197
{
public static readonly long[] Value={ 5L,6L,4L,1L,8L,9L,5L,8L,3L,5L,4L,7L,7L,5L,6L,2L,8L,6L,9L,4L,8L,0L,7L,9L,4L,5L,1L,5L,6L,0L,7L,7L,2L,5L,8L,5L,8L,4L,4L,0L,5L,0L,6L,2L,9L,3L,2L,8L,9L,9L,8L,8L,5L,6L,8L,4L,4L,0L,8L,5L,7L,2L,1L,7L,1L,0L,6L,4L,2L,4L,6L,8L,4L,4L,1L,4L,9L,3L,4L,1L,4L,4L,8L,6L,7L,4L,3L,6L,6L,0L,2L,0L,2L,1L,0L,7L,3L,6L,3L,4L,4L,3L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087197Inst : IEnumerable<long>
{
public static readonly long[] Value=A087197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087197.Bytes);
public long this[int i]=>Value[i];

public static A087197Inst Instance=new A087197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087198
{
public static readonly long[] Value={ 2L,8L,2L,0L,9L,4L,7L,9L,1L,7L,7L,3L,8L,7L,8L,1L,4L,3L,4L,7L,4L,0L,3L,9L,7L,2L,5L,7L,8L,0L,3L,8L,6L,2L,9L,2L,9L,2L,2L,0L,2L,5L,3L,1L,4L,6L,6L,4L,4L,9L,9L,4L,2L,8L,4L,2L,2L,0L,4L,2L,8L,6L,0L,8L,5L,5L,3L,2L,1L,2L,3L,4L,2L,2L,0L,7L,4L,6L,7L,0L,7L,2L,4L,3L,3L,7L,1L,8L,3L,0L,1L,0L,1L,0L,5L,3L,6L,8L,1L,7L,2L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087198Inst : IEnumerable<long>
{
public static readonly long[] Value=A087198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087198.Bytes);
public long this[int i]=>Value[i];

public static A087198Inst Instance=new A087198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087199
{
public static readonly long[] Value={ 6L,2L,0L,3L,5L,0L,4L,9L,0L,8L,9L,9L,4L,0L,0L,0L,1L,6L,6L,6L,8L,0L,0L,6L,8L,1L,2L,0L,4L,7L,7L,7L,8L,1L,6L,7L,3L,5L,0L,7L,8L,6L,2L,0L,0L,1L,8L,6L,0L,0L,1L,6L,2L,0L,0L,9L,8L,9L,5L,6L,8L,8L,9L,9L,1L,3L,1L,4L,6L,9L,0L,6L,0L,6L,0L,0L,3L,3L,3L,6L,4L,1L,8L,5L,5L,1L,6L,2L,5L,3L,1L,8L,1L,4L,9L,2L,4L,3L,2L,8L,0L,0L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087199Inst : IEnumerable<long>
{
public static readonly long[] Value=A087199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087199.Bytes);
public long this[int i]=>Value[i];

public static A087199Inst Instance=new A087199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087200
{
public static readonly long[] Value={ 5L,7L,11L,17L,29L,29L,41L,37L,47L,89L,83L,101L,107L,67L,109L,73L,89L,167L,139L,229L,163L,193L,269L,157L,173L,523L,233L,157L,251L,193L,179L,383L,647L,311L,223L,317L,509L,457L,211L,503L,251L,479L,617L,1019L,347L,863L,827L,349L,389L,563L,601L,419L,367L,349L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087200Inst : IEnumerable<long>
{
public static readonly long[] Value=A087200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087200.Bytes);
public long this[int i]=>Value[i];

public static A087200Inst Instance=new A087200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087201
{
public static readonly long[] Value={ 11L,13L,17L,19L,47L,37L,61L,67L,79L,107L,53L,149L,97L,89L,109L,223L,107L,179L,181L,101L,197L,101L,257L,139L,137L,197L,313L,257L,257L,223L,449L,373L,233L,463L,479L,409L,257L,409L,383L,317L,587L,607L,401L,463L,347L,313L,751L,313L,443L,349L,809L,661L,587L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087201Inst : IEnumerable<long>
{
public static readonly long[] Value=A087201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087201.Bytes);
public long this[int i]=>Value[i];

public static A087201Inst Instance=new A087201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087202
{
public static readonly long[] Value={ 4L,5L,7L,7L,11L,13L,19L,31L,23L,19L,19L,43L,73L,41L,149L,41L,53L,61L,109L,37L,37L,71L,109L,193L,97L,173L,59L,101L,229L,163L,241L,83L,139L,103L,83L,577L,397L,47L,269L,61L,211L,107L,97L,89L,379L,149L,269L,83L,137L,167L,281L,89L,79L,443L,229L,157L,179L,563L,389L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087202Inst : IEnumerable<long>
{
public static readonly long[] Value=A087202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087202.Bytes);
public long this[int i]=>Value[i];

public static A087202Inst Instance=new A087202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087203
{
public static readonly long[] Value={ 4L,7L,11L,19L,19L,37L,17L,17L,17L,17L,61L,43L,59L,71L,61L,43L,113L,71L,41L,101L,191L,103L,191L,179L,71L,127L,37L,97L,113L,373L,71L,373L,293L,157L,149L,241L,167L,211L,151L,89L,131L,113L,73L,107L,179L,227L,173L,113L,257L,239L,151L,227L,163L,509L,293L,347L,643L,373L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087203Inst : IEnumerable<long>
{
public static readonly long[] Value=A087203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087203.Bytes);
public long this[int i]=>Value[i];

public static A087203Inst Instance=new A087203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087204
{
public static readonly long[] Value={ 2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087204Inst : IEnumerable<long>
{
public static readonly long[] Value=A087204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087204.Bytes);
public long this[int i]=>Value[i];

public static A087204Inst Instance=new A087204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087205
{
public static readonly long[] Value={ 1L,2L,0L,8L,-16L,64L,-192L,640L,-2048L,6656L,-21504L,69632L,-225280L,729088L,-2359296L,7634944L,-24707072L,79953920L,-258736128L,837287936L,-2709520384L,8768192512L,-28374466560L,91821703168L,-297141272576L,961569357824L,-3111703805952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087205Inst : IEnumerable<long>
{
public static readonly long[] Value=A087205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087205.Bytes);
public long this[int i]=>Value[i];

public static A087205Inst Instance=new A087205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087206
{
public static readonly long[] Value={ 1L,4L,12L,40L,128L,416L,1344L,4352L,14080L,45568L,147456L,477184L,1544192L,4997120L,16171008L,52330496L,169345024L,548012032L,1773404160L,5738856448L,18571329536L,60098084864L,194481487872L,629355315200L,2036636581888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087206Inst : IEnumerable<long>
{
public static readonly long[] Value=A087206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087206.Bytes);
public long this[int i]=>Value[i];

public static A087206Inst Instance=new A087206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087207
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,3L,8L,1L,2L,5L,16L,3L,32L,9L,6L,1L,64L,3L,128L,5L,10L,17L,256L,3L,4L,33L,2L,9L,512L,7L,1024L,1L,18L,65L,12L,3L,2048L,129L,34L,5L,4096L,11L,8192L,17L,6L,257L,16384L,3L,8L,5L,66L,33L,32768L,3L,20L,9L,130L,513L,65536L,7L,131072L,1025L,10L,1L,36L,19L,262144L,65L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087207Inst : IEnumerable<long>
{
public static readonly long[] Value=A087207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087207.Bytes);
public long this[int i]=>Value[i];

public static A087207Inst Instance=new A087207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087208
{
public static readonly long[] Value={ 1L,1L,3L,7L,37L,141L,1111L,5923L,62217L,426457L,5599531L,46910271L,739138093L,7318002277L,134523132927L,1536780478171L,32285551902481L,418004290062513L,9879378882159187L,142957467201379447L,3754163975220491061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087208Inst : IEnumerable<long>
{
public static readonly long[] Value=A087208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087208.Bytes);
public long this[int i]=>Value[i];

public static A087208Inst Instance=new A087208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087209
{
public static readonly long[] Value={ 3L,29L,45L,76L,162L,192L,397L,405L,612L,650L,1025L,1098L,1275L,1856L,2064L,2160L,2187L,2880L,3420L,4864L,5499L,6831L,6875L,8775L,9072L,10368L,12288L,12348L,15000L,21096L,21141L,25408L,25920L,26811L,29079L,30600L,30758L,32805L,33957L,36875L,39168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087209Inst : IEnumerable<long>
{
public static readonly long[] Value=A087209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087209.Bytes);
public long this[int i]=>Value[i];

public static A087209Inst Instance=new A087209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087210
{
public static readonly long[] Value={ 3L,29L,76L,397L,143027L,175784L,298483L,648613L,4146689L,4308693L,7079295L,8288063L,8893220L,22015007L,30042907L,54142096L,101907569L,109233295L,395856397L,444716637L,474554340L,579133627L,655054991L,949475843L,1036435896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087210Inst : IEnumerable<long>
{
public static readonly long[] Value=A087210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087210.Bytes);
public long this[int i]=>Value[i];

public static A087210Inst Instance=new A087210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087211
{
public static readonly long[] Value={ 1L,2L,4L,12L,32L,92L,264L,772L,2272L,6732L,20024L,59732L,178512L,534172L,1599784L,4793892L,14370752L,43090412L,129227544L,387595252L,1162610992L,3487483452L,10461751304L,31383855812L,94148771232L,282440721292L,847310979064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087211Inst : IEnumerable<long>
{
public static readonly long[] Value=A087211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087211.Bytes);
public long this[int i]=>Value[i];

public static A087211Inst Instance=new A087211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087212
{
public static readonly long[] Value={ 4L,10L,1L,16L,17L,13L,12L,11L,11L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087212Inst : IEnumerable<long>
{
public static readonly long[] Value=A087212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087212.Bytes);
public long this[int i]=>Value[i];

public static A087212Inst Instance=new A087212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087213
{
public static readonly long[] Value={ 1L,0L,0L,4L,-4L,20L,-20L,84L,-84L,340L,-340L,1364L,-1364L,5460L,-5460L,21844L,-21844L,87380L,-87380L,349524L,-349524L,1398100L,-1398100L,5592404L,-5592404L,22369620L,-22369620L,89478484L,-89478484L,357913940L,-357913940L,1431655764L,-1431655764L,5726623060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087213Inst : IEnumerable<long>
{
public static readonly long[] Value=A087213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087213.Bytes);
public long this[int i]=>Value[i];

public static A087213Inst Instance=new A087213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087214
{
public static readonly ulong[] Value={ 1L,1L,2L,4L,13L,41L,196L,862L,5489L,31033L,247006L,1706816L,16302397L,133131649L,1483518128L,13978823146L,178022175361L,1901119947857L,27237392830234L,325091511083548L,5175104637744461L,68269217327545081L,1195449171318970492L,17272111983868905494UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087214Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A087214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087214.Bytes);
public ulong this[int i]=>Value[i];

public static A087214Inst Instance=new A087214Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087215
{
public static readonly BigInteger[] Value={ 2L,18L,322L,5778L,103682L,1860498L,33385282L,599074578L,10749957122L,192900153618L,3461452808002L,62113250390418L,1114577054219522L,20000273725560978L,358890350005878082L,6440026026380244498L,BigInteger.Parse("115561578124838522882"),BigInteger.Parse("2073668380220713167378") };
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
public class A087215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087215Inst Instance=new A087215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087216
{
public static readonly BigInteger[] Value={ 1L,30L,6930L,3063060L,2007835830L,1746817172100L,1895296631728500L,2464427134570401000L,BigInteger.Parse("3735455429225085315750"),BigInteger.Parse("6467318499798364376668500"),BigInteger.Parse("12591869119107415441373569500"),BigInteger.Parse("27232778758505946668207019855000") };
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
public class A087216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087216Inst Instance=new A087216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087217
{
public static readonly long[] Value={ 10L,12L,30L,24L,15L,36L,70L,48L,90L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,120L,210L,220L,230L,240L,125L,260L,270L,280L,290L,300L,310L,320L,330L,340L,350L,360L,370L,380L,390L,240L,410L,420L,430L,440L,450L,460L,470L,480L,490L,150L,510L,520L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087217Inst : IEnumerable<long>
{
public static readonly long[] Value=A087217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087217.Bytes);
public long this[int i]=>Value[i];

public static A087217Inst Instance=new A087217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087218
{
public static readonly long[] Value={ 1L,1L,3L,6L,13L,30L,66L,147L,327L,726L,1614L,3588L,7974L,17725L,39399L,87573L,194655L,432669L,961716L,2137659L,4751490L,10561392L,23475378L,52179987L,115983270L,257802273L,573031011L,1273706934L,2831137095L,6292921101L,13987615113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087218Inst : IEnumerable<long>
{
public static readonly long[] Value=A087218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087218.Bytes);
public long this[int i]=>Value[i];

public static A087218Inst Instance=new A087218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087219
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,44L,99L,219L,487L,1083L,2406L,5349L,11889L,26426L,58739L,130563L,290208L,645062L,1433814L,3187014L,7083951L,15745878L,34999212L,77794638L,172918335L,384354909L,854326387L,1898957331L,4220914872L,9382055124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087219Inst : IEnumerable<long>
{
public static readonly long[] Value=A087219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087219.Bytes);
public long this[int i]=>Value[i];

public static A087219Inst Instance=new A087219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087220
{
public static readonly long[] Value={ 1L,2L,-2L,-12L,126L,-84L,-10532L,72584L,1398454L,-23934644L,-279791836L,10005551128L,74538179116L,-5628788533000L,-20339727800264L,4187789575589776L,-1855072071151834L,-4010464443848609780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087220Inst : IEnumerable<long>
{
public static readonly long[] Value=A087220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087220.Bytes);
public long this[int i]=>Value[i];

public static A087220Inst Instance=new A087220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087221
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,10L,14L,19L,26L,36L,50L,69L,96L,133L,184L,254L,352L,488L,676L,935L,1294L,1792L,2482L,3436L,4756L,6584L,9116L,12621L,17473L,24190L,33490L,46365L,64190L,88868L,123034L,170334L,235818L,326478L,451994L,625764L,866338L,1199400L,1660510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087221Inst : IEnumerable<long>
{
public static readonly long[] Value=A087221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087221.Bytes);
public long this[int i]=>Value[i];

public static A087221Inst Instance=new A087221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087222
{
public static readonly long[] Value={ 1L,1L,4L,10L,26L,69L,184L,488L,1294L,3436L,9116L,24190L,64190L,170334L,451994L,1199400L,3182706L,8445556L,22410946L,59469200L,157806184L,418751069L,1111188772L,2948626472L,7824411358L,20762688580L,55095420880L,146200015984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087222Inst : IEnumerable<long>
{
public static readonly long[] Value=A087222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087222.Bytes);
public long this[int i]=>Value[i];

public static A087222Inst Instance=new A087222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087223
{
public static readonly long[] Value={ 1L,2L,5L,14L,36L,96L,254L,676L,1792L,4756L,12621L,33490L,88868L,235818L,625764L,1660510L,4406296L,11692452L,31026836L,82332140L,218474784L,579739960L,1538385398L,4082226194L,10832507040L,28744906148L,76276860598L,202406625820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087223Inst : IEnumerable<long>
{
public static readonly long[] Value=A087223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087223.Bytes);
public long this[int i]=>Value[i];

public static A087223Inst Instance=new A087223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087224
{
public static readonly long[] Value={ 1L,3L,7L,19L,50L,133L,352L,935L,2482L,6584L,17473L,46365L,123034L,326478L,866338L,2298895L,6100296L,16187616L,42955106L,113984740L,302467434L,802621041L,2129817812L,5651638433L,14997065388L,39795888008L,105601506802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087224Inst : IEnumerable<long>
{
public static readonly long[] Value=A087224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087224.Bytes);
public long this[int i]=>Value[i];

public static A087224Inst Instance=new A087224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087225
{
public static readonly long[] Value={ 1L,1L,4L,1L,2L,5L,6L,1L,9L,3L,4L,6L,2L,7L,8L,1L,2L,10L,4L,1L,2L,5L,6L,1L,7L,3L,78L,8L,2L,9L,73L,1L,2L,3L,4L,11L,2L,5L,11L,1L,76L,3L,4L,6L,2L,7L,71L,1L,2L,8L,4L,1L,2L,79L,79L,1L,7L,3L,9L,10L,2L,74L,74L,1L,2L,3L,4L,1L,2L,5L,69L,1L,82L,3L,4L,6L,2L,12L,8L,1L,2L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087225Inst : IEnumerable<long>
{
public static readonly long[] Value=A087225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087225.Bytes);
public long this[int i]=>Value[i];

public static A087225Inst Instance=new A087225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087226
{
public static readonly BigInteger[] Value={ 1L,2L,240L,4L,80L,240L,1361360L,8L,12252240L,80L,194480L,240L,1040L,1361360L,4095840L,16L,17680L,12252240L,107158480L,80L,1344L,194480L,1365280L,240L,535792400L,1040L,BigInteger.Parse("44841486948146266934850832405421294927083491752830032389039800908293040266400") };
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
public class A087226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087226Inst Instance=new A087226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087227
{
public static readonly long[] Value={ 0L,1L,3L,1L,2L,3L,6L,1L,7L,2L,5L,3L,3L,6L,6L,1L,4L,7L,7L,2L,3L,5L,5L,3L,7L,3L,37L,6L,6L,6L,35L,1L,8L,4L,4L,7L,7L,7L,12L,2L,36L,3L,8L,5L,5L,5L,35L,3L,7L,7L,8L,3L,3L,37L,35L,6L,10L,6L,11L,6L,6L,35L,36L,1L,7L,8L,9L,4L,5L,4L,34L,7L,36L,7L,5L,7L,7L,12L,12L,2L,7L,36L,35L,3L,3L,8L,11L,5L,10L,5L,32L,5L,6L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087227Inst : IEnumerable<long>
{
public static readonly long[] Value=A087227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087227.Bytes);
public long this[int i]=>Value[i];

public static A087227Inst Instance=new A087227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087228
{
public static readonly long[] Value={ 2L,5L,3L,17L,11L,7L,9L,33L,67L,57L,59L,39L,105L,185L,191L,123L,225L,219L,239L,159L,319L,283L,251L,167L,335L,111L,297L,175L,233L,155L,103L,91L,107L,71L,31L,41L,27L,193L,129L,231L,171L,463L,327L,411L,859L,731L,487L,649L,639L,1153L,1563L,1607L,1071L,1215L,1307L,871L,1161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087228Inst : IEnumerable<long>
{
public static readonly long[] Value=A087228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087228.Bytes);
public long this[int i]=>Value[i];

public static A087228Inst Instance=new A087228Inst();

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