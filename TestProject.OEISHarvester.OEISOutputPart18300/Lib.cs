using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A073612
{
public static readonly long[] Value={ 4L,8L,14L,23L,35L,50L,68L,89L,115L,145L,179L,218L,260L,305L,355L,411L,471L,535L,604L,676L,752L,833L,919L,1012L,1111L,1213L,1318L,1426L,1537L,1657L,1786L,1920L,2058L,2202L,2352L,2506L,2666L,2831L,3001L,3177L,3357L,3543L,3735L,3930L,4128L,4333L,4550L,4775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073612Inst : IEnumerable<long>
{
public static readonly long[] Value=A073612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073612.Bytes);
public long this[int i]=>Value[i];

public static A073612Inst Instance=new A073612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073611
{
public static readonly long[] Value={ 1L,4L,5L,10L,16L,22L,24L,34L,36L,74L,48L,106L,60L,178L,78L,142L,84L,202L,90L,358L,114L,274L,144L,386L,120L,466L,168L,514L,180L,502L,234L,802L,246L,622L,288L,746L,240L,694L,210L,914L,324L,1322L,300L,958L,360L,1094L,474L,1198L,330L,1234L,528L,1282L,576L,1366L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073611Inst : IEnumerable<long>
{
public static readonly long[] Value=A073611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073611.Bytes);
public long this[int i]=>Value[i];

public static A073611Inst Instance=new A073611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073610
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,2L,2L,2L,3L,0L,2L,2L,3L,2L,4L,0L,4L,2L,4L,2L,5L,0L,6L,2L,5L,0L,4L,0L,6L,2L,4L,2L,7L,0L,8L,0L,3L,2L,6L,0L,8L,2L,6L,2L,7L,0L,10L,2L,8L,0L,6L,0L,10L,2L,6L,0L,7L,0L,12L,2L,5L,2L,10L,0L,12L,0L,4L,2L,10L,0L,12L,2L,9L,2L,10L,0L,14L,0L,8L,2L,9L,0L,16L,2L,9L,0L,8L,0L,18L,2L,8L,0L,9L,0L,14L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073610Inst : IEnumerable<long>
{
public static readonly long[] Value=A073610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073610.Bytes);
public long this[int i]=>Value[i];

public static A073610Inst Instance=new A073610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073609
{
public static readonly long[] Value={ 2L,3L,7L,11L,47L,83L,227L,263L,587L,911L,947L,983L,1019L,1163L,1307L,1451L,1487L,1523L,1559L,2459L,3359L,4259L,4583L,5483L,5519L,5843L,5879L,6203L,6779L,7103L,7247L,7283L,7607L,7643L,8219L,8363L,10667L,11243L,11279L,11423L,12323L,12647L,12791L,13367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073609Inst : IEnumerable<long>
{
public static readonly long[] Value=A073609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073609.Bytes);
public long this[int i]=>Value[i];

public static A073609Inst Instance=new A073609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073608
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073608Inst : IEnumerable<long>
{
public static readonly long[] Value=A073608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073608.Bytes);
public long this[int i]=>Value[i];

public static A073608Inst Instance=new A073608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073607
{
public static readonly long[] Value={ 8L,20L,38L,54L,68L,98L,114L,128L,158L,159L,169L,188L,218L,248L,264L,278L,308L,338L,368L,369L,398L,405L,428L,458L,474L,488L,518L,548L,578L,579L,608L,638L,668L,684L,698L,728L,758L,788L,789L,790L,791L,818L,848L,878L,894L,908L,938L,968L,998L,999L,1028L,1058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073607Inst : IEnumerable<long>
{
public static readonly long[] Value=A073607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073607.Bytes);
public long this[int i]=>Value[i];

public static A073607Inst Instance=new A073607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073606
{
public static readonly long[] Value={ 2L,8L,9L,14L,20L,21L,24L,26L,32L,38L,39L,44L,50L,54L,55L,56L,62L,68L,69L,74L,77L,80L,84L,86L,90L,92L,98L,99L,104L,110L,114L,115L,116L,122L,125L,128L,129L,134L,140L,144L,146L,152L,158L,159L,160L,164L,169L,170L,174L,175L,176L,182L,188L,189L,194L,195L,200L,204L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073606Inst : IEnumerable<long>
{
public static readonly long[] Value=A073606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073606.Bytes);
public long this[int i]=>Value[i];

public static A073606Inst Instance=new A073606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073605
{
public static readonly BigInteger[] Value={ 1L,1L,7L,157L,787L,787L,210997L,5316097L,34415167L,703693777L,194794490677L,5208806743927L,138782093170507L,5006786309605867L,253579251611336437L,12551374903381164637UL,BigInteger.Parse("142908008812141343557"),BigInteger.Parse("77053322014980646906357") };
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
public class A073605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073605Inst Instance=new A073605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073604
{
public static readonly long[] Value={ 3L,10L,21L,22L,78L,170L,171L,115L,116L,465L,962L,1148L,903L,517L,424L,531L,1830L,3417L,1207L,2628L,4819L,1660L,1246L,7566L,7373L,5253L,2782L,5886L,9266L,13335L,4192L,3014L,9591L,2086L,11325L,19782L,21353L,6847L,4844L,5191L,16290L,31133L,18528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073604Inst : IEnumerable<long>
{
public static readonly long[] Value=A073604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073604.Bytes);
public long this[int i]=>Value[i];

public static A073604Inst Instance=new A073604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073539
{
public static readonly long[] Value={ 1L,4L,8L,9L,16L,18L,25L,27L,32L,36L,49L,50L,54L,64L,72L,81L,98L,100L,108L,121L,125L,128L,144L,147L,162L,169L,196L,200L,216L,225L,242L,243L,250L,256L,288L,289L,294L,324L,338L,343L,361L,392L,400L,432L,441L,450L,484L,486L,500L,507L,512L,529L,576L,578L,588L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073539Inst : IEnumerable<long>
{
public static readonly long[] Value=A073539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073539.Bytes);
public long this[int i]=>Value[i];

public static A073539Inst Instance=new A073539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073538
{
public static readonly long[] Value={ 0L,0L,3L,0L,2L,0L,12L,1L,5L,0L,11L,0L,2L,4L,6L,0L,10L,0L,3L,1L,3L,0L,5L,1L,93L,9L,5L,0L,2L,0L,35L,2L,17L,8L,4L,0L,3L,92L,8L,0L,4L,0L,6L,1L,2L,0L,34L,1L,13L,16L,7L,0L,3L,26L,4L,2L,91L,0L,7L,0L,2L,3L,7L,1L,5L,0L,3L,1L,2L,0L,33L,0L,4L,12L,15L,33L,6L,0L,5L,2L,25L,0L,3L,1L,2L,90L,19L,0L,6L,52L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073538Inst : IEnumerable<long>
{
public static readonly long[] Value=A073538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073538.Bytes);
public long this[int i]=>Value[i];

public static A073538Inst Instance=new A073538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073537
{
public static readonly long[] Value={ 1L,27L,729L,2197L,1331L,6859L,24389L,343L,3375L,9261L,59319L,35937L,15625L,12167L,29791L,125L,4913L,79507L,19683L,389017L,91125L,166375L,132651L,117649L,185193L,2460375L,50653L,42875L,300763L,250047L,753571L,148877L,205379L,68921L,226981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073537Inst : IEnumerable<long>
{
public static readonly long[] Value=A073537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073537.Bytes);
public long this[int i]=>Value[i];

public static A073537Inst Instance=new A073537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073536
{
public static readonly long[] Value={ 3L,9L,12L,15L,17L,27L,34L,39L,46L,49L,52L,54L,66L,70L,73L,81L,84L,90L,95L,102L,106L,110L,116L,119L,124L,132L,140L,143L,149L,153L,158L,161L,165L,171L,177L,180L,183L,186L,189L,194L,198L,209L,215L,221L,224L,226L,233L,235L,241L,244L,248L,251L,255L,259L,262L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073536Inst : IEnumerable<long>
{
public static readonly long[] Value=A073536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073536.Bytes);
public long this[int i]=>Value[i];

public static A073536Inst Instance=new A073536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073535
{
public static readonly long[] Value={ 1L,2L,14L,34L,46L,96L,142L,178L,196L,240L,358L,598L,718L,1048L,1350L,1398L,1598L,1790L,1798L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073535Inst : IEnumerable<long>
{
public static readonly long[] Value=A073535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073535.Bytes);
public long this[int i]=>Value[i];

public static A073535Inst Instance=new A073535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073534
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,17L,29L,40L,41L,59L,71L,101L,107L,108L,137L,149L,154L,179L,191L,197L,227L,239L,243L,269L,281L,311L,340L,343L,347L,419L,431L,448L,461L,521L,569L,599L,617L,641L,659L,663L,684L,809L,821L,827L,857L,881L,928L,1019L,1031L,1049L,1061L,1091L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073534Inst : IEnumerable<long>
{
public static readonly long[] Value=A073534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073534.Bytes);
public long this[int i]=>Value[i];

public static A073534Inst Instance=new A073534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073533
{
public static readonly long[] Value={ 1L,4L,16L,64L,13L,52L,208L,832L,3328L,13312L,53248L,212992L,851968L,3407872L,13631488L,11479231L,45916924L,183667696L,734670784L,2938683136L,1294379341L,5177517364L,20710069456L,82840277824L,331361111296L,1325444445184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073533Inst : IEnumerable<long>
{
public static readonly long[] Value=A073533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073533.Bytes);
public long this[int i]=>Value[i];

public static A073533Inst Instance=new A073533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073532
{
public static readonly long[] Value={ 4L,20L,97L,510L,2529L,10239L,33950L,90510L,145227L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073532Inst : IEnumerable<long>
{
public static readonly long[] Value=A073532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073532.Bytes);
public long this[int i]=>Value[i];

public static A073532Inst Instance=new A073532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073531
{
public static readonly long[] Value={ 9L,81L,648L,4536L,27216L,136080L,544320L,1632960L,3265920L,3265920L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073531Inst : IEnumerable<long>
{
public static readonly long[] Value=A073531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073531.Bytes);
public long this[int i]=>Value[i];

public static A073531Inst Instance=new A073531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073530
{
public static readonly ulong[] Value={ 1L,3L,22L,225L,2706L,35861L,507060L,7510005L,115175530L,1815002145L,29231242206L,479251119815L,7975209124260L,134398986236625L,2289535943534920L,39370761619959165L,682603570436824602L,11921040322642855193UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073530Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A073530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073530.Bytes);
public ulong this[int i]=>Value[i];

public static A073530Inst Instance=new A073530Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073529
{
public static readonly long[] Value={ 0L,1L,2L,3L,18L,26L,56L,79L,200L,225L,388L,1444L,4287L,6143L,7627L,10901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073529Inst : IEnumerable<long>
{
public static readonly long[] Value=A073529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073529.Bytes);
public long this[int i]=>Value[i];

public static A073529Inst Instance=new A073529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073528
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,11L,19L,31L,37L,67L,149L,199L,601L,941L,1447L,1709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073528Inst : IEnumerable<long>
{
public static readonly long[] Value=A073528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073528.Bytes);
public long this[int i]=>Value[i];

public static A073528Inst Instance=new A073528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073527
{
public static readonly long[] Value={ 10L,11L,12L,13L,14L,20L,21L,22L,23L,24L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073527Inst : IEnumerable<long>
{
public static readonly long[] Value=A073527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073527.Bytes);
public long this[int i]=>Value[i];

public static A073527Inst Instance=new A073527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073526
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,16L,17L,18L,19L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,49L,75L,76L,77L,91L,92L,93L,94L,95L,96L,97L,98L,99L,125L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,153L,154L,155L,205L,206L,207L,208L,209L,210L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073526Inst : IEnumerable<long>
{
public static readonly long[] Value=A073526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073526.Bytes);
public long this[int i]=>Value[i];

public static A073526Inst Instance=new A073526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073525
{
public static readonly long[] Value={ 1L,2L,5L,15L,51L,187L,716L,2811L,11204L,45089L,182636L,743180L,3034361L,12420945L,50946169L,209296302L,860941813L,3545265139L,14611979639L,60268977054L,248744871983L,1027188978686L,4243751316106L,17539851091965L,72519657462805L,299930389183429L,1240806275485094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073525Inst : IEnumerable<long>
{
public static readonly long[] Value=A073525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073525.Bytes);
public long this[int i]=>Value[i];

public static A073525Inst Instance=new A073525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073524
{
public static readonly long[] Value={ 0L,1L,2L,3L,18L,2L,3L,4L,6L,7L,26L,4L,9L,3L,4L,8L,6L,4L,56L,11L,3L,4L,42L,4L,33L,7L,5L,4L,38L,5L,79L,6L,4L,15L,14L,8L,200L,29L,13L,5L,36L,3L,4L,5L,7L,10L,11L,8L,6L,20L,47L,27L,43L,9L,41L,9L,10L,23L,37L,17L,18L,6L,7L,6L,32L,15L,225L,7L,73L,11L,20L,12L,182L,9L,16L,7L,10L,15L,196L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073524Inst : IEnumerable<long>
{
public static readonly long[] Value=A073524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073524.Bytes);
public long this[int i]=>Value[i];

public static A073524Inst Instance=new A073524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073331
{
public static readonly long[] Value={ 1L,1L,2L,11L,3L,57L,2L,3L,6L,1013L,2L,4083L,50L,1L,2L,65519L,2L,262125L,61L,43L,1002L,4194281L,2L,23L,4070L,9L,36L,268435427L,51L,1073741793L,8L,991L,65502L,29L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073331Inst : IEnumerable<long>
{
public static readonly long[] Value=A073331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073331.Bytes);
public long this[int i]=>Value[i];

public static A073331Inst Instance=new A073331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073330
{
public static readonly long[] Value={ 7L,2L,6L,8L,18L,8L,14L,3L,5L,7L,9L,7L,9L,9L,17L,19L,23L,19L,31L,9L,13L,15L,17L,15L,17L,4L,6L,4L,22L,6L,10L,8L,14L,8L,12L,10L,12L,8L,10L,8L,10L,10L,14L,10L,14L,10L,16L,18L,22L,18L,20L,20L,22L,24L,26L,24L,28L,20L,30L,32L,36L,32L,36L,10L,12L,14L,16L,14L,16L,16L,20L,16L,22L,18L,22L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073330Inst : IEnumerable<long>
{
public static readonly long[] Value=A073330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073330.Bytes);
public long this[int i]=>Value[i];

public static A073330Inst Instance=new A073330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073329
{
public static readonly BigInteger[] Value={ 2L,10L,60L,420L,4290L,53130L,903210L,17687670L,406816410L,11125544430L,338431883790L,11833068917670L,457077357006270L,20384767656323070L,955041577211912190L,BigInteger.Parse("49230430891074322890"),BigInteger.Parse("2740956243836856315270") };
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
public class A073329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073329Inst Instance=new A073329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073328
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,14L,15L,20L,21L,22L,28L,30L,33L,35L,40L,42L,44L,55L,56L,60L,63L,66L,70L,77L,84L,88L,99L,101L,105L,110L,112L,120L,126L,131L,132L,140L,151L,154L,165L,168L,176L,181L,191L,198L,202L,210L,220L,231L,252L,262L,264L,275L,280L,297L,302L,303L,308L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073328Inst : IEnumerable<long>
{
public static readonly long[] Value=A073328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073328.Bytes);
public long this[int i]=>Value[i];

public static A073328Inst Instance=new A073328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073327
{
public static readonly long[] Value={ 64L,34L,58L,56L,60L,42L,52L,65L,49L,42L,39L,63L,87L,99L,104L,65L,96L,109L,73L,86L,107L,141L,165L,163L,167L,149L,159L,172L,156L,149L,100L,134L,158L,156L,160L,142L,152L,165L,149L,142L,84L,118L,142L,140L,144L,126L,136L,149L,133L,126L,66L,100L,124L,122L,126L,108L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073327Inst : IEnumerable<long>
{
public static readonly long[] Value=A073327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073327.Bytes);
public long this[int i]=>Value[i];

public static A073327Inst Instance=new A073327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073326
{
public static readonly long[] Value={ 6L,67L,9L,10L,13L,96L,15L,16L,74L,73L,32L,85L,31L,4086L,228L,611L,28L,30L,44L,616L,263L,617L,43L,4090L,47L,633L,241L,631L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073326Inst : IEnumerable<long>
{
public static readonly long[] Value=A073326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073326.Bytes);
public long this[int i]=>Value[i];

public static A073326Inst Instance=new A073326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073325
{
public static readonly long[] Value={ 1L,2L,3L,4L,75L,9L,79L,18L,17L,10L,19L,20L,91L,22L,23L,41L,83L,24L,16049L,43L,2711L,94L,25L,26L,95L,198L,449L,452L,99L,50L,451L,48L,453L,1072L,447L,54L,16043L,55L,2719L,56L,459L,57L,101L,472L,100371L,62L,105L,102L,103L,104L,467L,110L,107L,65L,109L,63L,115L,118L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073325Inst : IEnumerable<long>
{
public static readonly long[] Value=A073325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073325.Bytes);
public long this[int i]=>Value[i];

public static A073325Inst Instance=new A073325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073324
{
public static readonly long[] Value={ 5L,1L,2L,8L,3L,242L,4L,245L,100L,8313L,10L,50190L,23L,8338L,3390L,12L,24L,308926L,13L,49L,25L,15L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073324Inst : IEnumerable<long>
{
public static readonly long[] Value=A073324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073324.Bytes);
public long this[int i]=>Value[i];

public static A073324Inst Instance=new A073324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073323
{
public static readonly long[] Value={ 0L,0L,4L,1L,29L,153L,4913L,73114L,1985627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073323Inst : IEnumerable<long>
{
public static readonly long[] Value=A073323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073323.Bytes);
public long this[int i]=>Value[i];

public static A073323Inst Instance=new A073323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073322
{
public static readonly long[] Value={ 3L,4L,3L,3L,4L,4L,4L,4L,3L,3L,4L,4L,3L,3L,4L,4L,3L,4L,4L,4L,4L,4L,3L,3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,4L,5L,4L,4L,3L,4L,4L,5L,4L,4L,3L,4L,4L,4L,3L,3L,4L,4L,4L,5L,4L,4L,5L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,4L,4L,5L,4L,4L,4L,5L,4L,4L,3L,3L,3L,4L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073322Inst : IEnumerable<long>
{
public static readonly long[] Value=A073322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073322.Bytes);
public long this[int i]=>Value[i];

public static A073322Inst Instance=new A073322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073321
{
public static readonly long[] Value={ 4L,4L,3L,4L,4L,3L,3L,4L,3L,5L,3L,4L,3L,5L,3L,4L,4L,4L,4L,3L,4L,5L,5L,3L,4L,4L,3L,4L,3L,3L,4L,4L,4L,5L,5L,4L,4L,3L,4L,3L,5L,4L,4L,4L,4L,4L,4L,5L,4L,4L,4L,4L,3L,5L,4L,3L,5L,4L,3L,4L,5L,4L,5L,4L,4L,4L,4L,4L,4L,5L,4L,4L,4L,6L,4L,4L,4L,5L,4L,4L,4L,4L,4L,4L,3L,4L,4L,4L,4L,4L,5L,4L,4L,6L,4L,4L,4L,4L,4L,5L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073321Inst : IEnumerable<long>
{
public static readonly long[] Value=A073321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073321.Bytes);
public long this[int i]=>Value[i];

public static A073321Inst Instance=new A073321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073320
{
public static readonly long[] Value={ 4L,5L,8L,9L,13L,16L,17L,18L,22L,23L,24L,27L,31L,35L,36L,40L,41L,46L,47L,56L,64L,69L,70L,71L,89L,90L,91L,92L,93L,94L,95L,103L,109L,110L,111L,112L,113L,146L,147L,161L,162L,163L,171L,172L,173L,174L,196L,240L,241L,242L,243L,261L,262L,263L,277L,438L,439L,440L,1137L,1138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073320Inst : IEnumerable<long>
{
public static readonly long[] Value=A073320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073320.Bytes);
public long this[int i]=>Value[i];

public static A073320Inst Instance=new A073320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073319
{
public static readonly long[] Value={ 19L,23L,29L,31L,37L,43L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073319Inst : IEnumerable<long>
{
public static readonly long[] Value=A073319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073319.Bytes);
public long this[int i]=>Value[i];

public static A073319Inst Instance=new A073319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073318
{
public static readonly long[] Value={ 0L,-1L,-2L,-3L,-6L,-4L,-10L,-13L,-26L,-14L,-183L,-15L,-22L,-57L,-210L,-211L,-1730L,-58L,25160L,-240L,-3356L,-949L,238031L,-241L,-256823L,-3918L,-143243L,-3919L,46326924L,-242L,281620682L,-61817L,-639769L,-61818L,-4718174L,-4415L,2023569890L,-224436L,-7556927L,-63639L,-43279525745L,-4416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073318Inst : IEnumerable<long>
{
public static readonly long[] Value=A073318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073318.Bytes);
public long this[int i]=>Value[i];

public static A073318Inst Instance=new A073318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073317
{
public static readonly long[] Value={ 2L,3L,6L,7L,22L,8L,74L,29L,90L,30L,1207L,31L,4118L,121L,466L,467L,67266L,122L,236984L,496L,7452L,1973L,3956273L,497L,1305399L,8014L,405387L,8015L,222108532L,498L,792121142L,127353L,1688345L,127354L,21495390L,8511L,66695906846L,486580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073317Inst : IEnumerable<long>
{
public static readonly long[] Value=A073317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073317.Bytes);
public long this[int i]=>Value[i];

public static A073317Inst Instance=new A073317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073316
{
public static readonly long[] Value={ 1L,1L,5L,3L,5L,5L,3L,5L,11L,9L,17L,15L,13L,17L,15L,13L,11L,23L,21L,19L,23L,21L,23L,21L,19L,17L,15L,13L,23L,21L,19L,17L,15L,13L,29L,29L,27L,25L,23L,21L,19L,17L,15L,23L,21L,19L,17L,15L,13L,29L,35L,33L,31L,41L,39L,53L,51L,49L,47L,45L,43L,41L,39L,37L,35L,33L,31L,35L,33L,31L,29L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073316Inst : IEnumerable<long>
{
public static readonly long[] Value=A073316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073316.Bytes);
public long this[int i]=>Value[i];

public static A073316Inst Instance=new A073316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073315
{
public static readonly long[] Value={ 1L,1L,2L,2L,9L,6L,6L,44L,72L,24L,24L,250L,700L,600L,120L,120L,1644L,6750L,10200L,5400L,720L,720L,12348L,68208L,154350L,147000L,52920L,5040L,5040L,104544L,735392L,2274384L,3292800L,2163840L,564480L,40320L,40320L,986256L,8504928L,33911136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073315Inst : IEnumerable<long>
{
public static readonly long[] Value=A073315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073315.Bytes);
public long this[int i]=>Value[i];

public static A073315Inst Instance=new A073315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073314
{
public static readonly long[] Value={ 3L,2L,4L,2L,0L,-8L,-20L,-40L,-64L,-88L,-96L,-64L,48L,288L,704L,1312L,2048L,2688L,2752L,1408L,-2560L,-10624L,-24064L,-43008L,-64768L,-81408L,-76800L,-24064L,114688L,382976L,814080L,1398784L,2031616L,2435072L,2072576L,81920L,-4706304L,-13557760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073314Inst : IEnumerable<long>
{
public static readonly long[] Value=A073314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073314.Bytes);
public long this[int i]=>Value[i];

public static A073314Inst Instance=new A073314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073313
{
public static readonly long[] Value={ 3L,4L,8L,22L,64L,184L,524L,1488L,4224L,11992L,34048L,96672L,274480L,779328L,2212736L,6282592L,17838080L,50647424L,143802560L,408296704L,1159271424L,3291504000L,9345523712L,26534621696L,75339399936L,213910160384L,607352285184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073313Inst : IEnumerable<long>
{
public static readonly long[] Value=A073313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073313.Bytes);
public long this[int i]=>Value[i];

public static A073313Inst Instance=new A073313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073312
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,2L,1L,3L,0L,4L,1L,2L,1L,5L,0L,6L,1L,4L,1L,7L,0L,7L,2L,5L,3L,11L,0L,11L,3L,7L,3L,9L,1L,13L,3L,7L,2L,14L,1L,14L,3L,6L,4L,16L,1L,16L,3L,11L,5L,20L,2L,15L,4L,13L,5L,22L,1L,23L,5L,10L,6L,18L,2L,25L,6L,15L,2L,26L,2L,27L,6L,11L,7L,24L,2L,29L,4L,17L,8L,31L,1L,23L,8L,17L,8L,33L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073312Inst : IEnumerable<long>
{
public static readonly long[] Value=A073312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073312.Bytes);
public long this[int i]=>Value[i];

public static A073312Inst Instance=new A073312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073311
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,5L,4L,4L,3L,7L,4L,8L,5L,6L,7L,11L,6L,12L,7L,8L,9L,15L,8L,13L,10L,13L,9L,17L,8L,19L,13L,13L,13L,15L,11L,23L,15L,17L,14L,26L,11L,28L,17L,18L,18L,30L,15L,26L,17L,21L,19L,32L,16L,25L,20L,23L,23L,36L,15L,37L,25L,26L,26L,30L,18L,41L,26L,29L,22L,44L,22L,45L,30L,29L,29L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073311Inst : IEnumerable<long>
{
public static readonly long[] Value=A073311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073311.Bytes);
public long this[int i]=>Value[i];

public static A073311Inst Instance=new A073311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073310
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,5L,3L,1L,1L,5L,3L,1L,3L,1L,1L,3L,1L,5L,3L,1L,5L,3L,1L,1L,5L,3L,1L,3L,1L,1L,5L,3L,1L,3L,1L,5L,3L,1L,11L,5L,3L,1L,3L,1L,1L,3L,1L,1L,3L,1L,17L,11L,9L,11L,5L,3L,1L,3L,1L,5L,3L,1L,1L,9L,9L,5L,3L,1L,1L,5L,3L,1L,5L,3L,1L,3L,1L,5L,3L,1L,5L,3L,1L,1L,9L,9L,5L,3L,1L,1L,3L,1L,1L,11L,9L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073310Inst : IEnumerable<long>
{
public static readonly long[] Value=A073310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073310.Bytes);
public long this[int i]=>Value[i];

public static A073310Inst Instance=new A073310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073309
{
public static readonly BigInteger[] Value={ 2L,3L,5L,29L,727L,3628811L,BigInteger.Parse("80658175170943878571660636856403766975289505440883277824000000000053") };
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
public class A073309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073309Inst Instance=new A073309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073308
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,52L,6822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073308Inst : IEnumerable<long>
{
public static readonly long[] Value=A073308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073308.Bytes);
public long this[int i]=>Value[i];

public static A073308Inst Instance=new A073308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073307
{
public static readonly long[] Value={ 1L,2L,8L,18L,45L,128L,486L,1215L,1701L,2673L,3750L,5000L,8750L,13122L,13125L,13750L,16250L,16875L,20625L,21250L,23750L,24375L,31875L,32768L,32805L,35625L,45927L,48125L,56875L,72171L,74375L,83125L,85293L,89375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073307Inst : IEnumerable<long>
{
public static readonly long[] Value=A073307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073307.Bytes);
public long this[int i]=>Value[i];

public static A073307Inst Instance=new A073307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073306
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,10L,105L,1260L,48510L,2162160L,312161850L,52562109600L,28836887379300L,18539497049673600L,BigInteger.Parse("38989721014029185400"),BigInteger.Parse("96410946507417622080000"),BigInteger.Parse("782067521015701609508820000") };
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
public class A073306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073306Inst Instance=new A073306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073305
{
public static readonly long[] Value={ 366L,335L,306L,275L,245L,214L,184L,153L,122L,92L,61L,31L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073305Inst : IEnumerable<long>
{
public static readonly long[] Value=A073305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073305.Bytes);
public long this[int i]=>Value[i];

public static A073305Inst Instance=new A073305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073304
{
public static readonly long[] Value={ 365L,334L,306L,275L,245L,214L,184L,153L,122L,92L,61L,31L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073304Inst : IEnumerable<long>
{
public static readonly long[] Value=A073304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073304.Bytes);
public long this[int i]=>Value[i];

public static A073304Inst Instance=new A073304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073303
{
public static readonly long[] Value={ 0L,4L,6L,8L,9L,10L,13L,15L,16L,17L,21L,24L,25L,27L,28L,29L,31L,33L,39L,43L,46L,47L,48L,51L,53L,56L,61L,63L,64L,66L,73L,76L,83L,86L,89L,90L,91L,93L,96L,99L,102L,109L,111L,112L,114L,115L,120L,123L,130L,131L,133L,135L,136L,137L,139L,140L,141L,142L,143L,149L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073303Inst : IEnumerable<long>
{
public static readonly long[] Value=A073303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073303.Bytes);
public long this[int i]=>Value[i];

public static A073303Inst Instance=new A073303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073302
{
public static readonly long[] Value={ 0L,1L,4L,8L,11L,15L,16L,17L,18L,19L,22L,24L,26L,28L,29L,30L,33L,36L,37L,38L,39L,40L,42L,45L,50L,52L,53L,60L,62L,63L,64L,65L,68L,71L,73L,74L,75L,76L,78L,79L,82L,83L,85L,87L,89L,91L,92L,93L,98L,99L,101L,102L,106L,110L,111L,114L,116L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073302Inst : IEnumerable<long>
{
public static readonly long[] Value=A073302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073302.Bytes);
public long this[int i]=>Value[i];

public static A073302Inst Instance=new A073302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073301
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,12L,17L,19L,29L,41L,46L,70L,99L,111L,169L,239L,268L,408L,577L,647L,985L,1393L,1562L,2378L,3363L,3771L,5741L,8119L,9104L,13860L,19601L,21979L,33461L,47321L,53062L,80782L,114243L,128103L,195025L,275807L,309268L,470832L,665857L,746639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073301Inst : IEnumerable<long>
{
public static readonly long[] Value=A073301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073301.Bytes);
public long this[int i]=>Value[i];

public static A073301Inst Instance=new A073301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073300
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,3L,5L,1L,2L,3L,1L,3L,5L,1L,4L,7L,2L,3L,4L,2L,5L,8L,2L,7L,12L,1L,2L,3L,1L,3L,5L,1L,4L,7L,2L,3L,4L,2L,5L,8L,2L,7L,12L,3L,4L,5L,3L,7L,11L,3L,10L,17L,1L,3L,5L,1L,4L,7L,1L,5L,9L,3L,5L,7L,3L,8L,13L,3L,11L,19L,5L,7L,9L,5L,12L,19L,5L,17L,29L,1L,2L,3L,1L,3L,5L,1L,4L,7L,2L,3L,4L,2L,5L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073300Inst : IEnumerable<long>
{
public static readonly long[] Value=A073300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073300.Bytes);
public long this[int i]=>Value[i];

public static A073300Inst Instance=new A073300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073283
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,5L,4L,22L,21L,19L,15L,14L,20L,16L,18L,13L,12L,17L,11L,10L,9L,64L,63L,62L,59L,58L,60L,56L,52L,41L,40L,51L,39L,38L,37L,61L,57L,53L,43L,42L,55L,47L,50L,36L,35L,49L,34L,32L,31L,54L,44L,48L,33L,30L,46L,29L,27L,26L,45L,28L,25L,24L,23L,196L,195L,194L,190L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073283Inst : IEnumerable<long>
{
public static readonly long[] Value=A073283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073283.Bytes);
public long this[int i]=>Value[i];

public static A073283Inst Instance=new A073283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073282
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,6L,4L,22L,21L,20L,18L,17L,13L,12L,15L,19L,16L,11L,14L,10L,9L,64L,63L,62L,59L,58L,61L,57L,55L,50L,49L,54L,48L,46L,45L,36L,35L,34L,32L,31L,41L,40L,52L,60L,56L,43L,53L,47L,44L,33L,30L,39L,51L,42L,29L,38L,27L,26L,28L,37L,25L,24L,23L,196L,195L,194L,190L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073282Inst : IEnumerable<long>
{
public static readonly long[] Value=A073282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073282.Bytes);
public long this[int i]=>Value[i];

public static A073282Inst Instance=new A073282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073281
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,5L,8L,4L,6L,17L,18L,12L,11L,15L,20L,13L,21L,9L,10L,22L,14L,16L,19L,45L,46L,48L,49L,50L,31L,32L,30L,28L,29L,40L,39L,43L,52L,54L,55L,34L,33L,41L,57L,35L,58L,23L,24L,59L,25L,26L,27L,61L,36L,62L,37L,38L,63L,42L,44L,47L,64L,51L,53L,56L,60L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073281Inst : IEnumerable<long>
{
public static readonly long[] Value=A073281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073281.Bytes);
public long this[int i]=>Value[i];

public static A073281Inst Instance=new A073281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073280
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,8L,7L,13L,12L,11L,10L,9L,15L,14L,19L,22L,21L,16L,20L,18L,17L,36L,35L,34L,32L,31L,33L,30L,29L,27L,26L,28L,25L,24L,23L,41L,40L,39L,38L,37L,52L,51L,60L,64L,63L,56L,62L,59L,58L,43L,42L,53L,61L,57L,47L,55L,50L,49L,44L,54L,48L,46L,45L,106L,105L,104L,101L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073280Inst : IEnumerable<long>
{
public static readonly long[] Value=A073280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073280.Bytes);
public long this[int i]=>Value[i];

public static A073280Inst Instance=new A073280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073279
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,34L,250L,2058L,18661L,185695L,2017527L,23804069L,303413813L,4157895295L,60989187252L,953766105164L,15844435971349L,278704524938621L,5175632136205088L,101198102131888304L,2078318050691940125L,BigInteger.Parse("44731639502987747576"),BigInteger.Parse("1006917859088311808499") };
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
public class A073279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073279Inst Instance=new A073279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073278
{
public static readonly long[] Value={ 1L,-1L,0L,1L,0L,-1L,-1L,0L,3L,0L,1L,0L,-6L,0L,3L,-1L,0L,10L,0L,-15L,0L,1L,0L,-15L,0L,45L,0L,-15L,-1L,0L,21L,0L,-105L,0L,105L,0L,1L,0L,-28L,0L,210L,0L,-420L,0L,105L,-1L,0L,36L,0L,-378L,0L,1260L,0L,-945L,0L,1L,0L,-45L,0L,630L,0L,-3150L,0L,4725L,0L,-945L,-1L,0L,55L,0L,-990L,0L,6930L,0L,-17325L,0L,10395L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073278Inst : IEnumerable<long>
{
public static readonly long[] Value=A073278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073278.Bytes);
public long this[int i]=>Value[i];

public static A073278Inst Instance=new A073278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073277
{
public static readonly long[] Value={ 157L,353L,379L,467L,547L,587L,631L,673L,691L,809L,929L,1291L,1297L,1307L,1663L,1669L,1733L,1789L,1933L,1997L,2003L,2087L,2273L,2309L,2371L,2383L,2423L,2441L,2591L,2671L,2789L,2909L,2957L,3391L,3407L,3511L,3517L,3533L,3539L,3559L,3593L,3617L,3637L,3851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073277Inst : IEnumerable<long>
{
public static readonly long[] Value=A073277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073277.Bytes);
public long this[int i]=>Value[i];

public static A073277Inst Instance=new A073277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073276
{
public static readonly long[] Value={ 37L,59L,67L,101L,103L,131L,149L,233L,257L,263L,271L,283L,293L,307L,311L,347L,389L,401L,409L,421L,433L,461L,463L,523L,541L,557L,577L,593L,607L,613L,619L,653L,659L,677L,683L,727L,751L,757L,761L,773L,797L,811L,821L,827L,839L,877L,881L,887L,953L,971L,1061L,1091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073276Inst : IEnumerable<long>
{
public static readonly long[] Value=A073276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073276.Bytes);
public long this[int i]=>Value[i];

public static A073276Inst Instance=new A073276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073275
{
public static readonly long[] Value={ 4L,3L,0L,0L,0L,0L,8L,10L,11L,14L,19L,20L,25L,28L,29L,32L,37L,42L,43L,48L,51L,52L,57L,60L,65L,72L,75L,76L,79L,80L,83L,96L,99L,104L,105L,114L,115L,120L,125L,128L,133L,138L,139L,148L,149L,152L,153L,164L,175L,178L,179L,182L,187L,188L,197L,202L,207L,212L,213L,218L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073275Inst : IEnumerable<long>
{
public static readonly long[] Value=A073275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073275.Bytes);
public long this[int i]=>Value[i];

public static A073275Inst Instance=new A073275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073274
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,2L,0L,0L,3L,-1L,2L,2L,0L,0L,1L,3L,-1L,2L,2L,-1L,2L,0L,0L,3L,2L,0L,2L,0L,-4L,6L,0L,3L,-3L,5L,-1L,1L,2L,0L,1L,3L,-3L,5L,0L,2L,-4L,1L,5L,2L,0L,0L,3L,-3L,3L,1L,1L,3L,-1L,2L,2L,-3L,-1L,6L,2L,0L,-4L,5L,-1L,5L,0L,0L,0L,2L,1L,2L,0L,0L,3L,-1L,0L,5L,-3L,5L,-1L,2L,0L,0L,3L,2L,0L,-3L,3L,3L,-1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073274Inst : IEnumerable<long>
{
public static readonly long[] Value=A073274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073274.Bytes);
public long this[int i]=>Value[i];

public static A073274Inst Instance=new A073274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073273
{
public static readonly long[] Value={ 3L,4L,7L,9L,13L,15L,19L,23L,26L,32L,35L,39L,43L,47L,52L,56L,62L,65L,69L,74L,77L,83L,89L,94L,99L,103L,105L,109L,117L,121L,131L,134L,142L,144L,152L,156L,161L,167L,172L,176L,184L,186L,193L,195L,203L,210L,218L,225L,229L,233L,236L,244L,248L,256L,262L,266L,272L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073273Inst : IEnumerable<long>
{
public static readonly long[] Value=A073273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073273.Bytes);
public long this[int i]=>Value[i];

public static A073273Inst Instance=new A073273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073272
{
public static readonly long[] Value={ 0L,1L,0L,3L,-1L,3L,-1L,0L,5L,-3L,3L,3L,-1L,-1L,1L,5L,-3L,3L,3L,-3L,3L,-1L,-1L,5L,3L,-1L,3L,-1L,-9L,11L,-1L,5L,-7L,9L,-3L,1L,3L,-1L,1L,5L,-7L,9L,-1L,3L,-9L,1L,9L,3L,-1L,-1L,5L,-7L,5L,1L,1L,5L,-3L,3L,3L,-7L,-3L,11L,3L,-1L,-9L,9L,-3L,9L,-1L,-1L,-1L,3L,1L,3L,-1L,-1L,5L,-3L,-1L,9L,-7L,9L,-3L,3L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073272Inst : IEnumerable<long>
{
public static readonly long[] Value=A073272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073272.Bytes);
public long this[int i]=>Value[i];

public static A073272Inst Instance=new A073272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073271
{
public static readonly long[] Value={ 3L,4L,7L,8L,14L,14L,20L,23L,24L,34L,34L,38L,44L,48L,52L,54L,64L,64L,68L,76L,76L,84L,90L,92L,98L,104L,104L,110L,122L,116L,132L,132L,146L,140L,154L,156L,160L,168L,172L,174L,188L,182L,194L,194L,208L,210L,214L,224L,230L,234L,234L,248L,246L,256L,262L,264L,274L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073271Inst : IEnumerable<long>
{
public static readonly long[] Value=A073271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073271.Bytes);
public long this[int i]=>Value[i];

public static A073271Inst Instance=new A073271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073270
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,4L,6L,17L,18L,20L,21L,22L,12L,13L,11L,9L,10L,15L,14L,16L,19L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,31L,32L,34L,35L,36L,30L,33L,28L,23L,24L,29L,25L,26L,27L,40L,41L,39L,37L,38L,43L,42L,44L,47L,52L,51L,53L,56L,60L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073270Inst : IEnumerable<long>
{
public static readonly long[] Value=A073270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073270.Bytes);
public long this[int i]=>Value[i];

public static A073270Inst Instance=new A073270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073269
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,4L,5L,17L,18L,16L,14L,15L,20L,19L,21L,9L,10L,22L,11L,12L,13L,45L,46L,48L,49L,50L,44L,47L,42L,37L,38L,43L,39L,40L,41L,54L,55L,53L,51L,52L,57L,56L,58L,23L,24L,59L,25L,26L,27L,61L,60L,62L,28L,29L,63L,30L,31L,32L,64L,33L,34L,35L,36L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073269Inst : IEnumerable<long>
{
public static readonly long[] Value=A073269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073269.Bytes);
public long this[int i]=>Value[i];

public static A073269Inst Instance=new A073269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073268
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,20L,58L,179L,576L,1902L,6426L,22092L,77026L,271702L,967840L,3476555L,12578728L,45800278L,167693698L,617037126L,2280467586L,8461771342L,31510700712L,117725789124L,441141656810L,1657559677646L,6243810767912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073268Inst : IEnumerable<long>
{
public static readonly long[] Value=A073268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073268.Bytes);
public long this[int i]=>Value[i];

public static A073268Inst Instance=new A073268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073267
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,2L,0L,1L,2L,2L,0L,2L,0L,0L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073267Inst : IEnumerable<long>
{
public static readonly long[] Value=A073267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073267.Bytes);
public long this[int i]=>Value[i];

public static A073267Inst Instance=new A073267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073266
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,1L,1L,3L,1L,0L,2L,3L,4L,1L,0L,2L,4L,6L,5L,1L,0L,0L,6L,8L,10L,6L,1L,1L,1L,3L,13L,15L,15L,7L,1L,0L,2L,3L,12L,25L,26L,21L,8L,1L,0L,2L,6L,10L,31L,45L,42L,28L,9L,1L,0L,0L,6L,16L,30L,66L,77L,64L,36L,10L,1L,0L,2L,4L,18L,40L,76L,126L,126L,93L,45L,11L,1L,0L,0L,6L,16L,50L,96L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073266Inst : IEnumerable<long>
{
public static readonly long[] Value=A073266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073266.Bytes);
public long this[int i]=>Value[i];

public static A073266Inst Instance=new A073266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073265
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,1L,0L,0L,0L,2L,3L,0L,0L,0L,0L,2L,3L,1L,0L,0L,0L,1L,0L,4L,4L,0L,0L,0L,0L,0L,1L,6L,6L,1L,0L,0L,0L,0L,0L,2L,3L,8L,5L,0L,0L,0L,0L,0L,0L,2L,3L,13L,10L,1L,0L,0L,0L,0L,0L,0L,0L,6L,12L,15L,6L,0L,0L,0L,0L,0L,0L,0L,2L,6L,10L,25L,15L,1L,0L,0L,0L,0L,0L,0L,0L,0L,4L,16L,31L,26L,7L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073265Inst : IEnumerable<long>
{
public static readonly long[] Value=A073265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073265.Bytes);
public long this[int i]=>Value[i];

public static A073265Inst Instance=new A073265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073264
{
public static readonly long[] Value={ 3L,5L,2L,5L,3L,5L,7L,3L,2L,3L,2L,3L,3L,3L,2L,7L,5L,2L,7L,3L,3L,7L,5L,5L,2L,7L,5L,2L,3L,7L,2L,2L,2L,3L,2L,5L,3L,2L,7L,7L,2L,5L,3L,2L,2L,3L,7L,3L,5L,5L,5L,2L,2L,3L,7L,2L,5L,3L,5L,2L,7L,5L,2L,2L,7L,3L,5L,2L,5L,5L,5L,2L,2L,5L,3L,3L,2L,7L,5L,5L,3L,3L,2L,7L,5L,2L,3L,3L,7L,7L,3L,5L,2L,7L,2L,5L,5L,2L,3L,3L,5L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073264Inst : IEnumerable<long>
{
public static readonly long[] Value=A073264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073264.Bytes);
public long this[int i]=>Value[i];

public static A073264Inst Instance=new A073264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073263
{
public static readonly long[] Value={ 4L,5L,6L,9L,12L,52L,75L,80L,95L,105L,422L,1002L,2841L,12165L,16944L,170997L,430041L,5844984L,11095683L,71438394L,86938085L,485470043L,3341061731L,11203279551L,25053055391L,29329179630L,150058180590L,278953774325L,771115150044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073263Inst : IEnumerable<long>
{
public static readonly long[] Value=A073263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073263.Bytes);
public long this[int i]=>Value[i];

public static A073263Inst Instance=new A073263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073262
{
public static readonly long[] Value={ 4L,10L,18L,63L,132L,3692L,8025L,9200L,13205L,16275L,287382L,1674342L,13852716L,261109560L,509099424L,53226407187L,339194408709L,63673280091408L,230160748303410L,9613333448250222L,14247374595414090L,446710602178803172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073262Inst : IEnumerable<long>
{
public static readonly long[] Value=A073262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073262.Bytes);
public long this[int i]=>Value[i];

public static A073262Inst Instance=new A073262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073261
{
public static readonly long[] Value={ 4L,4L,3L,3L,3L,4L,3L,5L,4L,4L,5L,4L,5L,6L,6L,6L,6L,5L,6L,6L,7L,6L,6L,6L,7L,7L,8L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073261Inst : IEnumerable<long>
{
public static readonly long[] Value=A073261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073261.Bytes);
public long this[int i]=>Value[i];

public static A073261Inst Instance=new A073261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073260
{
public static readonly long[] Value={ 4L,4L,4L,5L,5L,6L,7L,7L,7L,8L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073260Inst : IEnumerable<long>
{
public static readonly long[] Value=A073260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073260.Bytes);
public long this[int i]=>Value[i];

public static A073260Inst Instance=new A073260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073259
{
public static readonly long[] Value={ 4L,4L,4L,3L,3L,4L,4L,3L,3L,4L,4L,4L,3L,4L,4L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,3L,4L,5L,4L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,4L,5L,4L,4L,3L,3L,4L,4L,4L,4L,5L,4L,4L,4L,3L,4L,4L,4L,5L,4L,4L,4L,3L,4L,4L,4L,4L,3L,3L,3L,4L,4L,4L,4L,5L,4L,4L,5L,5L,4L,4L,5L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,5L,4L,4L,4L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073259Inst : IEnumerable<long>
{
public static readonly long[] Value=A073259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073259.Bytes);
public long this[int i]=>Value[i];

public static A073259Inst Instance=new A073259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073258
{
public static readonly long[] Value={ 1L,3L,4L,8L,9L,11L,13L,17L,19L,23L,25L,27L,29L,31L,33L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,53L,57L,58L,59L,61L,66L,67L,68L,69L,71L,73L,79L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,94L,95L,97L,100L,101L,103L,106L,107L,108L,109L,111L,113L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073258Inst : IEnumerable<long>
{
public static readonly long[] Value=A073258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073258.Bytes);
public long this[int i]=>Value[i];

public static A073258Inst Instance=new A073258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073257
{
public static readonly long[] Value={ 1L,2L,12L,20L,5L,6L,7L,64L,234L,50L,55L,24L,26L,28L,30L,32L,629L,1008L,209L,220L,231L,1012L,506L,168L,425L,182L,189L,2716L,2204L,1080L,93L,96L,99L,2176L,105L,4428L,1369L,5586L,1755L,1800L,6109L,2478L,2279L,3916L,5760L,644L,4606L,1920L,1960L,10250L,2040L,2444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073257Inst : IEnumerable<long>
{
public static readonly long[] Value=A073257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073257.Bytes);
public long this[int i]=>Value[i];

public static A073257Inst Instance=new A073257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073256
{
public static readonly long[] Value={ 2L,2L,4L,6L,4L,4L,6L,8L,8L,6L,8L,12L,10L,8L,20L,12L,18L,12L,8L,16L,20L,16L,24L,12L,18L,24L,16L,12L,20L,24L,22L,16L,42L,20L,32L,24L,18L,40L,24L,36L,28L,16L,30L,36L,32L,48L,20L,32L,44L,24L,24L,36L,40L,36L,60L,24L,32L,54L,40L,24L,64L,42L,56L,40L,24L,72L,44L,60L,46L,72L,32L,42L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073256Inst : IEnumerable<long>
{
public static readonly long[] Value=A073256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073256.Bytes);
public long this[int i]=>Value[i];

public static A073256Inst Instance=new A073256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073255
{
public static readonly long[] Value={ 7L,12L,15L,13L,18L,28L,24L,24L,31L,39L,42L,32L,36L,60L,31L,42L,40L,56L,72L,63L,48L,54L,48L,91L,60L,56L,90L,96L,84L,78L,72L,124L,57L,93L,72L,98L,120L,72L,120L,80L,90L,168L,96L,104L,127L,84L,144L,126L,96L,144L,195L,114L,124L,140L,96L,168L,186L,121L,126L,224L,108L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073255Inst : IEnumerable<long>
{
public static readonly long[] Value=A073255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073255.Bytes);
public long this[int i]=>Value[i];

public static A073255Inst Instance=new A073255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073254
{
public static readonly long[] Value={ 0L,1L,1L,4L,3L,4L,9L,7L,7L,9L,16L,13L,12L,13L,16L,25L,21L,19L,19L,21L,25L,36L,31L,28L,27L,28L,31L,36L,49L,43L,39L,37L,37L,39L,43L,49L,64L,57L,52L,49L,48L,49L,52L,57L,64L,81L,73L,67L,63L,61L,61L,63L,67L,73L,81L,100L,91L,84L,79L,76L,75L,76L,79L,84L,91L,100L,121L,111L,103L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073254Inst : IEnumerable<long>
{
public static readonly long[] Value=A073254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073254.Bytes);
public long this[int i]=>Value[i];

public static A073254Inst Instance=new A073254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073253
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,0L,2L,2L,0L,0L,0L,0L,1L,3L,1L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,0L,2L,5L,2L,0L,0L,0L,0L,0L,0L,1L,5L,5L,1L,0L,0L,0L,0L,0L,0L,0L,3L,7L,3L,0L,0L,0L,0L,0L,0L,0L,0L,1L,7L,7L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,11L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,11L,11L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073253Inst : IEnumerable<long>
{
public static readonly long[] Value=A073253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073253.Bytes);
public long this[int i]=>Value[i];

public static A073253Inst Instance=new A073253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073252
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,4L,5L,6L,9L,12L,13L,16L,21L,26L,29L,36L,46L,54L,62L,74L,90L,106L,122L,142L,171L,200L,227L,264L,311L,358L,408L,470L,545L,626L,709L,810L,933L,1062L,1198L,1362L,1555L,1760L,1980L,2238L,2536L,2858L,3205L,3602L,4063L,4560L,5092L,5704L,6400L,7150L,7966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073252Inst : IEnumerable<long>
{
public static readonly long[] Value=A073252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073252.Bytes);
public long this[int i]=>Value[i];

public static A073252Inst Instance=new A073252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073251
{
public static readonly long[] Value={ 33L,85L,93L,141L,185L,201L,213L,217L,253L,265L,285L,301L,321L,393L,445L,453L,469L,481L,517L,533L,553L,581L,589L,609L,633L,669L,697L,705L,713L,753L,777L,789L,793L,805L,813L,869L,893L,897L,901L,913L,921L,933L,957L,985L,993L,1001L,1005L,1041L,1045L,1065L,1113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073251Inst : IEnumerable<long>
{
public static readonly long[] Value=A073251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073251.Bytes);
public long this[int i]=>Value[i];

public static A073251Inst Instance=new A073251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073250
{
public static readonly long[] Value={ 14L,21L,38L,57L,65L,69L,77L,105L,110L,114L,118L,122L,129L,133L,145L,154L,158L,165L,177L,182L,194L,205L,209L,221L,230L,237L,246L,258L,273L,290L,298L,309L,318L,326L,329L,334L,345L,354L,357L,365L,370L,381L,385L,390L,398L,402L,406L,410L,417L,426L,429L,434L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073250Inst : IEnumerable<long>
{
public static readonly long[] Value=A073250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073250.Bytes);
public long this[int i]=>Value[i];

public static A073250Inst Instance=new A073250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073249
{
public static readonly long[] Value={ 1L,6L,10L,26L,30L,42L,46L,51L,55L,62L,74L,82L,91L,102L,138L,161L,170L,174L,190L,226L,235L,249L,262L,278L,282L,295L,305L,314L,339L,341L,362L,374L,377L,413L,415L,422L,442L,451L,458L,462L,478L,485L,489L,530L,551L,559L,570L,579L,586L,595L,602L,606L,618L,629L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073249Inst : IEnumerable<long>
{
public static readonly long[] Value=A073249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073249.Bytes);
public long this[int i]=>Value[i];

public static A073249Inst Instance=new A073249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073248
{
public static readonly long[] Value={ 10L,46L,61L,73L,82L,118L,122L,133L,145L,154L,173L,190L,205L,226L,246L,262L,273L,277L,290L,298L,313L,326L,334L,370L,373L,385L,406L,421L,426L,442L,457L,473L,478L,493L,505L,514L,526L,537L,565L,573L,586L,601L,606L,622L,626L,658L,673L,694L,709L,730L,733L,745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073248Inst : IEnumerable<long>
{
public static readonly long[] Value=A073248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073248.Bytes);
public long this[int i]=>Value[i];

public static A073248Inst Instance=new A073248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073247
{
public static readonly long[] Value={ 17L,19L,26L,51L,53L,55L,89L,91L,97L,127L,149L,151L,161L,163L,170L,197L,199L,233L,235L,241L,249L,251L,269L,271L,293L,295L,305L,307L,337L,339L,341L,349L,362L,377L,379L,413L,415L,449L,451L,485L,487L,489L,491L,521L,523L,530L,551L,557L,559L,577L,579L,593L,595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073247Inst : IEnumerable<long>
{
public static readonly long[] Value=A073247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073247.Bytes);
public long this[int i]=>Value[i];

public static A073247Inst Instance=new A073247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073246
{
public static readonly long[] Value={ 2L,7L,2L,2L,5L,5L,2L,3L,5L,3L,2L,7L,7L,3L,5L,2L,2L,7L,7L,5L,7L,2L,7L,3L,5L,5L,7L,7L,2L,7L,7L,2L,7L,3L,3L,5L,3L,5L,7L,5L,5L,7L,3L,2L,7L,5L,2L,5L,2L,7L,2L,7L,3L,3L,2L,3L,5L,2L,7L,3L,5L,2L,3L,5L,7L,2L,3L,3L,2L,5L,2L,5L,5L,3L,7L,3L,3L,2L,3L,2L,2L,7L,3L,7L,3L,2L,3L,3L,2L,7L,5L,3L,5L,2L,5L,5L,7L,3L,3L,7L,3L,7L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073246Inst : IEnumerable<long>
{
public static readonly long[] Value=A073246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073246.Bytes);
public long this[int i]=>Value[i];

public static A073246Inst Instance=new A073246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073245
{
public static readonly long[] Value={ 1L,6L,12L,30L,72L,56L,180L,132L,182L,336L,360L,306L,380L,672L,792L,552L,1092L,870L,2160L,992L,1584L,1836L,1680L,1406L,2280L,2184L,1722L,4032L,1892L,3312L,2256L,3672L,2862L,3960L,4560L,5220L,3540L,3782L,5952L,5460L,9504L,4556L,6624L,10080L,5112L,5402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073245Inst : IEnumerable<long>
{
public static readonly long[] Value=A073245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073245.Bytes);
public long this[int i]=>Value[i];

public static A073245Inst Instance=new A073245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073244
{
public static readonly long[] Value={ 4L,2L,3L,3L,1L,0L,8L,2L,5L,1L,3L,0L,7L,4L,8L,0L,0L,3L,1L,0L,2L,3L,5L,5L,9L,1L,1L,9L,2L,6L,8L,4L,0L,3L,8L,6L,4L,3L,9L,9L,2L,2L,3L,0L,5L,6L,7L,5L,1L,4L,6L,2L,4L,6L,0L,0L,7L,9L,7L,6L,9L,6L,4L,5L,8L,3L,7L,3L,9L,7L,7L,5L,9L,3L,2L,6L,6L,1L,4L,0L,4L,0L,5L,6L,6L,5L,2L,6L,4L,6L,8L,1L,6L,9L,5L,0L,6L,4L,0L,5L,5L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073244Inst : IEnumerable<long>
{
public static readonly long[] Value=A073244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073244.Bytes);
public long this[int i]=>Value[i];

public static A073244Inst Instance=new A073244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073243
{
public static readonly long[] Value={ 5L,3L,9L,3L,4L,3L,4L,9L,8L,8L,6L,2L,3L,0L,1L,2L,0L,8L,0L,6L,0L,7L,9L,5L,6L,8L,4L,4L,5L,5L,5L,9L,8L,4L,2L,0L,9L,8L,6L,4L,5L,5L,9L,7L,3L,2L,9L,4L,8L,4L,2L,6L,1L,1L,9L,4L,8L,8L,1L,5L,0L,1L,4L,8L,7L,0L,4L,6L,2L,7L,5L,4L,0L,1L,7L,4L,9L,0L,4L,5L,5L,5L,2L,8L,4L,1L,5L,2L,4L,2L,9L,3L,6L,8L,1L,7L,6L,7L,7L,3L,5L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073243Inst : IEnumerable<long>
{
public static readonly long[] Value=A073243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073243.Bytes);
public long this[int i]=>Value[i];

public static A073243Inst Instance=new A073243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073242
{
public static readonly long[] Value={ 8L,9L,0L,4L,8L,8L,2L,3L,5L,9L,2L,0L,3L,2L,7L,0L,6L,7L,0L,9L,1L,5L,2L,8L,6L,6L,4L,5L,6L,9L,4L,4L,2L,6L,7L,5L,5L,8L,4L,3L,5L,7L,6L,1L,7L,5L,8L,0L,0L,3L,9L,8L,3L,4L,3L,9L,4L,1L,4L,7L,3L,7L,1L,3L,0L,2L,4L,6L,6L,7L,6L,7L,9L,5L,2L,2L,3L,8L,4L,5L,5L,6L,9L,2L,0L,5L,6L,7L,8L,9L,3L,5L,9L,7L,5L,4L,9L,7L,4L,1L,5L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073242Inst : IEnumerable<long>
{
public static readonly long[] Value=A073242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073242.Bytes);
public long this[int i]=>Value[i];

public static A073242Inst Instance=new A073242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073241
{
public static readonly long[] Value={ 4L,5L,1L,5L,0L,8L,3L,4L,5L,5L,3L,6L,5L,7L,2L,8L,0L,5L,2L,2L,1L,9L,9L,3L,8L,1L,8L,0L,4L,4L,7L,3L,4L,0L,3L,6L,5L,4L,0L,9L,0L,2L,8L,0L,2L,6L,4L,5L,9L,7L,9L,7L,0L,5L,1L,8L,5L,4L,4L,2L,7L,3L,0L,0L,4L,1L,2L,5L,2L,6L,6L,9L,2L,7L,8L,9L,4L,8L,3L,4L,8L,2L,7L,7L,2L,5L,5L,0L,6L,0L,0L,3L,5L,5L,8L,4L,3L,1L,0L,8L,9L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073241Inst : IEnumerable<long>
{
public static readonly long[] Value=A073241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073241.Bytes);
public long this[int i]=>Value[i];

public static A073241Inst Instance=new A073241Inst();

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