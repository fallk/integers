using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A248882
{
public static readonly long[] Value={ 1L,1L,8L,35L,119L,433L,1476L,4962L,16128L,51367L,160105L,490219L,1476420L,4378430L,12805008L,36962779L,105417214L,297265597L,829429279L,2291305897L,6270497702L,17008094490L,45744921052L,122052000601L,323166712109L,849453194355L,2217289285055L,5749149331789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248882Inst : IEnumerable<long>
{
public static readonly long[] Value=A248882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248882.Bytes);
public long this[int i]=>Value[i];

public static A248882Inst Instance=new A248882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248883
{
public static readonly long[] Value={ 1L,1L,16L,97L,457L,2297L,11113L,52049L,235334L,1039886L,4497930L,19074006L,79418883L,325184763L,1311252535L,5212704708L,20449320159L,79231806015L,303428397505L,1149325838320L,4308477305997L,15993198330782L,58815616643170L,214383601754107L,774837953045873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248883Inst : IEnumerable<long>
{
public static readonly long[] Value=A248883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248883.Bytes);
public long this[int i]=>Value[i];

public static A248883Inst Instance=new A248883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248884
{
public static readonly long[] Value={ 1L,1L,32L,275L,1763L,12421L,85808L,561074L,3535678L,21815897L,131733641L,778099521L,4505634324L,25635135074L,143507764032L,791243636305L,4300983535471L,23070300486656L,122213931799869L,639848848696540L,3312824859756453L,16972058378914997L,86082216143323410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248884Inst : IEnumerable<long>
{
public static readonly long[] Value=A248884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248884.Bytes);
public long this[int i]=>Value[i];

public static A248884Inst Instance=new A248884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248885
{
public static readonly long[] Value={ 3L,0L,9L,9L,9L,9L,9L,8L,2L,1L,9L,5L,8L,2L,3L,9L,8L,5L,1L,2L,4L,4L,5L,4L,8L,1L,1L,8L,9L,4L,9L,4L,2L,7L,3L,2L,9L,9L,0L,8L,9L,2L,8L,8L,3L,0L,3L,0L,0L,2L,7L,1L,6L,7L,5L,8L,8L,9L,5L,5L,8L,6L,2L,3L,9L,7L,7L,8L,8L,3L,6L,5L,6L,2L,7L,0L,9L,5L,9L,1L,8L,9L,7L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248885Inst : IEnumerable<long>
{
public static readonly long[] Value=A248885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248885.Bytes);
public long this[int i]=>Value[i];

public static A248885Inst Instance=new A248885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248886
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,3L,-2L,2L,0L,2L,-2L,1L,-4L,0L,-2L,3L,-2L,2L,0L,4L,-2L,2L,0L,0L,-2L,1L,-4L,2L,-2L,2L,-2L,3L,-2L,0L,-2L,2L,-2L,2L,0L,2L,-4L,4L,0L,0L,0L,1L,-2L,4L,0L,2L,-4L,2L,-2L,1L,-6L,0L,-2L,2L,0L,0L,-2L,4L,-2L,0L,-2L,2L,0L,4L,0L,4L,-2L,1L,-2L,0L,-2L,4L,0L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248886Inst : IEnumerable<long>
{
public static readonly long[] Value=A248886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248886.Bytes);
public long this[int i]=>Value[i];

public static A248886Inst Instance=new A248886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248887
{
public static readonly long[] Value={ 677L,6635777L,28132417L,156400037L,234518597L,381655297L,386751557L,403849217L,820020497L,1215498497L,1298449157L,1539463697L,1580539537L,1839037457L,2072616677L,2774550277L,2969814017L,6147500837L,6194319617L,6703351877L,6937890437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248887Inst : IEnumerable<long>
{
public static readonly long[] Value=A248887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248887.Bytes);
public long this[int i]=>Value[i];

public static A248887Inst Instance=new A248887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248888
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,24L,28L,30L,36L,40L,42L,48L,60L,72L,84L,90L,96L,120L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248888Inst : IEnumerable<long>
{
public static readonly long[] Value=A248888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248888.Bytes);
public long this[int i]=>Value[i];

public static A248888Inst Instance=new A248888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248889
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,171L,323L,343L,505L,595L,686L,848L,1661L,2112L,3773L,23332L,46664L,69996L,262262L,583385L,782287L,859958L,981189L,1254521L,1403041L,1832381L,39388393L,54411445L,55499455L,88844888L,118919811L,191010191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248889Inst : IEnumerable<long>
{
public static readonly long[] Value=A248889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248889.Bytes);
public long this[int i]=>Value[i];

public static A248889Inst Instance=new A248889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248890
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,8L,16L,34L,75L,166L,374L,849L,1952L,4522L,10566L,24840L,58760L,139693L,333702L,800412L,1927207L,4655997L,11283835L,27423930L,66825194L,163227234L,399587270L,980222058L,2409181633L,5931839530L,14629639579L,36137308192L,89395224033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248890Inst : IEnumerable<long>
{
public static readonly long[] Value=A248890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248890.Bytes);
public long this[int i]=>Value[i];

public static A248890Inst Instance=new A248890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248891
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,4L,3L,4L,4L,3L,4L,3L,3L,2L,1L,2L,3L,2L,2L,5L,4L,3L,2L,1L,1L,4L,3L,2L,3L,4L,6L,5L,4L,3L,4L,5L,6L,7L,6L,5L,4L,5L,5L,5L,4L,5L,4L,5L,5L,5L,6L,9L,8L,8L,7L,7L,7L,8L,7L,6L,6L,5L,4L,3L,3L,3L,2L,7L,6L,5L,5L,5L,4L,3L,2L,5L,5L,8L,9L,11L,10L,10L,9L,9L,8L,7L,7L,6L,6L,6L,5L,4L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248891Inst : IEnumerable<long>
{
public static readonly long[] Value=A248891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248891.Bytes);
public long this[int i]=>Value[i];

public static A248891Inst Instance=new A248891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248892
{
public static readonly long[] Value={ 1565891838737L,1985917919077L,2060476510097L,5590084720897L,39623323626437L,94860314619877L,114027286862737L,115071875848337L,117140013119377L,136739205150917L,246382184192357L,254109295929637L,265883157493777L,340055949647237L,378534223873937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248892Inst : IEnumerable<long>
{
public static readonly long[] Value=A248892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248892.Bytes);
public long this[int i]=>Value[i];

public static A248892Inst Instance=new A248892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248893
{
public static readonly long[] Value={ 0L,2L,4L,5L,8L,9L,10L,12L,16L,17L,18L,20L,22L,24L,28L,32L,33L,34L,35L,38L,40L,44L,48L,49L,52L,56L,58L,64L,65L,66L,67L,68L,72L,73L,76L,80L,81L,84L,88L,92L,96L,97L,100L,104L,106L,112L,113L,118L,124L,128L,129L,130L,131L,134L,136L,140L,144L,145L,148L,152L,154L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248893Inst : IEnumerable<long>
{
public static readonly long[] Value=A248893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248893.Bytes);
public long this[int i]=>Value[i];

public static A248893Inst Instance=new A248893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248894
{
public static readonly long[] Value={ 17L,69L,70L,241L,405L,2606L,3339L,4116L,7116L,15148L,15149L,20162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248894Inst : IEnumerable<long>
{
public static readonly long[] Value=A248894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248894.Bytes);
public long this[int i]=>Value[i];

public static A248894Inst Instance=new A248894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248895
{
public static readonly long[] Value={ 0L,3L,7L,3L,6L,2L,2L,9L,3L,6L,9L,8L,9L,3L,6L,3L,1L,4L,7L,4L,2L,1L,3L,3L,2L,3L,4L,3L,8L,0L,8L,0L,5L,4L,1L,5L,5L,3L,2L,1L,7L,0L,3L,4L,0L,2L,8L,5L,5L,8L,7L,9L,3L,9L,3L,8L,6L,8L,7L,4L,2L,4L,7L,9L,8L,9L,6L,8L,5L,3L,9L,8L,9L,4L,9L,0L,9L,9L,7L,5L,4L,2L,3L,4L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248895Inst : IEnumerable<long>
{
public static readonly long[] Value=A248895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248895.Bytes);
public long this[int i]=>Value[i];

public static A248895Inst Instance=new A248895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248896
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,6L,1L,7L,5L,8L,6L,8L,0L,7L,7L,0L,7L,7L,8L,6L,6L,5L,0L,3L,9L,8L,7L,8L,7L,1L,0L,8L,0L,2L,6L,7L,3L,2L,9L,6L,0L,7L,5L,1L,0L,2L,7L,3L,3L,1L,9L,1L,9L,3L,3L,3L,8L,3L,7L,0L,2L,3L,5L,2L,5L,5L,9L,5L,3L,3L,8L,5L,5L,8L,5L,1L,6L,0L,6L,1L,6L,5L,1L,0L,6L,4L,4L,6L,2L,1L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248896Inst : IEnumerable<long>
{
public static readonly long[] Value=A248896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248896.Bytes);
public long this[int i]=>Value[i];

public static A248896Inst Instance=new A248896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248897
{
public static readonly long[] Value={ 1L,2L,0L,9L,1L,9L,9L,5L,7L,6L,1L,5L,6L,1L,4L,5L,2L,3L,3L,7L,2L,9L,3L,8L,5L,5L,0L,5L,0L,9L,4L,7L,7L,0L,4L,8L,8L,1L,8L,9L,3L,7L,7L,4L,9L,8L,7L,2L,8L,4L,9L,3L,7L,1L,7L,0L,4L,6L,5L,8L,9L,9L,5L,6L,9L,2L,5L,4L,1L,5L,4L,5L,4L,0L,8L,4L,2L,3L,5L,9L,2L,2L,4L,5L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248897Inst : IEnumerable<long>
{
public static readonly long[] Value=A248897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248897.Bytes);
public long this[int i]=>Value[i];

public static A248897Inst Instance=new A248897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248898
{
public static readonly long[] Value={ 0L,2L,4L,6L,9L,11L,13L,15L,17L,19L,23L,25L,27L,29L,32L,34L,36L,38L,40L,42L,46L,48L,50L,52L,55L,59L,61L,63L,65L,69L,71L,73L,75L,77L,79L,82L,84L,86L,88L,90L,92L,96L,98L,100L,102L,105L,107L,109L,111L,113L,115L,119L,121L,123L,125L,128L,132L,134L,136L,138L,142L,144L,146L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248898Inst : IEnumerable<long>
{
public static readonly long[] Value=A248898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248898.Bytes);
public long this[int i]=>Value[i];

public static A248898Inst Instance=new A248898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248899
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,666L,838L,1771L,432234L,864468L,1551551L,1897981L,2211122L,155292551L,330050033L,453848354L,467535764L,650767056L,666909666L,857383758L,863828368L,47069796074L,62558085526L,67269596276L,87161116178L,96060106069L,121791197121L,127673376721L,139103301931L,234595595432L,246025520642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248899Inst : IEnumerable<long>
{
public static readonly long[] Value=A248899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248899.Bytes);
public long this[int i]=>Value[i];

public static A248899Inst Instance=new A248899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248900
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,102L,492L,2492L,13003L,69172L,372963L,2031174L,11148948L,61588814L,342068774L,1908740089L,10694374242L,60137305751L,339276548456L,1919787554118L,10892575241125L,61957028188350L,353224194632459L,2018076850631391L,11552829351121139L,66259093178740462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248900Inst : IEnumerable<long>
{
public static readonly long[] Value=A248900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248900.Bytes);
public long this[int i]=>Value[i];

public static A248900Inst Instance=new A248900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248901
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,20L,29L,30L,2059L,5987L,7119L,20165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248901Inst : IEnumerable<long>
{
public static readonly long[] Value=A248901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248901.Bytes);
public long this[int i]=>Value[i];

public static A248901Inst Instance=new A248901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248902
{
public static readonly long[] Value={ 6L,7L,8L,10L,19L,21L,23L,24L,28L,33L,72L,80L,270L,271L,323L,404L,2058L,4118L,5986L,7118L,13387L,16041L,20164L,30024L,30025L,76955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248902Inst : IEnumerable<long>
{
public static readonly long[] Value=A248902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248902.Bytes);
public long this[int i]=>Value[i];

public static A248902Inst Instance=new A248902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248903
{
public static readonly long[] Value={ 9L,12L,15L,17L,18L,22L,27L,32L,34L,39L,69L,70L,71L,79L,128L,143L,172L,226L,241L,242L,248L,269L,322L,325L,403L,405L,406L,420L,745L,2057L,2272L,2606L,2607L,3339L,3340L,3562L,4116L,4117L,4446L,5985L,6834L,7116L,7117L,7490L,7669L,13386L,13388L,15148L,15149L,15150L,16040L,20162L,20163L,28990L,29043L,30023L,31745L,52880L,57447L,76954L,81990L,92560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248903Inst : IEnumerable<long>
{
public static readonly long[] Value=A248903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248903.Bytes);
public long this[int i]=>Value[i];

public static A248903Inst Instance=new A248903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248904
{
public static readonly long[] Value={ 31L,51L,53L,62L,95L,97L,209L,318L,429L,443L,553L,886L,887L,2165L,2217L,4387L,4439L,5498L,5553L,6714L,7775L,8932L,10548L,56105L,56107L,78292L,78320L,78324L,78328L,88887L,89439L,99998L,110747L,111083L,221861L,332969L,438885L,667023L,667025L,671853L,888880L,1107504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248904Inst : IEnumerable<long>
{
public static readonly long[] Value=A248904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248904.Bytes);
public long this[int i]=>Value[i];

public static A248904Inst Instance=new A248904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248905
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,5L,1L,30L,192L,15L,1L,1247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248905Inst : IEnumerable<long>
{
public static readonly long[] Value=A248905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248905.Bytes);
public long this[int i]=>Value[i];

public static A248905Inst Instance=new A248905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248906
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,3L,16L,37L,66L,9L,128L,7L,256L,17L,10L,549L,1024L,67L,2048L,13L,18L,129L,4096L,39L,8200L,257L,16450L,21L,32768L,11L,65536L,131621L,130L,1025L,24L,71L,262144L,2049L,258L,45L,524288L,19L,1048576L,133L,74L,4097L,2097152L,551L,4194320L,8201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248906Inst : IEnumerable<long>
{
public static readonly long[] Value=A248906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248906.Bytes);
public long this[int i]=>Value[i];

public static A248906Inst Instance=new A248906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248907
{
public static readonly long[] Value={ 2L,3L,22L,23L,32L,222L,33L,322L,223L,232L,323L,332L,2222L,3222L,233L,333L,2322L,3322L,2223L,3223L,2232L,3232L,2323L,3323L,2332L,3332L,22222L,32222L,23222L,33222L,2233L,3233L,2333L,3333L,22322L,32322L,23322L,33322L,22223L,32223L,23223L,33223L,22232L,32232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248907Inst : IEnumerable<long>
{
public static readonly long[] Value=A248907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248907.Bytes);
public long this[int i]=>Value[i];

public static A248907Inst Instance=new A248907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248908
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,7L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248908Inst : IEnumerable<long>
{
public static readonly long[] Value=A248908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248908.Bytes);
public long this[int i]=>Value[i];

public static A248908Inst Instance=new A248908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248909
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,13L,7L,1L,1L,1L,1L,19L,1L,7L,1L,1L,1L,1L,13L,1L,7L,1L,1L,31L,1L,1L,1L,7L,1L,37L,19L,13L,1L,1L,7L,43L,1L,1L,1L,1L,1L,49L,1L,1L,13L,1L,1L,1L,7L,19L,1L,1L,1L,61L,31L,7L,1L,13L,1L,67L,1L,1L,7L,1L,1L,73L,37L,1L,19L,7L,13L,79L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248909Inst : IEnumerable<long>
{
public static readonly long[] Value=A248909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248909.Bytes);
public long this[int i]=>Value[i];

public static A248909Inst Instance=new A248909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248910
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248910Inst : IEnumerable<long>
{
public static readonly long[] Value=A248910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248910.Bytes);
public long this[int i]=>Value[i];

public static A248910Inst Instance=new A248910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248911
{
public static readonly long[] Value={ 2L,0L,0L,0L,1L,0L,1L,0L,1L,3L,2L,4L,5L,3L,3L,5L,8L,6L,8L,8L,6L,7L,7L,9L,13L,13L,10L,10L,7L,7L,17L,16L,18L,15L,21L,18L,19L,21L,20L,21L,23L,20L,25L,22L,21L,19L,26L,33L,32L,29L,28L,29L,26L,31L,32L,33L,34L,31L,32L,31L,28L,32L,41L,40L,37L,36L,45L,45L,50L,47L,46L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248911Inst : IEnumerable<long>
{
public static readonly long[] Value=A248911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248911.Bytes);
public long this[int i]=>Value[i];

public static A248911Inst Instance=new A248911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248912
{
public static readonly long[] Value={ 4L,3L,2L,3L,2L,3L,1L,2L,4L,2L,4L,4L,2L,2L,4L,6L,3L,5L,5L,2L,3L,3L,4L,7L,7L,4L,3L,0L,-1L,8L,7L,8L,5L,10L,7L,7L,8L,7L,8L,8L,5L,10L,6L,5L,1L,8L,14L,13L,9L,8L,8L,5L,9L,9L,10L,10L,6L,7L,5L,1L,5L,13L,12L,8L,6L,14L,14L,18L,14L,12L,12L,14L,14L,14L,12L,12L,14L,12L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248912Inst : IEnumerable<long>
{
public static readonly long[] Value=A248912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248912.Bytes);
public long this[int i]=>Value[i];

public static A248912Inst Instance=new A248912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248913
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,4L,2L,2L,2L,6L,2L,6L,4L,2L,2L,2L,2L,4L,6L,2L,6L,4L,2L,6L,2L,2L,2L,4L,2L,2L,4L,4L,2L,4L,2L,2L,2L,4L,4L,6L,4L,2L,4L,2L,2L,4L,4L,2L,6L,6L,2L,2L,6L,2L,2L,2L,2L,10L,2L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,4L,2L,2L,2L,2L,4L,2L,6L,4L,2L,4L,4L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248913Inst : IEnumerable<long>
{
public static readonly long[] Value=A248913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248913.Bytes);
public long this[int i]=>Value[i];

public static A248913Inst Instance=new A248913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248914
{
public static readonly long[] Value={ 1L,4L,0L,3L,8L,2L,1L,9L,6L,5L,1L,5L,5L,3L,5L,5L,1L,6L,5L,7L,3L,0L,3L,6L,3L,7L,3L,8L,8L,9L,9L,6L,1L,0L,2L,7L,7L,4L,8L,0L,0L,3L,5L,3L,2L,8L,3L,0L,6L,6L,5L,7L,0L,2L,2L,0L,7L,0L,0L,0L,4L,5L,5L,7L,2L,5L,8L,4L,8L,6L,4L,0L,8L,1L,3L,7L,8L,1L,3L,4L,8L,0L,0L,2L,3L,0L,0L,2L,9L,0L,8L,4L,7L,6L,6L,2L,7L,4L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248914Inst : IEnumerable<long>
{
public static readonly long[] Value=A248914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248914.Bytes);
public long this[int i]=>Value[i];

public static A248914Inst Instance=new A248914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248915
{
public static readonly long[] Value={ 378L,12467L,95823L,10715274L,13485829L,111495095L,42002916561L,176685987695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248915Inst : IEnumerable<long>
{
public static readonly long[] Value=A248915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248915.Bytes);
public long this[int i]=>Value[i];

public static A248915Inst Instance=new A248915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248916
{
public static readonly long[] Value={ 3L,5L,1L,3L,8L,3L,0L,7L,1L,9L,1L,2L,5L,1L,6L,1L,2L,0L,6L,2L,0L,7L,8L,3L,7L,0L,9L,3L,2L,3L,8L,8L,2L,3L,5L,8L,7L,1L,0L,9L,1L,3L,4L,2L,1L,1L,9L,5L,1L,2L,8L,4L,3L,6L,8L,1L,8L,2L,5L,4L,1L,8L,5L,2L,5L,3L,4L,9L,2L,1L,8L,6L,0L,8L,7L,7L,3L,5L,3L,0L,6L,2L,2L,4L,5L,1L,3L,9L,8L,4L,8L,8L,7L,6L,5L,9L,9L,9L,7L,5L,7L,3L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248916Inst : IEnumerable<long>
{
public static readonly long[] Value=A248916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248916.Bytes);
public long this[int i]=>Value[i];

public static A248916Inst Instance=new A248916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248917
{
public static readonly long[] Value={ 1L,3L,17L,73L,257L,801L,2305L,6273L,16385L,41473L,102401L,247809L,589825L,1384449L,3211265L,7372801L,16777217L,37879809L,84934657L,189267969L,419430401L,924844033L,2030043137L,4437573633L,9663676417L,20971520001L,45365592065L,97844723713L,210453397505L,451508436993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248917Inst : IEnumerable<long>
{
public static readonly long[] Value=A248917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248917.Bytes);
public long this[int i]=>Value[i];

public static A248917Inst Instance=new A248917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248918
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,9L,31L,10L,11L,12L,27L,28L,14L,16L,63L,17L,18L,19L,20L,32L,21L,22L,23L,127L,24L,25L,26L,29L,115L,30L,33L,34L,35L,36L,37L,38L,39L,40L,111L,41L,255L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,58L,59L,60L,61L,62L,64L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248918Inst : IEnumerable<long>
{
public static readonly long[] Value=A248918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248918.Bytes);
public long this[int i]=>Value[i];

public static A248918Inst Instance=new A248918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248919
{
public static readonly long[] Value={ 13L,131L,653L,883L,1279L,10739L,17669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248919Inst : IEnumerable<long>
{
public static readonly long[] Value=A248919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248919.Bytes);
public long this[int i]=>Value[i];

public static A248919Inst Instance=new A248919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248920
{
public static readonly long[] Value={ 5L,7L,13L,18L,19L,34L,35L,38L,43L,48L,188L,286L,450L,501L,759L,1446L,2021L,2419L,2997L,3715L,5677L,13566L,46303L,57174L,108844L,117145L,166683L,178863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248920Inst : IEnumerable<long>
{
public static readonly long[] Value=A248920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248920.Bytes);
public long this[int i]=>Value[i];

public static A248920Inst Instance=new A248920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248921
{
public static readonly BigInteger[] Value={ 5L,17L,977L,28697L,56417L,1428864769L,2809074173L,21344178433L,626815657409L,18407729752001L,BigInteger.Parse("2317881588988297338942875602391948125494800020122167809"),BigInteger.Parse("136507010958920295813169620935932629930648432530102206331972221346174230852977164801") };
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
public class A248921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248921Inst Instance=new A248921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248922
{
public static readonly long[] Value={ 1L,6L,5L,0L,7L,6L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248922Inst : IEnumerable<long>
{
public static readonly long[] Value=A248922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248922.Bytes);
public long this[int i]=>Value[i];

public static A248922Inst Instance=new A248922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248923
{
public static readonly long[] Value={ 1L,3L,5L,57L,99L,10L,30L,17L,28L,91L,398L,2638L,292L,1383L,69L,1055L,860L,679L,10782L,5440L,1630L,997L,640L,34L,186L,1248L,102L,2039L,1457L,95L,7621L,3980L,273L,4005L,1071L,889L,56L,6309L,4295L,211L,6423L,1004L,2689L,427L,542L,463L,2430L,4815L,223L,277L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248923Inst : IEnumerable<long>
{
public static readonly long[] Value=A248923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248923.Bytes);
public long this[int i]=>Value[i];

public static A248923Inst Instance=new A248923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248924
{
public static readonly long[] Value={ 2L,2L,1L,7L,3L,16L,12L,36L,39L,85L,113L,210L,310L,534L,829L,1379L,2191L,3588L,5760L,9368L,15107L,24497L,39581L,64102L,103658L,167786L,271417L,439231L,710619L,1149880L,1860468L,3010380L,4870815L,7881229L,12752009L,20633274L,33385246L,54018558L,87403765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248924Inst : IEnumerable<long>
{
public static readonly long[] Value=A248924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248924.Bytes);
public long this[int i]=>Value[i];

public static A248924Inst Instance=new A248924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248925
{
public static readonly long[] Value={ 1L,1L,0L,1L,-2L,1L,1L,-5L,7L,-2L,1L,-9L,27L,-30L,9L,1L,-14L,72L,-165L,159L,-44L,1L,-20L,156L,-597L,1149L,-998L,265L,1L,-27L,296L,-1689L,5328L,-9041L,7251L,-1854L,1L,-35L,512L,-4057L,18840L,-51665L,79579L,-59862L,14833L,1L,-44L,827L,-8665L,55353L,-221225L,544564L,-776073L,553591L,-133496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248925Inst : IEnumerable<long>
{
public static readonly long[] Value=A248925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248925.Bytes);
public long this[int i]=>Value[i];

public static A248925Inst Instance=new A248925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248926
{
public static readonly long[] Value={ 4L,5L,5L,6L,2L,9L,7L,0L,6L,2L,0L,3L,6L,3L,7L,9L,9L,2L,1L,7L,9L,5L,7L,5L,3L,5L,4L,0L,6L,6L,0L,0L,3L,7L,9L,5L,0L,3L,4L,2L,8L,5L,5L,3L,9L,2L,2L,6L,0L,8L,2L,0L,0L,4L,4L,7L,0L,0L,2L,9L,6L,8L,8L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248926Inst : IEnumerable<long>
{
public static readonly long[] Value=A248926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248926.Bytes);
public long this[int i]=>Value[i];

public static A248926Inst Instance=new A248926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248927
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,9L,1L,24L,72L,12L,16L,1L,120L,600L,300L,200L,50L,25L,1L,720L,5400L,5400L,2400L,450L,1800L,450L,60L,90L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248927Inst : IEnumerable<long>
{
public static readonly long[] Value=A248927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248927.Bytes);
public long this[int i]=>Value[i];

public static A248927Inst Instance=new A248927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248928
{
public static readonly long[] Value={ 4L,9L,16L,16L,25L,25L,36L,36L,36L,49L,49L,49L,64L,64L,64L,64L,81L,81L,81L,81L,100L,100L,100L,100L,100L,121L,121L,121L,121L,121L,144L,144L,144L,144L,144L,144L,169L,169L,169L,169L,169L,169L,196L,196L,196L,196L,196L,196L,196L,225L,225L,225L,225L,225L,225L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248928Inst : IEnumerable<long>
{
public static readonly long[] Value=A248928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248928.Bytes);
public long this[int i]=>Value[i];

public static A248928Inst Instance=new A248928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248929
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,12L,7L,4L,1L,81L,25L,11L,5L,1L,2646L,216L,46L,16L,6L,1L,1422564L,12784L,477L,77L,22L,7L,1L,229809982112L,11115851L,45104L,925L,120L,29L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248929Inst : IEnumerable<long>
{
public static readonly long[] Value=A248929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248929.Bytes);
public long this[int i]=>Value[i];

public static A248929Inst Instance=new A248929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248930
{
public static readonly long[] Value={ 1L,6L,4L,9L,3L,3L,7L,6L,8L,9L,0L,9L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248930Inst : IEnumerable<long>
{
public static readonly long[] Value=A248930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248930.Bytes);
public long this[int i]=>Value[i];

public static A248930Inst Instance=new A248930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248931
{
public static readonly long[] Value={ 1L,0L,4L,0L,7L,9L,3L,2L,1L,9L,4L,6L,6L,4L,3L,9L,9L,0L,8L,1L,9L,2L,5L,2L,4L,0L,3L,2L,7L,3L,6L,4L,0L,8L,5L,5L,3L,8L,6L,1L,5L,2L,6L,2L,2L,4L,7L,2L,6L,6L,7L,0L,4L,8L,0L,5L,3L,1L,9L,1L,1L,2L,3L,5L,0L,4L,0L,3L,6L,0L,8L,0L,5L,9L,6L,7L,3L,3L,6L,0L,2L,9L,8L,0L,1L,2L,2L,3L,9L,4L,4L,1L,7L,3L,2L,3L,2L,4L,1L,8L,4L,8L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248931Inst : IEnumerable<long>
{
public static readonly long[] Value=A248931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248931.Bytes);
public long this[int i]=>Value[i];

public static A248931Inst Instance=new A248931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248932
{
public static readonly long[] Value={ 1L,4L,7L,5L,9L,7L,9L,9L,1L,5L,2L,1L,4L,1L,8L,0L,2L,3L,5L,0L,8L,4L,8L,9L,8L,6L,2L,2L,7L,3L,7L,3L,8L,1L,7L,3L,6L,3L,1L,2L,0L,6L,6L,1L,4L,5L,3L,3L,3L,1L,6L,9L,7L,7L,5L,1L,4L,7L,7L,7L,1L,2L,1L,6L,4L,7L,8L,5L,7L,0L,2L,9L,7L,8L,7L,8L,0L,7L,8L,9L,4L,9L,3L,7L,7L,4L,0L,7L,3L,3L,7L,0L,4L,9L,3L,8L,9L,2L,8L,9L,3L,8L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248932Inst : IEnumerable<long>
{
public static readonly long[] Value=A248932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248932.Bytes);
public long this[int i]=>Value[i];

public static A248932Inst Instance=new A248932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248933
{
public static readonly long[] Value={ 4L,4L,6L,0L,8L,7L,5L,5L,7L,1L,8L,3L,7L,5L,8L,4L,2L,9L,5L,7L,1L,1L,5L,1L,7L,0L,6L,4L,0L,2L,1L,0L,1L,8L,0L,9L,8L,8L,6L,2L,0L,8L,6L,3L,2L,4L,1L,2L,8L,5L,9L,9L,0L,1L,1L,1L,1L,9L,9L,1L,2L,1L,9L,9L,6L,3L,4L,0L,4L,6L,8L,5L,7L,9L,2L,8L,2L,0L,4L,7L,3L,3L,6L,9L,1L,1L,2L,5L,4L,5L,2L,6L,9L,0L,0L,3L,9L,8L,9L,0L,2L,6L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248933Inst : IEnumerable<long>
{
public static readonly long[] Value=A248933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248933.Bytes);
public long this[int i]=>Value[i];

public static A248933Inst Instance=new A248933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248934
{
public static readonly long[] Value={ 2L,5L,9L,1L,1L,7L,0L,8L,6L,0L,1L,3L,2L,0L,2L,6L,2L,7L,7L,7L,6L,2L,4L,6L,7L,6L,7L,9L,2L,2L,4L,4L,1L,5L,3L,0L,9L,4L,1L,8L,1L,8L,8L,8L,7L,5L,5L,3L,1L,2L,5L,4L,2L,7L,3L,0L,3L,9L,7L,4L,9L,2L,3L,1L,6L,1L,8L,7L,4L,0L,1L,9L,2L,6L,6L,5L,8L,6L,3L,6L,2L,0L,8L,6L,2L,0L,1L,2L,0L,9L,5L,1L,6L,8L,0L,0L,4L,8L,3L,4L,0L,6L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248934Inst : IEnumerable<long>
{
public static readonly long[] Value=A248934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248934.Bytes);
public long this[int i]=>Value[i];

public static A248934Inst Instance=new A248934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248935
{
public static readonly long[] Value={ 1L,9L,0L,7L,9L,7L,0L,0L,7L,5L,2L,4L,4L,3L,9L,0L,7L,3L,8L,0L,7L,4L,6L,8L,0L,4L,2L,9L,6L,9L,5L,2L,9L,1L,7L,3L,6L,6L,9L,3L,5L,6L,9L,9L,4L,7L,4L,9L,9L,4L,0L,1L,7L,7L,3L,9L,4L,7L,4L,1L,8L,8L,2L,6L,7L,3L,5L,2L,8L,9L,7L,9L,7L,8L,7L,0L,0L,5L,0L,5L,3L,7L,0L,6L,3L,6L,8L,0L,4L,9L,8L,3L,5L,5L,1L,4L,9L,0L,0L,2L,4L,4L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248935Inst : IEnumerable<long>
{
public static readonly long[] Value=A248935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248935.Bytes);
public long this[int i]=>Value[i];

public static A248935Inst Instance=new A248935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248936
{
public static readonly long[] Value={ 2L,8L,5L,5L,4L,2L,5L,4L,2L,2L,2L,8L,2L,7L,9L,6L,1L,3L,9L,0L,1L,5L,6L,3L,5L,6L,6L,1L,0L,2L,1L,6L,4L,0L,0L,8L,3L,2L,6L,1L,6L,4L,2L,3L,8L,6L,4L,4L,7L,0L,2L,8L,8L,9L,1L,9L,9L,2L,4L,7L,4L,5L,6L,6L,0L,2L,2L,8L,4L,4L,0L,0L,3L,9L,0L,6L,0L,0L,6L,5L,3L,8L,7L,5L,9L,5L,4L,5L,7L,1L,5L,0L,5L,5L,3L,9L,8L,4L,3L,2L,3L,9L,7L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248936Inst : IEnumerable<long>
{
public static readonly long[] Value=A248936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248936.Bytes);
public long this[int i]=>Value[i];

public static A248936Inst Instance=new A248936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248937
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,4L,6L,5L,11L,4L,13L,8L,5L,6L,17L,8L,19L,5L,12L,14L,23L,4L,10L,14L,33L,8L,29L,5L,31L,8L,12L,17L,7L,8L,37L,22L,13L,5L,41L,22L,43L,12L,6L,23L,47L,27L,14L,14L,21L,13L,53L,33L,15L,8L,21L,29L,59L,5L,61L,32L,7L,8L,15L,14L,67L,17L,23L,8L,71L,8L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248937Inst : IEnumerable<long>
{
public static readonly long[] Value=A248937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248937.Bytes);
public long this[int i]=>Value[i];

public static A248937Inst Instance=new A248937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248938
{
public static readonly long[] Value={ 4L,6L,1L,2L,6L,0L,9L,0L,8L,6L,1L,3L,8L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248938Inst : IEnumerable<long>
{
public static readonly long[] Value=A248938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248938.Bytes);
public long this[int i]=>Value[i];

public static A248938Inst Instance=new A248938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248939
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,-1L,-4L,0L,3L,2L,0L,4L,3L,1L,-2L,2L,-3L,-9L,-16L,-8L,-17L,-7L,-18L,-6L,7L,21L,6L,-10L,-27L,-45L,-26L,-46L,-25L,-47L,-24L,0L,5L,4L,2L,-1L,3L,-2L,-8L,-15L,-7L,-16L,-6L,-17L,-5L,8L,22L,7L,-9L,-26L,-44L,-25L,-45L,-24L,-46L,-23L,1L,26L,0L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248939Inst : IEnumerable<long>
{
public static readonly long[] Value=A248939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248939.Bytes);
public long this[int i]=>Value[i];

public static A248939Inst Instance=new A248939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248940
{
public static readonly long[] Value={ 7L,6L,4L,1L,-3L,2L,-4L,3L,-5L,-14L,-24L,-13L,-1L,12L,-2L,13L,29L,46L,28L,9L,-11L,10L,-12L,11L,35L,60L,34L,61L,33L,62L,32L,63L,31L,64L,30L,65L,101L,138L,100L,139L,99L,58L,16L,-27L,17L,-28L,18L,-29L,19L,-30L,20L,-31L,21L,-32L,22L,-33L,23L,-34L,24L,-35L,25L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248940Inst : IEnumerable<long>
{
public static readonly long[] Value=A248940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248940.Bytes);
public long this[int i]=>Value[i];

public static A248940Inst Instance=new A248940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248941
{
public static readonly long[] Value={ 17L,16L,14L,11L,7L,2L,-4L,3L,-5L,4L,-6L,5L,-7L,6L,-8L,-23L,-39L,-22L,-40L,-21L,-1L,20L,-2L,21L,-3L,22L,48L,75L,47L,18L,-12L,19L,-13L,-46L,-80L,-45L,-9L,28L,-10L,29L,-11L,30L,72L,115L,71L,26L,-20L,27L,75L,124L,74L,23L,-29L,24L,-30L,25L,-31L,-88L,-146L,-87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248941Inst : IEnumerable<long>
{
public static readonly long[] Value=A248941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248941.Bytes);
public long this[int i]=>Value[i];

public static A248941Inst Instance=new A248941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248942
{
public static readonly long[] Value={ 20L,19L,17L,14L,10L,5L,-1L,6L,-2L,7L,-3L,8L,-4L,9L,-5L,-20L,-36L,-19L,-37L,-18L,2L,23L,1L,-22L,-46L,-21L,-47L,-74L,-102L,-73L,-43L,-12L,-44L,-11L,-45L,-10L,26L,63L,25L,-14L,-54L,-13L,29L,72L,28L,-17L,-63L,-16L,32L,81L,31L,82L,30L,-23L,-77L,-132L,-76L,-133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248942Inst : IEnumerable<long>
{
public static readonly long[] Value=A248942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248942.Bytes);
public long this[int i]=>Value[i];

public static A248942Inst Instance=new A248942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248943
{
public static readonly long[] Value={ 130L,170L,250L,260L,290L,340L,370L,410L,442L,500L,530L,580L,610L,650L,650L,650L,730L,740L,754L,820L,850L,850L,850L,884L,890L,962L,970L,986L,1010L,1060L,1066L,1090L,1130L,1220L,1250L,1258L,1300L,1300L,1300L,1370L,1378L,1394L,1450L,1450L,1450L,1460L,1490L,1508L,1570L,1586L,1690L,1690L,1690L,1700L,1700L,1700L,1730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248943Inst : IEnumerable<long>
{
public static readonly long[] Value=A248943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248943.Bytes);
public long this[int i]=>Value[i];

public static A248943Inst Instance=new A248943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248944
{
public static readonly long[] Value={ 2L,3L,3L,4L,7L,4L,5L,13L,14L,5L,6L,21L,36L,26L,6L,7L,31L,76L,90L,46L,7L,8L,43L,140L,246L,212L,79L,8L,9L,57L,234L,566L,738L,478L,133L,9L,10L,73L,364L,1146L,2104L,2108L,1044L,221L,10L,11L,91L,536L,2106L,5150L,7364L,5794L,2227L,364L,11L,12L,111L,756L,3590L,11196L,21652L,24720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248944Inst : IEnumerable<long>
{
public static readonly long[] Value=A248944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248944.Bytes);
public long this[int i]=>Value[i];

public static A248944Inst Instance=new A248944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248945
{
public static readonly long[] Value={ 1L,3L,2L,6L,3L,2L,4L,4L,0L,5L,2L,6L,6L,6L,5L,3L,4L,3L,3L,5L,4L,9L,4L,0L,3L,7L,7L,8L,1L,4L,2L,6L,8L,8L,9L,9L,6L,8L,3L,1L,1L,3L,3L,7L,1L,0L,8L,2L,5L,7L,1L,8L,8L,9L,5L,5L,5L,5L,6L,6L,4L,1L,4L,2L,4L,4L,0L,3L,9L,8L,9L,8L,3L,4L,3L,1L,7L,0L,8L,2L,5L,3L,4L,9L,1L,5L,4L,8L,3L,8L,3L,1L,0L,6L,8L,4L,4L,8L,5L,9L,6L,3L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248945Inst : IEnumerable<long>
{
public static readonly long[] Value=A248945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248945.Bytes);
public long this[int i]=>Value[i];

public static A248945Inst Instance=new A248945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248946
{
public static readonly long[] Value={ 1L,4L,8L,3L,5L,2L,2L,8L,1L,7L,3L,0L,9L,5L,5L,2L,2L,8L,6L,4L,1L,9L,2L,9L,9L,1L,8L,6L,3L,6L,1L,8L,8L,4L,2L,2L,2L,1L,9L,8L,9L,6L,6L,3L,1L,3L,7L,1L,5L,1L,6L,4L,0L,2L,6L,1L,7L,0L,8L,8L,5L,5L,9L,5L,6L,8L,8L,5L,9L,5L,0L,5L,0L,7L,7L,6L,1L,7L,0L,2L,1L,2L,2L,9L,4L,2L,5L,6L,7L,3L,3L,6L,1L,8L,2L,2L,7L,9L,2L,7L,4L,7L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248946Inst : IEnumerable<long>
{
public static readonly long[] Value=A248946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248946.Bytes);
public long this[int i]=>Value[i];

public static A248946Inst Instance=new A248946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248947
{
public static readonly long[] Value={ 3L,1L,3L,2L,7L,9L,9L,3L,6L,2L,8L,1L,8L,0L,0L,5L,2L,2L,6L,7L,2L,0L,0L,3L,4L,0L,1L,2L,8L,5L,8L,5L,6L,7L,6L,3L,8L,0L,5L,2L,2L,8L,0L,5L,2L,2L,4L,1L,8L,8L,7L,2L,4L,0L,1L,1L,2L,7L,1L,9L,2L,0L,0L,4L,1L,8L,0L,5L,4L,4L,3L,7L,2L,3L,1L,9L,8L,2L,3L,3L,8L,7L,1L,5L,9L,3L,5L,4L,5L,4L,9L,3L,6L,5L,3L,7L,9L,6L,2L,9L,4L,8L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248947Inst : IEnumerable<long>
{
public static readonly long[] Value=A248947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248947.Bytes);
public long this[int i]=>Value[i];

public static A248947Inst Instance=new A248947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248948
{
public static readonly long[] Value={ 2L,2L,0L,8L,2L,5L,8L,8L,1L,3L,2L,8L,7L,1L,7L,5L,7L,0L,9L,0L,8L,4L,3L,4L,9L,6L,8L,0L,7L,3L,0L,3L,4L,7L,3L,2L,6L,2L,4L,5L,8L,6L,8L,0L,7L,4L,1L,9L,8L,7L,7L,0L,6L,7L,6L,7L,2L,7L,6L,5L,9L,9L,1L,5L,3L,9L,8L,2L,6L,6L,2L,1L,6L,3L,1L,8L,6L,9L,1L,9L,6L,5L,4L,2L,2L,4L,4L,0L,5L,0L,3L,4L,0L,3L,0L,2L,4L,2L,1L,1L,3L,4L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248948Inst : IEnumerable<long>
{
public static readonly long[] Value=A248948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248948.Bytes);
public long this[int i]=>Value[i];

public static A248948Inst Instance=new A248948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248949
{
public static readonly long[] Value={ 3L,0L,1L,3L,6L,5L,8L,0L,2L,5L,8L,1L,0L,0L,5L,9L,1L,7L,6L,2L,1L,0L,1L,9L,5L,5L,8L,1L,9L,5L,4L,8L,2L,7L,0L,2L,2L,4L,0L,7L,5L,4L,4L,2L,5L,6L,7L,1L,3L,4L,9L,0L,3L,9L,9L,8L,8L,8L,3L,6L,7L,2L,9L,6L,4L,2L,8L,1L,4L,4L,9L,2L,8L,3L,5L,0L,0L,1L,1L,3L,3L,5L,2L,0L,9L,1L,8L,0L,5L,4L,1L,0L,4L,7L,4L,2L,1L,8L,8L,9L,7L,7L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248949Inst : IEnumerable<long>
{
public static readonly long[] Value=A248949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248949.Bytes);
public long this[int i]=>Value[i];

public static A248949Inst Instance=new A248949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248950
{
public static readonly long[] Value={ 2L,1L,7L,6L,3L,0L,5L,1L,4L,7L,7L,7L,5L,8L,3L,2L,4L,0L,2L,1L,8L,6L,2L,2L,9L,5L,6L,9L,8L,6L,3L,9L,3L,6L,4L,7L,9L,3L,4L,9L,4L,3L,9L,2L,0L,3L,1L,9L,1L,6L,9L,8L,1L,5L,4L,4L,9L,5L,1L,6L,5L,1L,5L,5L,0L,6L,2L,8L,6L,6L,7L,1L,8L,6L,7L,1L,5L,4L,4L,8L,2L,5L,4L,6L,2L,1L,4L,6L,0L,3L,5L,0L,0L,2L,8L,8L,7L,6L,1L,9L,4L,2L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248950Inst : IEnumerable<long>
{
public static readonly long[] Value=A248950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248950.Bytes);
public long this[int i]=>Value[i];

public static A248950Inst Instance=new A248950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248951
{
public static readonly long[] Value={ 9L,0L,4L,3L,5L,2L,8L,6L,0L,8L,6L,5L,8L,2L,1L,1L,1L,5L,2L,6L,5L,6L,3L,8L,2L,7L,4L,7L,2L,9L,5L,8L,9L,9L,5L,7L,9L,1L,5L,1L,3L,3L,3L,5L,7L,1L,9L,8L,7L,1L,5L,0L,4L,1L,3L,9L,2L,4L,2L,5L,1L,2L,7L,8L,0L,7L,1L,9L,3L,6L,3L,4L,5L,9L,9L,6L,4L,4L,8L,8L,9L,4L,6L,7L,5L,4L,6L,4L,2L,4L,8L,4L,7L,2L,8L,5L,9L,7L,0L,9L,8L,5L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248951Inst : IEnumerable<long>
{
public static readonly long[] Value=A248951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248951.Bytes);
public long this[int i]=>Value[i];

public static A248951Inst Instance=new A248951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248952
{
public static readonly long[] Value={ 0L,0L,-4L,0L,-47L,-46L,0L,-6362L,-23L,-22L,0L,-32L,-471L,-470L,-29L,0L,-218L,-4843985L,-39L,-38L,-657367L,0L,-101L,-57L,-56L,-7609937L,-45L,-44L,0L,-736L,-56168428L,-3113136L,-3113135L,-3113134L,-3113133L,-51L,0L,-190L,-1213998L,-1213997L,-495L,-62L,-61L,-60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248952Inst : IEnumerable<long>
{
public static readonly long[] Value=A248952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248952.Bytes);
public long this[int i]=>Value[i];

public static A248952Inst Instance=new A248952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248953
{
public static readonly long[] Value={ 0L,1L,2L,3L,21L,26L,6L,6843L,8L,14L,10L,72L,365L,366L,14L,15L,352L,4674389L,18L,22L,891114L,21L,102L,23L,31L,7856204L,26L,27L,28L,1700L,61960674L,3702823L,3702824L,3702825L,3702826L,35L,36L,370L,1047903L,1047904L,596L,41L,42L,43L,2976L,45L,341L,260L,261L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248953Inst : IEnumerable<long>
{
public static readonly long[] Value=A248953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248953.Bytes);
public long this[int i]=>Value[i];

public static A248953Inst Instance=new A248953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248954
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,111L,142L,214L,222L,284L,333L,421L,428L,444L,555L,666L,777L,842L,888L,999L,1111L,1142L,1212L,1242L,1346L,1421L,1422L,1442L,2114L,2121L,2124L,2142L,2144L,2214L,2222L,2284L,2421L,2424L,2484L,2842L,2844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248954Inst : IEnumerable<long>
{
public static readonly long[] Value=A248954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248954.Bytes);
public long this[int i]=>Value[i];

public static A248954Inst Instance=new A248954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248955
{
public static readonly long[] Value={ 1L,3L,3L,5L,3L,9L,3L,9L,5L,9L,3L,17L,3L,9L,9L,13L,3L,17L,3L,17L,9L,9L,3L,31L,5L,9L,9L,17L,3L,29L,3L,19L,9L,9L,9L,35L,3L,9L,9L,31L,3L,29L,3L,17L,17L,9L,3L,49L,5L,17L,9L,17L,3L,31L,9L,31L,9L,9L,3L,61L,3L,9L,17L,27L,9L,29L,3L,17L,9L,29L,3L,67L,3L,9L,17L,17L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248955Inst : IEnumerable<long>
{
public static readonly long[] Value=A248955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248955.Bytes);
public long this[int i]=>Value[i];

public static A248955Inst Instance=new A248955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248956
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,19L,27L,37L,49L,65L,85L,109L,139L,175L,219L,273L,337L,413L,505L,613L,741L,893L,1071L,1279L,1523L,1807L,2137L,2521L,2965L,3477L,4069L,4749L,5529L,6425L,7449L,8619L,9955L,11475L,13203L,15167L,17393L,19913L,22765L,25985L,29617L,33713L,38321L,43501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248956Inst : IEnumerable<long>
{
public static readonly long[] Value=A248956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248956.Bytes);
public long this[int i]=>Value[i];

public static A248956Inst Instance=new A248956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248957
{
public static readonly long[] Value={ 0L,1L,4L,14L,48L,161L,546L,1869L,6488L,22903L,81853L,295638L,1077307L,3956781L,14628943L,54396516L,203273679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248957Inst : IEnumerable<long>
{
public static readonly long[] Value=A248957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248957.Bytes);
public long this[int i]=>Value[i];

public static A248957Inst Instance=new A248957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248958
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248958Inst : IEnumerable<long>
{
public static readonly long[] Value=A248958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248958.Bytes);
public long this[int i]=>Value[i];

public static A248958Inst Instance=new A248958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248959
{
public static readonly long[] Value={ 1L,3L,9L,27L,36L,72L,132L,240L,444L,816L,1500L,2760L,5076L,9336L,17172L,31584L,58092L,106848L,196524L,361464L,664836L,1222824L,2249124L,4136784L,7608732L,13994640L,25740156L,47343528L,87078324L,160162008L,294583860L,541824192L,996570060L,1832978112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248959Inst : IEnumerable<long>
{
public static readonly long[] Value=A248959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248959.Bytes);
public long this[int i]=>Value[i];

public static A248959Inst Instance=new A248959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248960
{
public static readonly long[] Value={ 1L,3L,9L,27L,81L,150L,366L,870L,2022L,4686L,10974L,25614L,59742L,139398L,325350L,759198L,1771590L,4134126L,9647262L,22512342L,52533750L,122590422L,286071414L,667563054L,1557794622L,3635198310L,8482932318L,19795382454L,46193598486L,107795266974L,251546100558L,586996465758L,1369788083022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248960Inst : IEnumerable<long>
{
public static readonly long[] Value=A248960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248960.Bytes);
public long this[int i]=>Value[i];

public static A248960Inst Instance=new A248960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248961
{
public static readonly long[] Value={ 0L,1L,-2L,5L,-292L,-241L,14L,-437861L,-28L,-1L,30L,313L,-4472L,-4223L,-2L,55L,3252L,-214246256269L,-70L,-27L,5260887648L,91L,-538L,-193L,-132L,-864538549823L,-22L,27L,140L,40053L,53088613819206L,86166834699L,86167898716L,86168962733L,86170026754L,49L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248961Inst : IEnumerable<long>
{
public static readonly long[] Value=A248961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248961.Bytes);
public long this[int i]=>Value[i];

public static A248961Inst Instance=new A248961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248962
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,9L,11L,12L,14L,15L,15L,16L,18L,19L,21L,22L,23L,24L,24L,26L,28L,30L,30L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,44L,46L,46L,47L,47L,48L,50L,51L,53L,54L,55L,56L,58L,59L,61L,61L,62L,62L,64L,66L,66L,67L,68L,68L,70L,72L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248962Inst : IEnumerable<long>
{
public static readonly long[] Value=A248962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248962.Bytes);
public long this[int i]=>Value[i];

public static A248962Inst Instance=new A248962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248963
{
public static readonly long[] Value={ 1L,7L,9L,11L,13L,16L,19L,23L,25L,29L,31L,32L,37L,43L,47L,53L,61L,67L,73L,79L,81L,83L,97L,103L,107L,109L,113L,121L,127L,128L,137L,139L,149L,151L,157L,163L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,243L,251L,257L,263L,269L,271L,277L,281L,283L,307L,311L,313L,317L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248963Inst : IEnumerable<long>
{
public static readonly long[] Value=A248963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248963.Bytes);
public long this[int i]=>Value[i];

public static A248963Inst Instance=new A248963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248964
{
public static readonly long[] Value={ 1L,4L,40L,160L,5600L,896L,19200L,76800L,14784000L,19712000L,512512000L,186368000L,19568640000L,6021120000L,20889600000L,7798784000L,71310131200000L,16778854400000L,503365632000000L,15138816000000L,221798793216000000L,6035341312000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248964Inst : IEnumerable<long>
{
public static readonly long[] Value=A248964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248964.Bytes);
public long this[int i]=>Value[i];

public static A248964Inst Instance=new A248964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248965
{
public static readonly long[] Value={ 0L,8L,1L,2L,8L,2L,7L,2L,6L,8L,0L,8L,4L,6L,1L,2L,3L,2L,5L,9L,6L,3L,6L,8L,2L,0L,7L,8L,2L,3L,5L,5L,0L,6L,6L,0L,6L,6L,7L,1L,4L,4L,3L,6L,4L,1L,5L,2L,5L,6L,2L,7L,6L,9L,6L,7L,7L,2L,0L,0L,4L,0L,2L,4L,4L,0L,6L,4L,7L,8L,0L,1L,1L,4L,3L,8L,4L,8L,2L,8L,6L,9L,8L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248965Inst : IEnumerable<long>
{
public static readonly long[] Value=A248965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248965.Bytes);
public long this[int i]=>Value[i];

public static A248965Inst Instance=new A248965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248966
{
public static readonly long[] Value={ 2L,0L,3L,6L,6L,2L,4L,2L,6L,7L,2L,4L,0L,6L,1L,9L,1L,2L,1L,1L,2L,1L,3L,9L,4L,8L,1L,0L,7L,6L,6L,5L,3L,0L,4L,3L,5L,0L,2L,7L,2L,5L,2L,1L,3L,5L,6L,3L,0L,3L,4L,0L,4L,6L,7L,8L,0L,7L,8L,5L,3L,7L,4L,3L,9L,8L,1L,0L,9L,9L,2L,6L,3L,2L,3L,1L,8L,1L,1L,0L,3L,2L,6L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248966Inst : IEnumerable<long>
{
public static readonly long[] Value=A248966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248966.Bytes);
public long this[int i]=>Value[i];

public static A248966Inst Instance=new A248966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248967
{
public static readonly long[] Value={ 2L,1L,3L,0L,7L,5L,9L,0L,5L,4L,6L,5L,3L,9L,2L,3L,0L,7L,4L,7L,9L,6L,3L,8L,0L,7L,6L,8L,2L,5L,7L,6L,5L,6L,8L,8L,2L,0L,7L,8L,6L,9L,6L,5L,9L,6L,5L,7L,0L,7L,6L,8L,6L,2L,9L,8L,6L,1L,6L,1L,1L,1L,1L,8L,5L,0L,1L,6L,1L,9L,4L,9L,2L,2L,7L,6L,5L,8L,0L,7L,9L,6L,6L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248967Inst : IEnumerable<long>
{
public static readonly long[] Value=A248967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248967.Bytes);
public long this[int i]=>Value[i];

public static A248967Inst Instance=new A248967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248968
{
public static readonly long[] Value={ 2L,9L,4L,3L,5L,8L,6L,3L,2L,2L,7L,3L,8L,5L,3L,5L,4L,0L,0L,7L,6L,0L,0L,6L,2L,8L,4L,6L,4L,9L,3L,1L,6L,3L,4L,8L,8L,7L,5L,0L,1L,4L,0L,2L,3L,8L,0L,9L,6L,3L,9L,6L,3L,2L,6L,6L,3L,3L,6L,1L,5L,1L,4L,2L,9L,0L,8L,0L,9L,7L,5L,0L,3L,7L,1L,5L,0L,6L,3L,6L,6L,6L,5L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248968Inst : IEnumerable<long>
{
public static readonly long[] Value=A248968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248968.Bytes);
public long this[int i]=>Value[i];

public static A248968Inst Instance=new A248968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248969
{
public static readonly long[] Value={ 1L,3L,6L,15L,18L,42L,24L,57L,30L,72L,36L,87L,48L,114L,54L,129L,60L,144L,66L,159L,78L,186L,84L,201L,90L,216L,96L,231L,108L,258L,114L,273L,120L,288L,126L,303L,138L,330L,144L,345L,150L,360L,156L,375L,168L,402L,174L,417L,180L,432L,186L,447L,198L,474L,204L,489L,210L,504L,216L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248969Inst : IEnumerable<long>
{
public static readonly long[] Value=A248969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248969.Bytes);
public long this[int i]=>Value[i];

public static A248969Inst Instance=new A248969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248970
{
public static readonly long[] Value={ 72L,90L,108L,153L,270L,423L,450L,531L,558L,630L,648L,738L,1044L,1098L,1125L,1224L,1242L,1287L,1440L,1503L,1566L,1611L,1620L,1800L,1935L,2034L,2142L,2250L,2358L,2439L,2448L,2511L,2754L,2790L,2799L,2862L,2943L,2952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248970Inst : IEnumerable<long>
{
public static readonly long[] Value=A248970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248970.Bytes);
public long this[int i]=>Value[i];

public static A248970Inst Instance=new A248970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248971
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,10L,7L,6L,15L,11L,9L,21L,16L,13L,12L,28L,22L,18L,16L,36L,29L,24L,21L,20L,45L,37L,31L,27L,25L,55L,46L,39L,34L,31L,30L,66L,56L,48L,42L,38L,36L,78L,67L,58L,51L,46L,43L,42L,91L,79L,69L,61L,55L,51L,49L,105L,92L,81L,72L,65L,60L,57L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248971Inst : IEnumerable<long>
{
public static readonly long[] Value=A248971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248971.Bytes);
public long this[int i]=>Value[i];

public static A248971Inst Instance=new A248971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248972
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,5L,3L,5L,7L,3L,3L,3L,5L,3L,5L,7L,3L,5L,3L,3L,3L,5L,13L,3L,3L,3L,5L,3L,5L,7L,5L,13L,3L,3L,13L,3L,11L,5L,3L,3L,3L,11L,3L,11L,3L,3L,5L,3L,7L,3L,3L,5L,3L,5L,11L,3L,3L,5L,11L,3L,7L,5L,5L,3L,5L,3L,5L,3L,3L,3L,5L,3L,3L,3L,19L,3L,3L,3L,7L,7L,3L,3L,11L,5L,3L,3L,5L,3L,11L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248972Inst : IEnumerable<long>
{
public static readonly long[] Value=A248972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248972.Bytes);
public long this[int i]=>Value[i];

public static A248972Inst Instance=new A248972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248973
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,2L,-2L,-2L,3L,5L,5L,4L,7L,8L,6L,8L,5L,-4L,-20L,-28L,-45L,-52L,-70L,-76L,-69L,-48L,-42L,-52L,-79L,-124L,-150L,-196L,-221L,-268L,-292L,-292L,5L,9L,11L,10L,13L,11L,3L,-12L,-19L,-35L,-41L,-58L,-63L,-55L,-33L,-26L,-35L,-61L,-105L,-130L,-175L,-199L,-245L,-268L,-267L,-241L,-241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248973Inst : IEnumerable<long>
{
public static readonly long[] Value=A248973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248973.Bytes);
public long this[int i]=>Value[i];

public static A248973Inst Instance=new A248973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248974
{
public static readonly long[] Value={ 59L,959L,4859L,15359L,37499L,77759L,144059L,245759L,393659L,599999L,878459L,1244159L,1713659L,2304959L,3037499L,3932159L,5011259L,6298559L,7819259L,9599999L,11668859L,14055359L,16790459L,19906559L,23437499L,27418559L,31886459L,36879359L,42436859L,48599999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248974Inst : IEnumerable<long>
{
public static readonly long[] Value=A248974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248974.Bytes);
public long this[int i]=>Value[i];

public static A248974Inst Instance=new A248974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248975
{
public static readonly long[] Value={ 1L,2L,1L,-1L,-1L,1L,-12L,-10L,4L,1L,45L,34L,-14L,-3L,1L,406L,319L,-124L,-33L,6L,1L,-2357L,-1847L,731L,187L,-39L,-5L,1L,-26968L,-21188L,8312L,2182L,-424L,-68L,8L,1L,223769L,175700L,-69052L,-18034L,3566L,548L,-76L,-7L,1L,3096810L,2432333L,-955048L,-250126L,49052L,7730L,-1000L,-115L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248975Inst : IEnumerable<long>
{
public static readonly long[] Value=A248975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248975.Bytes);
public long this[int i]=>Value[i];

public static A248975Inst Instance=new A248975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248976
{
public static readonly long[] Value={ 1L,0L,1L,-3L,3L,1L,8L,-6L,-2L,1L,65L,-50L,-20L,5L,1L,-296L,235L,90L,-25L,-4L,1L,-3059L,2401L,945L,-245L,-49L,7L,1L,21552L,-16940L,-6636L,1750L,336L,-56L,-6L,1L,272289L,-213828L,-84000L,21966L,4326L,-672L,-90L,9L,1L,-2600752L,2042805L,801996L,-210126L,-41160L,6570L,834L,-99L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248976Inst : IEnumerable<long>
{
public static readonly long[] Value=A248976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248976.Bytes);
public long this[int i]=>Value[i];

public static A248976Inst Instance=new A248976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248977
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,-11L,1L,-2L,70L,-26L,1L,-2L,-362L,406L,-47L,1L,-2L,1663L,-4994L,1303L,-74L,1L,-2L,-7085L,53326L,-27857L,3166L,-107L,1L,-2L,28636L,-518210L,507958L,-102674L,6508L,-146L,1L,-2L,-111332L,4707262L,-8310026L,2800366L,-295892L,11950L,-191L,1L,-2L,420109L,-40642370L,125613106L,-67743506L,11185858L,-722882L,20221L,-242L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248977Inst : IEnumerable<long>
{
public static readonly long[] Value=A248977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248977.Bytes);
public long this[int i]=>Value[i];

public static A248977Inst Instance=new A248977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248978
{
public static readonly long[] Value={ 1L,4L,1L,4L,13L,1L,4L,94L,28L,1L,4L,526L,460L,49L,1L,4L,2551L,5860L,1399L,76L,1L,4L,11299L,64180L,30559L,3316L,109L,1L,4L,47020L,635716L,566374L,109156L,6724L,148L,1L,4L,186988L,5861188L,9384358L,3012196L,309124L,12244L,193L,1L,4L,718429L,51210820L,143307490L,73556068L,11790874L,747076L,20605L,244L,1L,4L,2686729L,429124420L,2056495090L,1641197668L,394515874L,37488676L,1608205L,32644L,301L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248978Inst : IEnumerable<long>
{
public static readonly long[] Value=A248978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248978.Bytes);
public long this[int i]=>Value[i];

public static A248978Inst Instance=new A248978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248979
{
public static readonly long[] Value={ 0L,33L,77L,110L,847L,880L,924L,957L,1210L,1243L,1287L,1320L,9328L,9372L,9416L,9702L,9768L,10538L,10582L,10626L,14201L,14223L,102608L,102641L,102685L,102718L,103136L,103158L,116413L,116457L,116501L,156255L,156277L,1128688L,1128721L,1128765L,1128798L,1129073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248979Inst : IEnumerable<long>
{
public static readonly long[] Value=A248979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248979.Bytes);
public long this[int i]=>Value[i];

public static A248979Inst Instance=new A248979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248980
{
public static readonly long[] Value={ 1L,5L,13L,17L,37L,53L,61L,85L,89L,97L,101L,109L,149L,185L,197L,205L,221L,229L,257L,313L,349L,397L,421L,425L,461L,481L,485L,493L,545L,557L,577L,629L,689L,701L,725L,733L,797L,829L,841L,845L,865L,901L,953L,1021L,1037L,1069L,1073L,1105L,1157L,1165L,1181L,1189L,1193L,1241L,1249L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248980Inst : IEnumerable<long>
{
public static readonly long[] Value=A248980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248980.Bytes);
public long this[int i]=>Value[i];

public static A248980Inst Instance=new A248980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248981
{
public static readonly long[] Value={ 2L,4L,3L,11L,5L,17L,7L,39L,29L,13L,57L,41L,19L,75L,23L,119L,63L,31L,145L,37L,121L,85L,43L,139L,47L,203L,53L,221L,59L,299L,67L,195L,71L,343L,79L,223L,83L,311L,89L,409L,97L,265L,101L,189L,103L,287L,107L,395L,113L,813L,127L,335L,131L,455L,137L,249L,709L,149L,267L,151L,517L,157L,535L,163L,423L,167L,569L,173L,587L,179L,321L,181L,911L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248981Inst : IEnumerable<long>
{
public static readonly long[] Value=A248981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248981.Bytes);
public long this[int i]=>Value[i];

public static A248981Inst Instance=new A248981Inst();

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