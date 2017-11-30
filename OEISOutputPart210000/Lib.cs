using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A260662
{
public static readonly long[] Value={ 1L,2L,2L,2L,9L,4L,4L,2L,5L,1L,8L,0L,8L,1L,3L,3L,8L,7L,2L,6L,4L,7L,8L,9L,9L,9L,6L,0L,7L,2L,7L,7L,1L,7L,9L,8L,8L,5L,6L,1L,2L,6L,5L,8L,0L,3L,1L,2L,9L,5L,3L,2L,9L,5L,0L,1L,0L,8L,3L,7L,2L,8L,1L,0L,3L,4L,4L,6L,0L,6L,4L,2L,2L,7L,6L,8L,6L,6L,2L,0L,3L,0L,3L,0L,0L,1L,2L,6L,4L,2L,6L,9L,2L,1L,7L,5L,1L,1L,4L,2L,6L,1L,2L,4L,4L,9L,1L,8L,3L,6L,0L,0L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260662Inst : IEnumerable<long>
{
public static readonly long[] Value=A260662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260662.Bytes);
public long this[int i]=>Value[i];

public static A260662Inst Instance=new A260662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260663
{
public static readonly long[] Value={ 2L,0L,1L,2L,6L,1L,2L,7L,2L,5L,1L,6L,5L,6L,9L,3L,8L,0L,8L,6L,0L,2L,2L,2L,4L,6L,4L,7L,8L,7L,8L,1L,1L,2L,0L,5L,4L,9L,7L,4L,3L,3L,7L,9L,0L,9L,4L,8L,3L,8L,7L,7L,6L,9L,7L,6L,1L,1L,6L,0L,2L,6L,0L,3L,7L,3L,4L,0L,9L,1L,9L,6L,9L,4L,4L,6L,9L,4L,4L,5L,9L,1L,6L,6L,4L,3L,6L,9L,9L,3L,3L,3L,0L,9L,0L,2L,8L,8L,3L,0L,7L,3L,3L,2L,1L,8L,8L,5L,7L,5L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260663Inst : IEnumerable<long>
{
public static readonly long[] Value=A260663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260663.Bytes);
public long this[int i]=>Value[i];

public static A260663Inst Instance=new A260663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260664
{
public static readonly long[] Value={ 1L,0L,6L,18L,90L,192L,864L,1710L,5970L,13110L,36810L,75984L,210546L,410130L,1003908L,2045808L,4616730L,8950176L,19746720L,37297710L,78247344L,147410640L,294299424L,543058032L,1067679540L,1925323308L,3653769792L,6555529158L,12129597486L,21348640230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260664Inst : IEnumerable<long>
{
public static readonly long[] Value=A260664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260664.Bytes);
public long this[int i]=>Value[i];

public static A260664Inst Instance=new A260664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260665
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,15L,7L,1L,1L,52L,39L,13L,12L,2L,1L,1L,203L,211L,112L,103L,41L,24L,17L,5L,2L,1L,1L,877L,1168L,843L,811L,492L,337L,238L,122L,68L,39L,28L,8L,5L,2L,1L,1L,4140L,6728L,6089L,6273L,4851L,3798L,2956L,1960L,1303L,859L,594L,314L,204L,110L,64L,43L,17L,8L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260665Inst : IEnumerable<long>
{
public static readonly long[] Value=A260665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260665.Bytes);
public long this[int i]=>Value[i];

public static A260665Inst Instance=new A260665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260666
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,6L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260666Inst : IEnumerable<long>
{
public static readonly long[] Value=A260666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260666.Bytes);
public long this[int i]=>Value[i];

public static A260666Inst Instance=new A260666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260667
{
public static readonly BigInteger[] Value={ 1L,37L,1737L,102501L,6979833L,523680739L,42129659113L,3572184623653L,315561396741609L,28807571694394593L,2701627814373536601L,BigInteger.Parse("259121323945378645947"),BigInteger.Parse("25330657454041707496017"),BigInteger.Parse("2516984276442279642274311"),BigInteger.Parse("253667099464270541534450025"),BigInteger.Parse("25884030861250181046253181349"),BigInteger.Parse("2670255662315910532447096232073") };
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
public class A260667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260667Inst Instance=new A260667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260668
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,24L,45L,84L,158L,298L,566L,1079L,2066L,3966L,7635L,14730L,28484L,55188L,107130L,208294L,405594L,790812L,1543766L,3016923L,5901858L,11556244L,22647431L,44418613L,87182680L,171234318L,336532357L,661788956L,1302124526L,2563365624L,5048704640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260668Inst : IEnumerable<long>
{
public static readonly long[] Value=A260668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260668.Bytes);
public long this[int i]=>Value[i];

public static A260668Inst Instance=new A260668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260669
{
public static readonly long[] Value={ 0L,1L,2L,6L,8L,24L,30L,74L,110L,219L,309L,651L,870L,1608L,2394L,4085L,5756L,9931L,13785L,22724L,32300L,50404L,70862L,111540L,153756L,232868L,326259L,484090L,667015L,986082L,1345566L,1951216L,2673588L,3805742L,5179213L,7348514L,9895254L,13845750L,18681896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260669Inst : IEnumerable<long>
{
public static readonly long[] Value=A260669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260669.Bytes);
public long this[int i]=>Value[i];

public static A260669Inst Instance=new A260669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260670
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,15L,6L,3L,52L,32L,23L,10L,3L,203L,171L,152L,98L,62L,22L,11L,1L,877L,944L,984L,791L,624L,392L,240L,111L,55L,18L,4L,4140L,5444L,6460L,6082L,5513L,4302L,3328L,2141L,1393L,780L,432L,187L,88L,24L,6L,21147L,32919L,43626L,46508L,46880L,41979L,36774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260670Inst : IEnumerable<long>
{
public static readonly long[] Value=A260670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260670.Bytes);
public long this[int i]=>Value[i];

public static A260670Inst Instance=new A260670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260671
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,6L,0L,0L,4L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,10L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,4L,0L,0L,4L,0L,2L,0L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260671Inst : IEnumerable<long>
{
public static readonly long[] Value=A260671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260671.Bytes);
public long this[int i]=>Value[i];

public static A260671Inst Instance=new A260671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260672
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,4L,3L,2L,5L,4L,3L,0L,6L,5L,4L,1L,7L,6L,5L,2L,0L,8L,7L,6L,3L,1L,9L,8L,7L,4L,2L,10L,9L,8L,5L,3L,11L,10L,9L,6L,4L,12L,11L,10L,7L,5L,0L,13L,12L,11L,8L,6L,1L,14L,13L,12L,9L,7L,2L,15L,14L,13L,10L,8L,3L,0L,16L,15L,14L,11L,9L,4L,1L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260672Inst : IEnumerable<long>
{
public static readonly long[] Value=A260672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260672.Bytes);
public long this[int i]=>Value[i];

public static A260672Inst Instance=new A260672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260673
{
public static readonly long[] Value={ 31L,37L,1229L,4931L,12553L,3259909L,3324329L,9291521L,24066643L,26025107L,46330021L,95979511L,99268649L,116923057L,170995151L,204041417L,213084871L,218568971L,229981399L,232850557L,254042641L,255432869L,256714219L,300222341L,375303157L,383432249L,421514827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260673Inst : IEnumerable<long>
{
public static readonly long[] Value=A260673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260673.Bytes);
public long this[int i]=>Value[i];

public static A260673Inst Instance=new A260673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260674
{
public static readonly long[] Value={ 2L,83L,107L,367L,569L,887L,1327L,1451L,1621L,1987L,2027L,3307L,3547L,3631L,3691L,4421L,4547L,4967L,5669L,5843L,5927L,6011L,6911L,6991L,7207L,7949L,8167L,8431L,10771L,10889L,11287L,11621L,12007L,12227L,12487L,12763L,12983L,15391L,15767L,16127L,17107L,17183L,17231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260674Inst : IEnumerable<long>
{
public static readonly long[] Value=A260674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260674.Bytes);
public long this[int i]=>Value[i];

public static A260674Inst Instance=new A260674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260675
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,2L,0L,0L,1L,2L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,3L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260675Inst : IEnumerable<long>
{
public static readonly long[] Value=A260675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260675.Bytes);
public long this[int i]=>Value[i];

public static A260675Inst Instance=new A260675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260676
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,2L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260676Inst : IEnumerable<long>
{
public static readonly long[] Value=A260676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260676.Bytes);
public long this[int i]=>Value[i];

public static A260676Inst Instance=new A260676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260677
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,17L,35L,74L,150L,304L,612L,1228L,2460L,4926L,9857L,19721L,39449L,78905L,157818L,315644L,631296L,1262601L,2525212L,5050435L,10100879L,20201769L,40403550L,80807112L,161614235L,323228483L,646456979L,1292913972L,2585827958L,5171655931L,10343311876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260677Inst : IEnumerable<long>
{
public static readonly long[] Value=A260677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260677.Bytes);
public long this[int i]=>Value[i];

public static A260677Inst Instance=new A260677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260678
{
public static readonly long[] Value={ 33L,34L,37L,42L,49L,50L,51L,53L,56L,58L,60L,65L,67L,68L,69L,71L,72L,75L,78L,82L,83L,84L,85L,86L,88L,91L,94L,95L,97L,100L,101L,102L,105L,106L,107L,110L,111L,113L,114L,116L,117L,118L,119L,122L,123L,124L,128L,129L,132L,133L,134L,135L,136L,139L,141L,143L,148L,151L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260678Inst : IEnumerable<long>
{
public static readonly long[] Value=A260678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260678.Bytes);
public long this[int i]=>Value[i];

public static A260678Inst Instance=new A260678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260679
{
public static readonly long[] Value={ 257L,227L,199L,173L,149L,127L,107L,89L,73L,59L,47L,37L,29L,23L,19L,17L,17L,19L,23L,29L,37L,47L,59L,73L,89L,107L,127L,149L,173L,199L,227L,257L,289L,323L,359L,397L,437L,479L,523L,569L,617L,667L,719L,773L,829L,887L,947L,1009L,1073L,1139L,1207L,1277L,1349L,1423L,1499L,1577L,1657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260679Inst : IEnumerable<long>
{
public static readonly long[] Value=A260679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260679.Bytes);
public long this[int i]=>Value[i];

public static A260679Inst Instance=new A260679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260680
{
public static readonly long[] Value={ 1L,1L,1L,8L,3L,34L,19L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260680Inst : IEnumerable<long>
{
public static readonly long[] Value=A260680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260680.Bytes);
public long this[int i]=>Value[i];

public static A260680Inst Instance=new A260680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260681
{
public static readonly BigInteger[] Value={ 1L,1L,3L,5L,7L,9L,62L,105L,4612L,477839L,5221660L,120695273L,13517914794489425446UL,BigInteger.Parse("949763730038903507583"),BigInteger.Parse("805993247839619614799176726719363512"),BigInteger.Parse("2572332284084802308827712032135882716710570503279953274299454873") };
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
public class A260681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260681Inst Instance=new A260681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260682
{
public static readonly long[] Value={ 1L,7L,13L,19L,25L,31L,37L,43L,49L,61L,67L,73L,79L,91L,97L,103L,109L,121L,127L,133L,139L,151L,157L,163L,169L,175L,181L,193L,199L,211L,217L,223L,229L,241L,247L,259L,271L,277L,283L,289L,301L,307L,313L,325L,331L,337L,343L,349L,361L,367L,373L,379L,397L,403L,409L,421L,427L,433L,439L,457L,463L,469L,475L,481L,487L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260682Inst : IEnumerable<long>
{
public static readonly long[] Value=A260682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260682.Bytes);
public long this[int i]=>Value[i];

public static A260682Inst Instance=new A260682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260683
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,1L,2L,0L,4L,2L,4L,3L,3L,2L,6L,5L,5L,3L,7L,4L,7L,5L,4L,1L,5L,2L,8L,8L,7L,9L,9L,8L,7L,7L,8L,4L,6L,8L,9L,11L,11L,7L,11L,10L,8L,9L,8L,8L,10L,11L,16L,13L,10L,9L,12L,13L,16L,12L,13L,15L,15L,11L,15L,16L,14L,14L,12L,14L,15L,14L,16L,11L,18L,11L,17L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260683Inst : IEnumerable<long>
{
public static readonly long[] Value=A260683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260683.Bytes);
public long this[int i]=>Value[i];

public static A260683Inst Instance=new A260683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260684
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,5L,5L,5L,7L,5L,7L,5L,7L,7L,7L,11L,7L,11L,7L,11L,13L,11L,13L,11L,13L,11L,13L,11L,13L,17L,11L,13L,17L,11L,13L,17L,19L,11L,13L,17L,19L,11L,13L,17L,19L,13L,17L,19L,13L,17L,19L,23L,13L,17L,19L,23L,13L,17L,19L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260684Inst : IEnumerable<long>
{
public static readonly long[] Value=A260684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260684.Bytes);
public long this[int i]=>Value[i];

public static A260684Inst Instance=new A260684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260685
{
public static readonly long[] Value={ 1L,-1L,-1L,-2L,-1L,-1L,-1L,-6L,0L,-1L,-1L,4L,-1L,-1L,1L,-54L,-1L,0L,-1L,28L,1L,-1L,-1L,132L,0L,-1L,0L,124L,-1L,-1L,-1L,-4470L,1L,-1L,1L,444L,-1L,-1L,1L,5964L,-1L,-1L,-1L,2044L,0L,-1L,-1L,89028L,0L,0L,1L,8188L,-1L,0L,1L,248172L,1L,-1L,-1L,9784L,-1L,-1L,0L,-30229110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260685Inst : IEnumerable<long>
{
public static readonly long[] Value=A260685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260685.Bytes);
public long this[int i]=>Value[i];

public static A260685Inst Instance=new A260685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260686
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260686Inst : IEnumerable<long>
{
public static readonly long[] Value=A260686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260686.Bytes);
public long this[int i]=>Value[i];

public static A260686Inst Instance=new A260686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260687
{
public static readonly long[] Value={ 1L,2L,2L,6L,15L,9L,24L,104L,144L,64L,120L,770L,1775L,1750L,625L,720L,6264L,20880L,33480L,25920L,7776L,5040L,56196L,250096L,571095L,708295L,453789L,117649L,40320L,554112L,3127040L,9433088L,16486400L,16744448L,9175040L,2097152L,362880L,5973264L,41229324L,156498804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260687Inst : IEnumerable<long>
{
public static readonly long[] Value=A260687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260687.Bytes);
public long this[int i]=>Value[i];

public static A260687Inst Instance=new A260687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260688
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,5L,6L,7L,8L,9L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260688Inst : IEnumerable<long>
{
public static readonly long[] Value=A260688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260688.Bytes);
public long this[int i]=>Value[i];

public static A260688Inst Instance=new A260688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260689
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,7L,1L,5L,7L,3L,9L,3L,13L,1L,5L,11L,13L,3L,9L,17L,9L,15L,19L,5L,7L,13L,17L,19L,3L,15L,21L,9L,15L,25L,1L,7L,11L,13L,17L,23L,9L,15L,21L,27L,29L,3L,27L,5L,7L,17L,23L,25L,31L,9L,15L,21L,33L,35L,3L,21L,27L,33L,1L,5L,11L,19L,25L,29L,31L,37L,3L,15L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260689Inst : IEnumerable<long>
{
public static readonly long[] Value=A260689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260689.Bytes);
public long this[int i]=>Value[i];

public static A260689Inst Instance=new A260689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260690
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,6L,5L,5L,6L,6L,8L,8L,6L,6L,7L,7L,10L,10L,10L,7L,7L,8L,8L,12L,12L,12L,12L,8L,8L,9L,9L,14L,14L,16L,14L,14L,9L,9L,10L,10L,16L,16L,18L,18L,16L,16L,10L,10L,11L,11L,18L,18L,21L,21L,21L,18L,18L,11L,11L,12L,12L,20L,20L,24L,24L,24L,24L,20L,20L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260690Inst : IEnumerable<long>
{
public static readonly long[] Value=A260690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260690.Bytes);
public long this[int i]=>Value[i];

public static A260690Inst Instance=new A260690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260691
{
public static readonly long[] Value={ 0L,6L,8L,5L,7L,5L,6L,5L,9L,8L,1L,1L,3L,2L,9L,1L,0L,3L,9L,7L,6L,5L,5L,3L,3L,1L,1L,4L,1L,5L,5L,0L,6L,5L,5L,4L,2L,3L,3L,5L,6L,3L,5L,7L,1L,3L,7L,8L,6L,1L,9L,4L,4L,7L,4L,6L,8L,1L,2L,5L,1L,7L,0L,5L,1L,0L,3L,4L,8L,4L,4L,6L,8L,0L,7L,3L,4L,9L,7L,3L,7L,7L,4L,6L,0L,7L,1L,7L,1L,4L,3L,0L,9L,3L,0L,8L,1L,9L,7L,9L,1L,1L,1L,3L,9L,7L,4L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260691Inst : IEnumerable<long>
{
public static readonly long[] Value=A260691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260691.Bytes);
public long this[int i]=>Value[i];

public static A260691Inst Instance=new A260691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260692
{
public static readonly BigInteger[] Value={ 1L,1L,1000L,1001111L,1000000L,11001111111L,1000000000L,111001111111111L,1000000000000L,1111001111111111111L,1000000000000000L,BigInteger.Parse("11111001111111111111111"),1000000000000000000L,BigInteger.Parse("111111001111111111111111111"),BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("1111111001111111111111111111111") };
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
public class A260692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260692Inst Instance=new A260692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260693
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,6L,9L,0L,1L,14L,46L,64L,0L,1L,30L,175L,465L,625L,0L,1L,62L,596L,2471L,5901L,7776L,0L,1L,126L,1925L,11634L,40376L,90433L,117649L,0L,1L,254L,6042L,51570L,243454L,757940L,1626556L,2097152L,0L,1L,510L,18651L,220887L,1376715L,5580021L,16146957L,33609537L,43046721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260693Inst : IEnumerable<long>
{
public static readonly long[] Value=A260693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260693.Bytes);
public long this[int i]=>Value[i];

public static A260693Inst Instance=new A260693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260694
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,17L,120L,915L,9470L,104436L,1432713L,20709209L,354493902L,6343919118L,130255212146L,2780356513594L,66607482974307L,1651884203936474L,45240390673466869L,1278413274487999471L,BigInteger.Parse("39403978336643657797"),BigInteger.Parse("1249821733374560346851"),BigInteger.Parse("42820844948653526713511") };
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
public class A260694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260694Inst Instance=new A260694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260695
{
public static readonly long[] Value={ 1L,1L,5L,8L,84L,180L,3044L,8064L,193248L,604800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260695Inst : IEnumerable<long>
{
public static readonly long[] Value=A260695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260695.Bytes);
public long this[int i]=>Value[i];

public static A260695Inst Instance=new A260695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260696
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,62L,172L,471L,1337L,3846L,11030L,31442L,89470L,254934L,727203L,2074435L,5915652L,16866988L,48093810L,137141828L,391072846L,1115164897L,3179915535L,9067592160L,25856510664L,73730732368L,210245631360L,599521974384L,1709555338705L,4874850377793L,13900789573274L,39638539791222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260696Inst : IEnumerable<long>
{
public static readonly long[] Value=A260696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260696.Bytes);
public long this[int i]=>Value[i];

public static A260696Inst Instance=new A260696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260697
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,18L,32L,54L,95L,164L,291L,514L,923L,1656L,3000L,5442L,9942L,18216L,33564L,62040L,115167L,214404L,400497L,750070L,1408734L,2652088L,5004833L,9464616L,17935137L,34049044L,64754844L,123351410L,235335966L,449632300L,860241606L,1647932000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260697Inst : IEnumerable<long>
{
public static readonly long[] Value=A260697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260697.Bytes);
public long this[int i]=>Value[i];

public static A260697Inst Instance=new A260697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260698
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,16L,18L,28L,30L,36L,40L,42L,60L,66L,72L,78L,88L,96L,100L,108L,112L,126L,150L,156L,162L,180L,192L,196L,198L,210L,228L,240L,256L,270L,276L,280L,306L,312L,330L,336L,348L,352L,378L,396L,400L,408L,420L,432L,448L,456L,460L,462L,486L,520L,522L,540L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260698Inst : IEnumerable<long>
{
public static readonly long[] Value=A260698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260698.Bytes);
public long this[int i]=>Value[i];

public static A260698Inst Instance=new A260698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260699
{
public static readonly long[] Value={ 0L,1L,2L,6L,9L,15L,20L,28L,34L,45L,53L,66L,76L,91L,102L,120L,133L,153L,168L,190L,206L,231L,249L,276L,296L,325L,346L,378L,401L,435L,460L,496L,522L,561L,589L,630L,660L,703L,734L,780L,813L,861L,896L,946L,982L,1035L,1073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260699Inst : IEnumerable<long>
{
public static readonly long[] Value=A260699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260699.Bytes);
public long this[int i]=>Value[i];

public static A260699Inst Instance=new A260699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260700
{
public static readonly long[] Value={ 1L,3L,19L,167L,1791L,22715L,334031L,5597524L,105351108L,2200768698L,50533675542L,1265155704413L,34300156146805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260700Inst : IEnumerable<long>
{
public static readonly long[] Value=A260700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260700.Bytes);
public long this[int i]=>Value[i];

public static A260700Inst Instance=new A260700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260701
{
public static readonly BigInteger[] Value={ -1L,2L,-1L,5L,20L,197L,2219L,30620L,496565L,9265037L,195535514L,4605925535L,119796721835L,3410051954402L,105449267146859L,3520120318516625L,126168879827914580L,4832661370036811417L,BigInteger.Parse("197001989531658791879"),BigInteger.Parse("8515772839409988885140"),BigInteger.Parse("389080859811496699020425") };
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
public class A260701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260701Inst Instance=new A260701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260702
{
public static readonly long[] Value={ 0L,3L,6L,9L,12L,15L,18L,21L,30L,33L,39L,45L,48L,51L,60L,66L,90L,96L,99L,102L,105L,111L,120L,123L,129L,132L,150L,153L,156L,159L,162L,165L,180L,189L,195L,198L,201L,210L,225L,231L,246L,252L,255L,261L,285L,300L,330L,333L,348L,351L,390L,399L,429L,450L,453L,459L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260702Inst : IEnumerable<long>
{
public static readonly long[] Value=A260702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260702.Bytes);
public long this[int i]=>Value[i];

public static A260702Inst Instance=new A260702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260703
{
public static readonly long[] Value={ 84L,162L,168L,216L,252L,255L,270L,324L,336L,403L,420L,432L,486L,504L,510L,540L,574L,588L,648L,672L,736L,756L,765L,806L,810L,840L,864L,924L,972L,976L,1008L,1020L,1080L,1092L,1134L,1148L,1176L,1207L,1209L,1260L,1275L,1296L,1300L,1344L,1350L,1425L,1428L,1458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260703Inst : IEnumerable<long>
{
public static readonly long[] Value=A260703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260703.Bytes);
public long this[int i]=>Value[i];

public static A260703Inst Instance=new A260703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260704
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,3L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,4L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,3L,1L,1L,1L,1L,1L,2L,4L,1L,1L,2L,2L,3L,1L,1L,1L,2L,2L,1L,4L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,2L,2L,2L,1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260704Inst : IEnumerable<long>
{
public static readonly long[] Value=A260704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260704.Bytes);
public long this[int i]=>Value[i];

public static A260704Inst Instance=new A260704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260705
{
public static readonly long[] Value={ 84L,168L,336L,1008L,3024L,5544L,11088L,16632L,33264L,49896L,99792L,182952L,365904L,249480L,498960L,1097712L,2162160L,3359664L,1846152L,3027024L,5538456L,6054048L,9081072L,9230760L,14270256L,19891872L,20307672L,25197480L,33297264L,45405360L,55135080L,71351280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260705Inst : IEnumerable<long>
{
public static readonly long[] Value=A260705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260705.Bytes);
public long this[int i]=>Value[i];

public static A260705Inst Instance=new A260705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260706
{
public static readonly long[] Value={ 0L,1L,3L,6L,9L,12L,16L,20L,25L,30L,35L,40L,45L,51L,57L,63L,70L,77L,84L,91L,98L,105L,112L,120L,128L,136L,144L,153L,162L,171L,180L,189L,198L,207L,216L,225L,235L,245L,255L,265L,275L,286L,297L,308L,319L,330L,341L,352L,363L,374L,385L,396L,408L,420L,432L,444L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260706Inst : IEnumerable<long>
{
public static readonly long[] Value=A260706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260706.Bytes);
public long this[int i]=>Value[i];

public static A260706Inst Instance=new A260706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260707
{
public static readonly long[] Value={ 100L,50L,66L,25L,60L,16L,28L,12L,22L,30L,36L,16L,30L,14L,6L,18L,17L,22L,26L,5L,23L,9L,21L,16L,24L,11L,22L,17L,3L,23L,19L,6L,21L,2L,17L,19L,21L,21L,7L,22L,9L,2L,23L,18L,20L,19L,23L,4L,20L,22L,23L,25L,22L,3L,9L,25L,10L,22L,3L,16L,24L,22L,25L,23L,4L,24L,4L,25L,24L,25L,25L,5L,26L,27L,5L,27L,28L,8L,24L,3L,28L,8L,24L,5L,28L,9L,3L,28L,8L,28L,29L,30L,9L,30L,4L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260707Inst : IEnumerable<long>
{
public static readonly long[] Value=A260707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260707.Bytes);
public long this[int i]=>Value[i];

public static A260707Inst Instance=new A260707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260708
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,16L,21L,29L,36L,46L,55L,68L,78L,93L,105L,122L,136L,156L,171L,193L,210L,234L,253L,280L,300L,329L,351L,382L,406L,440L,465L,501L,528L,566L,595L,636L,666L,709L,741L,786L,820L,868L,903L,953L,990L,1042L,1081L,1136L,1176L,1233L,1275L,1334L,1378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260708Inst : IEnumerable<long>
{
public static readonly long[] Value=A260708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260708.Bytes);
public long this[int i]=>Value[i];

public static A260708Inst Instance=new A260708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260709
{
public static readonly long[] Value={ 2L,5L,13L,52L,241L,241L,436L,1009L,1009L,1009L,2641L,2641L,8089L,8089L,8089L,8089L,18001L,18001L,53881L,53881L,53881L,53881L,87481L,87481L,87481L,87481L,87481L,87481L,117049L,117049L,515761L,515761L,515761L,515761L,515761L,515761L,1083289L,1083289L,1083289L,1083289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260709Inst : IEnumerable<long>
{
public static readonly long[] Value=A260709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260709.Bytes);
public long this[int i]=>Value[i];

public static A260709Inst Instance=new A260709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260710
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,16L,25L,43L,69L,116L,188L,313L,511L,846L,1386L,2288L,3756L,6191L,10174L,16756L,27552L,45357L,74604L,122787L,201996L,332414L,546901L,899946L,1480699L,2436459L,4008858L,6596366L,10853563L,17858788L,29384804L,48350401L,79555943L,130902711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260710Inst : IEnumerable<long>
{
public static readonly long[] Value=A260710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260710.Bytes);
public long this[int i]=>Value[i];

public static A260710Inst Instance=new A260710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260711
{
public static readonly long[] Value={ 0L,8L,16L,32L,48L,64L,96L,128L,160L,192L,224L,256L,320L,384L,448L,512L,576L,640L,704L,768L,832L,896L,960L,1024L,1152L,1280L,1408L,1536L,1664L,1792L,1920L,2048L,2176L,2304L,2432L,2560L,2688L,2816L,2944L,3072L,3200L,3328L,3456L,3584L,3712L,3840L,3968L,4096L,4352L,4608L,4864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260711Inst : IEnumerable<long>
{
public static readonly long[] Value=A260711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260711.Bytes);
public long this[int i]=>Value[i];

public static A260711Inst Instance=new A260711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260712
{
public static readonly long[] Value={ 0L,0L,0L,0L,6L,0L,0L,0L,5L,6L,0L,0L,0L,0L,5L,0L,4L,5L,0L,6L,4L,0L,55L,0L,0L,0L,4L,0L,141L,5L,0L,0L,140L,4L,1L,5L,0L,0L,54L,6L,0L,4L,2L,0L,145L,55L,0L,0L,3L,0L,6L,0L,2L,4L,0L,0L,1L,141L,0L,5L,0L,0L,3L,0L,2L,140L,0L,4L,4L,1L,4L,5L,0L,0L,1L,0L,2L,54L,5L,6L,3L,0L,3L,4L,4L,2L,0L,0L,4L,145L,0L,55L,139L,0L,1L,0L,0L,3L,53L,0L,3L,6L,0L,0L,3L,2L,14L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260712Inst : IEnumerable<long>
{
public static readonly long[] Value=A260712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260712.Bytes);
public long this[int i]=>Value[i];

public static A260712Inst Instance=new A260712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260713
{
public static readonly long[] Value={ 6L,6L,5L,4L,6L,55L,141L,5L,4L,1L,6L,2L,145L,55L,6L,2L,141L,5L,2L,4L,4L,1L,4L,5L,6L,3L,4L,2L,4L,145L,55L,1L,3L,6L,3L,2L,14L,2L,141L,27L,5L,65L,1L,10L,2L,1L,4L,4L,4L,1L,4L,3L,1L,3L,9L,5L,1L,6L,5L,18L,3L,4L,2L,6L,4L,3L,145L,17L,55L,4L,1L,11L,36L,1L,3L,6L,5L,14L,3L,2L,14L,4L,1L,10L,2L,13L,141L,1L,6L,3L,27L,5L,9L,2L,65L,10L,1L,10L,2L,10L,2L,2L,3L,52L,86L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260713Inst : IEnumerable<long>
{
public static readonly long[] Value=A260713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260713.Bytes);
public long this[int i]=>Value[i];

public static A260713Inst Instance=new A260713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260714
{
public static readonly long[] Value={ 7L,11L,13L,17L,23L,25L,29L,31L,37L,41L,43L,47L,53L,55L,59L,61L,67L,71L,73L,77L,83L,85L,89L,91L,97L,101L,103L,107L,113L,115L,119L,121L,127L,131L,133L,137L,143L,145L,149L,151L,157L,161L,163L,167L,173L,175L,179L,181L,187L,191L,193L,197L,203L,205L,209L,211L,217L,221L,223L,227L,233L,235L,239L,241L,247L,251L,253L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260714Inst : IEnumerable<long>
{
public static readonly long[] Value=A260714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260714.Bytes);
public long this[int i]=>Value[i];

public static A260714Inst Instance=new A260714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260715
{
public static readonly long[] Value={ 11L,13L,17L,23L,25L,29L,37L,41L,43L,47L,53L,55L,61L,67L,71L,73L,77L,83L,89L,91L,97L,101L,103L,107L,115L,119L,121L,127L,131L,133L,143L,145L,149L,151L,157L,161L,167L,173L,175L,179L,181L,187L,193L,197L,203L,205L,209L,211L,221L,223L,227L,233L,235L,239L,247L,251L,253L,257L,263L,265L,271L,277L,281L,283L,287L,293L,299L,301L,307L,311L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260715Inst : IEnumerable<long>
{
public static readonly long[] Value=A260715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260715.Bytes);
public long this[int i]=>Value[i];

public static A260715Inst Instance=new A260715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260716
{
public static readonly long[] Value={ 6L,4L,55L,141L,2L,2L,4L,5L,3L,4L,3L,14L,2L,1L,4L,3L,1L,18L,6L,3L,17L,36L,1L,10L,13L,1L,10L,2L,2L,86L,27L,7L,4L,50L,1L,4L,6L,4L,3L,13L,7L,3L,1L,207L,2L,7L,10L,10L,128L,7L,2L,4L,2L,9L,20L,2L,15L,24L,3L,10L,64L,7L,4L,4L,1L,4L,15L,8L,4L,1L,45L,3L,2L,1L,1L,2L,6L,28L,1L,2L,11L,1L,3L,14L,13L,3L,11L,12L,4L,28L,3L,7L,55L,40L,9L,4L,51L,5L,2L,6L,1L,2L,1L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260716Inst : IEnumerable<long>
{
public static readonly long[] Value=A260716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260716.Bytes);
public long this[int i]=>Value[i];

public static A260716Inst Instance=new A260716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260717
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,5L,5L,7L,7L,7L,6L,9L,11L,11L,11L,7L,11L,13L,13L,13L,13L,8L,13L,17L,17L,17L,17L,17L,9L,15L,19L,23L,23L,23L,23L,23L,10L,17L,23L,25L,25L,25L,25L,25L,25L,11L,19L,25L,29L,29L,29L,29L,29L,29L,29L,12L,21L,29L,31L,37L,37L,37L,37L,37L,37L,37L,13L,23L,31L,37L,41L,41L,41L,41L,41L,41L,41L,41L,14L,25L,35L,41L,43L,43L,43L,43L,43L,43L,43L,43L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260717Inst : IEnumerable<long>
{
public static readonly long[] Value=A260717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260717.Bytes);
public long this[int i]=>Value[i];

public static A260717Inst Instance=new A260717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260718
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,4L,7L,7L,7L,5L,11L,11L,11L,9L,6L,13L,13L,13L,13L,11L,7L,17L,17L,17L,17L,17L,13L,8L,23L,23L,23L,23L,23L,19L,15L,9L,25L,25L,25L,25L,25L,25L,23L,17L,10L,29L,29L,29L,29L,29L,29L,29L,25L,19L,11L,37L,37L,37L,37L,37L,37L,37L,31L,29L,21L,12L,41L,41L,41L,41L,41L,41L,41L,41L,37L,31L,23L,13L,43L,43L,43L,43L,43L,43L,43L,43L,43L,41L,35L,25L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260718Inst : IEnumerable<long>
{
public static readonly long[] Value=A260718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260718.Bytes);
public long this[int i]=>Value[i];

public static A260718Inst Instance=new A260718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260719
{
public static readonly long[] Value={ 5L,5L,3L,4L,3L,5L,9L,2L,7L,2L,6L,6L,2L,2L,2L,3L,8L,8L,6L,5L,5L,7L,6L,4L,5L,6L,2L,7L,6L,4L,5L,4L,5L,4L,5L,9L,4L,10L,3L,4L,7L,4L,4L,3L,4L,3L,5L,8L,6L,4L,7L,5L,3L,7L,3L,3L,3L,3L,3L,7L,3L,5L,6L,6L,9L,4L,9L,3L,5L,6L,3L,4L,5L,7L,7L,4L,5L,2L,10L,11L,6L,6L,7L,13L,4L,6L,5L,10L,6L,4L,7L,4L,10L,8L,3L,7L,7L,4L,5L,5L,2L,4L,8L,3L,4L,3L,7L,4L,6L,3L,15L,3L,4L,7L,6L,6L,6L,5L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260719Inst : IEnumerable<long>
{
public static readonly long[] Value=A260719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260719.Bytes);
public long this[int i]=>Value[i];

public static A260719Inst Instance=new A260719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260720
{
public static readonly long[] Value={ 2L,4L,5L,2L,6L,4L,4L,8L,3L,3L,4L,3L,3L,3L,2L,2L,3L,5L,2L,4L,7L,2L,5L,3L,7L,3L,3L,4L,4L,7L,4L,6L,5L,3L,2L,5L,6L,4L,8L,4L,4L,6L,3L,4L,5L,3L,3L,4L,5L,6L,6L,6L,3L,6L,10L,6L,4L,5L,6L,8L,3L,3L,5L,3L,8L,2L,3L,4L,5L,6L,5L,4L,5L,5L,7L,4L,5L,6L,3L,5L,6L,5L,6L,7L,3L,8L,7L,10L,7L,9L,6L,5L,2L,6L,5L,7L,6L,8L,6L,3L,10L,3L,9L,8L,6L,6L,5L,8L,6L,7L,3L,6L,8L,5L,5L,5L,8L,5L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260720Inst : IEnumerable<long>
{
public static readonly long[] Value=A260720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260720.Bytes);
public long this[int i]=>Value[i];

public static A260720Inst Instance=new A260720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260721
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,-1L,-1L,-2L,-1L,-3L,-2L,0L,-1L,-3L,-2L,-5L,-3L,-1L,-1L,1L,2L,1L,-1L,-1L,1L,2L,2L,-3L,-1L,-1L,4L,4L,3L,1L,5L,3L,4L,-4L,0L,7L,5L,8L,6L,4L,5L,2L,2L,5L,8L,3L,8L,8L,7L,9L,11L,12L,16L,14L,15L,11L,16L,16L,15L,19L,17L,16L,18L,20L,15L,14L,14L,16L,12L,11L,12L,18L,19L,21L,15L,15L,11L,13L,13L,15L,19L,20L,15L,18L,23L,24L,23L,28L,27L,27L,27L,20L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260721Inst : IEnumerable<long>
{
public static readonly long[] Value=A260721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260721.Bytes);
public long this[int i]=>Value[i];

public static A260721Inst Instance=new A260721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260722
{
public static readonly long[] Value={ 0L,0L,-2L,-2L,-2L,-2L,-4L,-2L,-6L,-4L,0L,-2L,-6L,-4L,-10L,-6L,-2L,-2L,2L,4L,2L,-2L,-2L,2L,4L,4L,-6L,-2L,-2L,8L,8L,6L,2L,10L,6L,8L,-8L,0L,14L,10L,16L,12L,8L,10L,4L,4L,10L,16L,6L,16L,16L,14L,18L,22L,24L,32L,28L,30L,22L,32L,32L,30L,38L,34L,32L,36L,40L,30L,28L,28L,32L,24L,22L,24L,36L,38L,42L,30L,30L,22L,26L,26L,30L,38L,40L,30L,36L,46L,48L,46L,56L,54L,54L,54L,40L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260722Inst : IEnumerable<long>
{
public static readonly long[] Value=A260722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260722.Bytes);
public long this[int i]=>Value[i];

public static A260722Inst Instance=new A260722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260723
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,4L,6L,2L,4L,8L,4L,2L,4L,6L,8L,6L,4L,6L,6L,6L,2L,6L,10L,8L,4L,2L,6L,4L,12L,6L,8L,4L,12L,2L,4L,2L,12L,16L,2L,10L,2L,4L,6L,2L,4L,8L,10L,8L,12L,6L,4L,14L,6L,6L,16L,2L,6L,4L,12L,6L,2L,16L,6L,6L,8L,10L,8L,4L,2L,10L,2L,4L,8L,18L,4L,8L,6L,12L,4L,6L,6L,8L,10L,8L,6L,12L,12L,12L,4L,12L,2L,12L,6L,4L,8L,18L,4L,6L,6L,8L,6L,12L,6L,6L,6L,4L,20L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260723Inst : IEnumerable<long>
{
public static readonly long[] Value=A260723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260723.Bytes);
public long this[int i]=>Value[i];

public static A260723Inst Instance=new A260723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260724
{
public static readonly BigInteger[] Value={ 2L,3L,2L,7L,5L,2L,31L,3L,109L,13L,97L,83L,8731L,461L,3078769L,574933L,206179L,510583L,5153873111L,1900169L,372828179L,4032506435771041L,3445362972116384083L,BigInteger.Parse("49898596950715368948711529590337583"),BigInteger.Parse("54176564592185030069557382121821") };
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
public class A260724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260724Inst Instance=new A260724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260725
{
public static readonly BigInteger[] Value={ 2L,2L,2L,2L,2L,11L,59L,577L,13999L,232988779L,7616971L,141695022522269L,BigInteger.Parse("52247207549418855988531757"),BigInteger.Parse("784710183186946763762727466890094566789132493"),BigInteger.Parse("2696635801755076542772762485782137063037806561559423"),BigInteger.Parse("406892172682482048521833925827793697965504908008299460763") };
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
public class A260725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260725Inst Instance=new A260725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260726
{
public static readonly long[] Value={ 4L,8L,363L,484L,5445L,46464L,252L,2138312L,12321L,0L,44L,23232L,31213L,686L,53187678135L,44944L,272L,24642L,171L,0L,525L,88L,575L,46464L,5221225L,62426L,36963L,252L,464L,0L,1783799973871L,291080192L,2112L,4114L,53235L,69696L,333L,20102L,93639L,0L,656L,858858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260726Inst : IEnumerable<long>
{
public static readonly long[] Value=A260726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260726.Bytes);
public long this[int i]=>Value[i];

public static A260726Inst Instance=new A260726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260727
{
public static readonly long[] Value={ 1L,23L,325L,3368L,28819L,218788L,1539399L,10314315L,66953292L,425761614L,2671506918L,16618186770L,102796975770L,633596982417L,3896224129259L,23924104985984L,146764696175937L,899809941054468L,5514653407814317L,33789681789605283L,207007665004469906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260727Inst : IEnumerable<long>
{
public static readonly long[] Value=A260727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260727.Bytes);
public long this[int i]=>Value[i];

public static A260727Inst Instance=new A260727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260728
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,0L,2L,0L,1L,1L,0L,1L,1L,0L,0L,2L,1L,0L,1L,1L,1L,1L,0L,0L,3L,1L,0L,1L,1L,0L,1L,0L,1L,2L,0L,1L,1L,0L,0L,1L,1L,1L,2L,1L,1L,1L,2L,0L,1L,0L,0L,3L,1L,1L,1L,0L,1L,1L,0L,1L,3L,0L,0L,1L,1L,0L,1L,1L,1L,2L,0L,0L,1L,1L,1L,1L,1L,0L,4L,0L,1L,1L,0L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,0L,2L,3L,0L,0L,1L,1L,0L,1L,0L,1L,3L,0L,1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260728Inst : IEnumerable<long>
{
public static readonly long[] Value=A260728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260728.Bytes);
public long this[int i]=>Value[i];

public static A260728Inst Instance=new A260728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260729
{
public static readonly long[] Value={ 29L,33L,93L,217L,341L,961L,2821L,7409L,8973L,53625L,94325L,225169L,470517L,1349089L,4076589L,22862205L,40165377L,506257425L,918577233L,1042701969L,5347778553L,76822655445L,242180261569L,243151045949L,835744242025L,1398202164821L,7718585207745L,17886399120625L,36628781776125L,140199249091321L,579641775855025L,3110633457224293L,9887055813390673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260729Inst : IEnumerable<long>
{
public static readonly long[] Value=A260729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260729.Bytes);
public long this[int i]=>Value[i];

public static A260729Inst Instance=new A260729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260730
{
public static readonly long[] Value={ 21L,33L,42L,57L,66L,69L,77L,84L,93L,105L,114L,129L,132L,133L,138L,141L,154L,161L,165L,168L,177L,186L,189L,201L,209L,210L,213L,217L,228L,231L,237L,249L,253L,258L,264L,266L,273L,276L,282L,285L,297L,301L,308L,309L,321L,322L,329L,330L,336L,341L,345L,354L,357L,372L,378L,381L,385L,393L,399L,402L,413L,417L,418L,420L,426L,429L,434L,437L,441L,453L,456L,462L,465L,469L,473L,474L,483L,489L,497L,498L,501L,506L,513L,516L,517L,525L,528L,532L,537L,546L,552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260730Inst : IEnumerable<long>
{
public static readonly long[] Value=A260730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260730.Bytes);
public long this[int i]=>Value[i];

public static A260730Inst Instance=new A260730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260731
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,8L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,27L,27L,28L,28L,28L,29L,29L,29L,30L,31L,31L,31L,32L,32L,32L,32L,33L,33L,34L,34L,34L,35L,35L,35L,36L,36L,37L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260731Inst : IEnumerable<long>
{
public static readonly long[] Value=A260731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260731.Bytes);
public long this[int i]=>Value[i];

public static A260731Inst Instance=new A260731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260732
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,14L,19L,24L,31L,38L,45L,53L,63L,72L,82L,92L,105L,118L,132L,145L,160L,175L,191L,208L,225L,244L,263L,282L,302L,322L,344L,366L,389L,413L,438L,462L,488L,515L,540L,568L,597L,626L,655L,685L,716L,749L,782L,815L,849L,884L,919L,956L,992L,1031L,1068L,1106L,1146L,1188L,1228L,1270L,1312L,1355L,1397L,1442L,1487L,1532L,1580L,1625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260732Inst : IEnumerable<long>
{
public static readonly long[] Value=A260732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260732.Bytes);
public long this[int i]=>Value[i];

public static A260732Inst Instance=new A260732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260733
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,13L,18L,23L,30L,37L,44L,52L,62L,71L,81L,91L,104L,117L,131L,144L,159L,174L,190L,207L,224L,243L,262L,281L,301L,321L,343L,365L,388L,412L,437L,461L,487L,514L,539L,567L,596L,625L,654L,684L,715L,748L,781L,814L,848L,883L,918L,955L,991L,1030L,1067L,1105L,1145L,1187L,1227L,1269L,1311L,1354L,1396L,1441L,1486L,1531L,1579L,1624L,1673L,1723L,1773L,1821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260733Inst : IEnumerable<long>
{
public static readonly long[] Value=A260733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260733.Bytes);
public long this[int i]=>Value[i];

public static A260733Inst Instance=new A260733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260734
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,5L,5L,7L,7L,7L,8L,10L,9L,10L,10L,13L,13L,14L,13L,15L,15L,16L,17L,17L,19L,19L,19L,20L,20L,22L,22L,23L,24L,25L,24L,26L,27L,25L,28L,29L,29L,29L,30L,31L,33L,33L,33L,34L,35L,35L,37L,36L,39L,37L,38L,40L,42L,40L,42L,42L,43L,42L,45L,45L,45L,48L,45L,49L,50L,50L,48L,53L,50L,51L,54L,52L,53L,54L,56L,56L,56L,58L,59L,59L,60L,60L,60L,61L,62L,62L,62L,65L,66L,66L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260734Inst : IEnumerable<long>
{
public static readonly long[] Value=A260734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260734.Bytes);
public long this[int i]=>Value[i];

public static A260734Inst Instance=new A260734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260735
{
public static readonly BigInteger[] Value={ 455L,3087L,24843L,72975L,332563L,602919L,5893875L,221402727L,322063831L,5853742587L,10696444275L,75642464331L,749833439355L,1724537517955L,2295761459035L,4498164915283L,9436077956619L,369311889576231L,10610033249983167L,135786986032294135L,460149860040811083L,2879918014301480295L,BigInteger.Parse("63102417694969716063"),BigInteger.Parse("339029616686070752991") };
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
public class A260735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260735.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260735Inst Instance=new A260735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260736
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,2L,3L,2L,3L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260736Inst : IEnumerable<long>
{
public static readonly long[] Value=A260736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260736.Bytes);
public long this[int i]=>Value[i];

public static A260736Inst Instance=new A260736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260737
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,2L,0L,2L,2L,0L,0L,2L,0L,6L,1L,2L,0L,3L,0L,4L,0L,4L,0L,6L,0L,0L,1L,3L,1L,4L,0L,2L,3L,9L,0L,4L,0L,4L,4L,3L,0L,4L,0L,6L,2L,8L,0L,3L,3L,6L,1L,5L,0L,10L,0L,4L,2L,0L,1L,4L,0L,6L,2L,6L,0L,6L,0L,4L,4L,4L,2L,8L,0L,12L,0L,4L,0L,7L,2L,3L,4L,6L,0L,9L,2L,6L,3L,4L,3L,5L,0L,4L,2L,12L,0L,6L,0L,12L,4L,5L,0L,6L,0L,8L,3L,8L,0L,4L,2L,10L,6L,4L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260737Inst : IEnumerable<long>
{
public static readonly long[] Value=A260737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260737.Bytes);
public long this[int i]=>Value[i];

public static A260737Inst Instance=new A260737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260738
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,4L,1L,2L,1L,5L,1L,6L,1L,2L,1L,7L,1L,3L,1L,2L,1L,8L,1L,9L,1L,2L,1L,10L,1L,4L,1L,2L,1L,3L,1L,11L,1L,2L,1L,12L,1L,13L,1L,2L,1L,14L,1L,3L,1L,2L,1L,15L,1L,5L,1L,2L,1L,4L,1L,16L,1L,2L,1L,3L,1L,17L,1L,2L,1L,18L,1L,6L,1L,2L,1L,19L,1L,3L,1L,2L,1L,20L,1L,4L,1L,2L,1L,21L,1L,22L,1L,2L,1L,3L,1L,23L,1L,2L,1L,7L,1L,5L,1L,2L,1L,24L,1L,3L,1L,2L,1L,4L,1L,25L,1L,2L,1L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260738Inst : IEnumerable<long>
{
public static readonly long[] Value=A260738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260738.Bytes);
public long this[int i]=>Value[i];

public static A260738Inst Instance=new A260738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260739
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,6L,1L,7L,3L,8L,1L,9L,2L,10L,4L,11L,1L,12L,1L,13L,5L,14L,1L,15L,2L,16L,6L,17L,3L,18L,1L,19L,7L,20L,1L,21L,1L,22L,8L,23L,1L,24L,4L,25L,9L,26L,1L,27L,2L,28L,10L,29L,3L,30L,1L,31L,11L,32L,5L,33L,1L,34L,12L,35L,1L,36L,2L,37L,13L,38L,1L,39L,6L,40L,14L,41L,1L,42L,4L,43L,15L,44L,1L,45L,1L,46L,16L,47L,7L,48L,1L,49L,17L,50L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260739Inst : IEnumerable<long>
{
public static readonly long[] Value=A260739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260739.Bytes);
public long this[int i]=>Value[i];

public static A260739Inst Instance=new A260739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260740
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,3L,3L,3L,6L,8L,8L,8L,8L,11L,11L,11L,15L,15L,15L,15L,18L,18L,18L,18L,21L,24L,24L,24L,24L,27L,27L,27L,27L,30L,32L,32L,35L,35L,35L,35L,38L,38L,38L,38L,41L,43L,43L,43L,43L,48L,48L,48L,48L,51L,51L,51L,51L,54L,56L,56L,56L,56L,59L,59L,63L,63L,63L,63L,66L,66L,66L,66L,69L,71L,71L,71L,71L,74L,74L,74L,78L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260740Inst : IEnumerable<long>
{
public static readonly long[] Value=A260740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260740.Bytes);
public long this[int i]=>Value[i];

public static A260740Inst Instance=new A260740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260741
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,6L,5L,8L,7L,18L,15L,12L,11L,10L,13L,16L,21L,14L,19L,36L,17L,30L,51L,24L,23L,22L,31L,20L,33L,26L,25L,32L,29L,42L,27L,28L,37L,38L,35L,72L,45L,34L,41L,60L,55L,102L,39L,48L,43L,46L,47L,44L,105L,62L,73L,40L,59L,66L,87L,52L,49L,50L,53L,64L,69L,58L,61L,84L,67L,54L,63L,56L,71L,74L,77L,76L,57L,70L,83L,144L,125L,90L,75L,68L,101L,82L,89L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260741Inst : IEnumerable<long>
{
public static readonly long[] Value=A260741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260741.Bytes);
public long this[int i]=>Value[i];

public static A260741Inst Instance=new A260741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260742
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,9L,8L,5L,14L,13L,12L,15L,18L,11L,16L,21L,10L,19L,28L,17L,26L,25L,24L,31L,30L,35L,36L,33L,22L,27L,32L,29L,42L,39L,20L,37L,38L,47L,56L,43L,34L,49L,52L,41L,50L,51L,48L,61L,62L,23L,60L,63L,70L,45L,72L,77L,66L,57L,44L,67L,54L,71L,64L,123L,58L,69L,84L,65L,78L,73L,40L,55L,74L,83L,76L,75L,94L,103L,112L,101L,86L,79L,68L,91L,98L,59L,104L,87L,82L,93L,100L,89L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260742Inst : IEnumerable<long>
{
public static readonly long[] Value=A260742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260742.Bytes);
public long this[int i]=>Value[i];

public static A260742Inst Instance=new A260742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260743
{
public static readonly long[] Value={ 0L,1L,10L,20L,100L,101L,200L,220L,300L,310L,1000L,1001L,1010L,1020L,2000L,2001L,2200L,2300L,3000L,3020L,3100L,3300L,4000L,4010L,4100L,4200L,10000L,10001L,10010L,10020L,10100L,10101L,10200L,10220L,10300L,10310L,20000L,20001L,20010L,20020L,22000L,22001L,23000L,23020L,24000L,24010L,30000L,30001L,30200L,30300L,31000L,31001L,33000L,33300L,34000L,34200L,40000L,40020L,40100L,40300L,41000L,41020L,42000L,42300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260743Inst : IEnumerable<long>
{
public static readonly long[] Value=A260743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260743.Bytes);
public long this[int i]=>Value[i];

public static A260743Inst Instance=new A260743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260744
{
public static readonly long[] Value={ 1L,2L,5L,10L,23L,48L,105L,216L,467L,958L,2021L,4146L,8631L,17604L,36377L,73876L,151379L,306882L,625149L,1263294L,2563895L,5169544L,10454105L,21046800L,42451179L,85334982L,171799853L,344952010L,693368423L,1391049900L,2792734257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260744Inst : IEnumerable<long>
{
public static readonly long[] Value=A260744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260744.Bytes);
public long this[int i]=>Value[i];

public static A260744Inst Instance=new A260744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260745
{
public static readonly long[] Value={ 1L,3L,11L,36L,127L,405L,1409L,4561L,15559L,50294L,169537L,551001L,1835073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260745Inst : IEnumerable<long>
{
public static readonly long[] Value=A260745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260745.Bytes);
public long this[int i]=>Value[i];

public static A260745Inst Instance=new A260745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260746
{
public static readonly long[] Value={ 1L,4L,19L,83L,391L,1663L,7739L,33812L,153575L,677901L,3075879L,13586581L,61458267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260746Inst : IEnumerable<long>
{
public static readonly long[] Value=A260746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260746.Bytes);
public long this[int i]=>Value[i];

public static A260746Inst Instance=new A260746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260747
{
public static readonly long[] Value={ 13L,21L,23L,26L,37L,39L,42L,46L,47L,52L,73L,74L,78L,81L,83L,84L,92L,94L,97L,99L,103L,104L,107L,111L,113L,133L,141L,143L,146L,148L,156L,157L,159L,162L,163L,166L,167L,168L,171L,173L,184L,188L,193L,194L,198L,199L,201L,203L,206L,207L,208L,209L,211L,213L,214L,217L,219L,221L,222L,223L,226L,227L,231L,233L,253L,261L,263L,266L,277L,279L,282L,283L,286L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260747Inst : IEnumerable<long>
{
public static readonly long[] Value=A260747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260747.Bytes);
public long this[int i]=>Value[i];

public static A260747Inst Instance=new A260747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260748
{
public static readonly long[] Value={ 13L,26L,37L,52L,73L,74L,97L,103L,104L,111L,133L,146L,148L,157L,193L,194L,199L,206L,207L,208L,209L,217L,221L,222L,223L,231L,253L,266L,277L,292L,296L,307L,313L,314L,317L,337L,373L,386L,388L,397L,398L,409L,412L,414L,416L,417L,418L,419L,431L,433L,434L,439L,442L,444L,446L,447L,449L,457L,461L,462L,463L,471L,493L,506L,517L,532L,553L,554L,577L,583L,584L,591L,592L,613L,614L,619L,626L,627L,628L,629L,631L,634L,637L,667L,673L,674L,677L,697L,733L,746L,757L,772L,776L,787L,793L,794L,797L,817L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260748Inst : IEnumerable<long>
{
public static readonly long[] Value=A260748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260748.Bytes);
public long this[int i]=>Value[i];

public static A260748Inst Instance=new A260748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260749
{
public static readonly long[] Value={ 21L,42L,39L,84L,81L,78L,99L,171L,168L,113L,141L,162L,156L,159L,201L,198L,213L,342L,211L,336L,319L,219L,327L,226L,291L,233L,261L,282L,279L,324L,312L,309L,321L,318L,367L,339L,381L,402L,396L,399L,426L,423L,684L,422L,672L,421L,638L,649L,657L,441L,438L,453L,654L,452L,582L,451L,559L,459L,567L,466L,531L,473L,501L,522L,519L,564L,561L,558L,579L,651L,648L,593L,624L,621L,618L,749L,642L,641L,636L,633L,747L,734L,639L,669L,681L,678L,727L,699L,741L,762L,759L,804L,792L,789L,801L,798L,847L,819L,861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260749Inst : IEnumerable<long>
{
public static readonly long[] Value=A260749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260749.Bytes);
public long this[int i]=>Value[i];

public static A260749Inst Instance=new A260749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260750
{
public static readonly long[] Value={ 23L,46L,47L,92L,83L,94L,107L,173L,184L,163L,143L,166L,188L,167L,203L,214L,329L,346L,341L,368L,333L,227L,331L,326L,293L,283L,263L,286L,287L,332L,376L,377L,323L,334L,369L,347L,383L,406L,428L,407L,658L,659L,692L,682L,736L,671L,666L,663L,661L,443L,454L,569L,662L,652L,586L,581L,573L,467L,571L,566L,533L,523L,503L,526L,527L,572L,563L,574L,587L,653L,664L,643L,752L,623L,754L,753L,646L,751L,668L,739L,761L,738L,647L,737L,683L,694L,729L,707L,743L,766L,767L,812L,856L,857L,803L,814L,849L,827L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260750Inst : IEnumerable<long>
{
public static readonly long[] Value=A260750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260750.Bytes);
public long this[int i]=>Value[i];

public static A260750Inst Instance=new A260750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260751
{
public static readonly long[] Value={ 6171054912832631L,6252792570914711L,6334530228996791L,6416267887078871L,6498005545160951L,6579743203243031L,6661480861325111L,6743218519407191L,6824956177489271L,6906693835571351L,6988431493653431L,7070169151735511L,7151906809817591L,7233644467899671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260751Inst : IEnumerable<long>
{
public static readonly long[] Value=A260751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260751.Bytes);
public long this[int i]=>Value[i];

public static A260751Inst Instance=new A260751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260752
{
public static readonly long[] Value={ 1L,5L,29L,157L,901L,4822L,27447L,149393L,836527L,4610088L,25846123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260752Inst : IEnumerable<long>
{
public static readonly long[] Value=A260752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260752.Bytes);
public long this[int i]=>Value[i];

public static A260752Inst Instance=new A260752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260753
{
public static readonly long[] Value={ 2L,2L,2279L,5806L,4L,1135L,816L,6556L,725L,2L,1333L,10839L,27L,829L,2279L,2838L,3881L,6540L,2564L,2L,7830L,6540L,27L,4905L,6121L,8220L,316L,1061L,2L,14691L,2L,1168L,738L,4707L,785L,12467L,5492L,1447L,542L,538L,12840L,829L,4732L,5637L,785L,1246L,1198L,433L,58L,573L,26280L,17387L,316L,430L,1198L,4315L,4315L,1479L,4315L,1497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260753Inst : IEnumerable<long>
{
public static readonly long[] Value=A260753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260753.Bytes);
public long this[int i]=>Value[i];

public static A260753Inst Instance=new A260753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260754
{
public static readonly BigInteger[] Value={ 3L,40L,1008L,5702400L,566092800L,27360571392000L,7155594141696000L,BigInteger.Parse("1360632459941314560000"),BigInteger.Parse("384424434510421824110592000000"),BigInteger.Parse("283546160488893890266398720000000") };
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
public class A260754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260754Inst Instance=new A260754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260755
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,4L,252L,2304L,343712160L,17361257184L,BigInteger.Parse("817232021393069622912"),BigInteger.Parse("337615438409845853800240"),BigInteger.Parse("1002314950534089781700930298791626826040504"),BigInteger.Parse("4687493998578314511363173974007271386258869456") };
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
public class A260755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260755Inst Instance=new A260755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260756
{
public static readonly BigInteger[] Value={ 1L,2L,10L,44739260L,BigInteger.Parse("28948022309329048855892746252171976963317496166410141009864396001978371888518") };
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
public class A260756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260756Inst Instance=new A260756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260757
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,4L,1L,1L,7L,10L,1L,10L,1L,10L,5L,1L,14L,24L,1L,1L,13L,1L,16L,3L,82L,1L,19L,1L,23L,94L,64L,58L,7L,6L,14L,3L,46L,22L,5L,13L,107L,69L,38L,90L,59L,75L,104L,25L,4L,10L,14L,4L,44L,10L,5L,1L,77L,81L,85L,94L,71L,9L,14L,111L,13L,27L,20L,9L,37L,6L,5L,4L,62L,12L,38L,4L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260757Inst : IEnumerable<long>
{
public static readonly long[] Value=A260757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260757.Bytes);
public long this[int i]=>Value[i];

public static A260757Inst Instance=new A260757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260758
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,10L,5L,1L,3L,14L,11L,4L,5L,4L,5L,8L,30L,2L,6L,1L,8L,29L,12L,29L,30L,11L,2L,4L,5L,19L,29L,2L,9L,7L,11L,4L,74L,16L,24L,8L,18L,10L,30L,56L,15L,35L,24L,4L,35L,19L,111L,19L,18L,1L,57L,8L,20L,14L,2L,2L,48L,29L,26L,92L,24L,19L,155L,2L,78L,35L,56L,113L,33L,70L,32L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260758Inst : IEnumerable<long>
{
public static readonly long[] Value=A260758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260758.Bytes);
public long this[int i]=>Value[i];

public static A260758Inst Instance=new A260758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260759
{
public static readonly long[] Value={ 48L,115L,652L,2449L,5256L,24103L,104308L,305402L,1256376L,5925416L,21507088L,91126064L,441481332L,1976848566L,8589712868L,45244127036L,228262628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260759Inst : IEnumerable<long>
{
public static readonly long[] Value=A260759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260759.Bytes);
public long this[int i]=>Value[i];

public static A260759Inst Instance=new A260759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260760
{
public static readonly long[] Value={ 48L,82L,190L,350L,622L,1315L,2478L,4597L,9184L,17591L,33096L,64829L,124590L,236647L,458914L,883290L,1686838L,3255660L,6266216L,12003508L,23114992L,44476139L,85340062L,164169628L,315782978L,606459354L,1166124310L,2242522630L,4308761510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260760Inst : IEnumerable<long>
{
public static readonly long[] Value=A260760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260760.Bytes);
public long this[int i]=>Value[i];

public static A260760Inst Instance=new A260760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260761
{
public static readonly long[] Value={ 82L,115L,265L,481L,798L,1671L,3196L,5596L,11008L,21414L,38685L,73802L,143343L,265124L,499236L,961606L,1804214L,3387690L,6472826L,12229083L,22991554L,43688857L,82748766L,155915780L,295370360L,559665162L,1056451639L,1998590816L,3785473856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260761Inst : IEnumerable<long>
{
public static readonly long[] Value=A260761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260761.Bytes);
public long this[int i]=>Value[i];

public static A260761Inst Instance=new A260761Inst();

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