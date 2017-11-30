using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A186968
{
public static readonly long[] Value={ 0L,0L,5120L,77384L,473632L,1875432L,5706000L,14543984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186968Inst : IEnumerable<long>
{
public static readonly long[] Value=A186968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186968.Bytes);
public long this[int i]=>Value[i];

public static A186968Inst Instance=new A186968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186969
{
public static readonly long[] Value={ 3L,5L,5L,4259L,25409L,25409L,512819L,512819L,17733438029L,1095010766849L,766405913232959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186969Inst : IEnumerable<long>
{
public static readonly long[] Value=A186969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186969.Bytes);
public long this[int i]=>Value[i];

public static A186969Inst Instance=new A186969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186970
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,3L,6L,4L,8L,5L,10L,7L,12L,8L,9L,12L,16L,11L,18L,12L,14L,14L,22L,9L,24L,16L,18L,18L,28L,13L,30L,16L,22L,21L,25L,24L,36L,24L,27L,17L,40L,17L,42L,30L,33L,29L,46L,27L,48L,32L,36L,36L,52L,24L,42L,25L,40L,37L,58L,28L,60L,40L,49L,48L,50L,30L,66L,48L,49L,35L,70L,32L,72L,48L,54L,54L,61L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186970Inst : IEnumerable<long>
{
public static readonly long[] Value=A186970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186970.Bytes);
public long this[int i]=>Value[i];

public static A186970Inst Instance=new A186970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186971
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,3L,5L,5L,5L,4L,6L,5L,7L,6L,6L,7L,8L,7L,9L,8L,8L,8L,10L,9L,10L,9L,10L,9L,11L,9L,12L,12L,11L,11L,11L,11L,13L,12L,12L,12L,14L,12L,15L,14L,14L,14L,16L,15L,16L,15L,15L,15L,17L,16L,16L,16L,16L,16L,18L,16L,19L,18L,18L,19L,18L,17L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186971Inst : IEnumerable<long>
{
public static readonly long[] Value=A186971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186971.Bytes);
public long this[int i]=>Value[i];

public static A186971Inst Instance=new A186971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187052
{
public static readonly long[] Value={ 0L,0L,0L,80L,22200L,226864L,961728L,2625640L,5543744L,9907248L,15787528L,23174472L,32030516L,42322492L,54034656L,67163804L,81709936L,97673052L,115053152L,133850236L,154064304L,175695356L,198743392L,223208412L,249090416L,276389404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187052Inst : IEnumerable<long>
{
public static readonly long[] Value=A187052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187052.Bytes);
public long this[int i]=>Value[i];

public static A187052Inst Instance=new A187052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187053
{
public static readonly long[] Value={ 1L,-3L,9L,-22L,48L,-99L,194L,-363L,657L,-1155L,1977L,-3312L,5443L,-8787L,13968L,-21894L,33873L,-51795L,78345L,-117312L,174033L,-255945L,373353L,-540486L,776848L,-1109040L,1573209L,-2218198L,3109713L,-4335840L,6014123L,-8300811L,11402928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187053Inst : IEnumerable<long>
{
public static readonly long[] Value=A187053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187053.Bytes);
public long this[int i]=>Value[i];

public static A187053Inst Instance=new A187053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187054
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,15L,23L,31L,87L,111L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187054Inst : IEnumerable<long>
{
public static readonly long[] Value=A187054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187054.Bytes);
public long this[int i]=>Value[i];

public static A187054Inst Instance=new A187054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187055
{
public static readonly long[] Value={ 1L,4L,1L,14L,8L,1L,46L,44L,12L,1L,141L,204L,90L,16L,1L,409L,846L,538L,152L,20L,1L,1132L,3234L,2787L,1112L,230L,24L,1L,3011L,11600L,13035L,6892L,1990L,324L,28L,1L,7736L,39502L,56372L,37956L,14345L,3236L,434L,32L,1L,19275L,128765L,228921L,191008L,90749L,26586L,4914L,560L,36L,1L,46724L,404228L,882291L,894364L,519580L,189798L,45311L,7088L,702L,40L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187055Inst : IEnumerable<long>
{
public static readonly long[] Value=A187055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187055.Bytes);
public long this[int i]=>Value[i];

public static A187055Inst Instance=new A187055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187056
{
public static readonly long[] Value={ 1L,7L,4L,1L,131L,176L,96L,16L,1L,3067L,6588L,5895L,2416L,477L,36L,1L,79459L,235456L,298816L,197824L,73120L,14656L,1504L,64L,1L,2181257L,8252300L,13668975L,12563200L,6966400L,2373504L,490700L,58400L,3675L,100L,1L,62165039L,286326288L,587324232L,692965040L,516541455L,252283968L,81432456L,17138304L,2276145L,179440L,7632L,144L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187056Inst : IEnumerable<long>
{
public static readonly long[] Value=A187056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187056.Bytes);
public long this[int i]=>Value[i];

public static A187056Inst Instance=new A187056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187057
{
public static readonly long[] Value={ 11L,17L,41L,347L,641L,1277L,1427L,1607L,2687L,3527L,4001L,4637L,4931L,13901L,19421L,21011L,21557L,22271L,23741L,26681L,26711L,27941L,28277L,31247L,32057L,33617L,43781L,45821L,55331L,55661L,55817L,68207L,68897L,71327L,91571L,97367L,113147L,128657L,128981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187057Inst : IEnumerable<long>
{
public static readonly long[] Value=A187057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187057.Bytes);
public long this[int i]=>Value[i];

public static A187057Inst Instance=new A187057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187058
{
public static readonly long[] Value={ 11L,17L,41L,1277L,1607L,3527L,13901L,21557L,26681L,28277L,31247L,33617L,55661L,68897L,97367L,113147L,128981L,166841L,195731L,221717L,347981L,348431L,354371L,416387L,421697L,506327L,548831L,566537L,665111L,844427L,929057L,954257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187058Inst : IEnumerable<long>
{
public static readonly long[] Value=A187058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187058.Bytes);
public long this[int i]=>Value[i];

public static A187058Inst Instance=new A187058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187059
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,2L,4L,0L,17L,10L,12L,4L,18L,8L,11L,0L,49L,34L,36L,20L,42L,24L,27L,8L,58L,36L,39L,16L,47L,22L,26L,0L,129L,98L,100L,68L,106L,72L,75L,40L,122L,84L,87L,48L,95L,54L,58L,16L,162L,116L,119L,72L,127L,78L,82L,32L,147L,94L,98L,44L,108L,52L,57L,0L,321L,258L,260L,196L,266L,200L,203L,136L,282L,212L,215L,144L,223L,150L,154L,80L,322L,244L,247L,168L,255L,174L,178L,96L,275L,190L,194L,108L,204L,116L,121L,32L,418L,324L,327L,232L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187059Inst : IEnumerable<long>
{
public static readonly long[] Value=A187059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187059.Bytes);
public long this[int i]=>Value[i];

public static A187059Inst Instance=new A187059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187060
{
public static readonly long[] Value={ 11L,17L,41L,21557L,26681L,128981L,844427L,2073347L,3992201L,4889237L,6184637L,11900501L,21456047L,24598361L,33771581L,34864211L,50943791L,51448361L,51867197L,55793951L,56421347L,61218251L,67787537L,69726647L,76345121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187060Inst : IEnumerable<long>
{
public static readonly long[] Value=A187060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187060.Bytes);
public long this[int i]=>Value[i];

public static A187060Inst Instance=new A187060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187061
{
public static readonly long[] Value={ 3L,8L,6L,7L,4L,9L,9L,7L,0L,7L,1L,4L,3L,0L,0L,7L,0L,6L,1L,7L,1L,5L,2L,4L,8L,0L,3L,4L,8L,5L,5L,8L,0L,9L,3L,9L,6L,6L,1L,4L,4L,7L,6L,1L,5L,5L,6L,3L,0L,7L,7L,5L,0L,5L,1L,4L,7L,5L,0L,2L,8L,0L,5L,6L,8L,1L,2L,2L,4L,0L,7L,0L,7L,5L,8L,0L,5L,2L,9L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187061Inst : IEnumerable<long>
{
public static readonly long[] Value=A187061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187061.Bytes);
public long this[int i]=>Value[i];

public static A187061Inst Instance=new A187061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187062
{
public static readonly long[] Value={ 0L,0L,8L,14L,26L,42L,64L,90L,134L,172L,232L,300L,378L,464L,584L,690L,834L,990L,1160L,1342L,1574L,1784L,2048L,2328L,2626L,2940L,3320L,3670L,4090L,4530L,4992L,5474L,6038L,6564L,7176L,7812L,8474L,9160L,9944L,10682L,11522L,12390L,13288L,14214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187062Inst : IEnumerable<long>
{
public static readonly long[] Value=A187062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187062.Bytes);
public long this[int i]=>Value[i];

public static A187062Inst Instance=new A187062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187063
{
public static readonly BigInteger[] Value={ 5L,21L,85L,341L,5461L,21845L,22369621L,89478485L,1431655765L,5726623061L,91625968981L,1501199875790165L,1537228672809129301L,BigInteger.Parse("98382635059784275285"),BigInteger.Parse("1690200800304305868662270940501"),BigInteger.Parse("1772303994379887830538409413707126101") };
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
public class A187063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187063Inst Instance=new A187063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187064
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,3L,1L,4L,5L,7L,5L,3L,1L,5L,11L,19L,24L,26L,22L,16L,9L,4L,1L,6L,7L,15L,18L,23L,21L,21L,15L,11L,6L,3L,1L,7L,15L,32L,52L,77L,99L,120L,128L,130L,119L,102L,79L,57L,36L,21L,10L,4L,1L,8L,17L,36L,58L,93L,125L,165L,193L,220L,229L,231L,213L,191L,157L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187064Inst : IEnumerable<long>
{
public static readonly long[] Value=A187064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187064.Bytes);
public long this[int i]=>Value[i];

public static A187064Inst Instance=new A187064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187065
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,1L,1L,3L,5L,4L,5L,9L,14L,14L,19L,28L,42L,47L,66L,89L,131L,155L,221L,286L,417L,507L,728L,924L,1341L,1652L,2380L,2993L,4334L,5373L,7753L,9707L,14041L,17460L,25213L,31501L,45542L,56714L,81927L,102256L,147798L,184183L,266110L,331981L,479779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187065Inst : IEnumerable<long>
{
public static readonly long[] Value=A187065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187065.Bytes);
public long this[int i]=>Value[i];

public static A187065Inst Instance=new A187065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187066
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,1L,1L,3L,5L,4L,5L,9L,14L,14L,19L,28L,42L,47L,66L,89L,131L,155L,221L,286L,417L,507L,728L,924L,1341L,1652L,2380L,2993L,4334L,5373L,7753L,9707L,14041L,17460L,25213L,31501L,45542L,56714L,81927L,102256L,147798L,184183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187066Inst : IEnumerable<long>
{
public static readonly long[] Value=A187066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187066.Bytes);
public long this[int i]=>Value[i];

public static A187066Inst Instance=new A187066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187067
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,3L,3L,4L,6L,9L,10L,14L,19L,28L,33L,47L,61L,89L,108L,155L,197L,286L,352L,507L,638L,924L,1145L,1652L,2069L,2993L,3721L,5373L,6714L,9707L,12087L,17460L,21794L,31501L,39254L,56714L,70755L,102256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187067Inst : IEnumerable<long>
{
public static readonly long[] Value=A187067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187067.Bytes);
public long this[int i]=>Value[i];

public static A187067Inst Instance=new A187067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187116
{
public static readonly BigInteger[] Value={ 1L,4L,20L,138L,1258L,14476L,202655L,3354848L,64246776L,1398909332L,34157026526L,924757926320L,27503093599024L,891534666547216L,31289986924954924L,1182213869836721036L,BigInteger.Parse("47846600590876178320"),BigInteger.Parse("2065282617724684345208") };
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
public class A187116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187116Inst Instance=new A187116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187117
{
public static readonly BigInteger[] Value={ 1L,6L,39L,318L,3242L,40348L,598083L,10337402L,204706486L,4577520108L,114208773268L,3147671423964L,95023271024164L,3119560618275648L,110684959354534001L,4221624141483353436L,BigInteger.Parse("172274971776090819870") };
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
public class A187117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187117Inst Instance=new A187117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187118
{
public static readonly BigInteger[] Value={ 1L,3L,12L,67L,512L,5143L,64988L,995334L,17948683L,372703529L,8759307844L,229843336284L,6660078541359L,211201170221925L,7274712426981184L,270441300892307916L,10791919593795653296UL,BigInteger.Parse("460087687818627367809") };
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
public class A187118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187118Inst Instance=new A187118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187119
{
public static readonly long[] Value={ 1L,-2L,4L,-12L,36L,-140L,519L,-2632L,11776L,-82020L,426990L,-4149112L,22719260L,-309921456L,1487214652L,-31477804596L,82495148888L,-4227929653508L,-7155535440434L,-767565126075852L,-6245080462329816L,-194907866415800464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187119Inst : IEnumerable<long>
{
public static readonly long[] Value=A187119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187119.Bytes);
public long this[int i]=>Value[i];

public static A187119Inst Instance=new A187119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187120
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,15L,1L,9L,42L,112L,1L,12L,81L,377L,1128L,1L,15L,132L,855L,4248L,14373L,1L,18L,195L,1606L,10758L,58269L,221952L,1L,21L,270L,2690L,22416L,159633L,947117L,4029915L,1L,24L,357L,4167L,41340L,359616L,2750067L,17848872L,84135510L,1L,27L,456L,6097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187120Inst : IEnumerable<long>
{
public static readonly long[] Value=A187120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187120.Bytes);
public long this[int i]=>Value[i];

public static A187120Inst Instance=new A187120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187121
{
public static readonly BigInteger[] Value={ 1L,6L,42L,377L,4248L,58269L,947117L,17848872L,383237040L,9243654925L,247586590398L,7293962774574L,234458181733224L,8167132024738422L,306500617604837898L,12329458457556027538UL,BigInteger.Parse("529269910501209999900") };
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
public class A187121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187121Inst Instance=new A187121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187122
{
public static readonly BigInteger[] Value={ 1L,9L,81L,855L,10758L,159633L,2750067L,54178485L,1204443432L,29871630837L,818490738402L,24571782872034L,802459134168208L,28332664539686670L,1075700621922471621L,BigInteger.Parse("43710289920461797346"),BigInteger.Parse("1893011243289589171122") };
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
public class A187122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187122Inst Instance=new A187122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187123
{
public static readonly BigInteger[] Value={ 1L,4L,22L,164L,1599L,19624L,292799L,5162063L,105139954L,2430528374L,62877375426L,1799698534522L,56461862815496L,1926534563625822L,71024188655886038L,2813193432059656268L,BigInteger.Parse("119136308527407025379"),BigInteger.Parse("5371507426340905440926") };
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
public class A187123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187123Inst Instance=new A187123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187124
{
public static readonly long[] Value={ 1L,-3L,6L,-18L,48L,-195L,549L,-3465L,7452L,-112707L,-5994L,-6866904L,-25659292L,-700243362L,-5594278734L,-106900155574L,-1284177510456L,-22692117042216L,-348993455353854L,-6343625959542180L,-114598750263323292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187124Inst : IEnumerable<long>
{
public static readonly long[] Value=A187124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187124.Bytes);
public long this[int i]=>Value[i];

public static A187124Inst Instance=new A187124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187125
{
public static readonly long[] Value={ 1074107L,1076107L,1079107L,1093109L,1098109L,1114111L,1117111L,1131113L,1134113L,1171117L,1191119L,1193119L,1196119L,1212121L,1215121L,1218121L,1273127L,1294129L,1297129L,1311131L,1317131L,1333133L,1336133L,1371137L,1373137L,1377137L,1379137L,1398139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187125Inst : IEnumerable<long>
{
public static readonly long[] Value=A187125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187125.Bytes);
public long this[int i]=>Value[i];

public static A187125Inst Instance=new A187125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187126
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,10L,11L,15L,16L,20L,21L,25L,26L,28L,30L,31L,35L,36L,40L,41L,45L,46L,50L,51L,55L,56L,60L,61L,65L,66L,70L,71L,75L,76L,78L,80L,81L,85L,86L,90L,91L,95L,96L,100L,101L,105L,106L,110L,111L,115L,116L,120L,121L,125L,126L,128L,130L,131L,135L,136L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187126Inst : IEnumerable<long>
{
public static readonly long[] Value=A187126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187126.Bytes);
public long this[int i]=>Value[i];

public static A187126Inst Instance=new A187126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187127
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,10L,11L,15L,16L,20L,21L,25L,26L,28L,30L,31L,35L,36L,40L,41L,45L,46L,50L,51L,53L,55L,56L,60L,61L,65L,66L,70L,71L,75L,76L,78L,80L,81L,85L,86L,90L,91L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187127Inst : IEnumerable<long>
{
public static readonly long[] Value=A187127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187127.Bytes);
public long this[int i]=>Value[i];

public static A187127Inst Instance=new A187127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187128
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,5L,2L,2L,3L,2L,5L,2L,3L,7L,2L,2L,3L,2L,2L,3L,5L,2L,2L,7L,2L,3L,5L,2L,2L,11L,3L,7L,2L,2L,3L,2L,11L,2L,5L,2L,3L,13L,2L,5L,7L,2L,3L,2L,2L,3L,7L,2L,2L,11L,3L,2L,5L,13L,2L,2L,3L,11L,5L,2L,17L,7L,2L,13L,3L,2L,2L,3L,2L,17L,2L,5L,2L,3L,19L,11L,2L,2L,5L,3L,13L,2L,2L,7L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187128Inst : IEnumerable<long>
{
public static readonly long[] Value=A187128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187128.Bytes);
public long this[int i]=>Value[i];

public static A187128Inst Instance=new A187128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187129
{
public static readonly long[] Value={ 2L,3L,5L,12L,7L,18L,24L,24L,30L,47L,49L,55L,40L,59L,48L,100L,102L,50L,89L,120L,109L,136L,181L,158L,117L,199L,133L,170L,252L,133L,261L,300L,98L,267L,324L,279L,303L,419L,244L,303L,494L,345L,260L,593L,302L,343L,503L,207L,452L,612L,399L,488L,668L,526L,619L,872L,574L,540L,1082L,352L,475L,920L,273L,691L,865L,598L,523L,822L,725L,864L,1211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187129Inst : IEnumerable<long>
{
public static readonly long[] Value=A187129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187129.Bytes);
public long this[int i]=>Value[i];

public static A187129Inst Instance=new A187129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187130
{
public static readonly long[] Value={ 1L,-3L,2L,0L,1L,0L,0L,0L,-2L,0L,-2L,0L,2L,0L,4L,0L,3L,0L,-4L,0L,-8L,0L,-4L,0L,5L,0L,14L,0L,7L,0L,-8L,0L,-20L,0L,-12L,0L,14L,0L,28L,0L,17L,0L,-20L,0L,-44L,0L,-24L,0L,28L,0L,66L,0L,36L,0L,-40L,0L,-90L,0L,-52L,0L,56L,0L,124L,0L,71L,0L,-80L,0L,-176L,0L,-96L,0L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187130Inst : IEnumerable<long>
{
public static readonly long[] Value=A187130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187130.Bytes);
public long this[int i]=>Value[i];

public static A187130Inst Instance=new A187130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187131
{
public static readonly BigInteger[] Value={ 1L,1L,9L,1521L,71622369L,233297499911422401L,BigInteger.Parse("3390052406222940758260506721830900609"),BigInteger.Parse("934785860242188709610961043825803400592180434378516146129897302939414193921") };
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
public class A187131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187131Inst Instance=new A187131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187196
{
public static readonly long[] Value={ 1L,-2L,-1L,0L,7L,0L,-9L,0L,10L,0L,-23L,0L,38L,0L,-47L,0L,75L,0L,-112L,0L,148L,0L,-217L,0L,293L,0L,-385L,0L,553L,0L,-728L,0L,928L,0L,-1272L,0L,1670L,0L,-2111L,0L,2765L,0L,-3566L,0L,4504L,0L,-5784L,0L,7300L,0L,-9123L,0L,11592L,0L,-14458L,0L,17838L,0L,-22342L,0L,27668L,0L,-33884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187196Inst : IEnumerable<long>
{
public static readonly long[] Value=A187196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187196.Bytes);
public long this[int i]=>Value[i];

public static A187196Inst Instance=new A187196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187197
{
public static readonly long[] Value={ 1L,2L,-1L,0L,7L,0L,-9L,0L,10L,0L,-23L,0L,38L,0L,-47L,0L,75L,0L,-112L,0L,148L,0L,-217L,0L,293L,0L,-385L,0L,553L,0L,-728L,0L,928L,0L,-1272L,0L,1670L,0L,-2111L,0L,2765L,0L,-3566L,0L,4504L,0L,-5784L,0L,7300L,0L,-9123L,0L,11592L,0L,-14458L,0L,17838L,0L,-22342L,0L,27668L,0L,-33884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187197Inst : IEnumerable<long>
{
public static readonly long[] Value=A187197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187197.Bytes);
public long this[int i]=>Value[i];

public static A187197Inst Instance=new A187197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187198
{
public static readonly long[] Value={ 1L,5L,14L,36L,85L,180L,360L,684L,1246L,2196L,3754L,6264L,10226L,16380L,25804L,40032L,61275L,92628L,138452L,204804L,300040L,435672L,627356L,896400L,1271525L,1791324L,2507426L,3488472L,4825531L,6638688L,9085888L,12373992L,16772908L,22633812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187198Inst : IEnumerable<long>
{
public static readonly long[] Value=A187198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187198.Bytes);
public long this[int i]=>Value[i];

public static A187198Inst Instance=new A187198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187199
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,5L,2L,3L,3L,4L,6L,3L,6L,4L,2L,5L,4L,6L,4L,3L,5L,7L,4L,5L,7L,5L,4L,6L,6L,5L,5L,6L,6L,4L,8L,5L,5L,9L,10L,7L,9L,8L,7L,5L,8L,11L,5L,6L,6L,7L,8L,7L,6L,6L,7L,7L,7L,9L,4L,4L,8L,8L,10L,5L,7L,8L,7L,9L,8L,12L,6L,10L,6L,8L,6L,10L,7L,9L,9L,8L,7L,8L,7L,9L,8L,7L,8L,8L,9L,9L,10L,8L,10L,9L,8L,11L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187199Inst : IEnumerable<long>
{
public static readonly long[] Value=A187199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187199.Bytes);
public long this[int i]=>Value[i];

public static A187199Inst Instance=new A187199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187200
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,5L,4L,5L,5L,6L,6L,5L,5L,6L,6L,7L,7L,7L,8L,7L,6L,8L,9L,6L,6L,10L,7L,8L,8L,7L,8L,7L,11L,7L,9L,8L,9L,8L,10L,9L,8L,9L,8L,9L,9L,9L,12L,10L,10L,9L,10L,9L,11L,10L,13L,12L,10L,10L,11L,11L,11L,10L,11L,11L,14L,11L,12L,12L,11L,13L,10L,12L,12L,11L,12L,13L,12L,13L,14L,13L,11L,13L,14L,15L,14L,13L,16L,15L,12L,12L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187200Inst : IEnumerable<long>
{
public static readonly long[] Value=A187200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187200.Bytes);
public long this[int i]=>Value[i];

public static A187200Inst Instance=new A187200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187201
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,3L,4L,2L,2L,3L,3L,3L,4L,3L,2L,3L,4L,3L,5L,4L,6L,3L,4L,4L,2L,7L,3L,4L,3L,5L,5L,5L,8L,3L,4L,5L,5L,5L,4L,2L,5L,5L,6L,4L,7L,4L,6L,5L,5L,6L,6L,6L,5L,4L,2L,8L,3L,7L,6L,6L,8L,6L,3L,9L,10L,10L,9L,7L,7L,9L,10L,10L,9L,7L,7L,6L,5L,4L,8L,10L,8L,8L,4L,7L,6L,3L,8L,5L,6L,9L,4L,7L,8L,10L,11L,11L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187201Inst : IEnumerable<long>
{
public static readonly long[] Value=A187201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187201.Bytes);
public long this[int i]=>Value[i];

public static A187201Inst Instance=new A187201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187202
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,4L,0L,10L,1L,12L,-2L,8L,1L,16L,12L,18L,-11L,8L,-6L,22L,-12L,16L,-8L,8L,-3L,28L,50L,30L,1L,8L,-12L,28L,-11L,36L,-14L,8L,-66L,40L,104L,42L,13L,24L,-18L,46L,-103L,36L,-16L,8L,21L,52L,88L,36L,48L,8L,-24L,58L,-667L,60L,-26L,-8L,1L,40L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187202Inst : IEnumerable<long>
{
public static readonly long[] Value=A187202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187202.Bytes);
public long this[int i]=>Value[i];

public static A187202Inst Instance=new A187202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187203
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,4L,0L,10L,1L,12L,2L,8L,1L,16L,4L,18L,1L,8L,6L,22L,2L,16L,8L,8L,3L,28L,4L,30L,1L,8L,12L,24L,1L,36L,14L,8L,0L,40L,4L,42L,3L,20L,18L,46L,1L,36L,0L,8L,3L,52L,8L,36L,0L,8L,24L,58L,3L,60L,26L,4L,1L,40L,12L,66L,3L,8L,2L,70L,4L,72L,32L,32L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187203Inst : IEnumerable<long>
{
public static readonly long[] Value=A187203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187203.Bytes);
public long this[int i]=>Value[i];

public static A187203Inst Instance=new A187203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187204
{
public static readonly long[] Value={ 10L,171L,1947L,2619L,265105L,478834027L,974622397L,11373118351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187204Inst : IEnumerable<long>
{
public static readonly long[] Value=A187204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187204.Bytes);
public long this[int i]=>Value[i];

public static A187204Inst Instance=new A187204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187205
{
public static readonly long[] Value={ 10L,40L,50L,56L,104L,130L,136L,160L,170L,171L,224L,230L,232L,250L,290L,310L,312L,370L,392L,410L,430L,459L,470L,520L,530L,560L,590L,610L,624L,640L,648L,670L,710L,730L,790L,830L,890L,896L,970L,1000L,1010L,1030L,1070L,1088L,1090L,1130L,1160L,1216L,1218L,1221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187205Inst : IEnumerable<long>
{
public static readonly long[] Value=A187205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187205.Bytes);
public long this[int i]=>Value[i];

public static A187205Inst Instance=new A187205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187206
{
public static readonly long[] Value={ 138L,282L,426L,570L,714L,858L,1002L,1146L,1290L,1434L,1578L,1722L,1866L,2010L,2154L,2298L,2442L,2586L,2730L,2874L,3018L,3162L,3306L,3450L,3594L,3738L,3882L,4026L,4170L,4314L,4458L,4602L,4746L,4890L,5034L,5178L,5322L,5466L,5610L,5754L,5898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187206Inst : IEnumerable<long>
{
public static readonly long[] Value=A187206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187206.Bytes);
public long this[int i]=>Value[i];

public static A187206Inst Instance=new A187206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187207
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,2L,4L,2L,1L,2L,1L,1L,5L,1L,4L,6L,3L,2L,1L,3L,1L,1L,2L,0L,2L,7L,1L,6L,8L,4L,2L,1L,4L,2L,1L,2L,1L,1L,9L,3L,1L,6L,2L,4L,10L,5L,2L,1L,5L,3L,1L,2L,2L,0L,11L,1L,10L,12L,6L,4L,3L,2L,1L,6L,2L,1L,1L,1L,4L,1L,0L,0L,3L,1L,0L,2L,1L,1L,13L,1L,12L,14L,7L,2L,1L,7L,5L,1L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187207Inst : IEnumerable<long>
{
public static readonly long[] Value=A187207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187207.Bytes);
public long this[int i]=>Value[i];

public static A187207Inst Instance=new A187207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187208
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,20L,32L,36L,48L,64L,80L,108L,112L,128L,156L,192L,204L,220L,252L,256L,260L,272L,304L,320L,324L,368L,396L,448L,476L,484L,512L,544L,608L,656L,660L,688L,768L,972L,1008L,1024L,1044L,1120L,1184L,1248L,1280L,1300L,1332L,1476L,1764L,1792L,1908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187208Inst : IEnumerable<long>
{
public static readonly long[] Value=A187208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187208.Bytes);
public long this[int i]=>Value[i];

public static A187208Inst Instance=new A187208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187209
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,9L,6L,11L,12L,13L,10L,24L,12L,21L,30L,26L,16L,43L,18L,40L,40L,37L,22L,59L,40L,45L,50L,52L,28L,89L,30L,57L,60L,61L,86L,90L,36L,69L,70L,103L,40L,125L,42L,88L,140L,85L,46L,128L,84L,97L,90L,106L,52L,165L,130L,113L,100L,109L,58L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187209Inst : IEnumerable<long>
{
public static readonly long[] Value=A187209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187209.Bytes);
public long this[int i]=>Value[i];

public static A187209Inst Instance=new A187209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187210
{
public static readonly long[] Value={ 0L,1L,5L,12L,24L,46L,66L,88L,128L,182L,222L,244L,284L,338L,394L,464L,584L,718L,790L,812L,852L,906L,962L,1032L,1152L,1286L,1374L,1444L,1564L,1714L,1882L,2128L,2488L,2814L,2950L,2972L,3012L,3066L,3122L,3192L,3312L,3446L,3534L,3604L,3724L,3874L,4042L,4288L,4648L,4974L,5126L,5196L,5316L,5466L,5634L,5880L,6240L,6582L,6814L,7060L,7436L,7890L,8458L,9296L,10328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187210Inst : IEnumerable<long>
{
public static readonly long[] Value=A187210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187210.Bytes);
public long this[int i]=>Value[i];

public static A187210Inst Instance=new A187210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187211
{
public static readonly long[] Value={ 0L,1L,4L,7L,12L,22L,20L,22L,40L,54L,40L,22L,40L,54L,56L,70L,120L,134L,72L,22L,40L,54L,56L,70L,120L,134L,88L,70L,120L,150L,168L,246L,360L,326L,136L,22L,40L,54L,56L,70L,120L,134L,88L,70L,120L,150L,168L,246L,360L,326L,152L,70L,120L,150L,168L,246L,360L,342L,232L,246L,376L,454L,568L,838L,1032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187211Inst : IEnumerable<long>
{
public static readonly long[] Value=A187211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187211.Bytes);
public long this[int i]=>Value[i];

public static A187211Inst Instance=new A187211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187468
{
public static readonly long[] Value={ 1L,2L,4L,40L,208L,928L,3904L,16000L,64768L,260608L,1045504L,4188160L,16764928L,67084288L,268386304L,1073643520L,4294770688L,17179475968L,68718690304L,274876334080L,1099508482048L,4398040219648L,17592173461504L,70368719011840L,281474926379008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187468Inst : IEnumerable<long>
{
public static readonly long[] Value=A187468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187468.Bytes);
public long this[int i]=>Value[i];

public static A187468Inst Instance=new A187468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187469
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,3L,3L,3L,5L,4L,4L,4L,4L,7L,6L,6L,6L,6L,9L,7L,8L,8L,8L,11L,9L,9L,9L,9L,13L,10L,11L,11L,11L,15L,12L,13L,12L,12L,17L,13L,14L,14L,14L,19L,15L,16L,16L,16L,21L,16L,18L,17L,17L,23L,18L,19L,19L,19L,25L,19L,21L,20L,21L,27L,21L,23L,22L,22L,29L,22L,24L,24L,24L,31L,24L,26L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187469Inst : IEnumerable<long>
{
public static readonly long[] Value=A187469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187469.Bytes);
public long this[int i]=>Value[i];

public static A187469Inst Instance=new A187469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187470
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,3L,3L,3L,3L,6L,4L,5L,5L,5L,9L,6L,7L,7L,7L,12L,8L,9L,9L,9L,14L,9L,11L,10L,10L,17L,11L,13L,12L,13L,19L,12L,15L,14L,14L,22L,14L,17L,16L,16L,25L,16L,19L,18L,18L,27L,17L,21L,19L,20L,30L,19L,23L,21L,22L,33L,21L,25L,23L,24L,35L,22L,27L,25L,26L,38L,24L,29L,27L,28L,40L,25L,31L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187470Inst : IEnumerable<long>
{
public static readonly long[] Value=A187470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187470.Bytes);
public long this[int i]=>Value[i];

public static A187470Inst Instance=new A187470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187471
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,3L,3L,3L,3L,3L,6L,5L,5L,5L,5L,5L,5L,8L,6L,6L,6L,6L,6L,6L,11L,8L,9L,9L,9L,9L,9L,13L,9L,10L,10L,10L,10L,10L,15L,11L,12L,11L,11L,11L,11L,18L,12L,14L,14L,14L,14L,14L,20L,14L,16L,15L,16L,16L,16L,23L,16L,18L,17L,17L,17L,17L,25L,17L,20L,19L,19L,19L,19L,27L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187471Inst : IEnumerable<long>
{
public static readonly long[] Value=A187471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187471.Bytes);
public long this[int i]=>Value[i];

public static A187471Inst Instance=new A187471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187472
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,14L,17L,18L,20L,22L,24L,26L,28L,30L,32L,33L,35L,38L,40L,41L,43L,45L,47L,49L,51L,53L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187472Inst : IEnumerable<long>
{
public static readonly long[] Value=A187472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187472.Bytes);
public long this[int i]=>Value[i];

public static A187472Inst Instance=new A187472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187473
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,15L,16L,19L,21L,23L,25L,27L,29L,31L,34L,36L,37L,39L,42L,44L,46L,48L,50L,52L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,76L,78L,80L,82L,84L,86L,88L,90L,92L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,116L,118L,120L,122L,124L,126L,128L,130L,132L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187473Inst : IEnumerable<long>
{
public static readonly long[] Value=A187473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187473.Bytes);
public long this[int i]=>Value[i];

public static A187473Inst Instance=new A187473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187474
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,13L,15L,16L,18L,19L,21L,22L,25L,26L,28L,30L,31L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,50L,51L,53L,55L,56L,58L,60L,62L,63L,65L,67L,68L,70L,72L,73L,75L,77L,78L,80L,81L,84L,85L,87L,88L,90L,91L,93L,95L,97L,98L,100L,102L,103L,105L,107L,109L,110L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187474Inst : IEnumerable<long>
{
public static readonly long[] Value=A187474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187474.Bytes);
public long this[int i]=>Value[i];

public static A187474Inst Instance=new A187474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187475
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,14L,17L,20L,23L,24L,27L,29L,32L,34L,37L,39L,42L,45L,47L,49L,52L,54L,57L,59L,61L,64L,66L,69L,71L,74L,76L,79L,82L,83L,86L,89L,92L,94L,96L,99L,101L,104L,106L,108L,111L,114L,116L,118L,120L,124L,126L,129L,130L,133L,135L,138L,141L,143L,145L,148L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187475Inst : IEnumerable<long>
{
public static readonly long[] Value=A187475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187475.Bytes);
public long this[int i]=>Value[i];

public static A187475Inst Instance=new A187475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187476
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,10L,12L,13L,15L,17L,19L,21L,23L,24L,26L,28L,30L,32L,34L,35L,37L,39L,41L,42L,45L,46L,48L,50L,52L,54L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,86L,88L,90L,92L,94L,96L,97L,99L,101L,103L,104L,107L,108L,110L,112L,114L,115L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187476Inst : IEnumerable<long>
{
public static readonly long[] Value=A187476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187476.Bytes);
public long this[int i]=>Value[i];

public static A187476Inst Instance=new A187476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187477
{
public static readonly long[] Value={ 3L,4L,7L,9L,11L,14L,16L,18L,20L,22L,25L,27L,29L,31L,33L,36L,38L,40L,43L,44L,47L,49L,51L,53L,56L,58L,60L,62L,65L,67L,69L,71L,73L,76L,78L,80L,82L,84L,87L,89L,91L,93L,95L,98L,100L,102L,105L,106L,109L,111L,113L,116L,118L,120L,122L,124L,127L,128L,131L,133L,135L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187477Inst : IEnumerable<long>
{
public static readonly long[] Value=A187477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187477.Bytes);
public long this[int i]=>Value[i];

public static A187477Inst Instance=new A187477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187478
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,9L,11L,13L,15L,17L,18L,20L,22L,24L,26L,28L,29L,31L,33L,35L,36L,39L,40L,42L,44L,46L,48L,49L,51L,53L,55L,57L,58L,60L,62L,64L,66L,68L,69L,71L,73L,75L,77L,79L,80L,82L,84L,86L,88L,90L,91L,93L,95L,97L,98L,101L,102L,104L,106L,108L,109L,111L,113L,115L,117L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187478Inst : IEnumerable<long>
{
public static readonly long[] Value=A187478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187478.Bytes);
public long this[int i]=>Value[i];

public static A187478Inst Instance=new A187478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187479
{
public static readonly long[] Value={ 4L,5L,7L,10L,12L,14L,16L,19L,21L,23L,25L,27L,30L,32L,34L,37L,38L,41L,43L,45L,47L,50L,52L,54L,56L,59L,61L,63L,65L,67L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,92L,94L,96L,99L,100L,103L,105L,107L,110L,112L,114L,116L,118L,121L,122L,125L,127L,129L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187479Inst : IEnumerable<long>
{
public static readonly long[] Value=A187479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187479.Bytes);
public long this[int i]=>Value[i];

public static A187479Inst Instance=new A187479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187480
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,11L,13L,15L,16L,17L,19L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,46L,48L,49L,50L,51L,53L,54L,55L,57L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,71L,73L,75L,76L,77L,79L,80L,81L,82L,84L,85L,86L,87L,89L,91L,92L,93L,95L,97L,98L,99L,100L,102L,103L,104L,106L,108L,109L,110L,112L,113L,114L,115L,117L,119L,120L,121L,123L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187480Inst : IEnumerable<long>
{
public static readonly long[] Value=A187480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187480.Bytes);
public long this[int i]=>Value[i];

public static A187480Inst Instance=new A187480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187481
{
public static readonly long[] Value={ 3L,7L,12L,14L,18L,23L,25L,29L,31L,36L,41L,45L,47L,52L,56L,58L,62L,67L,72L,74L,78L,83L,88L,90L,94L,96L,101L,105L,107L,111L,116L,118L,122L,127L,132L,134L,138L,140L,145L,149L,151L,156L,161L,165L,167L,172L,176L,178L,182L,187L,189L,193L,195L,200L,205L,209L,211L,216L,220L,222L,226L,231L,233L,237L,239L,244L,249L,253L,255L,260L,265L,269L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187481Inst : IEnumerable<long>
{
public static readonly long[] Value=A187481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187481.Bytes);
public long this[int i]=>Value[i];

public static A187481Inst Instance=new A187481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187482
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,12L,13L,14L,16L,17L,19L,20L,21L,23L,24L,25L,27L,29L,30L,32L,33L,34L,36L,38L,39L,40L,42L,43L,45L,47L,48L,49L,51L,52L,54L,56L,57L,58L,60L,61L,62L,64L,65L,67L,68L,69L,71L,73L,74L,76L,77L,78L,80L,81L,82L,84L,86L,87L,89L,90L,91L,93L,95L,96L,97L,99L,100L,101L,103L,104L,106L,108L,109L,110L,112L,113L,115L,116L,117L,119L,120L,121L,123L,125L,126L,128L,129L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187482Inst : IEnumerable<long>
{
public static readonly long[] Value=A187482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187482.Bytes);
public long this[int i]=>Value[i];

public static A187482Inst Instance=new A187482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187483
{
public static readonly long[] Value={ 2L,6L,9L,11L,15L,18L,22L,26L,28L,31L,35L,37L,41L,44L,46L,50L,53L,55L,59L,63L,66L,70L,72L,75L,79L,83L,85L,88L,92L,94L,98L,102L,105L,107L,111L,114L,118L,122L,124L,127L,131L,133L,136L,140L,142L,146L,149L,151L,155L,159L,162L,166L,168L,171L,175L,177L,180L,184L,188L,190L,194L,197L,199L,203L,207L,210L,212L,216L,219L,221L,225L,228L,232L,236L,238L,241L,245L,247L,251L,254L,256L,260L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187483Inst : IEnumerable<long>
{
public static readonly long[] Value=A187483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187483.Bytes);
public long this[int i]=>Value[i];

public static A187483Inst Instance=new A187483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187564
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,6L,10L,22L,2L,6L,10L,22L,10L,30L,50L,78L,2L,6L,10L,22L,10L,30L,50L,78L,10L,30L,50L,86L,58L,142L,210L,262L,2L,6L,10L,22L,10L,30L,50L,78L,10L,30L,50L,86L,58L,142L,210L,262L,10L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187564Inst : IEnumerable<long>
{
public static readonly long[] Value=A187564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187564.Bytes);
public long this[int i]=>Value[i];

public static A187564Inst Instance=new A187564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187565
{
public static readonly long[] Value={ 1234759680L,1234857960L,1234895760L,1234958760L,1235487960L,1235679480L,1235976840L,1236795840L,1237569480L,1237589640L,1237594680L,1237695480L,1237894560L,1238549760L,1238574960L,1238597640L,1238975640L,1239547680L,1239567840L,1239756840L,1239784560L,1239847560L,1239857640L,1243579680L,1243589760L,1243879560L,1243957680L,1245378960L,1245973680L,1245983760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187565Inst : IEnumerable<long>
{
public static readonly long[] Value=A187565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187565.Bytes);
public long this[int i]=>Value[i];

public static A187565Inst Instance=new A187565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187566
{
public static readonly long[] Value={ 1L,3L,-2L,4L,-6L,4L,7L,-8L,12L,-8L,6L,-14L,16L,-24L,21L,12L,-12L,28L,-32L,63L,-52L,8L,-24L,24L,-56L,84L,-156L,131L,15L,-16L,48L,-48L,147L,-208L,393L,-316L,13L,-30L,32L,-96L,126L,-364L,524L,-948L,765L,18L,-26L,60L,-64L,252L,-312L,917L,-1264L,2295L,-1846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187566Inst : IEnumerable<long>
{
public static readonly long[] Value=A187566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187566.Bytes);
public long this[int i]=>Value[i];

public static A187566Inst Instance=new A187566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187567
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,18L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187567Inst : IEnumerable<long>
{
public static readonly long[] Value=A187567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187567.Bytes);
public long this[int i]=>Value[i];

public static A187567Inst Instance=new A187567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187568
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,10L,11L,12L,14L,15L,17L,19L,20L,21L,23L,24L,26L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,41L,43L,45L,46L,48L,49L,50L,52L,54L,55L,56L,58L,59L,60L,62L,63L,65L,67L,68L,69L,71L,72L,74L,75L,76L,78L,80L,81L,83L,84L,85L,87L,89L,90L,92L,93L,94L,96L,97L,98L,100L,102L,103L,104L,106L,107L,109L,111L,112L,113L,115L,116L,117L,119L,120L,122L,124L,125L,126L,128L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187568Inst : IEnumerable<long>
{
public static readonly long[] Value=A187568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187568.Bytes);
public long this[int i]=>Value[i];

public static A187568Inst Instance=new A187568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187569
{
public static readonly long[] Value={ 3L,5L,9L,13L,16L,18L,22L,25L,27L,31L,34L,38L,42L,44L,47L,51L,53L,57L,61L,64L,66L,70L,73L,77L,79L,82L,86L,88L,91L,95L,99L,101L,105L,108L,110L,114L,118L,121L,123L,127L,130L,132L,136L,139L,143L,147L,149L,152L,156L,158L,162L,165L,167L,171L,175L,178L,182L,184L,187L,191L,195L,197L,201L,204L,206L,210L,213L,215L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187569Inst : IEnumerable<long>
{
public static readonly long[] Value=A187569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187569.Bytes);
public long this[int i]=>Value[i];

public static A187569Inst Instance=new A187569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187570
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,88L,89L,90L,92L,93L,94L,96L,97L,98L,100L,101L,102L,103L,104L,105L,107L,108L,109L,111L,112L,113L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187570Inst : IEnumerable<long>
{
public static readonly long[] Value=A187570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187570.Bytes);
public long this[int i]=>Value[i];

public static A187570Inst Instance=new A187570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187571
{
public static readonly long[] Value={ 4L,8L,12L,19L,23L,27L,34L,38L,42L,49L,53L,57L,61L,65L,69L,76L,80L,84L,91L,95L,99L,106L,110L,114L,118L,122L,126L,133L,137L,141L,148L,152L,156L,163L,167L,171L,175L,179L,183L,190L,194L,198L,205L,209L,213L,220L,224L,228L,235L,239L,243L,250L,254L,258L,265L,269L,273L,277L,281L,285L,292L,296L,300L,307L,311L,315L,322L,326L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187571Inst : IEnumerable<long>
{
public static readonly long[] Value=A187571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187571.Bytes);
public long this[int i]=>Value[i];

public static A187571Inst Instance=new A187571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187572
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,78L,79L,80L,82L,83L,84L,86L,87L,88L,90L,91L,92L,93L,94L,95L,97L,98L,99L,101L,102L,103L,105L,106L,107L,108L,109L,110L,112L,113L,114L,116L,117L,118L,120L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187572Inst : IEnumerable<long>
{
public static readonly long[] Value=A187572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187572.Bytes);
public long this[int i]=>Value[i];

public static A187572Inst Instance=new A187572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187573
{
public static readonly long[] Value={ 5L,9L,13L,17L,24L,28L,32L,39L,43L,47L,54L,58L,62L,69L,73L,77L,81L,85L,89L,96L,100L,104L,111L,115L,119L,126L,130L,134L,138L,142L,146L,153L,157L,161L,168L,172L,176L,183L,187L,191L,195L,199L,203L,210L,214L,218L,225L,229L,233L,240L,244L,248L,252L,256L,260L,267L,271L,275L,282L,286L,290L,297L,301L,305L,312L,316L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187573Inst : IEnumerable<long>
{
public static readonly long[] Value=A187573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187573.Bytes);
public long this[int i]=>Value[i];

public static A187573Inst Instance=new A187573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187574
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,10L,12L,14L,15L,17L,19L,21L,23L,25L,26L,28L,30L,31L,34L,35L,37L,39L,41L,42L,45L,46L,48L,50L,51L,54L,55L,57L,59L,61L,62L,64L,66L,67L,70L,71L,73L,75L,77L,79L,80L,82L,84L,86L,87L,90L,91L,93L,95L,96L,98L,100L,102L,104L,106L,107L,109L,111L,112L,115L,116L,118L,120L,122L,124L,125L,127L,129L,131L,132L,135L,136L,138L,140L,142L,143L,145L,147L,149L,151L,152L,154L,156L,158L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187574Inst : IEnumerable<long>
{
public static readonly long[] Value=A187574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187574.Bytes);
public long this[int i]=>Value[i];

public static A187574Inst Instance=new A187574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187575
{
public static readonly long[] Value={ 2L,4L,7L,8L,11L,13L,16L,18L,20L,22L,24L,27L,29L,32L,33L,36L,38L,40L,43L,44L,47L,49L,52L,53L,56L,58L,60L,63L,65L,68L,69L,72L,74L,76L,78L,81L,83L,85L,88L,89L,92L,94L,97L,99L,101L,103L,105L,108L,110L,113L,114L,117L,119L,121L,123L,126L,128L,130L,133L,134L,137L,139L,141L,144L,146L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187575Inst : IEnumerable<long>
{
public static readonly long[] Value=A187575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187575.Bytes);
public long this[int i]=>Value[i];

public static A187575Inst Instance=new A187575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187576
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,27L,28L,30L,31L,33L,34L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,69L,70L,72L,73L,75L,76L,79L,80L,82L,83L,85L,86L,88L,89L,91L,92L,95L,96L,98L,99L,101L,102L,105L,106L,108L,109L,111L,112L,114L,115L,117L,118L,121L,122L,124L,125L,127L,128L,130L,131L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187576Inst : IEnumerable<long>
{
public static readonly long[] Value=A187576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187576.Bytes);
public long this[int i]=>Value[i];

public static A187576Inst Instance=new A187576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187577
{
public static readonly long[] Value={ 3L,6L,9L,10L,13L,16L,19L,22L,25L,26L,29L,32L,35L,36L,39L,42L,45L,48L,51L,52L,55L,58L,61L,64L,67L,68L,71L,74L,77L,78L,81L,84L,87L,90L,93L,94L,97L,100L,103L,104L,107L,110L,113L,116L,119L,120L,123L,126L,129L,132L,135L,136L,139L,142L,145L,146L,149L,152L,155L,158L,161L,162L,165L,168L,171L,174L,177L,178L,181L,184L,187L,188L,191L,194L,197L,200L,203L,204L,207L,210L,213L,214L,217L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187577Inst : IEnumerable<long>
{
public static readonly long[] Value=A187577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187577.Bytes);
public long this[int i]=>Value[i];

public static A187577Inst Instance=new A187577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187578
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,9L,10L,11L,14L,15L,16L,20L,21L,22L,24L,25L,26L,29L,30L,31L,33L,34L,35L,38L,39L,40L,44L,45L,46L,48L,49L,50L,53L,54L,55L,59L,60L,61L,63L,64L,65L,68L,69L,70L,72L,73L,74L,77L,78L,79L,83L,84L,85L,87L,88L,89L,92L,93L,94L,96L,97L,98L,101L,102L,103L,107L,108L,109L,111L,112L,113L,116L,117L,118L,122L,123L,124L,126L,127L,128L,131L,132L,133L,135L,136L,137L,140L,141L,142L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187578Inst : IEnumerable<long>
{
public static readonly long[] Value=A187578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187578.Bytes);
public long this[int i]=>Value[i];

public static A187578Inst Instance=new A187578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187579
{
public static readonly long[] Value={ 3L,4L,8L,12L,13L,17L,18L,19L,23L,27L,28L,32L,36L,37L,41L,42L,43L,47L,51L,52L,56L,57L,58L,62L,66L,67L,71L,75L,76L,80L,81L,82L,86L,90L,91L,95L,99L,100L,104L,105L,106L,110L,114L,115L,119L,120L,121L,125L,129L,130L,134L,138L,139L,143L,144L,145L,149L,153L,154L,158L,159L,160L,164L,168L,169L,173L,177L,178L,182L,183L,184L,188L,192L,193L,197L,201L,202L,206L,207L,208L,212L,216L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187579Inst : IEnumerable<long>
{
public static readonly long[] Value=A187579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187579.Bytes);
public long this[int i]=>Value[i];

public static A187579Inst Instance=new A187579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187868
{
public static readonly long[] Value={ 9901L,99990001L,999999000001L,9999999900000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187868Inst : IEnumerable<long>
{
public static readonly long[] Value=A187868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187868.Bytes);
public long this[int i]=>Value[i];

public static A187868Inst Instance=new A187868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187869
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1234L,14325L,143256L,1432567L,12347658L,123476589L,12347658910L,1234710985611L,123471098561112L,12347651211891013L,1234761310981112514L,BigInteger.Parse("123476131098111251415"),BigInteger.Parse("12347651211815149101316"),BigInteger.Parse("1234765121189101316151417"),BigInteger.Parse("123476589101316151417121118") };
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
public class A187869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187869Inst Instance=new A187869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187870
{
public static readonly BigInteger[] Value={ 4L,44L,428L,10196L,10719068L,25865068L,5472607916L,74185965772L,264698472181028L,2290048394728148L,BigInteger.Parse("19435959308462817284"),2753151578548809148L,BigInteger.Parse("20586893910854623222436"),BigInteger.Parse("134344844535611780572028924") };
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
public class A187870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187870Inst Instance=new A187870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187871
{
public static readonly long[] Value={ 1L,12L,123L,1234L,14325L,143256L,1234765L,12347658L,123476589L,10123476589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187871Inst : IEnumerable<long>
{
public static readonly long[] Value=A187871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187871.Bytes);
public long this[int i]=>Value[i];

public static A187871Inst Instance=new A187871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187872
{
public static readonly long[] Value={ 3L,5L,7L,13L,19L,41L,71L,137L,263L,523L,1033L,2063L,4111L,8219L,16417L,32779L,65539L,131111L,262151L,524341L,1048589L,2097211L,4194329L,8388619L,16777289L,33554473L,67108913L,134217773L,268435463L,536870951L,1073741831L,2147483693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187872Inst : IEnumerable<long>
{
public static readonly long[] Value=A187872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187872.Bytes);
public long this[int i]=>Value[i];

public static A187872Inst Instance=new A187872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187873
{
public static readonly long[] Value={ 3L,3L,7L,13L,19L,31L,41L,59L,71L,89L,103L,131L,151L,179L,199L,229L,263L,307L,337L,373L,409L,449L,491L,547L,587L,641L,683L,739L,797L,857L,911L,971L,1033L,1093L,1171L,1231L,1301L,1381L,1451L,1531L,1607L,1697L,1783L,1867L,1951L,2029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187873Inst : IEnumerable<long>
{
public static readonly long[] Value=A187873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187873.Bytes);
public long this[int i]=>Value[i];

public static A187873Inst Instance=new A187873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187874
{
public static readonly BigInteger[] Value={ 3L,3L,5L,11L,31L,131L,733L,5059L,40351L,362903L,3628819L,39916817L,479001643L,6227020873L,87178291241L,1307674368149L,20922789888041L,355687428096053L,6402373705728061L,121645100408832109L,2432902008176640037L,BigInteger.Parse("51090942171709440037") };
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
public class A187874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187874Inst Instance=new A187874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187875
{
public static readonly long[] Value={ 5L,2L,10L,8L,9L,4L,7L,6L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187875Inst : IEnumerable<long>
{
public static readonly long[] Value=A187875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187875.Bytes);
public long this[int i]=>Value[i];

public static A187875Inst Instance=new A187875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187876
{
public static readonly long[] Value={ 5L,2L,8L,9L,4L,7L,6L,3L,1L,0L,50L,55L,52L,51L,58L,59L,54L,57L,56L,53L,10L,18L,19L,17L,12L,11L,40L,45L,42L,41L,48L,49L,44L,47L,46L,43L,14L,85L,82L,90L,98L,99L,97L,92L,88L,89L,91L,94L,84L,95L,80L,96L,87L,86L,93L,83L,81L,15L,16L,60L,65L,62L,70L,78L,79L,77L,72L,71L,61L,68L,69L,74L,64L,75L,76L,67L,66L,73L,63L,13L,30L,35L,32L,31L,38L,39L,34L,37L,36L,33L,20L,25L,22L,21L,28L,29L,24L,27L,26L,23L,100L,105L,150L,155L,152L,151L,158L,159L,157L,156L,153L,102L,110L,118L,119L,117L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187876Inst : IEnumerable<long>
{
public static readonly long[] Value=A187876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187876.Bytes);
public long this[int i]=>Value[i];

public static A187876Inst Instance=new A187876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187877
{
public static readonly long[] Value={ 1L,5L,10L,45L,60L,128L,231L,308L,470L,847L,1846L,3570L,4284L,4740L,5126L,5688L,6171L,6650L,7473L,7980L,8687L,9310L,9964L,10640L,11172L,12896L,17877L,19716L,22011L,22736L,23280L,23836L,24823L,33480L,34335L,36384L,37260L,41202L,42315L,43761L,44480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187877Inst : IEnumerable<long>
{
public static readonly long[] Value=A187877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187877.Bytes);
public long this[int i]=>Value[i];

public static A187877Inst Instance=new A187877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187878
{
public static readonly long[] Value={ 5L,8L,10L,125L,231L,250L,470L,1846L,2844L,2856L,3570L,5126L,5320L,7473L,8687L,12555L,12573L,16740L,16764L,17877L,18630L,20601L,21620L,22011L,24823L,27468L,28861L,31941L,33120L,37053L,42315L,42588L,43761L,49404L,58078L,61072L,67728L,68320L,75042L,79947L,84660L,86427L,92432L,97723L,98802L,99580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187878Inst : IEnumerable<long>
{
public static readonly long[] Value=A187878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187878.Bytes);
public long this[int i]=>Value[i];

public static A187878Inst Instance=new A187878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187879
{
public static readonly BigInteger[] Value={ 1L,3L,6561L,7625597484987L,BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("436673502879206784130402698570834024654748577491697818855443") };
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
public class A187879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187879Inst Instance=new A187879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187880
{
public static readonly BigInteger[] Value={ 0L,2L,120L,18624L,9876480L,20135116800L,163839423283200L,5348052945894113280L,BigInteger.Parse("699612285096273924587520"),BigInteger.Parse("366440137172271078986848665600"),BigInteger.Parse("768105432116827516249785005978419200"),BigInteger.Parse("6441762292785726797799215491828242028953600") };
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
public class A187880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187880Inst Instance=new A187880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187881
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,0L,3L,4L,0L,0L,3L,4L,5L,0L,0L,0L,4L,5L,6L,0L,0L,0L,4L,5L,6L,7L,0L,0L,0L,0L,5L,6L,7L,8L,0L,0L,0L,0L,5L,6L,7L,8L,9L,0L,0L,0L,0L,0L,6L,7L,8L,9L,10L,0L,0L,0L,0L,0L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187881Inst : IEnumerable<long>
{
public static readonly long[] Value=A187881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187881.Bytes);
public long this[int i]=>Value[i];

public static A187881Inst Instance=new A187881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187882
{
public static readonly long[] Value={ 103L,101L,97L,197L,229L,109L,281L,233L,167L,607L,233L,349L,821L,307L,631L,1093L,853L,373L,1597L,1009L,439L,643L,503L,2111L,983L,769L,1811L,569L,2423L,3823L,3581L,2027L,941L,677L,997L,691L,1753L,3539L,1193L,5381L,4289L,2411L,2063L,1307L,919L,8311L,2719L,3187L,6373L,1459L,3331L,9431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187882Inst : IEnumerable<long>
{
public static readonly long[] Value=A187882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187882.Bytes);
public long this[int i]=>Value[i];

public static A187882Inst Instance=new A187882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187883
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,6L,5L,3L,1L,9L,8L,6L,3L,1L,12L,11L,9L,6L,3L,1L,16L,15L,13L,10L,6L,3L,1L,20L,19L,17L,14L,10L,6L,3L,1L,25L,24L,22L,19L,15L,10L,6L,3L,1L,30L,29L,27L,24L,20L,15L,10L,6L,3L,1L,36L,35L,33L,30L,26L,21L,15L,10L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187883Inst : IEnumerable<long>
{
public static readonly long[] Value=A187883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187883.Bytes);
public long this[int i]=>Value[i];

public static A187883Inst Instance=new A187883Inst();

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