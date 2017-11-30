using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238873
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,5L,7L,9L,11L,14L,19L,25L,31L,38L,46L,59L,73L,92L,112L,135L,162L,196L,237L,289L,349L,417L,496L,587L,691L,820L,970L,1151L,1357L,1598L,1870L,2183L,2537L,2952L,3433L,3997L,4644L,5393L,6248L,7220L,8318L,9566L,10981L,12605L,14457L,16582L,19002L,21767L,24886L,28424L,32396L,36873L,41901L,47579L,53974L,61221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238873Inst : IEnumerable<long>
{
public static readonly long[] Value=A238873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238873.Bytes);
public long this[int i]=>Value[i];

public static A238873Inst Instance=new A238873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238874
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,4L,5L,7L,10L,14L,19L,25L,33L,44L,59L,79L,105L,138L,180L,234L,304L,395L,513L,665L,859L,1105L,1416L,1809L,2306L,2935L,3731L,4737L,6005L,7598L,9593L,12085L,15192L,19061L,23875L,29861L,37299L,46532L,57978L,72145L,89650L,111243L,137837L,170545L,210725L,260034L,320492L,394557L,485213L,596074L,731508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238874Inst : IEnumerable<long>
{
public static readonly long[] Value=A238874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238874.Bytes);
public long this[int i]=>Value[i];

public static A238874Inst Instance=new A238874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238875
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,7L,10L,15L,18L,26L,35L,47L,61L,80L,103L,138L,175L,224L,283L,362L,455L,577L,721L,898L,1111L,1380L,1701L,2106L,2577L,3156L,3844L,4680L,5671L,6879L,8312L,10034L,12060L,14478L,17319L,20715L,24703L,29442L,35004L,41578L,49247L,58278L,68796L,81132L,95502L,112320L,131877L,154705L,181158L,211908L,247475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238875Inst : IEnumerable<long>
{
public static readonly long[] Value=A238875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238875.Bytes);
public long this[int i]=>Value[i];

public static A238875Inst Instance=new A238875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238876
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,10L,15L,20L,24L,34L,46L,58L,76L,97L,126L,166L,209L,262L,333L,422L,529L,667L,833L,1024L,1268L,1567L,1934L,2385L,2911L,3549L,4319L,5237L,6340L,7675L,9274L,11164L,13404L,16046L,19173L,22889L,27278L,32458L,38574L,45750L,54140L,63976L,75449L,88848L,104503L,122773L,144077L,168860L,197609L,230916L,269494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238876Inst : IEnumerable<long>
{
public static readonly long[] Value=A238876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238876.Bytes);
public long this[int i]=>Value[i];

public static A238876Inst Instance=new A238876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238877
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,1L,0L,3L,2L,2L,0L,1L,1L,1L,0L,2L,3L,1L,0L,1L,1L,1L,0L,5L,9L,1L,0L,2L,3L,1L,0L,2L,3L,1L,1L,1L,1L,1L,0L,3L,12L,2L,0L,1L,1L,3L,2L,2L,2L,1L,0L,1L,3L,1L,0L,7L,44L,1L,0L,1L,1L,1L,0L,4L,10L,1L,0L,1L,1L,1L,1L,3L,11L,1L,0L,1L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238877Inst : IEnumerable<long>
{
public static readonly long[] Value=A238877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238877.Bytes);
public long this[int i]=>Value[i];

public static A238877Inst Instance=new A238877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238878
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,4L,3L,2L,5L,5L,3L,4L,2L,2L,3L,3L,5L,3L,1L,3L,4L,4L,2L,5L,2L,2L,7L,3L,2L,4L,4L,7L,4L,4L,4L,4L,4L,3L,4L,4L,4L,2L,4L,3L,7L,4L,9L,6L,3L,4L,5L,4L,2L,4L,4L,4L,3L,4L,5L,6L,10L,4L,4L,8L,9L,6L,5L,6L,5L,7L,8L,9L,5L,2L,5L,7L,1L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238878Inst : IEnumerable<long>
{
public static readonly long[] Value=A238878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238878.Bytes);
public long this[int i]=>Value[i];

