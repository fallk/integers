using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A029624
{
public static readonly long[] Value={ 1L,5L,7L,11L,15L,9L,11L,17L,35L,13L,57L,85L,15L,23L,77L,147L,175L,133L,63L,17L,19L,29L,99L,21L,155L,375L,23L,35L,187L,605L,1155L,495L,143L,25L,1925L,3069L,27L,41L,2717L,5291L,7293L,4719L,195L,29L,301L,3731L,13013L,15873L,7007L,1001L,31L,47L,345L,1575L,5005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029624Inst : IEnumerable<long>
{
public static readonly long[] Value=A029624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029624.Bytes);
public long this[int i]=>Value[i];

public static A029624Inst Instance=new A029624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029625
{
public static readonly long[] Value={ 8L,14L,26L,24L,40L,50L,20L,90L,48L,26L,100L,224L,322L,308L,196L,80L,126L,324L,546L,630L,504L,276L,32L,450L,870L,1176L,1134L,780L,120L,1320L,2046L,2310L,1914L,38L,222L,792L,3366L,4356L,4224L,1650L,638L,168L,260L,1014L,7722L,8580L,2288L,806L,44L,1274L,8008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029625Inst : IEnumerable<long>
{
public static readonly long[] Value=A029625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029625.Bytes);
public long this[int i]=>Value[i];

public static A029625Inst Instance=new A029625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029626
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,15L,9L,17L,35L,13L,57L,85L,23L,77L,147L,175L,133L,63L,19L,29L,99L,21L,155L,375L,187L,605L,1155L,495L,143L,25L,1925L,3069L,27L,41L,2717L,5291L,7293L,4719L,195L,301L,3731L,13013L,15873L,7007L,1001L,31L,47L,345L,1575L,5005L,11739L,21021L,29315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029626Inst : IEnumerable<long>
{
public static readonly long[] Value=A029626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029626.Bytes);
public long this[int i]=>Value[i];

public static A029626Inst Instance=new A029626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029627
{
public static readonly long[] Value={ 2L,2L,2L,2L,24L,2L,2L,48L,2L,2L,308L,196L,80L,2L,504L,276L,2L,1134L,780L,120L,2L,1914L,2L,4224L,1650L,638L,168L,2L,2288L,806L,2L,12012L,3094L,224L,2L,2L,60060L,46904L,29120L,14196L,5320L,1480L,288L,2L,106964L,76024L,43316L,19516L,6800L,1768L,2L,228514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029627Inst : IEnumerable<long>
{
public static readonly long[] Value=A029627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029627.Bytes);
public long this[int i]=>Value[i];

public static A029627Inst Instance=new A029627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029628
{
public static readonly long[] Value={ 3L,3L,3L,8L,3L,11L,3L,14L,26L,3L,17L,40L,3L,20L,57L,90L,3L,23L,77L,147L,3L,26L,100L,224L,322L,3L,29L,126L,324L,546L,3L,32L,155L,450L,870L,1176L,3L,35L,187L,605L,1320L,2046L,3L,38L,222L,792L,1925L,3366L,4356L,3L,41L,260L,1014L,2717L,5291L,7722L,3L,44L,301L,1274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029628Inst : IEnumerable<long>
{
public static readonly long[] Value=A029628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029628.Bytes);
public long this[int i]=>Value[i];

public static A029628Inst Instance=new A029628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029645
{
public static readonly long[] Value={ 4L,5L,6L,14L,7L,20L,8L,27L,50L,9L,35L,77L,10L,44L,112L,182L,11L,54L,156L,294L,12L,65L,210L,450L,672L,13L,77L,275L,660L,1122L,14L,90L,352L,935L,1782L,2508L,15L,104L,442L,1287L,2717L,4290L,16L,119L,546L,1729L,4004L,7007L,9438L,17L,135L,665L,2275L,5733L,11011L,16445L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029645Inst : IEnumerable<long>
{
public static readonly long[] Value=A029645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029645.Bytes);
public long this[int i]=>Value[i];

public static A029645Inst Instance=new A029645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029646
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,7L,1L,27L,1L,9L,35L,77L,1L,1L,11L,1L,65L,1L,13L,77L,275L,1L,935L,1L,15L,1287L,2717L,1L,119L,1729L,7007L,1L,17L,135L,665L,2275L,5733L,11011L,16445L,1L,1L,19L,1L,189L,1L,21L,209L,1311L,1L,7125L,1L,23L,8645L,32319L,1L,275L,10395L,127281L,1L,25L,299L,2277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029646Inst : IEnumerable<long>
{
public static readonly long[] Value=A029646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029646.Bytes);
public long this[int i]=>Value[i];

public static A029646Inst Instance=new A029646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029647
{
public static readonly long[] Value={ 4L,6L,14L,20L,8L,50L,10L,44L,112L,182L,54L,156L,294L,12L,210L,450L,672L,660L,1122L,14L,90L,352L,1782L,2508L,104L,442L,4290L,16L,546L,4004L,9438L,18L,152L,800L,2940L,8008L,16744L,27456L,35750L,170L,952L,3740L,10948L,24752L,44200L,63206L,20L,1122L,4692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029647Inst : IEnumerable<long>
{
public static readonly long[] Value=A029647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029647.Bytes);
public long this[int i]=>Value[i];

public static A029647Inst Instance=new A029647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029648
{
public static readonly long[] Value={ 2L,2L,5L,2L,7L,2L,16L,9L,2L,25L,11L,2L,55L,36L,13L,2L,91L,49L,15L,2L,196L,140L,64L,17L,2L,336L,204L,81L,19L,2L,714L,540L,285L,100L,21L,2L,1254L,825L,385L,121L,23L,2L,2640L,2079L,1210L,506L,144L,25L,2L,4719L,3289L,1716L,650L,169L,27L,2L,9867L,8008L,5005L,2366L,819L,196L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029648Inst : IEnumerable<long>
{
public static readonly long[] Value=A029648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029648.Bytes);
public long this[int i]=>Value[i];

public static A029648Inst Instance=new A029648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029649
{
public static readonly long[] Value={ 5L,7L,16L,9L,25L,11L,55L,36L,13L,91L,49L,15L,196L,140L,64L,17L,336L,204L,81L,19L,714L,540L,285L,100L,21L,1254L,825L,385L,121L,23L,2640L,2079L,1210L,506L,144L,25L,4719L,3289L,1716L,650L,169L,27L,9867L,8008L,5005L,2366L,819L,196L,29L,17875L,13013L,7371L,3185L,1015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029649Inst : IEnumerable<long>
{
public static readonly long[] Value=A029649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029649.Bytes);
public long this[int i]=>Value[i];

public static A029649Inst Instance=new A029649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029650
{
public static readonly long[] Value={ 5L,7L,9L,25L,11L,55L,13L,91L,49L,15L,17L,81L,19L,285L,21L,825L,385L,121L,23L,2079L,25L,4719L,3289L,169L,27L,9867L,5005L,819L,29L,17875L,13013L,7371L,3185L,1015L,225L,31L,33L,289L,35L,1785L,37L,8721L,2109L,361L,39L,35853L,41L,128877L,46683L,441L,43L,415701L,59983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029650Inst : IEnumerable<long>
{
public static readonly long[] Value=A029650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029650.Bytes);
public long this[int i]=>Value[i];

public static A029650Inst Instance=new A029650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029651
{
public static readonly long[] Value={ 1L,3L,9L,30L,105L,378L,1386L,5148L,19305L,72930L,277134L,1058148L,4056234L,15600900L,60174900L,232676280L,901620585L,3500409330L,13612702950L,53017895700L,206769793230L,807386811660L,3156148445580L,12350146091400L,48371405524650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029651Inst : IEnumerable<long>
{
public static readonly long[] Value=A029651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029651.Bytes);
public long this[int i]=>Value[i];

public static A029651Inst Instance=new A029651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029652
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,1L,5L,9L,7L,1L,9L,1L,7L,25L,11L,1L,27L,55L,13L,1L,9L,35L,77L,105L,91L,49L,15L,1L,17L,1L,11L,81L,19L,1L,65L,285L,21L,1L,13L,77L,275L,825L,385L,121L,23L,1L,935L,2079L,25L,1L,15L,1287L,2717L,4719L,3289L,169L,27L,1L,119L,1729L,7007L,9867L,5005L,819L,29L,1L,17L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029652Inst : IEnumerable<long>
{
public static readonly long[] Value=A029652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029652.Bytes);
public long this[int i]=>Value[i];

public static A029652Inst Instance=new A029652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029653
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,5L,4L,1L,2L,7L,9L,5L,1L,2L,9L,16L,14L,6L,1L,2L,11L,25L,30L,20L,7L,1L,2L,13L,36L,55L,50L,27L,8L,1L,2L,15L,49L,91L,105L,77L,35L,9L,1L,2L,17L,64L,140L,196L,182L,112L,44L,10L,1L,2L,19L,81L,204L,336L,378L,294L,156L,54L,11L,1L,2L,21L,100L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029653Inst : IEnumerable<long>
{
public static readonly long[] Value=A029653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029653.Bytes);
public long this[int i]=>Value[i];

public static A029653Inst Instance=new A029653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029654
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,16L,14L,6L,11L,25L,30L,20L,13L,36L,55L,50L,27L,8L,15L,49L,91L,105L,77L,35L,17L,64L,140L,196L,182L,112L,44L,10L,19L,81L,204L,336L,378L,294L,156L,54L,21L,100L,285L,540L,714L,672L,450L,210L,65L,12L,23L,121L,385L,825L,1254L,1386L,1122L,660L,275L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029654Inst : IEnumerable<long>
{
public static readonly long[] Value=A029654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029654.Bytes);
public long this[int i]=>Value[i];

public static A029654Inst Instance=new A029654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029655
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,4L,1L,7L,9L,5L,1L,9L,16L,14L,6L,1L,11L,25L,30L,20L,7L,1L,13L,36L,55L,50L,27L,8L,1L,15L,49L,91L,105L,77L,35L,9L,1L,17L,64L,140L,196L,182L,112L,44L,10L,1L,19L,81L,204L,336L,378L,294L,156L,54L,11L,1L,21L,100L,285L,540L,714L,672L,450L,210L,65L,12L,1L,23L,121L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029655Inst : IEnumerable<long>
{
public static readonly long[] Value=A029655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029655.Bytes);
public long this[int i]=>Value[i];

public static A029655Inst Instance=new A029655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029656
{
public static readonly long[] Value={ 2L,2L,3L,2L,5L,4L,2L,7L,9L,5L,2L,9L,16L,14L,6L,2L,11L,25L,30L,20L,7L,2L,13L,36L,55L,50L,27L,8L,2L,15L,49L,91L,105L,77L,35L,9L,2L,17L,64L,140L,196L,182L,112L,44L,10L,2L,19L,81L,204L,336L,378L,294L,156L,54L,11L,2L,21L,100L,285L,540L,714L,672L,450L,210L,65L,12L,2L,23L,121L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029656Inst : IEnumerable<long>
{
public static readonly long[] Value=A029656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029656.Bytes);
public long this[int i]=>Value[i];

public static A029656Inst Instance=new A029656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029657
{
public static readonly long[] Value={ 3L,5L,7L,9L,5L,9L,11L,25L,7L,13L,55L,27L,15L,49L,91L,105L,77L,35L,9L,17L,19L,81L,11L,21L,285L,65L,23L,121L,385L,825L,275L,77L,13L,25L,2079L,935L,27L,169L,3289L,4719L,2717L,1287L,15L,29L,819L,5005L,9867L,7007L,1729L,119L,31L,225L,1015L,3185L,7371L,13013L,17875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029657Inst : IEnumerable<long>
{
public static readonly long[] Value=A029657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029657.Bytes);
public long this[int i]=>Value[i];

public static A029657Inst Instance=new A029657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029658
{
public static readonly long[] Value={ 2L,2L,2L,4L,2L,2L,16L,14L,6L,2L,30L,20L,2L,36L,50L,8L,2L,2L,64L,140L,196L,182L,112L,44L,10L,2L,204L,336L,378L,294L,156L,54L,2L,100L,540L,714L,672L,450L,210L,12L,2L,1254L,1386L,1122L,660L,2L,144L,506L,1210L,2640L,2508L,1782L,352L,90L,14L,2L,650L,1716L,5148L,4290L,442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029658Inst : IEnumerable<long>
{
public static readonly long[] Value=A029658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029658.Bytes);
public long this[int i]=>Value[i];

public static A029658Inst Instance=new A029658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029659
{
public static readonly long[] Value={ 4L,16L,14L,6L,30L,20L,36L,50L,8L,64L,140L,196L,182L,112L,44L,10L,204L,336L,378L,294L,156L,54L,100L,540L,714L,672L,450L,210L,12L,1254L,1386L,1122L,660L,144L,506L,1210L,2640L,2508L,1782L,352L,90L,14L,650L,1716L,5148L,4290L,442L,104L,196L,2366L,8008L,9438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029659Inst : IEnumerable<long>
{
public static readonly long[] Value=A029659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029659.Bytes);
public long this[int i]=>Value[i];

public static A029659Inst Instance=new A029659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029660
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,25L,13L,55L,27L,15L,49L,91L,105L,77L,35L,17L,19L,81L,21L,285L,65L,23L,121L,385L,825L,275L,2079L,935L,169L,3289L,4719L,2717L,1287L,29L,819L,5005L,9867L,7007L,1729L,119L,31L,225L,1015L,3185L,7371L,13013L,17875L,19305L,16445L,11011L,5733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029660Inst : IEnumerable<long>
{
public static readonly long[] Value=A029660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029660.Bytes);
public long this[int i]=>Value[i];

public static A029660Inst Instance=new A029660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029677
{
public static readonly long[] Value={ 1L,0L,4L,6L,2L,6L,2L,6L,10L,2L,4L,10L,12L,6L,6L,6L,6L,10L,10L,10L,16L,6L,2L,12L,12L,4L,8L,22L,12L,12L,8L,8L,22L,10L,4L,22L,10L,0L,16L,10L,12L,18L,10L,14L,20L,16L,8L,26L,20L,6L,16L,14L,16L,10L,14L,10L,16L,10L,12L,28L,12L,8L,28L,28L,10L,16L,10L,16L,36L,8L,8L,18L,30L,18L,0L,26L,20L,22L,12L,6L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029677Inst : IEnumerable<long>
{
public static readonly long[] Value=A029677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029677.Bytes);
public long this[int i]=>Value[i];

public static A029677Inst Instance=new A029677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029678
{
public static readonly long[] Value={ 1L,0L,0L,4L,6L,4L,0L,0L,2L,8L,0L,4L,18L,0L,0L,8L,6L,0L,0L,4L,12L,12L,0L,8L,12L,8L,0L,8L,12L,4L,0L,8L,2L,8L,0L,0L,42L,8L,0L,16L,0L,8L,0L,4L,24L,12L,0L,0L,18L,8L,0L,16L,12L,4L,0L,8L,12L,16L,0L,12L,48L,8L,0L,16L,6L,8L,0L,12L,12L,16L,0L,8L,14L,0L,0L,20L,24L,8L,0L,8L,12L,24L,0L,4L,72L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029678Inst : IEnumerable<long>
{
public static readonly long[] Value=A029678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029678.Bytes);
public long this[int i]=>Value[i];

public static A029678Inst Instance=new A029678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029679
{
public static readonly long[] Value={ 1L,4L,8L,8L,8L,16L,8L,2L,24L,20L,8L,16L,24L,16L,4L,16L,16L,40L,24L,8L,40L,0L,16L,32L,24L,28L,24L,32L,6L,32L,16L,16L,56L,48L,16L,0L,40L,32L,40L,16L,24L,56L,0L,16L,48L,48L,16L,48L,56L,4L,40L,16L,40L,64L,32L,16L,12L,64L,32L,40L,48L,16L,48L,10L,32L,80L,16L,32L,80L,32L,0L,48L,72L,56L,32L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029679Inst : IEnumerable<long>
{
public static readonly long[] Value=A029679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029679.Bytes);
public long this[int i]=>Value[i];

public static A029679Inst Instance=new A029679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029680
{
public static readonly long[] Value={ 1L,0L,6L,4L,4L,0L,14L,4L,6L,8L,2L,0L,20L,8L,12L,4L,16L,0L,26L,0L,0L,8L,8L,4L,42L,0L,20L,16L,12L,8L,0L,8L,14L,16L,20L,4L,36L,0L,20L,8L,6L,8L,52L,4L,8L,0L,12L,12L,52L,8L,6L,16L,24L,8L,46L,0L,20L,8L,20L,8L,16L,8L,20L,12L,28L,0L,64L,12L,16L,32L,0L,8L,58L,8L,20L,4L,16L,8L,60L,0L,0L,24L,44L,4L,40L,0L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029680Inst : IEnumerable<long>
{
public static readonly long[] Value=A029680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029680.Bytes);
public long this[int i]=>Value[i];

public static A029680Inst Instance=new A029680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029681
{
public static readonly long[] Value={ 1L,0L,6L,6L,0L,6L,6L,12L,6L,0L,6L,12L,6L,6L,24L,12L,0L,0L,18L,6L,6L,14L,12L,24L,6L,0L,18L,24L,12L,12L,12L,12L,6L,0L,12L,42L,0L,12L,30L,12L,6L,0L,42L,12L,12L,18L,12L,36L,6L,0L,30L,12L,6L,24L,24L,12L,24L,0L,24L,30L,12L,6L,36L,60L,0L,0L,12L,24L,0L,12L,42L,36L,18L,0L,24L,30L,6L,48L,36L,12L,6L,0L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029681Inst : IEnumerable<long>
{
public static readonly long[] Value=A029681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029681.Bytes);
public long this[int i]=>Value[i];

public static A029681Inst Instance=new A029681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029682
{
public static readonly long[] Value={ 1L,6L,6L,12L,18L,0L,12L,24L,18L,18L,6L,24L,24L,24L,12L,8L,42L,12L,30L,48L,0L,24L,36L,24L,36L,6L,12L,48L,60L,24L,0L,48L,42L,24L,36L,12L,54L,48L,12L,48L,18L,24L,24L,84L,48L,0L,60L,24L,48L,42L,6L,72L,72L,24L,48L,0L,36L,48L,60L,48L,20L,48L,24L,72L,90L,12L,24L,108L,36L,24L,0L,48L,90L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029682Inst : IEnumerable<long>
{
public static readonly long[] Value=A029682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029682.Bytes);
public long this[int i]=>Value[i];

public static A029682Inst Instance=new A029682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029683
{
public static readonly long[] Value={ 0L,5L,2L,4L,7L,0L,1L,0L,3L,0L,6L,6L,7L,2L,0L,3L,5L,7L,3L,1L,5L,6L,3L,6L,3L,8L,0L,5L,0L,2L,7L,1L,0L,7L,4L,6L,4L,0L,2L,1L,9L,8L,7L,6L,4L,0L,6L,2L,3L,8L,6L,8L,2L,0L,4L,2L,6L,0L,0L,8L,9L,4L,8L,0L,1L,1L,1L,5L,0L,6L,5L,2L,8L,0L,5L,8L,1L,5L,9L,0L,9L,1L,7L,8L,7L,6L,4L,1L,7L,3L,4L,3L,5L,0L,9L,8L,8L,7L,2L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029683Inst : IEnumerable<long>
{
public static readonly long[] Value=A029683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029683.Bytes);
public long this[int i]=>Value[i];

public static A029683Inst Instance=new A029683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029684
{
public static readonly long[] Value={ 0L,8L,6L,2L,4L,4L,5L,3L,7L,0L,3L,4L,9L,6L,0L,0L,1L,5L,3L,7L,6L,0L,6L,0L,6L,0L,1L,6L,3L,6L,5L,5L,9L,7L,9L,1L,1L,7L,9L,9L,8L,0L,2L,5L,5L,9L,6L,1L,4L,5L,1L,9L,1L,7L,9L,2L,2L,6L,3L,4L,5L,5L,0L,9L,8L,2L,0L,6L,8L,2L,0L,1L,3L,3L,9L,5L,7L,2L,6L,2L,0L,9L,7L,0L,0L,4L,3L,5L,5L,2L,8L,8L,0L,3L,3L,7L,5L,2L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029684Inst : IEnumerable<long>
{
public static readonly long[] Value=A029684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029684.Bytes);
public long this[int i]=>Value[i];

public static A029684Inst Instance=new A029684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029685
{
public static readonly long[] Value={ 0L,4L,5L,5L,2L,9L,1L,6L,3L,4L,0L,7L,8L,3L,8L,2L,1L,5L,1L,7L,2L,7L,5L,9L,2L,6L,3L,8L,9L,8L,4L,0L,4L,4L,9L,5L,9L,5L,1L,6L,9L,2L,8L,3L,0L,4L,6L,7L,1L,9L,4L,8L,2L,2L,9L,0L,8L,8L,0L,1L,7L,0L,8L,9L,6L,0L,7L,5L,0L,5L,1L,6L,6L,6L,1L,1L,3L,4L,0L,7L,2L,6L,1L,5L,9L,3L,6L,5L,8L,8L,1L,2L,0L,1L,2L,6L,1L,7L,1L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029685Inst : IEnumerable<long>
{
public static readonly long[] Value=A029685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029685.Bytes);
public long this[int i]=>Value[i];

public static A029685Inst Instance=new A029685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029686
{
public static readonly long[] Value={ 0L,2L,0L,9L,6L,6L,5L,6L,0L,6L,1L,2L,3L,0L,9L,4L,8L,1L,7L,7L,6L,0L,9L,4L,8L,4L,1L,7L,8L,2L,1L,2L,3L,1L,8L,2L,4L,9L,1L,4L,1L,2L,6L,8L,5L,1L,0L,0L,8L,1L,7L,2L,0L,4L,1L,3L,8L,7L,4L,5L,1L,7L,6L,0L,0L,9L,3L,2L,1L,2L,4L,1L,9L,5L,6L,2L,6L,0L,0L,9L,3L,4L,2L,7L,2L,7L,9L,7L,5L,6L,8L,9L,4L,8L,6L,9L,5L,0L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029686Inst : IEnumerable<long>
{
public static readonly long[] Value=A029686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029686.Bytes);
public long this[int i]=>Value[i];

public static A029686Inst Instance=new A029686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029687
{
public static readonly long[] Value={ 0L,0L,9L,0L,9L,8L,2L,9L,6L,3L,2L,7L,9L,8L,6L,4L,1L,5L,3L,7L,4L,3L,5L,8L,3L,6L,1L,0L,7L,4L,6L,9L,6L,2L,9L,6L,8L,1L,4L,0L,9L,9L,2L,2L,1L,4L,6L,1L,3L,9L,3L,1L,7L,5L,9L,7L,0L,7L,6L,8L,1L,7L,6L,7L,8L,8L,3L,6L,1L,3L,5L,8L,6L,5L,0L,6L,5L,7L,7L,8L,5L,7L,3L,6L,3L,5L,1L,6L,6L,8L,8L,4L,7L,6L,8L,7L,2L,6L,6L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029687Inst : IEnumerable<long>
{
public static readonly long[] Value=A029687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029687.Bytes);
public long this[int i]=>Value[i];

public static A029687Inst Instance=new A029687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029688
{
public static readonly long[] Value={ 0L,9L,7L,2L,4L,3L,1L,5L,2L,1L,1L,1L,6L,5L,4L,0L,7L,4L,0L,8L,3L,1L,2L,7L,9L,1L,4L,5L,8L,1L,4L,3L,0L,5L,4L,9L,5L,9L,1L,5L,4L,7L,5L,7L,6L,1L,3L,0L,4L,1L,9L,4L,5L,7L,1L,9L,5L,6L,3L,4L,3L,0L,4L,9L,6L,4L,7L,8L,3L,5L,3L,7L,1L,1L,4L,3L,0L,9L,6L,7L,7L,0L,9L,4L,1L,3L,8L,3L,8L,0L,3L,6L,1L,1L,4L,1L,4L,1L,2L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029688Inst : IEnumerable<long>
{
public static readonly long[] Value=A029688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029688.Bytes);
public long this[int i]=>Value[i];

public static A029688Inst Instance=new A029688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029689
{
public static readonly long[] Value={ 0L,8L,9L,5L,1L,4L,8L,4L,7L,0L,9L,3L,7L,8L,0L,9L,0L,4L,7L,6L,3L,7L,9L,0L,4L,1L,0L,9L,5L,5L,3L,2L,7L,5L,6L,2L,9L,4L,5L,4L,7L,2L,6L,5L,8L,6L,0L,2L,2L,5L,0L,0L,0L,1L,2L,6L,2L,8L,1L,6L,1L,4L,7L,8L,9L,4L,8L,4L,2L,3L,1L,3L,7L,2L,4L,2L,3L,1L,4L,2L,7L,8L,5L,6L,1L,2L,3L,0L,7L,6L,8L,7L,3L,4L,0L,7L,4L,4L,2L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029689Inst : IEnumerable<long>
{
public static readonly long[] Value=A029689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029689.Bytes);
public long this[int i]=>Value[i];

public static A029689Inst Instance=new A029689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029690
{
public static readonly long[] Value={ 1L,0L,44L,60L,54L,256L,252L,216L,572L,544L,540L,1008L,1020L,864L,1728L,1560L,1134L,2800L,2080L,1512L,3832L,3264L,2160L,4608L,4092L,3024L,6328L,4380L,3456L,8224L,6552L,4104L,9308L,8160L,5292L,10656L,8224L,6912L,12960L,10200L,7884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029690Inst : IEnumerable<long>
{
public static readonly long[] Value=A029690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029690.Bytes);
public long this[int i]=>Value[i];

public static A029690Inst Instance=new A029690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029691
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029691Inst : IEnumerable<long>
{
public static readonly long[] Value=A029691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029691.Bytes);
public long this[int i]=>Value[i];

public static A029691Inst Instance=new A029691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029692
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029692Inst : IEnumerable<long>
{
public static readonly long[] Value=A029692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029692.Bytes);
public long this[int i]=>Value[i];

public static A029692Inst Instance=new A029692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029805
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,9L,11L,27L,65L,73L,79L,81L,83L,195L,219L,237L,366L,513L,543L,585L,697L,1094L,1539L,1755L,1875L,2910L,4097L,4161L,4225L,4477L,4617L,4681L,4727L,4891L,5267L,8698L,8730L,11841L,12291L,12483L,12675L,13065L,13851L,14673L,15021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029805Inst : IEnumerable<long>
{
public static readonly long[] Value=A029805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029805.Bytes);
public long this[int i]=>Value[i];

public static A029805Inst Instance=new A029805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029806
{
public static readonly long[] Value={ 0L,1L,4L,9L,36L,81L,121L,729L,4225L,5329L,6241L,6561L,6889L,38025L,47961L,56169L,133956L,263169L,294849L,342225L,485809L,1196836L,2368521L,3080025L,3515625L,8468100L,16785409L,17313921L,17850625L,20043529L,21316689L,21911761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029806Inst : IEnumerable<long>
{
public static readonly long[] Value=A029806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029806.Bytes);
public long this[int i]=>Value[i];

public static A029806Inst Instance=new A029806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029807
{
public static readonly BigInteger[] Value={ 1L,13L,333L,10712L,400075L,16435017L,721861385L,33308540000L,1596292110000L,78832566399375L,3989172320345245L,205979496842877048L,10817872108002076923UL,BigInteger.Parse("576440295110730997877"),BigInteger.Parse("31102930647624990624975") };
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
public class A029807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A029807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A029807Inst Instance=new A029807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029808
{
public static readonly BigInteger[] Value={ 1L,7L,93L,1440L,25225L,476427L,9501737L,197197440L,4219878330L,92516600575L,2068590840349L,47010163129632L,1083052539395723L,25244912684662559L,594388664281931925L,14118181920797391360UL,BigInteger.Parse("337939791145403719897") };
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
public class A029808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A029808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A029808Inst Instance=new A029808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029809
{
public static readonly BigInteger[] Value={ 1L,52L,5133L,656880L,97772875L,16032938340L,2812609211657L,518547356184000L,99318297529004400L,BigInteger.Parse("19605670296090989500"),BigInteger.Parse("3966181169996511862429"),BigInteger.Parse("818782296743542722132528"),BigInteger.Parse("171938262068874336023196923") };
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
public class A029809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A029809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A029809Inst Instance=new A029809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029810
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,1L,2L,1L,3L,6L,1L,1L,2L,2L,1L,8L,1L,1L,2L,1L,1L,2L,2L,583L,2L,1L,1L,4L,2L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029810Inst : IEnumerable<long>
{
public static readonly long[] Value=A029810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029810.Bytes);
public long this[int i]=>Value[i];

public static A029810Inst Instance=new A029810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029811
{
public static readonly long[] Value={ 17L,274L,2640L,11040L,34834L,73440L,125280L,216960L,382800L,592114L,756960L,1033440L,1600800L,2129760L,2402880L,3093120L,4458514L,5392320L,5847600L,7167840L,9473760L,11309760L,11946720L,13618560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029811Inst : IEnumerable<long>
{
public static readonly long[] Value=A029811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029811.Bytes);
public long this[int i]=>Value[i];

public static A029811Inst Instance=new A029811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029812
{
public static readonly long[] Value={ 5L,68L,1028L,4800L,16388L,42568L,81600L,144000L,262148L,440708L,643528L,878400L,1310400L,1942216L,2448000L,3004800L,4194308L,5679496L,6662468L,7819200L,10258888L,13056000L,14932800L,16790400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029812Inst : IEnumerable<long>
{
public static readonly long[] Value=A029812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029812.Bytes);
public long this[int i]=>Value[i];

public static A029812Inst Instance=new A029812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029813
{
public static readonly long[] Value={ 31L,330L,7524L,43736L,158730L,464904L,1052040L,1964160L,3619044L,6522450L,10433544L,15208200L,22346456L,33965448L,47828880L,60888960L,81259530L,114521616L,147492972L,176474760L,223618824L,295334160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029813Inst : IEnumerable<long>
{
public static readonly long[] Value=A029813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029813.Bytes);
public long this[int i]=>Value[i];

public static A029813Inst Instance=new A029813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029814
{
public static readonly long[] Value={ 691L,4030L,187720L,1748240L,8257470L,28108912L,79126320L,184957760L,372624200L,712927150L,1315399280L,2215956080L,3470256400L,5399589680L,8348381600L,12217183680L,16911302590L,23524431840L,33299838520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029814Inst : IEnumerable<long>
{
public static readonly long[] Value=A029814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029814.Bytes);
public long this[int i]=>Value[i];

public static A029814Inst Instance=new A029814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029815
{
public static readonly long[] Value={ 61L,252L,16380L,189280L,1048572L,3937752L,11930464L,30588480L,67108860L,133739676L,255953880L,460605600L,763366240L,1216356120L,1928015424L,2957689280L,4294967292L,6082667640L,8693078940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029815Inst : IEnumerable<long>
{
public static readonly long[] Value=A029815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029815.Bytes);
public long this[int i]=>Value[i];

public static A029815Inst Instance=new A029815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029816
{
public static readonly long[] Value={ 43L,122L,11052L,156520L,1015162L,4266360L,13948984L,38576704L,91963692L,194596466L,385793912L,728690040L,1282368360L,2123154488L,3440247984L,5469965248L,8316222842L,12152481264L,17612411940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029816Inst : IEnumerable<long>
{
public static readonly long[] Value=A029816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029816.Bytes);
public long this[int i]=>Value[i];

public static A029816Inst Instance=new A029816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029817
{
public static readonly long[] Value={ 17L,32L,4064L,70016L,528352L,2500032L,8892032L,26353408L,67637216L,153125024L,317504064L,623589504L,1156034176L,2007952576L,3346882816L,5470070016L,8657571808L,13130837568L,19446878048L,28603895680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029817Inst : IEnumerable<long>
{
public static readonly long[] Value=A029817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029817.Bytes);
public long this[int i]=>Value[i];

public static A029817Inst Instance=new A029817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029818
{
public static readonly long[] Value={ 929569L,1118498L,200825760L,4203101760L,36649832738L,195321562560L,760846576320L,2418032106240L,6632270724000L,16046778745058L,35093590203840L,71703741197760L,138807435624000L,253035567426240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029818Inst : IEnumerable<long>
{
public static readonly long[] Value=A029818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029818.Bytes);
public long this[int i]=>Value[i];

public static A029818Inst Instance=new A029818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029819
{
public static readonly long[] Value={ 1385L,1028L,262148L,6691200L,67108868L,401563528L,1719638400L,5880096000L,17179869188L,44245285508L,102401824648L,218646057600L,440234121600L,838571182216L,1511184672000L,2613756691200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029819Inst : IEnumerable<long>
{
public static readonly long[] Value=A029819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029819.Bytes);
public long this[int i]=>Value[i];

public static A029819Inst Instance=new A029819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029820
{
public static readonly long[] Value={ 3202291L,1421010L,514512324L,16086304856L,185528486610L,1241326706184L,5846619734280L,21588887128320L,67175243533764L,183518787692250L,449362610361864L,1006435487637000L,2108448001067096L,4179412198109448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029820Inst : IEnumerable<long>
{
public static readonly long[] Value=A029820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029820.Bytes);
public long this[int i]=>Value[i];

public static A029820Inst Instance=new A029820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029869
{
public static readonly long[] Value={ 1L,1L,5L,18L,63L,206L,671L,2087L,6434L,19472L,58375L,173316L,511452L,1500697L,4386021L,12775455L,37118209L,107621858L,311552351L,900775893L,2601887149L,7510011727L,21664873773L,62473966631L,180104101037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029869Inst : IEnumerable<long>
{
public static readonly long[] Value=A029869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029869.Bytes);
public long this[int i]=>Value[i];

public static A029869Inst Instance=new A029869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029870
{
public static readonly long[] Value={ 1L,1L,5L,21L,80L,285L,970L,3192L,10236L,32197L,99743L,305276L,925342L,2783012L,8316994L,24726109L,73195582L,215911767L,635028054L,1863156727L,5455350409L,15946267328L,46545783253L,135702643984L,395246786050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029870Inst : IEnumerable<long>
{
public static readonly long[] Value=A029870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029870.Bytes);
public long this[int i]=>Value[i];

public static A029870Inst Instance=new A029870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029871
{
public static readonly long[] Value={ 1L,1L,6L,25L,104L,384L,1380L,4729L,15806L,51478L,164788L,519296L,1617066L,4983855L,15233671L,46235252L,139506803L,418838281L,1252174861L,3730058316L,11077154790L,32808815240L,96953599162L,285945645659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029871Inst : IEnumerable<long>
{
public static readonly long[] Value=A029871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029871.Bytes);
public long this[int i]=>Value[i];

public static A029871Inst Instance=new A029871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029872
{
public static readonly long[] Value={ 16L,72L,288L,1200L,5376L,25480L,125504L,634608L,3269680L,17086168L,90282240L,481347152L,2585485504L,13974825960L,75941188736L,414593263952L,2272626444528L,12502223573304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029872Inst : IEnumerable<long>
{
public static readonly long[] Value=A029872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029872.Bytes);
public long this[int i]=>Value[i];

public static A029872Inst Instance=new A029872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029873
{
public static readonly long[] Value={ 64L,288L,1152L,4800L,21504L,101920L,502016L,2538432L,13078720L,68344672L,361128960L,1925388608L,10341942016L,55899303840L,303764754944L,1658373055808L,9090505778112L,50008894293216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029873Inst : IEnumerable<long>
{
public static readonly long[] Value=A029873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029873.Bytes);
public long this[int i]=>Value[i];

public static A029873Inst Instance=new A029873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029874
{
public static readonly long[] Value={ 2L,9L,36L,150L,672L,3185L,15688L,79326L,408710L,2135771L,11285280L,60168394L,323185688L,1746853245L,9492648592L,51824157994L,284078305566L,1562777946663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029874Inst : IEnumerable<long>
{
public static readonly long[] Value=A029874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029874.Bytes);
public long this[int i]=>Value[i];

public static A029874Inst Instance=new A029874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029875
{
public static readonly long[] Value={ 9L,27L,65L,114L,127L,202L,278L,323L,554L,554L,554L,704L,704L,704L,704L,704L,751L,751L,825L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029875Inst : IEnumerable<long>
{
public static readonly long[] Value=A029875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029875.Bytes);
public long this[int i]=>Value[i];

public static A029875Inst Instance=new A029875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029876
{
public static readonly long[] Value={ 1L,2L,3L,17L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029876Inst : IEnumerable<long>
{
public static readonly long[] Value=A029876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029876.Bytes);
public long this[int i]=>Value[i];

public static A029876Inst Instance=new A029876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029877
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,25L,38L,61L,91L,137L,200L,293L,416L,595L,832L,1161L,1601L,2198L,2983L,4042L,5419L,7245L,9615L,12714L,16703L,21879L,28492L,36989L,47795L,61561L,78956L,100986L,128653L,163461L,206981L,261393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029877Inst : IEnumerable<long>
{
public static readonly long[] Value=A029877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029877.Bytes);
public long this[int i]=>Value[i];

public static A029877Inst Instance=new A029877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029878
{
public static readonly long[] Value={ 1L,1L,0L,-2L,1L,0L,-1L,1L,2L,-3L,-2L,5L,1L,-6L,1L,8L,-6L,-10L,14L,7L,-25L,8L,36L,-34L,-41L,72L,25L,-125L,29L,187L,-150L,-216L,361L,137L,-657L,159L,977L,-810L,-1135L,1937L,752L,-3558L,792L,5361L,-4327L,-6318L,10641L,4281L,-19848L,4286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029878Inst : IEnumerable<long>
{
public static readonly long[] Value=A029878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029878.Bytes);
public long this[int i]=>Value[i];

public static A029878Inst Instance=new A029878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029879
{
public static readonly long[] Value={ 1L,3L,7L,14L,27L,52L,100L,192L,371L,728L,1454L,2940L,5968L,12080L,24304L,48608L,96851L,192816L,384562L,769636L,1546226L,3116184L,6290984L,12700832L,25603536L,51479808L,103178992L,206133344L,410674512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029879Inst : IEnumerable<long>
{
public static readonly long[] Value=A029879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029879.Bytes);
public long this[int i]=>Value[i];

public static A029879Inst Instance=new A029879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029880
{
public static readonly long[] Value={ 1L,1L,-1L,0L,3L,-10L,24L,-48L,83L,-126L,170L,-208L,240L,-272L,272L,0L,-1453L,6698L,-22050L,60896L,-148430L,326404L,-653280L,1188640L,-1939568L,2730976L,-2946256L,1085760L,5849808L,-22935520L,57106944L,-114213888L,188997203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029880Inst : IEnumerable<long>
{
public static readonly long[] Value=A029880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029880.Bytes);
public long this[int i]=>Value[i];

public static A029880Inst Instance=new A029880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029881
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,-2L,0L,1L,0L,-2L,0L,2L,0L,0L,-1L,-1L,1L,0L,0L,2L,-1L,0L,1L,-2L,-1L,0L,0L,0L,1L,2L,0L,1L,0L,-2L,-1L,0L,0L,0L,0L,-2L,0L,2L,1L,0L,0L,-2L,0L,2L,0L,2L,-1L,0L,1L,0L,-1L,0L,0L,-2L,0L,-2L,0L,0L,1L,-1L,0L,0L,0L,2L,-2L,2L,1L,0L,0L,0L,1L,0L,1L,0L,0L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029881Inst : IEnumerable<long>
{
public static readonly long[] Value=A029881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029881.Bytes);
public long this[int i]=>Value[i];

public static A029881Inst Instance=new A029881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029882
{
public static readonly long[] Value={ 1L,3L,3L,4L,3L,6L,2L,6L,5L,6L,2L,9L,2L,6L,7L,7L,3L,9L,2L,9L,5L,6L,3L,12L,4L,6L,7L,8L,3L,12L,2L,9L,6L,6L,5L,14L,2L,6L,6L,12L,2L,12L,3L,8L,11L,6L,2L,15L,3L,9L,7L,8L,3L,12L,5L,12L,6L,6L,2L,19L,2L,6L,9L,10L,6L,12L,2L,9L,6L,12L,3L,18L,2L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029882Inst : IEnumerable<long>
{
public static readonly long[] Value=A029882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029882.Bytes);
public long this[int i]=>Value[i];

public static A029882Inst Instance=new A029882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029883
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029883Inst : IEnumerable<long>
{
public static readonly long[] Value=A029883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029883.Bytes);
public long this[int i]=>Value[i];

public static A029883Inst Instance=new A029883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029884
{
public static readonly long[] Value={ -1L,-1L,2L,-2L,1L,1L,-1L,-1L,1L,1L,-2L,2L,-1L,-1L,2L,-2L,1L,1L,-2L,2L,-1L,-1L,1L,1L,-1L,-1L,2L,-2L,1L,1L,-1L,-1L,1L,1L,-2L,2L,-1L,-1L,1L,1L,-1L,-1L,2L,-2L,1L,1L,-2L,2L,-1L,-1L,2L,-2L,1L,1L,-1L,-1L,1L,1L,-2L,2L,-1L,-1L,2L,-2L,1L,1L,-2L,2L,-1L,-1L,1L,1L,-1L,-1L,2L,-2L,1L,1L,-2L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029884Inst : IEnumerable<long>
{
public static readonly long[] Value=A029884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029884.Bytes);
public long this[int i]=>Value[i];

public static A029884Inst Instance=new A029884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029901
{
public static readonly long[] Value={ 2L,5L,7L,9L,12L,14L,17L,19L,22L,23L,26L,29L,31L,33L,36L,38L,41L,43L,46L,47L,50L,52L,55L,58L,61L,62L,65L,67L,69L,71L,75L,77L,79L,81L,84L,86L,90L,91L,94L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029901Inst : IEnumerable<long>
{
public static readonly long[] Value=A029901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029901.Bytes);
public long this[int i]=>Value[i];

public static A029901Inst Instance=new A029901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029902
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,12L,13L,15L,16L,18L,20L,21L,23L,25L,27L,29L,30L,32L,33L,35L,37L,39L,41L,43L,44L,46L,47L,49L,50L,52L,54L,55L,57L,59L,61L,63L,64L,66L,68L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029902Inst : IEnumerable<long>
{
public static readonly long[] Value=A029902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029902.Bytes);
public long this[int i]=>Value[i];

public static A029902Inst Instance=new A029902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029903
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,9L,11L,12L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029903Inst : IEnumerable<long>
{
public static readonly long[] Value=A029903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029903.Bytes);
public long this[int i]=>Value[i];

public static A029903Inst Instance=new A029903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029904
{
public static readonly long[] Value={ 0L,2L,7L,10L,12L,19L,20L,24L,27L,31L,34L,36L,39L,44L,48L,50L,56L,60L,63L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029904Inst : IEnumerable<long>
{
public static readonly long[] Value=A029904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029904.Bytes);
public long this[int i]=>Value[i];

public static A029904Inst Instance=new A029904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029905
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,11L,14L,17L,19L,22L,24L,26L,28L,31L,34L,36L,38L,40L,42L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029905Inst : IEnumerable<long>
{
public static readonly long[] Value=A029905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029905.Bytes);
public long this[int i]=>Value[i];

public static A029905Inst Instance=new A029905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029906
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,2L,4L,0L,3L,3L,6L,0L,4L,4L,8L,0L,5L,5L,10L,0L,6L,6L,12L,0L,7L,7L,14L,0L,8L,8L,16L,0L,9L,9L,18L,0L,10L,10L,20L,0L,11L,11L,22L,0L,12L,12L,24L,0L,13L,13L,26L,0L,14L,14L,28L,0L,15L,15L,30L,0L,16L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029906Inst : IEnumerable<long>
{
public static readonly long[] Value=A029906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029906.Bytes);
public long this[int i]=>Value[i];

public static A029906Inst Instance=new A029906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029907
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,15L,28L,51L,92L,164L,290L,509L,888L,1541L,2662L,4580L,7852L,13419L,22868L,38871L,65920L,111556L,188422L,317689L,534768L,898825L,1508618L,2528836L,4233872L,7080519L,11828620L,19741179L,32916068L,54835556L,91276202L,151814645L,252318312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029907Inst : IEnumerable<long>
{
public static readonly long[] Value=A029907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029907.Bytes);
public long this[int i]=>Value[i];

public static A029907Inst Instance=new A029907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029908
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,5L,5L,7L,11L,7L,13L,5L,5L,5L,17L,5L,19L,5L,7L,13L,23L,5L,7L,5L,5L,11L,29L,7L,31L,7L,5L,19L,7L,7L,37L,7L,5L,11L,41L,7L,43L,5L,11L,7L,47L,11L,5L,7L,5L,17L,53L,11L,5L,13L,13L,31L,59L,7L,61L,5L,13L,7L,5L,5L,67L,7L,5L,5L,71L,7L,73L,5L,13L,23L,5L,5L,79L,13L,7L,43L,83L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029908Inst : IEnumerable<long>
{
public static readonly long[] Value=A029908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029908.Bytes);
public long this[int i]=>Value[i];

public static A029908Inst Instance=new A029908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029909
{
public static readonly long[] Value={ 0L,4L,5L,5L,5L,7L,7L,5L,5L,5L,5L,5L,7L,13L,5L,7L,5L,5L,11L,7L,7L,5L,19L,7L,7L,7L,5L,11L,7L,5L,11L,7L,11L,5L,7L,5L,17L,11L,5L,13L,13L,31L,7L,5L,13L,7L,5L,5L,7L,5L,5L,7L,5L,13L,23L,5L,5L,13L,7L,43L,5L,13L,11L,7L,17L,13L,5L,5L,19L,5L,5L,13L,5L,17L,5L,13L,19L,5L,5L,13L,5L,11L,5L,5L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029909Inst : IEnumerable<long>
{
public static readonly long[] Value=A029909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029909.Bytes);
public long this[int i]=>Value[i];

public static A029909Inst Instance=new A029909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029910
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,6L,7L,7L,7L,7L,11L,7L,13L,7L,7L,7L,17L,7L,19L,7L,11L,7L,23L,7L,11L,7L,7L,7L,29L,11L,31L,11L,7L,7L,13L,11L,37L,7L,17L,7L,41L,13L,43L,7L,7L,7L,47L,7L,7L,13L,11L,7L,53L,7L,17L,7L,23L,11L,59L,13L,61L,7L,7L,13L,19L,17L,67L,7L,7L,7L,71L,13L,73L,7L,7L,7L,19L,19L,79L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029910Inst : IEnumerable<long>
{
public static readonly long[] Value=A029910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029910.Bytes);
public long this[int i]=>Value[i];

public static A029910Inst Instance=new A029910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029911
{
public static readonly long[] Value={ 1L,5L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,11L,7L,7L,11L,7L,7L,7L,11L,11L,7L,7L,13L,11L,7L,17L,7L,13L,7L,7L,7L,7L,7L,13L,11L,7L,7L,17L,7L,23L,11L,13L,7L,7L,13L,19L,17L,7L,7L,7L,13L,7L,7L,7L,19L,19L,7L,13L,7L,7L,23L,7L,7L,7L,7L,11L,7L,13L,13L,11L,7L,17L,7L,7L,23L,7L,7L,7L,7L,19L,41L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029911Inst : IEnumerable<long>
{
public static readonly long[] Value=A029911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029911.Bytes);
public long this[int i]=>Value[i];

public static A029911Inst Instance=new A029911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029912
{
public static readonly long[] Value={ 1L,3L,5L,5L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,11L,7L,7L,7L,11L,7L,7L,7L,11L,11L,11L,11L,7L,7L,13L,11L,7L,7L,17L,7L,13L,13L,7L,7L,7L,7L,7L,7L,7L,13L,11L,7L,7L,7L,17L,7L,23L,11L,13L,13L,7L,7L,7L,13L,19L,17L,7L,7L,7L,7L,13L,13L,7L,7L,7L,7L,19L,19L,7L,7L,13L,7L,7L,7L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029912Inst : IEnumerable<long>
{
public static readonly long[] Value=A029912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029912.Bytes);
public long this[int i]=>Value[i];

public static A029912Inst Instance=new A029912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029913
{
public static readonly long[] Value={ 2L,3L,17L,5L,13L,7L,17L,59L,29L,11L,17L,13L,53L,293L,16L,17L,16L,19L,16L,16L,16L,23L,16L,16L,16L,16L,16L,29L,16L,31L,16L,16L,16L,16L,16L,37L,16L,16L,16L,41L,16L,43L,16L,16L,16L,47L,16L,16L,16L,16L,16L,53L,16L,16L,16L,16L,16L,59L,16L,61L,16L,16L,16L,16L,16L,67L,16L,16L,16L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029913Inst : IEnumerable<long>
{
public static readonly long[] Value=A029913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029913.Bytes);
public long this[int i]=>Value[i];

public static A029913Inst Instance=new A029913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029914
{
public static readonly long[] Value={ 2L,3L,17L,5L,13L,7L,17L,59L,29L,11L,17L,13L,53L,293L,16L,17L,16L,19L,16L,16L,16L,23L,16L,16L,16L,16L,16L,29L,16L,31L,16L,16L,16L,16L,16L,37L,16L,16L,16L,41L,16L,43L,16L,16L,16L,47L,16L,16L,16L,16L,16L,53L,16L,16L,16L,16L,16L,59L,16L,61L,16L,16L,16L,16L,16L,67L,16L,16L,16L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029914Inst : IEnumerable<long>
{
public static readonly long[] Value=A029914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029914.Bytes);
public long this[int i]=>Value[i];

public static A029914Inst Instance=new A029914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029915
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,59L,60L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029915Inst : IEnumerable<long>
{
public static readonly long[] Value=A029915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029915.Bytes);
public long this[int i]=>Value[i];

public static A029915Inst Instance=new A029915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029916
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029916Inst : IEnumerable<long>
{
public static readonly long[] Value=A029916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029916.Bytes);
public long this[int i]=>Value[i];

public static A029916Inst Instance=new A029916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029933
{
public static readonly long[] Value={ 2L,6L,8L,15L,12L,28L,16L,135L,80L,198L,24L,455L,28L,360L,256L,2295L,36L,2660L,40L,2079L,1408L,828L,48L,11375L,312L,1134L,2240L,6525L,60L,76384L,64L,75735L,1088L,1890L,3456L,1599325L,76L,2340L,4480L,767151L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029933Inst : IEnumerable<long>
{
public static readonly long[] Value=A029933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029933.Bytes);
public long this[int i]=>Value[i];

public static A029933Inst Instance=new A029933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029934
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,4L,3L,5L,1L,6L,1L,7L,5L,32L,1L,27L,1L,20L,21L,11L,1L,64L,5L,13L,27L,49L,1L,375L,1L,512L,11L,17L,35L,5832L,1L,19L,39L,3200L,1L,147L,1L,242L,135L,23L,1L,24576L,7L,625L,17L,676L,1L,6561L,55L,10976L,57L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029934Inst : IEnumerable<long>
{
public static readonly long[] Value=A029934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029934.Bytes);
public long this[int i]=>Value[i];

public static A029934Inst Instance=new A029934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029935
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,8L,12L,12L,16L,16L,20L,20L,24L,24L,32L,28L,32L,32L,36L,40L,48L,40L,44L,48L,56L,48L,60L,60L,56L,64L,60L,64L,80L,64L,96L,80L,72L,72L,96L,96L,80L,96L,84L,100L,128L,88L,92L,112L,120L,112L,128L,120L,104L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029935Inst : IEnumerable<long>
{
public static readonly long[] Value=A029935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029935.Bytes);
public long this[int i]=>Value[i];

public static A029935Inst Instance=new A029935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029936
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,6L,6L,8L,8L,10L,10L,12L,12L,16L,14L,16L,16L,18L,20L,24L,20L,22L,24L,28L,24L,30L,30L,28L,32L,30L,32L,40L,32L,48L,40L,36L,36L,48L,48L,40L,48L,42L,50L,64L,44L,46L,56L,60L,56L,64L,60L,52L,60L,80L,72L,72L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029936Inst : IEnumerable<long>
{
public static readonly long[] Value=A029936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029936.Bytes);
public long this[int i]=>Value[i];

public static A029936Inst Instance=new A029936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029937
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,2L,5L,2L,7L,3L,5L,6L,12L,5L,12L,10L,13L,10L,22L,9L,26L,17L,21L,21L,25L,17L,40L,28L,33L,25L,51L,25L,57L,36L,41L,45L,70L,37L,69L,48L,65L,55L,92L,52L,81L,61L,85L,78L,117L,57L,126L,91L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029937Inst : IEnumerable<long>
{
public static readonly long[] Value=A029937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029937.Bytes);
public long this[int i]=>Value[i];

public static A029937Inst Instance=new A029937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029938
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,7L,12L,22L,26L,40L,51L,57L,70L,92L,117L,126L,155L,176L,187L,222L,247L,287L,345L,376L,392L,425L,442L,477L,610L,651L,715L,737L,852L,876L,950L,1027L,1080L,1162L,1247L,1276L,1426L,1457L,1520L,1552L,1751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029938Inst : IEnumerable<long>
{
public static readonly long[] Value=A029938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029938.Bytes);
public long this[int i]=>Value[i];

public static A029938Inst Instance=new A029938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029939
{
public static readonly long[] Value={ 1L,2L,5L,6L,17L,10L,37L,22L,41L,34L,101L,30L,145L,74L,85L,86L,257L,82L,325L,102L,185L,202L,485L,110L,417L,290L,365L,222L,785L,170L,901L,342L,505L,514L,629L,246L,1297L,650L,725L,374L,1601L,370L,1765L,606L,697L,970L,2117L,430L,1801L,834L,1285L,870L,2705L,730L,1717L,814L,1625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029939Inst : IEnumerable<long>
{
public static readonly long[] Value=A029939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029939.Bytes);
public long this[int i]=>Value[i];

public static A029939Inst Instance=new A029939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029940
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,8L,12L,16L,10L,32L,12L,36L,64L,64L,16L,144L,18L,256L,144L,100L,22L,1024L,80L,144L,216L,864L,28L,4096L,30L,1024L,400L,256L,576L,13824L,36L,324L,576L,16384L,40L,20736L,42L,4000L,9216L,484L,46L,131072L,252L,6400L,1024L,6912L,52L,46656L,1600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029940Inst : IEnumerable<long>
{
public static readonly long[] Value=A029940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029940.Bytes);
public long this[int i]=>Value[i];

public static A029940Inst Instance=new A029940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029941
{
public static readonly long[] Value={ 1L,15L,50L,225L,590L,1485L,3130L,6435L,11931L,21450L,36220L,59670L,94140L,145350L,217500L,319770L,458981L,648945L,900350L,1233375L,1663850L,2220075L,2924870L,3817125L,4928511L,6310980L,8007640L,10086780L,12605560L,15651900L,19300440L,23662980L,28835081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029941Inst : IEnumerable<long>
{
public static readonly long[] Value=A029941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029941.Bytes);
public long this[int i]=>Value[i];

public static A029941Inst Instance=new A029941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029942
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,9L,10L,24L,25L,32L,40L,49L,50L,51L,56L,60L,75L,76L,90L,99L,100L,125L,240L,249L,250L,251L,375L,376L,400L,490L,499L,500L,501L,510L,600L,624L,625L,749L,750L,751L,760L,782L,875L,900L,990L,999L,1000L,1249L,1250L,2400L,2490L,2500L,2510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029942Inst : IEnumerable<long>
{
public static readonly long[] Value=A029942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029942.Bytes);
public long this[int i]=>Value[i];

public static A029942Inst Instance=new A029942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029943
{
public static readonly long[] Value={ 0L,1L,5L,6L,10L,25L,50L,60L,76L,100L,250L,376L,500L,600L,625L,760L,1000L,2500L,3760L,5000L,6000L,6250L,7600L,9376L,10000L,25000L,37600L,50000L,60000L,62500L,76000L,90625L,93760L,100000L,109376L,250000L,376000L,500000L,600000L,625000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029943Inst : IEnumerable<long>
{
public static readonly long[] Value=A029943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029943.Bytes);
public long this[int i]=>Value[i];

public static A029943Inst Instance=new A029943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029944
{
public static readonly long[] Value={ 5L,6L,5L,24L,34L,37L,42L,14L,48L,23L,56L,61L,21L,66L,69L,73L,77L,19L,26L,131L,86L,89L,94L,17L,176L,318L,321L,226L,331L,337L,113L,146L,371L,118L,339L,123L,397L,128L,409L,416L,134L,426L,438L,44L,346L,447L,46L,473L,472L,479L,483L,352L,79L,501L,507L,513L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029944Inst : IEnumerable<long>
{
public static readonly long[] Value=A029944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029944.Bytes);
public long this[int i]=>Value[i];

public static A029944Inst Instance=new A029944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029945
{
public static readonly long[] Value={ 25L,36L,25L,576L,1156L,1369L,1764L,196L,2304L,529L,3136L,3721L,441L,4356L,4761L,5329L,5929L,361L,676L,17161L,7396L,7921L,8836L,289L,30976L,101124L,103041L,51076L,109561L,113569L,12769L,21316L,137641L,13924L,114921L,15129L,157609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029945Inst : IEnumerable<long>
{
public static readonly long[] Value=A029945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029945.Bytes);
public long this[int i]=>Value[i];

public static A029945Inst Instance=new A029945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029946
{
public static readonly long[] Value={ 3L,7L,5L,3L,45L,11L,12L,13L,47L,9L,11L,15L,81L,7L,63L,37L,19L,21L,23L,83L,46L,31L,18L,29L,13L,106L,47L,221L,103L,225L,238L,236L,255L,225L,285L,205L,54L,168L,23L,161L,148L,122L,106L,57L,13L,271L,171L,247L,497L,132L,177L,198L,148L,136L,137L,133L,61L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029946Inst : IEnumerable<long>
{
public static readonly long[] Value=A029946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029946.Bytes);
public long this[int i]=>Value[i];

public static A029946Inst Instance=new A029946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029947
{
public static readonly long[] Value={ 27L,343L,125L,27L,91125L,1331L,1728L,2197L,103823L,729L,1331L,3375L,531441L,343L,250047L,50653L,6859L,9261L,12167L,571787L,97336L,29791L,5832L,24389L,2197L,1191016L,103823L,10793861L,1092727L,11390625L,13481272L,13144256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029947Inst : IEnumerable<long>
{
public static readonly long[] Value=A029947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029947.Bytes);
public long this[int i]=>Value[i];

public static A029947Inst Instance=new A029947Inst();

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