public static A238878Inst Instance=new A238878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238879
{
public static readonly long[] Value={ 1L,1L,2L,5L,5L,21L,14L,84L,42L,330L,132L,1287L,429L,5005L,1430L,19448L,4862L,75582L,16796L,293930L,58786L,1144066L,208012L,4457400L,742900L,17383860L,2674440L,67863915L,9694845L,265182525L,35357670L,1037158320L,129644790L,4059928950L,477638700L,15905368710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238879Inst : IEnumerable<long>
{
public static readonly long[] Value=A238879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238879.Bytes);
public long this[int i]=>Value[i];

public static A238879Inst Instance=new A238879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238944
{
public static readonly long[] Value={ 0L,2L,1L,3L,2L,6L,7L,13L,14L,23L,26L,40L,47L,69L,85L,119L,145L,198L,242L,320L,391L,507L,620L,794L,968L,1226L,1493L,1869L,2269L,2816L,3408L,4194L,5056L,6178L,7423L,9014L,10793L,13035L,15561L,18700L,22251L,26621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238944Inst : IEnumerable<long>
{
public static readonly long[] Value=A238944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238944.Bytes);
public long this[int i]=>Value[i];

public static A238944Inst Instance=new A238944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238945
{
public static readonly long[] Value={ 1L,0L,2L,2L,5L,5L,8L,9L,16L,19L,30L,37L,54L,66L,91L,112L,152L,187L,248L,307L,401L,495L,635L,781L,990L,1210L,1517L,1849L,2296L,2788L,3434L,4155L,5087L,6132L,7460L,8963L,10844L,12980L,15624L,18638L,22332L,26553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238945Inst : IEnumerable<long>
{
public static readonly long[] Value=A238945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238945.Bytes);
public long this[int i]=>Value[i];

public static A238945Inst Instance=new A238945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238946
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,2L,1L,1L,3L,1L,3L,2L,2L,1L,3L,1L,2L,1L,3L,1L,6L,1L,1L,2L,2L,2L,4L,1L,2L,2L,3L,1L,6L,1L,3L,3L,2L,1L,3L,1L,3L,2L,3L,1L,3L,2L,3L,2L,2L,1L,7L,1L,2L,3L,1L,2L,6L,1L,3L,2L,6L,1L,5L,1L,2L,3L,3L,2L,6L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238946Inst : IEnumerable<long>
{
public static readonly long[] Value=A238946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238946.Bytes);
public long this[int i]=>Value[i];

public static A238946Inst Instance=new A238946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238947
{
public static readonly long[] Value={ 8L,100L,3524L,5084L,36680L,77980L,21474824L,134201344L,148647496L,300741464L,73851531256L,153122539756L,778318386944L,6669171349484L,16526971109344L,596403262068016L,9376599920124524L,26698166963373164L,140144514160214876L,1613032378604451500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238947Inst : IEnumerable<long>
{
public static readonly long[] Value=A238947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238947.Bytes);
public long this[int i]=>Value[i];

public static A238947Inst Instance=new A238947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238948
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,4L,7L,11L,12L,23L,15L,6L,111L,22L,14L,25L,17L,18L,9L,117L,28L,10L,21L,33L,16L,27L,19L,110L,31L,24L,26L,38L,211L,32L,35L,48L,112L,43L,37L,210L,41L,45L,29L,311L,42L,36L,39L,212L,53L,58L,113L,34L,47L,411L,52L,57L,312L,63L,49L,213L,44L,68L,114L,55L,310L,51L,46L,410L,61L,67L,313L,54L,59L,214L,65L,511L,62L,78L,115L,56L,611L,72L,69L,215L,66L,412L,73L,510L,71L,88L,116L,77L,314L,75L,512L,83L,711L,82L,610L,81L,79L,216L,87L,315L,76L,413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238948Inst : IEnumerable<long>
{
public static readonly long[] Value=A238948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238948.Bytes);
public long this[int i]=>Value[i];

public static A238948Inst Instance=new A238948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238949
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,3L,2L,2L,1L,3L,2L,2L,2L,3L,1L,3L,1L,2L,2L,2L,2L,4L,1L,2L,2L,3L,1L,3L,1L,3L,3L,2L,1L,3L,2L,3L,2L,3L,1L,3L,2L,3L,2L,2L,1L,4L,1L,2L,3L,2L,2L,3L,1L,3L,2L,3L,1L,4L,1L,2L,3L,3L,2L,3L,1L,3L,2L,2L,1L,4L,2L,2L,2L,3L,1L,4L,2L,3L,2L,2L,2L,3L,1L,3L,3L,4L,1L,3L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238949Inst : IEnumerable<long>
{
public static readonly long[] Value=A238949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238949.Bytes);
public long this[int i]=>Value[i];

public static A238949Inst Instance=new A238949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238950
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,2L,2L,1L,4L,1L,4L,2L,2L,1L,5L,1L,2L,2L,4L,1L,6L,1L,3L,2L,2L,2L,6L,1L,2L,2L,5L,1L,6L,1L,4L,4L,2L,1L,7L,1L,4L,2L,4L,1L,5L,2L,5L,2L,2L,1L,10L,1L,2L,4L,3L,2L,6L,1L,4L,2L,6L,1L,9L,1L,2L,4L,4L,2L,6L,1L,7L,2L,2L,1L,10L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238950Inst : IEnumerable<long>
{
public static readonly long[] Value=A238950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238950.Bytes);
public long this[int i]=>Value[i];

public static A238950Inst Instance=new A238950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238951
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,1L,1L,2L,0L,3L,0L,2L,2L,2L,0L,3L,0L,3L,2L,2L,0L,5L,1L,2L,1L,3L,0L,6L,0L,2L,2L,2L,2L,6L,0L,2L,2L,5L,0L,6L,0L,3L,3L,2L,0L,6L,1L,3L,2L,3L,0L,5L,2L,5L,2L,2L,0L,10L,0L,2L,3L,3L,2L,6L,0L,3L,2L,6L,0L,8L,0L,2L,3L,3L,2L,6L,0L,6L,2L,2L,0L,10L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238951Inst : IEnumerable<long>
{
public static readonly long[] Value=A238951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238951.Bytes);
public long this[int i]=>Value[i];

public static A238951Inst Instance=new A238951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238952
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,1L,6L,3L,5L,1L,12L,1L,5L,5L,10L,1L,12L,1L,12L,5L,5L,1L,22L,3L,5L,6L,12L,1L,19L,1L,15L,5L,5L,5L,27L,1L,5L,5L,22L,1L,19L,1L,12L,12L,5L,1L,35L,3L,12L,5L,12L,1L,22L,5L,22L,5L,5L,1L,42L,1L,5L,12L,21L,5L,19L,1L,12L,5L,19L,1L,48L,1L,5L,12L,12L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238952Inst : IEnumerable<long>
{
public static readonly long[] Value=A238952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238952.Bytes);
public long this[int i]=>Value[i];

public static A238952Inst Instance=new A238952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238953
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,7L,12L,4L,10L,12L,20L,32L,5L,13L,17L,28L,33L,52L,80L,6L,16L,22L,24L,36L,46L,54L,72L,84L,128L,192L,7L,19L,27L,31L,44L,59L,64L,75L,92L,116L,135L,176L,204L,304L,448L,8L,22L,32L,38L,40L,52L,72L,82L,96L,104L,112L,148L,160L,186L,216L,224L,280L,324L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238953Inst : IEnumerable<long>
{
public static readonly long[] Value=A238953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238953.Bytes);
public long this[int i]=>Value[i];

public static A238953Inst Instance=new A238953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238954
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,6L,1L,2L,3L,4L,5L,7L,10L,1L,2L,3L,4L,4L,6L,7L,8L,10L,14L,20L,1L,2L,3L,4L,4L,6L,7L,8L,8L,11L,13L,15L,18L,25L,35L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238954Inst : IEnumerable<long>
{
public static readonly long[] Value=A238954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238954.Bytes);
public long this[int i]=>Value[i];

public static A238954Inst Instance=new A238954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238955
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,6L,1L,3L,4L,7L,12L,1L,3L,5L,8L,11L,18L,30L,1L,3L,5L,6L,8L,12L,15L,19L,24L,38L,60L,1L,3L,5L,7L,8L,13L,16L,19L,20L,30L,37L,46L,58L,90L,140L,1L,3L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238955Inst : IEnumerable<long>
{
public static readonly long[] Value=A238955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238955.Bytes);
public long this[int i]=>Value[i];

public static A238955Inst Instance=new A238955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238956
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,2L,3L,4L,4L,4L,2L,3L,4L,4L,5L,5L,5L,2L,3L,4L,4L,4L,5L,6L,5L,6L,6L,6L,2L,3L,4L,4L,4L,5L,5L,6L,5L,6L,7L,6L,7L,7L,7L,2L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238956Inst : IEnumerable<long>
{
public static readonly long[] Value=A238956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238956.Bytes);
public long this[int i]=>Value[i];

public static A238956Inst Instance=new A238956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238957
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,3L,4L,5L,6L,8L,3L,5L,6L,8L,9L,12L,16L,4L,6L,8L,8L,10L,12L,14L,16L,18L,24L,32L,4L,7L,9L,10L,12L,15L,16L,18L,20L,24L,27L,32L,36L,48L,64L,5L,8L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238957Inst : IEnumerable<long>
{
public static readonly long[] Value=A238957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238957.Bytes);
public long this[int i]=>Value[i];

public static A238957Inst Instance=new A238957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238958
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,2L,4L,4L,6L,8L,3L,5L,6L,8L,9L,12L,16L,3L,6L,7L,8L,10L,12L,13L,16L,18L,24L,32L,4L,7L,9L,10L,12L,15L,16L,18L,20L,24L,27L,32L,36L,48L,64L,4L,8L,10L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238958Inst : IEnumerable<long>
{
public static readonly long[] Value=A238958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238958.Bytes);
public long this[int i]=>Value[i];

public static A238958Inst Instance=new A238958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238959
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,4L,6L,2L,5L,6L,10L,16L,3L,7L,9L,14L,17L,26L,40L,3L,8L,11L,12L,18L,23L,27L,36L,42L,64L,96L,4L,10L,14L,16L,22L,30L,32L,38L,46L,58L,68L,88L,102L,152L,224L,4L,11L,16L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238959Inst : IEnumerable<long>
{
public static readonly long[] Value=A238959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238959.Bytes);
public long this[int i]=>Value[i];

public static A238959Inst Instance=new A238959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239008
{
public static readonly long[] Value={ 0L,3L,5L,7L,9L,11L,13L,19L,23L,24L,26L,28L,31L,34L,52L,65L,68L,136L,237L,4947L,7648L,42073L,50693L,52728L,395128L,2544983L,6013333L,76350564L,160451107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239008Inst : IEnumerable<long>
{
public static readonly long[] Value=A239008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239008.Bytes);
public long this[int i]=>Value[i];

public static A239008Inst Instance=new A239008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239009
{
public static readonly long[] Value={ 0L,2L,4L,7L,9L,12L,14L,16L,17L,23L,34L,36L,38L,43L,77L,88L,216L,350L,979L,24186L,28678L,134759L,205829L,374627L,2200364L,16625243L,29451854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239009Inst : IEnumerable<long>
{
public static readonly long[] Value=A239009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239009.Bytes);
public long this[int i]=>Value[i];

public static A239009Inst Instance=new A239009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239010
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,9L,11L,15L,17L,18L,25L,26L,30L,33L,57L,58L,153L,1839L,3290L,4081L,16431L,577839L,2190974L,15167023L,23155442L,24477994L,36290003L,53687441L,62497567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239010Inst : IEnumerable<long>
{
public static readonly long[] Value=A239010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239010.Bytes);
public long this[int i]=>Value[i];

public static A239010Inst Instance=new A239010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239011
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,8L,12L,17L,24L,29L,42L,44L,101L,104L,128L,1015L,1108L,2629L,9683L,676076L,917474L,34882222L,53229360L,58230015L,90064345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239011Inst : IEnumerable<long>
{
public static readonly long[] Value=A239011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239011.Bytes);
public long this[int i]=>Value[i];

public static A239011Inst Instance=new A239011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239012
{
public static readonly long[] Value={ 0L,2L,3L,6L,10L,11L,19L,35L,127L,131L,175L,207L,1235L,2470L,2651L,1241310L,1922910L,471056338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239012Inst : IEnumerable<long>
{
public static readonly long[] Value=A239012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239012.Bytes);
public long this[int i]=>Value[i];

public static A239012Inst Instance=new A239012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239013
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,11L,12L,13L,17L,24L,27L,43L,144L,342L,633L,653L,2642L,6966L,16124L,84595L,225177L,4069057L,4890280L,6298187L,39573326L,99250579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239013Inst : IEnumerable<long>
{
public static readonly long[] Value=A239013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239013.Bytes);
public long this[int i]=>Value[i];

public static A239013Inst Instance=new A239013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239014
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,12L,13L,14L,17L,26L,34L,68L,406L,926L,2227L,3379L,3824L,26364L,197564L,9669757L,11470439L,15754533L,18945654L,25742286L,38175282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239014Inst : IEnumerable<long>
{
public static readonly long[] Value=A239014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239014.Bytes);
public long this[int i]=>Value[i];

public static A239014Inst Instance=new A239014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239015
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,12L,13L,14L,15L,16L,18L,36L,41L,366L,488L,4357L,69137L,89371L,143907L,542116L,2431369L,5877361L,8966861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239015Inst : IEnumerable<long>
{
public static readonly long[] Value=A239015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239015.Bytes);
public long this[int i]=>Value[i];

public static A239015Inst Instance=new A239015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239016
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,33L,34L,35L,36L,37L,38L,39L,44L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,66L,67L,68L,69L,77L,78L,79L,88L,89L,99L,111L,112L,113L,114L,115L,116L,117L,118L,119L,122L,123L,124L,125L,126L,127L,128L,129L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239016Inst : IEnumerable<long>
{
public static readonly long[] Value=A239016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239016.Bytes);
public long this[int i]=>Value[i];

public static A239016Inst Instance=new A239016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239017
{
public static readonly long[] Value={ 1L,2L,3L,12L,13L,21L,23L,31L,32L,112L,113L,121L,122L,123L,131L,132L,133L,211L,212L,213L,221L,223L,231L,232L,233L,311L,312L,313L,321L,322L,323L,331L,332L,1112L,1113L,1121L,1122L,1123L,1131L,1132L,1133L,1211L,1213L,1221L,1222L,1223L,1231L,1232L,1233L,1311L,1312L,1321L,1322L,1323L,1331L,1332L,1333L,2111L,2112L,2113L,2122L,2123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239017Inst : IEnumerable<long>
{
public static readonly long[] Value=A239017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239017.Bytes);
public long this[int i]=>Value[i];

public static A239017Inst Instance=new A239017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239018
{
public static readonly long[] Value={ 11L,22L,33L,111L,222L,333L,1111L,1212L,1313L,2121L,2222L,2323L,3131L,3232L,3333L,11111L,22222L,33333L,111111L,112112L,113113L,121121L,121212L,122122L,123123L,131131L,131313L,132132L,133133L,211211L,212121L,212212L,213213L,221221L,222222L,223223L,231231L,232232L,232323L,233233L,311311L,312312L,313131L,313313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239018Inst : IEnumerable<long>
{
public static readonly long[] Value=A239018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239018.Bytes);
public long this[int i]=>Value[i];

public static A239018Inst Instance=new A239018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239019
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,111L,222L,333L,444L,555L,666L,777L,888L,999L,1010L,1111L,1212L,1313L,1414L,1515L,1616L,1717L,1818L,1919L,2020L,2121L,2222L,2323L,2424L,2525L,2626L,2727L,2828L,2929L,3030L,3131L,3232L,3333L,3434L,3535L,3636L,3737L,3838L,3939L,4040L,4141L,4242L,4343L,4444L,4545L,4646L,4747L,4848L,4949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239019Inst : IEnumerable<long>
{
public static readonly long[] Value=A239019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239019.Bytes);
public long this[int i]=>Value[i];

public static A239019Inst Instance=new A239019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239020
{
public static readonly long[] Value={ 4L,3L,2L,15L,6L,2L,150L,75L,20L,6L,78L,85L,2490L,30L,18L,195L,5160L,490L,330L,12L,2L,870L,330L,13L,42L,105L,2280L,375L,12L,41L,1632L,720L,90L,3L,216L,2L,1380L,615L,98L,84L,438L,65L,600L,210L,148L,735L,3870L,115L,138L,39L,182L,2715L,16590L,48L,60L,63L,210L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239020Inst : IEnumerable<long>
{
public static readonly long[] Value=A239020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239020.Bytes);
public long this[int i]=>Value[i];

public static A239020Inst Instance=new A239020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239021
{
public static readonly long[] Value={ 4L,105525L,10990L,15855L,344190L,2L,74580L,11580L,165592L,3759L,204918L,12670L,99090L,78L,3978L,11655L,8979180L,10605L,55188L,1221L,2L,23340L,4431420L,39158L,58464L,87318L,45420L,15780L,210L,91L,289422L,19740L,186410L,1293L,137664L,747L,443730L,94920L,278278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239021Inst : IEnumerable<long>
{
public static readonly long[] Value=A239021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239021.Bytes);
public long this[int i]=>Value[i];

public static A239021Inst Instance=new A239021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239022
{
public static readonly long[] Value={ 3L,0L,7L,9L,2L,0L,1L,4L,3L,5L,6L,7L,8L,0L,0L,4L,0L,7L,7L,3L,8L,2L,1L,2L,6L,8L,2L,9L,3L,4L,3L,7L,7L,3L,0L,9L,6L,7L,8L,7L,2L,0L,9L,3L,4L,0L,1L,0L,7L,3L,4L,3L,3L,3L,8L,7L,6L,5L,8L,7L,9L,0L,7L,4L,5L,8L,1L,2L,1L,4L,2L,5L,2L,2L,8L,2L,3L,1L,1L,1L,7L,7L,0L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239022Inst : IEnumerable<long>
{
public static readonly long[] Value=A239022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239022.Bytes);
public long this[int i]=>Value[i];

public static A239022Inst Instance=new A239022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239023
{
public static readonly BigInteger[] Value={ 1L,3L,7L,59L,354L,7265L,107611L,5388959L,194626082L,23726658020L,2082243229557L,617263247981529L,131451761499759800L,BigInteger.Parse("94681989011284774859"),BigInteger.Parse("48894324154695455938601") };
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
public class A239023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239023Inst Instance=new A239023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239040
{
public static readonly long[] Value={ 3L,7L,16L,38L,90L,212L,500L,1180L,2784L,6568L,15496L,36560L,86256L,203504L,480128L,1132768L,2672544L,6305344L,14876224L,35097536L,82805760L,195363968L,460923008L,1087457536L,2565643008L,6053132032L,14281179136L,33693644288L,79493552640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239040Inst : IEnumerable<long>
{
public static readonly long[] Value=A239040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239040.Bytes);
public long this[int i]=>Value[i];

public static A239040Inst Instance=new A239040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239041
{
public static readonly long[] Value={ 7L,41L,218L,1187L,6524L,35683L,194936L,1065802L,5827642L,31860101L,174181686L,952284895L,5206307168L,28463699289L,155615648162L,850776208722L,4651331810246L,25429586046868L,139027679384545L,760086916112708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239041Inst : IEnumerable<long>
{
public static readonly long[] Value=A239041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239041.Bytes);
public long this[int i]=>Value[i];

public static A239041Inst Instance=new A239041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239042
{
public static readonly long[] Value={ 16L,218L,2739L,34344L,432705L,5444993L,68414459L,859450650L,10797617215L,135648111799L,1704038993248L,21406334238897L,268908730806472L,3378051755872444L,42435273089271773L,533074068671063881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239042Inst : IEnumerable<long>
{
public static readonly long[] Value=A239042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239042.Bytes);
public long this[int i]=>Value[i];

public static A239042Inst Instance=new A239042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239043
{
public static readonly BigInteger[] Value={ 38L,1187L,34344L,996325L,28827920L,831472462L,23966393838L,690533224800L,19889264165241L,572800898558670L,16495673342248420L,475029183687749411L,13679240504824830042UL,BigInteger.Parse("393913243384994226842"),BigInteger.Parse("11343249595637879111211") };
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
public class A239043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239043Inst Instance=new A239043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239044
{
public static readonly BigInteger[] Value={ 90L,6524L,432705L,28827920L,1916936295L,126785422189L,8374355016629L,552972642874139L,36495962765384251L,2408028908123414830L,BigInteger.Parse("158867999243856672296"),BigInteger.Parse("10480609337583170118054"),BigInteger.Parse("691383558921685626557165") };
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
public class A239044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239044Inst Instance=new A239044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239045
{
public static readonly BigInteger[] Value={ 212L,35683L,5444993L,831472462L,126785422189L,19230047618078L,2910650412464677L,440291290383709457L,BigInteger.Parse("66567398078863767488"),BigInteger.Parse("10060537232509559609061"),BigInteger.Parse("1520209039141994341925737") };
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
public class A239045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239045Inst Instance=new A239045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239046
{
public static readonly BigInteger[] Value={ 500L,194936L,68414459L,23966393838L,8374355016629L,2910650412464677L,1009453455314170147L,BigInteger.Parse("349787407102201129657"),BigInteger.Parse("121125496496197907493593"),BigInteger.Parse("41926042184487835842653865"),BigInteger.Parse("14508850459207232983300171301") };
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
public class A239046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239046Inst Instance=new A239046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239047
{
public static readonly long[] Value={ 3L,7L,7L,16L,41L,16L,38L,218L,218L,38L,90L,1187L,2739L,1187L,90L,212L,6524L,34344L,34344L,6524L,212L,500L,35683L,432705L,996325L,432705L,35683L,500L,1180L,194936L,5444993L,28827920L,28827920L,5444993L,194936L,1180L,2784L,1065802L,68414459L,831472462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239047Inst : IEnumerable<long>
{
public static readonly long[] Value=A239047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239047.Bytes);
public long this[int i]=>Value[i];

public static A239047Inst Instance=new A239047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239048
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,13L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239048Inst : IEnumerable<long>
{
public static readonly long[] Value=A239048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239048.Bytes);
public long this[int i]=>Value[i];

public static A239048Inst Instance=new A239048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239049
{
public static readonly long[] Value={ 2L,5L,6L,5L,0L,9L,9L,6L,6L,0L,3L,2L,3L,7L,2L,8L,1L,9L,1L,0L,8L,8L,0L,7L,2L,7L,1L,9L,3L,4L,2L,0L,1L,2L,8L,2L,2L,9L,3L,4L,5L,2L,1L,3L,3L,5L,1L,2L,8L,1L,8L,4L,6L,4L,6L,2L,0L,2L,7L,7L,9L,2L,1L,3L,5L,1L,2L,7L,9L,7L,6L,4L,7L,0L,2L,6L,0L,4L,4L,2L,0L,2L,0L,6L,6L,5L,7L,3L,8L,3L,8L,1L,0L,4L,7L,8L,8L,8L,8L,1L,4L,9L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239049Inst : IEnumerable<long>
{
public static readonly long[] Value=A239049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239049.Bytes);
public long this[int i]=>Value[i];

public static A239049Inst Instance=new A239049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239050
{
public static readonly long[] Value={ 4L,12L,16L,28L,24L,48L,32L,60L,52L,72L,48L,112L,56L,96L,96L,124L,72L,156L,80L,168L,128L,144L,96L,240L,124L,168L,160L,224L,120L,288L,128L,252L,192L,216L,192L,364L,152L,240L,224L,360L,168L,384L,176L,336L,312L,288L,192L,496L,228L,372L,288L,392L,216L,480L,288L,480L,320L,360L,240L,672L,248L,384L,416L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239050Inst : IEnumerable<long>
{
public static readonly long[] Value=A239050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239050.Bytes);
public long this[int i]=>Value[i];

public static A239050Inst Instance=new A239050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239051
{
public static readonly long[] Value={ 1L,0L,10L,-10L,10L,0L,0L,10L,0L,-10L,10L,0L,10L,-10L,20L,-10L,0L,10L,-10L,0L,10L,0L,20L,-10L,0L,0L,0L,0L,10L,0L,0L,0L,10L,-20L,20L,10L,0L,10L,0L,-20L,0L,0L,20L,-10L,20L,-10L,0L,10L,-10L,10L,10L,0L,10L,-10L,0L,0L,0L,0L,0L,0L,10L,0L,20L,-10L,10L,-10L,0L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239051Inst : IEnumerable<long>
{
public static readonly long[] Value=A239051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239051.Bytes);
public long this[int i]=>Value[i];

public static A239051Inst Instance=new A239051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239052
{
public static readonly long[] Value={ 3L,12L,18L,24L,39L,36L,42L,72L,54L,60L,96L,72L,93L,120L,90L,96L,144L,144L,114L,168L,126L,132L,234L,144L,171L,216L,162L,216L,240L,180L,186L,312L,252L,204L,288L,216L,222L,372L,288L,240L,363L,252L,324L,360L,270L,336L,384L,360L,294L,468L,306L,312L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239052Inst : IEnumerable<long>
{
public static readonly long[] Value=A239052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239052.Bytes);
public long this[int i]=>Value[i];

public static A239052Inst Instance=new A239052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239053
{
public static readonly long[] Value={ 4L,8L,12L,24L,20L,24L,40L,32L,48L,56L,44L,48L,72L,72L,60L,104L,68L,72L,124L,80L,84L,120L,112L,120L,156L,104L,108L,152L,144L,144L,168L,128L,132L,240L,140L,168L,228L,152L,192L,216L,164L,168L,260L,248L,180L,248L,216L,192L,336L,200L,240L,312L,212L,264L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239053Inst : IEnumerable<long>
{
public static readonly long[] Value=A239053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239053.Bytes);
public long this[int i]=>Value[i];

public static A239053Inst Instance=new A239053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239054
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,25L,35L,55L,77L,125L,175L,275L,385L,625L,875L,1375L,1925L,3125L,4375L,6675L,9625L,15625L,21875L,34375L,48125L,78125L,109375L,171875L,240625L,390625L,546875L,859375L,1203125L,1953125L,2734375L,4296875L,6015625L,9765625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239054Inst : IEnumerable<long>
{
public static readonly long[] Value=A239054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239054.Bytes);
public long this[int i]=>Value[i];

public static A239054Inst Instance=new A239054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239055
{
public static readonly long[] Value={ 4L,10L,12L,15L,16L,18L,28L,39L,40L,52L,58L,63L,69L,72L,82L,87L,93L,100L,106L,120L,123L,126L,128L,138L,144L,186L,195L,212L,213L,214L,222L,225L,249L,263L,273L,274L,282L,286L,292L,294L,313L,321L,322L,339L,347L,375L,381L,386L,388L,400L,402L,426L,432L,436L,448L,454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239055Inst : IEnumerable<long>
{
public static readonly long[] Value=A239055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239055.Bytes);
public long this[int i]=>Value[i];

public static A239055Inst Instance=new A239055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239088
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,10L,12L,13L,14L,15L,16L,17L,18L,19L,22L,20L,21L,23L,24L,25L,26L,27L,28L,29L,33L,30L,31L,32L,34L,35L,36L,37L,38L,39L,44L,40L,41L,42L,43L,45L,46L,47L,38L,49L,55L,50L,51L,52L,53L,54L,56L,57L,58L,59L,66L,60L,61L,62L,63L,64L,65L,67L,68L,69L,77L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239088Inst : IEnumerable<long>
{
public static readonly long[] Value=A239088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239088.Bytes);
public long this[int i]=>Value[i];

public static A239088Inst Instance=new A239088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239089
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,19L,23L,24L,25L,26L,27L,28L,29L,34L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,56L,57L,58L,59L,67L,68L,69L,78L,79L,89L,90L,10L,11L,20L,21L,22L,30L,31L,32L,33L,40L,41L,42L,43L,44L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239089Inst : IEnumerable<long>
{
public static readonly long[] Value=A239089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239089.Bytes);
public long this[int i]=>Value[i];

public static A239089Inst Instance=new A239089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239090
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,111L,1111L,11111L,111111L,1111111L,11111111L,111111111L,1111111111L,11111111111L,111111111111L,1111111111111L,11111111111111L,111111111111111L,1111111111111111L,11111111111111111L,111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239090Inst : IEnumerable<long>
{
public static readonly long[] Value=A239090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239090.Bytes);
public long this[int i]=>Value[i];

public static A239090Inst Instance=new A239090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239091
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,12L,14L,17L,18L,21L,23L,26L,27L,31L,34L,38L,40L,44L,47L,51L,52L,56L,59L,63L,65L,69L,72L,76L,77L,82L,86L,91L,94L,99L,103L,108L,110L,115L,119L,124L,127L,132L,136L,141L,142L,147L,151L,156L,159L,164L,168L,173L,175L,180L,184L,189L,192L,197L,201L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239091Inst : IEnumerable<long>
{
public static readonly long[] Value=A239091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239091.Bytes);
public long this[int i]=>Value[i];

public static A239091Inst Instance=new A239091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239092
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239092Inst : IEnumerable<long>
{
public static readonly long[] Value=A239092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239092.Bytes);
public long this[int i]=>Value[i];

public static A239092Inst Instance=new A239092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239093
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,1L,6L,7L,1L,8L,13L,1L,10L,23L,24L,1L,12L,37L,44L,1L,14L,55L,80L,81L,1L,16L,77L,140L,149L,1L,18L,103L,232L,273L,274L,1L,20L,133L,364L,493L,504L,1L,22L,167L,544L,865L,926L,927L,1L,24L,205L,780L,1461L,1692L,1705L,1L,26L,247L,1080L,2369L,3050L,3135L,3136L,1L,28L,293L,1452L,3693L,5376L,5753L,5768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239093Inst : IEnumerable<long>
{
public static readonly long[] Value=A239093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239093.Bytes);
public long this[int i]=>Value[i];

public static A239093Inst Instance=new A239093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239094
{
public static readonly long[] Value={ 0L,0L,1L,130L,2446L,21146L,117971L,494732L,1695036L,4992492L,13072917L,31153342L,68720938L,142120342L,278268263L,519829688L,932250488L,1613106744L,2704301673L,4407716634L,7005003334L,10882290034L,16560665275L,24733398404L,36310956980L,52474986980L,74742532605L,105041888406L,145801597410L,200054234926L,271556748751L,364929262576L,485814390512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239094Inst : IEnumerable<long>
{
public static readonly long[] Value=A239094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239094.Bytes);
public long this[int i]=>Value[i];

public static A239094Inst Instance=new A239094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239095
{
public static readonly long[] Value={ 0L,0L,0L,8L,72L,360L,1312L,3888L,9936L,22704L,47520L,92664L,170456L,298584L,501696L,813280L,1277856L,1953504L,2914752L,4255848L,6094440L,8575688L,11876832L,16212240L,21838960L,29062800L,38244960L,49809240L,64249848L,82139832L,104140160L,131009472L,163614528L,202941376L,250107264L,306373320L,373158024L,452051496L,544830624L,653475056L,780184080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239095Inst : IEnumerable<long>
{
public static readonly long[] Value=A239095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239095.Bytes);
public long this[int i]=>Value[i];

public static A239095Inst Instance=new A239095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239096
{
public static readonly long[] Value={ 0L,0L,0L,16L,216L,1584L,8096L,32256L,106992L,308352L,795168L,1873872L,4098952L,8422128L,16406208L,30522752L,54556128L,94140288L,157458624L,256141584L,406401336L,630447664L,958234464L,1429591680L,2096803280L,3027697920L,4309325280L,6052297680L,8395883496L,11513946096L,15621829504L,20984299776L,27924659136L,36835158272L,48188840832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239096Inst : IEnumerable<long>
{
public static readonly long[] Value=A239096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239096.Bytes);
public long this[int i]=>Value[i];

public static A239096Inst Instance=new A239096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239097
{
public static readonly long[] Value={ 0L,5L,7L,9L,6L,5L,7L,5L,7L,8L,2L,9L,2L,0L,6L,2L,2L,4L,4L,0L,5L,3L,6L,0L,0L,1L,5L,6L,8L,7L,8L,8L,7L,0L,6L,8L,5L,1L,6L,6L,7L,0L,3L,9L,9L,2L,1L,0L,1L,6L,5L,8L,2L,7L,6L,5L,7L,4L,5L,6L,3L,8L,7L,3L,0L,4L,2L,6L,2L,9L,4L,7L,5L,9L,6L,0L,1L,5L,0L,2L,2L,3L,3L,4L,4L,5L,8L,1L,3L,1L,8L,5L,2L,3L,3L,5L,9L,6L,9L,0L,1L,3L,6L,8L,5L,0L,1L,6L,8L,8L,5L,3L,8L,1L,8L,0L,1L,6L,2L,6L,3L,6L,2L,5L,0L,8L,1L,1L,0L,6L,3L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239097Inst : IEnumerable<long>
{
public static readonly long[] Value=A239097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239097.Bytes);
public long this[int i]=>Value[i];

public static A239097Inst Instance=new A239097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239098
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,2L,10L,15L,0L,6L,40L,105L,105L,0L,24L,196L,700L,1260L,945L,0L,120L,1148L,5068L,12600L,17325L,10395L,0L,720L,7848L,40740L,126280L,242550L,270270L,135135L,0L,5040L,61416L,363660L,1332100L,3213210L,5045040L,4729725L,2027025L,0L,40320L,541728L,3584856L,15020720L,43022980L,85345260L,113513400L,91891800L,34459425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239098Inst : IEnumerable<long>
{
public static readonly long[] Value=A239098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239098.Bytes);
public long this[int i]=>Value[i];

public static A239098Inst Instance=new A239098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239099
{
public static readonly long[] Value={ 1L,1L,21L,671L,180323L,20898423L,7426362705L,1874409465055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239099Inst : IEnumerable<long>
{
public static readonly long[] Value=A239099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239099.Bytes);
public long this[int i]=>Value[i];

public static A239099Inst Instance=new A239099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239100
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,6L,8L,10L,13L,17L,22L,28L,37L,47L,59L,75L,96L,120L,153L,194L,242L,309L,391L,487L,619L,784L,976L,1241L,1570L,1954L,2485L,3143L,3911L,4971L,6288L,7824L,9945L,12578L,15650L,19893L,25159L,31303L,39787L,50320L,62608L,79577L,100642L,125218L,159157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239100Inst : IEnumerable<long>
{
public static readonly long[] Value=A239100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239100.Bytes);
public long this[int i]=>Value[i];

public static A239100Inst Instance=new A239100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239101
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,10L,5L,2L,1L,26L,13L,6L,2L,1L,70L,35L,16L,7L,2L,1L,192L,96L,45L,19L,8L,2L,1L,534L,267L,126L,56L,22L,9L,2L,1L,1500L,750L,357L,160L,68L,25L,10L,2L,1L,4246L,2123L,1016L,463L,198L,81L,28L,11L,2L,1L,12092L,6046L,2907L,1337L,586L,240L,95L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239101Inst : IEnumerable<long>
{
public static readonly long[] Value=A239101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239101.Bytes);
public long this[int i]=>Value[i];

public static A239101Inst Instance=new A239101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239102
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,20L,10L,4L,1L,66L,35L,15L,5L,1L,222L,121L,56L,21L,6L,1L,756L,420L,204L,84L,28L,7L,1L,2598L,1464L,736L,323L,120L,36L,8L,1L,8994L,5122L,2643L,1215L,487L,165L,45L,9L,1L,31322L,17983L,9468L,4510L,1912L,706L,220L,55L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239102Inst : IEnumerable<long>
{
public static readonly long[] Value=A239102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239102.Bytes);
public long this[int i]=>Value[i];

public static A239102Inst Instance=new A239102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239103
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,20L,10L,4L,1L,70L,35L,15L,5L,1L,248L,123L,54L,20L,6L,1L,894L,442L,198L,78L,26L,7L,1L,3264L,1611L,732L,300L,108L,33L,8L,1L,12036L,5936L,2727L,1150L,437L,146L,41L,9L,1L,44722L,22047L,10214L,4398L,1736L,617L,192L,50L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239103Inst : IEnumerable<long>
{
public static readonly long[] Value=A239103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239103.Bytes);
public long this[int i]=>Value[i];

public static A239103Inst Instance=new A239103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239184
{
public static readonly BigInteger[] Value={ 720L,196698L,26726740L,3901908720L,652274371446L,108383467365104L,17806026561159264L,2921245671064879068L,BigInteger.Parse("479740247531890299338"),BigInteger.Parse("78803065045379232569310"),BigInteger.Parse("12943940087672133212368806") };
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
public class A239184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239184Inst Instance=new A239184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239185
{
public static readonly BigInteger[] Value={ 1968L,1321986L,381984614L,119751372066L,44086966064930L,16126266923705212L,5817146886160257060L,BigInteger.Parse("2095254565928697307720"),BigInteger.Parse("755629982088203538445028"),BigInteger.Parse("272567770522954354280836610") };
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
public class A239185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239185Inst Instance=new A239185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239186
{
public static readonly long[] Value={ 2L,23L,93L,243L,492L,878L,1432L,2165L,3123L,4337L,5810L,7596L,9726L,12195L,15065L,18367L,22088L,26298L,31028L,36257L,42063L,48477L,55470L,63128L,71482L,80495L,90261L,100811L,112100L,124230L,137232L,151053L,165803L,181513L,198122L,215748L,234422L,254075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239186Inst : IEnumerable<long>
{
public static readonly long[] Value=A239186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239186.Bytes);
public long this[int i]=>Value[i];

public static A239186Inst Instance=new A239186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239187
{
public static readonly BigInteger[] Value={ 4L,120L,43648L,151351888L,5513429365240L,2035912702049716008L,BigInteger.Parse("7729009194864231554969192"),BigInteger.Parse("300075821246252998677257219449376") };
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
public class A239187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239187Inst Instance=new A239187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239188
{
public static readonly long[] Value={ 12L,120L,1276L,13128L,136684L,1416192L,14700364L,152485288L,1582134540L,16414034784L,170295680876L,1766793480968L,18330328103340L,190175177307584L,1973048416742796L,20470174034391656L,212375968504319052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239188Inst : IEnumerable<long>
{
public static readonly long[] Value=A239188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239188.Bytes);
public long this[int i]=>Value[i];

public static A239188Inst Instance=new A239188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239189
{
public static readonly BigInteger[] Value={ 40L,1276L,43648L,1436268L,47885992L,1588084496L,52771184780L,1752250223616L,58199143332448L,1932821596727928L,64192434819147292L,2131913717519150940L,BigInteger.Parse("70803992837719272728"),BigInteger.Parse("2351500085296140060216"),BigInteger.Parse("78096680530619644287320") };
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
public class A239189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239189Inst Instance=new A239189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239190
{
public static readonly BigInteger[] Value={ 128L,13128L,1436268L,151351888L,16147220164L,1713928533440L,182266933113924L,19369216287602148L,2058887399348279616L,BigInteger.Parse("218831382902751331440"),BigInteger.Parse("23259633451329349789236"),BigInteger.Parse("2472236789989482004181296") };
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
public class A239190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239190Inst Instance=new A239190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239191
{
public static readonly BigInteger[] Value={ 416L,136684L,47885992L,16147220164L,5513429365240L,1872818978720764L,637384123700005952L,BigInteger.Parse("216766214761274933980"),BigInteger.Parse("73739429314877219107168"),BigInteger.Parse("25082099946912055190524704"),BigInteger.Parse("8531874448158275888123451964") };
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
public class A239191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239191Inst Instance=new A239191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239192
{
public static readonly BigInteger[] Value={ 1344L,1416192L,1588084496L,1713928533440L,1872818978720764L,2035912702049716008L,BigInteger.Parse("2217423860160887904628"),BigInteger.Parse("2413375270129365459725544"),BigInteger.Parse("2627351569419044081035020396"),BigInteger.Parse("2860010938553142543075978614852") };
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
public class A239192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239192Inst Instance=new A239192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239193
{
public static readonly BigInteger[] Value={ 4352L,14700364L,52771184780L,182266933113924L,637384123700005952L,BigInteger.Parse("2217423860160887904628"),BigInteger.Parse("7729009194864231554969192"),BigInteger.Parse("26920608271552147526807393264"),BigInteger.Parse("93791464815062866314841873907296") };
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
public class A239193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239193Inst Instance=new A239193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239194
{
public static readonly long[] Value={ 4L,12L,12L,40L,120L,40L,128L,1276L,1276L,128L,416L,13128L,43648L,13128L,416L,1344L,136684L,1436268L,1436268L,136684L,1344L,4352L,1416192L,47885992L,151351888L,47885992L,1416192L,4352L,14080L,14700364L,1588084496L,16147220164L,16147220164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239194Inst : IEnumerable<long>
{
public static readonly long[] Value=A239194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239194.Bytes);
public long this[int i]=>Value[i];

public static A239194Inst Instance=new A239194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239195
{
public static readonly long[] Value={ 1L,5L,17L,42L,78L,134L,215L,315L,447L,616L,812L,1052L,1341L,1665L,2045L,2486L,2970L,3522L,4147L,4823L,5579L,6420L,7320L,8312L,9401L,10557L,11817L,13186L,14630L,16190L,17871L,19635L,21527L,23552L,25668L,27924L,30325L,32825L,35477L,38286L,41202L,44282L,47531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239195Inst : IEnumerable<long>
{
public static readonly long[] Value=A239195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239195.Bytes);
public long this[int i]=>Value[i];

public static A239195Inst Instance=new A239195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239196
{
public static readonly long[] Value={ 1L,2L,13L,37L,107L,113L,137L,1013L,1037L,1079L,1136L,1139L,1237L,1337L,1379L,10013L,10039L,10079L,10133L,10136L,10139L,10379L,12379L,13679L,100136L,100139L,100379L,101237L,102347L,102379L,103679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239196Inst : IEnumerable<long>
{
public static readonly long[] Value=A239196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239196.Bytes);
public long this[int i]=>Value[i];

public static A239196Inst Instance=new A239196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239197
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,9L,11L,17L,19L,21L,23L,25L,26L,29L,31L,32L,33L,44L,48L,52L,66L,89L,96L,106L,117L,164L,211L,236L,248L,311L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239197Inst : IEnumerable<long>
{
public static readonly long[] Value=A239197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239197.Bytes);
public long this[int i]=>Value[i];

public static A239197Inst Instance=new A239197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239198
{
public static readonly long[] Value={ 1L,3L,13L,67L,377L,2235L,13701L,85947L,548209L,3540851L,23093885L,151793203L,1004023273L,6675725867L,44581355765L,298829626795L,2009477057761L,13550281076451L,91594501130989L,620471833255971L,4211165312423001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239198Inst : IEnumerable<long>
{
public static readonly long[] Value=A239198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239198.Bytes);
public long this[int i]=>Value[i];

public static A239198Inst Instance=new A239198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239199
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239199Inst : IEnumerable<long>
{
public static readonly long[] Value=A239199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239199.Bytes);
public long this[int i]=>Value[i];

public static A239199Inst Instance=new A239199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239264
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,5L,5L,1L,1L,1L,0L,11L,0L,11L,0L,1L,1L,1L,21L,43L,43L,21L,1L,1L,1L,0L,43L,0L,280L,0L,43L,0L,1L,1L,1L,85L,451L,1563L,1563L,451L,85L,1L,1L,1L,0L,171L,0L,9415L,0L,9415L,0L,171L,0L,1L,1L,1L,341L,4945L,55553L,162409L,162409L,55553L,4945L,341L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239264Inst : IEnumerable<long>
{
public static readonly long[] Value=A239264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239264.Bytes);
public long this[int i]=>Value[i];

public static A239264Inst Instance=new A239264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239265
{
public static readonly BigInteger[] Value={ 1L,5L,43L,451L,4945L,54685L,605707L,6710971L,74358721L,823915861L,9129240139L,101154812563L,1120826772817L,12419109262381L,137607593744107L,1524734943844939L,16894537473570817L,187196730554444581L,2074198005431257579L,BigInteger.Parse("22982759116542299875") };
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
public class A239265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239265Inst Instance=new A239265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239266
{
public static readonly long[] Value={ 1L,1L,11L,43L,280L,1563L,9415L,55553L,331133L,1968400L,11716601L,69716257L,414898579L,2469046811L,14693544104L,87442204835L,520375602855L,3096794588441L,18429266069421L,109673987617376L,652678415082545L,3884139865306433L,23114817718082715L,137558073518189643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239266Inst : IEnumerable<long>
{
public static readonly long[] Value=A239266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239266.Bytes);
public long this[int i]=>Value[i];

public static A239266Inst Instance=new A239266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239267
{
public static readonly BigInteger[] Value={ 1L,21L,1563L,162409L,17508475L,1894621633L,205109410835L,22206188455913L,2404176415007051L,260291084969169553L,BigInteger.Parse("28180738494571199683"),BigInteger.Parse("3051022897700513626745"),BigInteger.Parse("330322812747235906893563"),BigInteger.Parse("35762812820215620676404385"),BigInteger.Parse("3871905699058282397207463923") };
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
public class A239267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239267Inst Instance=new A239267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239268
{
public static readonly BigInteger[] Value={ 1L,1L,43L,451L,9415L,162409L,3037561L,55263473L,1017093992L,18633949879L,342050825969L,6273663002379L,115107979930355L,2111655465575629L,38740910476086035L,710728644139932355L,13038974254406437397UL,BigInteger.Parse("239210680096992061776"),BigInteger.Parse("4388527184214799104521") };
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
public class A239268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239268Inst Instance=new A239268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239269
{
public static readonly BigInteger[] Value={ 1L,85L,55553L,55263473L,57228320561L,59567383578529L,62052716855623473L,BigInteger.Parse("64650946142760951261"),BigInteger.Parse("67359700036979921768537"),BigInteger.Parse("70182277765258094462607893"),BigInteger.Parse("73123194329034252403047192825"),BigInteger.Parse("76187359457974079841046201710145"),BigInteger.Parse("79379928242473326520049884806574585") };
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
public class A239269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239269Inst Instance=new A239269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239270
{
public static readonly BigInteger[] Value={ 1L,1L,171L,4945L,331133L,17508475L,1017093992L,57228320561L,3263262629905L,185175369431551L,10529540995776143L,598275977865042347L,BigInteger.Parse("34004634498887815603"),BigInteger.Parse("1932504421503220832048"),BigInteger.Parse("109831420296006021851427"),BigInteger.Parse("6242000703148139096486777"),BigInteger.Parse("354752087455830720672222391") };
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
public class A239270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239270Inst Instance=new A239270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239271
{
public static readonly BigInteger[] Value={ 1L,341L,1968400L,18633949879L,185175369431551L,1851260737169108297L,BigInteger.Parse("18523901518471987018869"),BigInteger.Parse("185376808904045560177646408"),BigInteger.Parse("1855186116430353424133583769247"),BigInteger.Parse("18566115077411836147307357343137943"),BigInteger.Parse("185803902034786238482393324889706764945") };
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
public class A239271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239271Inst Instance=new A239271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239272
{
public static readonly BigInteger[] Value={ 1L,1L,683L,54685L,11716601L,1894621633L,342050825969L,59567383578529L,10529540995776143L,1851260737169108297L,BigInteger.Parse("326207195516663381931"),BigInteger.Parse("57432330223655165724245"),BigInteger.Parse("10115159197829895564709879"),BigInteger.Parse("1781269009331896694492341991"),BigInteger.Parse("313697981363828055088298550945") };
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
public class A239272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239272Inst Instance=new A239272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239273
{
public static readonly BigInteger[] Value={ 1L,3L,280L,3037561L,3263262629905L,BigInteger.Parse("326207195516663381931"),BigInteger.Parse("3011882198082438957330143630563"),BigInteger.Parse("2565014347691062208319404612723752103028288"),BigInteger.Parse("201442620359313683494245316355883565275531844406384955392") };
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
public class A239273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239273Inst Instance=new A239273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239274
{
public static readonly long[] Value={ 1L,88L,1104L,492624L,30818736L,200827760L,1598249556L,4575586644L,8491046375L,8554970196L,29917317500L,54481242640L,202195886375L,3201891498000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239274Inst : IEnumerable<long>
{
public static readonly long[] Value=A239274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239274.Bytes);
public long this[int i]=>Value[i];

public static A239274Inst Instance=new A239274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239275
{
public static readonly BigInteger[] Value={ 1L,1L,2L,0L,-8L,0L,32L,0L,-128L,0L,2560L,0L,-1415168L,0L,57344L,0L,-118521856L,0L,5749735424L,0L,-91546451968L,0L,1792043646976L,0L,-1982765704675328L,0L,286994513002496L,0L,-3187598700536922112L,0L,BigInteger.Parse("4625594563496048066560"),0L,BigInteger.Parse("-16555640873195841519616"),0L,BigInteger.Parse("22142170101965089931264"),0L };
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
public class A239275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239275Inst Instance=new A239275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239276
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,5L,7L,9L,13L,13L,22L,22L,25L,25L,37L,37L,51L,51L,57L,67L,73L,73L,92L,92L,100L,113L,121L,121L,145L,145L,172L,183L,211L,211L,211L,243L,256L,281L,289L,289L,326L,331L,346L,369L,385L,385L,426L,426L,443L,469L,487L,487L,533L,533L,581L,581L,601L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239276Inst : IEnumerable<long>
{
public static readonly long[] Value=A239276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239276.Bytes);
public long this[int i]=>Value[i];

public static A239276Inst Instance=new A239276Inst();

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