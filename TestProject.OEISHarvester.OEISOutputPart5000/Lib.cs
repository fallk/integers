using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A230311
{
public static readonly BigInteger[] Value={ 1L,2L,6L,42L,1806L,47058L,2214502422L,BigInteger.Parse("8490421583559688410706771261086") };
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
public class A230311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230311.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230311Inst Instance=new A230311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230310
{
public static readonly long[] Value={ 14L,28L,42L,55L,56L,70L,84L,95L,110L,112L,126L,140L,154L,165L,168L,182L,190L,210L,220L,224L,238L,252L,266L,275L,280L,285L,308L,322L,330L,336L,350L,364L,378L,380L,385L,406L,420L,434L,440L,448L,462L,475L,476L,495L,504L,506L,518L,532L,546L,550L,560L,570L,574L,602L,616L,630L,644L,658L,660L,665L,672L,700L,714L,715L,728L,742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230310Inst : IEnumerable<long>
{
public static readonly long[] Value=A230310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230310.Bytes);
public long this[int i]=>Value[i];

public static A230310Inst Instance=new A230310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230309
{
public static readonly long[] Value={ 8L,32L,0L,32L,80L,0L,56L,128L,0L,80L,176L,0L,104L,272L,0L,128L,272L,0L,152L,320L,0L,176L,368L,0L,200L,416L,0L,416L,464L,0L,248L,512L,0L,272L,560L,0L,296L,608L,0L,320L,656L,432L,344L,704L,0L,368L,752L,0L,392L,800L,0L,416L,848L,0L,560L,320L,0L,464L,944L,0L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230309Inst : IEnumerable<long>
{
public static readonly long[] Value=A230309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230309.Bytes);
public long this[int i]=>Value[i];

public static A230309Inst Instance=new A230309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230308
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230308Inst : IEnumerable<long>
{
public static readonly long[] Value=A230308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230308.Bytes);
public long this[int i]=>Value[i];

public static A230308Inst Instance=new A230308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230307
{
public static readonly long[] Value={ 3331L,1163L,-727L,-2339L,-3673L,-4729L,-5507L,-6007L,-6229L,-6173L,-5839L,-5227L,-4337L,-3169L,-1723L,1L,2003L,4283L,6841L,9677L,12791L,16183L,19853L,23801L,28027L,32531L,37313L,42373L,47711L,53327L,59221L,65393L,71843L,78571L,85577L,92861L,100423L,108263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230307Inst : IEnumerable<long>
{
public static readonly long[] Value=A230307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230307.Bytes);
public long this[int i]=>Value[i];

public static A230307Inst Instance=new A230307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230306
{
public static readonly long[] Value={ 0L,9L,15L,18L,27L,30L,36L,45L,51L,54L,60L,72L,75L,85L,90L,99L,102L,108L,120L,129L,135L,144L,150L,153L,159L,165L,170L,180L,189L,195L,198L,204L,207L,215L,216L,225L,231L,240L,243L,249L,255L,258L,267L,270L,288L,297L,300L,303L,306L,315L,318L,325L,330L,340L,360L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230306Inst : IEnumerable<long>
{
public static readonly long[] Value=A230306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230306.Bytes);
public long this[int i]=>Value[i];

public static A230306Inst Instance=new A230306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230305
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,0L,1L,4L,3L,0L,1L,0L,3L,4L,2L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230305Inst : IEnumerable<long>
{
public static readonly long[] Value=A230305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230305.Bytes);
public long this[int i]=>Value[i];

public static A230305Inst Instance=new A230305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230304
{
public static readonly BigInteger[] Value={ 101L,10000000000001L,BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001") };
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
public class A230304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230304Inst Instance=new A230304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230255
{
public static readonly long[] Value={ 113L,157L,179L,199L,311L,337L,359L,733L,739L,751L,937L,953L,971L,991L,1031L,1033L,1091L,1097L,1103L,1109L,1181L,1213L,1217L,1231L,1237L,1259L,1279L,1301L,1321L,1381L,1439L,1453L,1471L,1499L,1523L,1583L,1619L,1657L,1723L,1741L,1811L,1831L,1901L,1949L,3011L,3019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230255Inst : IEnumerable<long>
{
public static readonly long[] Value=A230255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230255.Bytes);
public long this[int i]=>Value[i];

public static A230255Inst Instance=new A230255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230254
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,1L,2L,2L,2L,3L,2L,1L,4L,1L,2L,5L,2L,3L,2L,3L,4L,4L,3L,4L,4L,2L,2L,8L,1L,6L,6L,2L,3L,2L,3L,5L,5L,5L,1L,5L,3L,7L,5L,1L,7L,10L,1L,3L,4L,8L,5L,3L,3L,3L,5L,8L,4L,10L,2L,9L,3L,3L,4L,7L,5L,9L,5L,4L,3L,15L,4L,12L,7L,4L,5L,9L,3L,11L,4L,6L,5L,9L,5L,6L,12L,6L,5L,8L,1L,4L,8L,5L,13L,9L,2L,6L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230254Inst : IEnumerable<long>
{
public static readonly long[] Value=A230254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230254.Bytes);
public long this[int i]=>Value[i];

public static A230254Inst Instance=new A230254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230253
{
public static readonly BigInteger[] Value={ 1L,3L,3L,6L,27L,162L,1206L,10476L,103059L,1125738L,13473378L,174997908L,2448791838L,36706645908L,586646510796L,9957100024152L,178868488496643L,3390603439026618L,67639341903290730L,1416612563019545220L,BigInteger.Parse("31079692422132040170"),BigInteger.Parse("712855563504590236860"),BigInteger.Parse("17061654943814209044660") };
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
public class A230253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230253Inst Instance=new A230253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230252
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,4L,4L,3L,4L,1L,3L,3L,3L,5L,5L,4L,3L,6L,4L,7L,7L,2L,4L,6L,4L,4L,6L,3L,1L,4L,2L,4L,7L,4L,1L,4L,4L,2L,6L,4L,3L,4L,2L,3L,5L,3L,2L,1L,2L,3L,6L,2L,6L,6L,3L,5L,4L,5L,3L,7L,2L,4L,6L,2L,4L,5L,3L,5L,8L,5L,2L,10L,4L,4L,8L,5L,6L,7L,8L,4L,11L,4L,3L,6L,4L,2L,4L,8L,8L,11L,5L,3L,11L,5L,3L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230252Inst : IEnumerable<long>
{
public static readonly long[] Value=A230252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230252.Bytes);
public long this[int i]=>Value[i];

public static A230252Inst Instance=new A230252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230251
{
public static readonly BigInteger[] Value={ 1L,4L,41L,602L,11304L,257400L,6881160L,211170960L,7315701120L,282398538240L,12019910112000L,559278036979200L,28242651241728000L,1538394175334016000L,BigInteger.Parse("89912239244860032000"),BigInteger.Parse("5612575361948755200000"),BigInteger.Parse("372687441873534627840000"),BigInteger.Parse("26231028469670851706880000") };
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
public class A230251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230251Inst Instance=new A230251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230250
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,6L,6L,0L,0L,26L,34L,26L,0L,0L,118L,514L,514L,118L,0L,0L,522L,5838L,18218L,5838L,522L,0L,0L,2310L,64838L,517794L,517794L,64838L,2310L,0L,0L,10234L,722386L,15075834L,38111288L,15075834L,722386L,10234L,0L,0L,45334L,8040426L,442507578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230250Inst : IEnumerable<long>
{
public static readonly long[] Value=A230250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230250.Bytes);
public long this[int i]=>Value[i];

public static A230250Inst Instance=new A230250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230249
{
public static readonly BigInteger[] Value={ 0L,522L,64838L,15075834L,2905031942L,575915716590L,113395635811566L,22307089878854146L,4393204701131698706L,BigInteger.Parse("865095876749918611674"),BigInteger.Parse("170331251165790970494850"),BigInteger.Parse("33537951155031500480807238") };
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
public class A230249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230249Inst Instance=new A230249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230248
{
public static readonly BigInteger[] Value={ 0L,118L,5838L,517794L,38111288L,2905031942L,220881339818L,16727315344402L,1267371575854592L,96051870649304886L,7279121508944890350L,BigInteger.Parse("551622030187576806890"),BigInteger.Parse("41802997413105272045312"),BigInteger.Parse("3167917547077219351494862") };
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
public class A230248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230248Inst Instance=new A230248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230247
{
public static readonly BigInteger[] Value={ 0L,26L,514L,18218L,517794L,15075834L,442507578L,12967930114L,379758106610L,11121513851802L,325716543442890L,9539276850178962L,279376258709766802L,8182075105297220362L,BigInteger.Parse("239627981406267902506"),BigInteger.Parse("7017971646531106112850") };
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
public class A230247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230247Inst Instance=new A230247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230246
{
public static readonly long[] Value={ 0L,6L,34L,514L,5838L,64838L,722386L,8040426L,89496950L,996201406L,11088801786L,123430533890L,1373917986238L,15293224744246L,170230491719618L,1894853512698394L,21091813842617094L,234775199414692462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230246Inst : IEnumerable<long>
{
public static readonly long[] Value=A230246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230246.Bytes);
public long this[int i]=>Value[i];

public static A230246Inst Instance=new A230246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230245
{
public static readonly long[] Value={ 0L,2L,6L,26L,118L,522L,2310L,10234L,45334L,200810L,889510L,3940186L,17453494L,77312202L,342463046L,1516978362L,6719625302L,29765331754L,131848865766L,584039296026L,2587067376886L,11459704266634L,50762041627526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230245Inst : IEnumerable<long>
{
public static readonly long[] Value=A230245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230245.Bytes);
public long this[int i]=>Value[i];

public static A230245Inst Instance=new A230245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230244
{
public static readonly long[] Value={ 0L,2L,34L,18218L,38111288L,575915716590L,57955254721687188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230244Inst : IEnumerable<long>
{
public static readonly long[] Value=A230244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230244.Bytes);
public long this[int i]=>Value[i];

public static A230244Inst Instance=new A230244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230243
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,1L,4L,2L,1L,4L,2L,2L,4L,2L,3L,2L,4L,3L,4L,4L,2L,2L,2L,1L,5L,3L,4L,3L,3L,2L,3L,4L,2L,2L,4L,2L,4L,4L,1L,5L,3L,2L,6L,4L,1L,5L,6L,3L,3L,5L,1L,5L,5L,2L,7L,5L,3L,4L,4L,3L,4L,6L,3L,4L,6L,4L,5L,6L,3L,7L,4L,2L,6L,1L,3L,5L,9L,3L,3L,7L,4L,3L,7L,1L,6L,5L,5L,5L,6L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230243Inst : IEnumerable<long>
{
public static readonly long[] Value=A230243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230243.Bytes);
public long this[int i]=>Value[i];

public static A230243Inst Instance=new A230243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230242
{
public static readonly long[] Value={ 2L,4L,9L,5L,9L,9L,3L,5L,7L,9L,4L,3L,7L,7L,1L,1L,2L,2L,7L,8L,8L,7L,6L,3L,9L,4L,1L,1L,7L,3L,6L,1L,2L,3L,8L,0L,1L,5L,3L,4L,8L,3L,2L,1L,3L,7L,3L,4L,3L,3L,4L,8L,3L,6L,6L,9L,1L,4L,8L,2L,8L,2L,5L,5L,3L,5L,5L,6L,3L,7L,7L,5L,5L,0L,1L,3L,4L,7L,2L,7L,3L,6L,0L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230242Inst : IEnumerable<long>
{
public static readonly long[] Value=A230242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230242.Bytes);
public long this[int i]=>Value[i];

public static A230242Inst Instance=new A230242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230241
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,1L,2L,2L,1L,2L,3L,2L,2L,4L,1L,4L,5L,1L,6L,2L,3L,6L,3L,1L,2L,6L,2L,3L,7L,3L,6L,4L,2L,4L,2L,5L,6L,1L,2L,6L,5L,4L,6L,8L,3L,5L,10L,3L,6L,6L,2L,9L,4L,2L,4L,6L,3L,4L,11L,1L,6L,7L,2L,9L,7L,3L,5L,8L,5L,9L,6L,4L,3L,6L,3L,6L,4L,3L,10L,9L,2L,13L,2L,5L,8L,10L,3L,3L,11L,1L,10L,11L,3L,9L,4L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230241Inst : IEnumerable<long>
{
public static readonly long[] Value=A230241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230241.Bytes);
public long this[int i]=>Value[i];

public static A230241Inst Instance=new A230241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230240
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,13L,16L,19L,25L,27L,28L,31L,36L,37L,40L,43L,45L,49L,52L,55L,61L,63L,64L,67L,72L,73L,76L,79L,81L,85L,88L,91L,97L,99L,100L,103L,108L,109L,112L,115L,117L,121L,124L,127L,133L,135L,136L,139L,144L,145L,148L,151L,153L,157L,160L,163L,169L,171L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230240Inst : IEnumerable<long>
{
public static readonly long[] Value=A230240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230240.Bytes);
public long this[int i]=>Value[i];

public static A230240Inst Instance=new A230240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230143
{
public static readonly BigInteger[] Value={ 3L,75L,1785L,333795L,25638459L,5788790007L,898772045457L,1467030741832227L,380324118068556519L,BigInteger.Parse("244108884436744360605"),BigInteger.Parse("94974266622893811200463"),BigInteger.Parse("58717088286185620331978925"),BigInteger.Parse("95962705639251788100721754775"),BigInteger.Parse("121363236202656183485569513082175") };
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
public class A230143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230143Inst Instance=new A230143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230142
{
public static readonly BigInteger[] Value={ 16L,256L,5632L,1048576L,80543744L,18185977856L,2823575044096L,4608812904349696L,1194823452775677952L,BigInteger.Parse("766890677854432919552"),BigInteger.Parse("298370458295691856838656"),BigInteger.Parse("184465173199612912007643136"),BigInteger.Parse("301475731054794304317414178816"),BigInteger.Parse("381273851270136749855228154609664") };
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
public class A230142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230142Inst Instance=new A230142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230141
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,5L,3L,2L,3L,4L,4L,5L,6L,5L,3L,5L,4L,4L,2L,4L,6L,2L,3L,2L,6L,9L,8L,8L,5L,5L,4L,5L,10L,14L,10L,12L,6L,11L,7L,9L,13L,6L,11L,3L,9L,7L,8L,14L,6L,11L,4L,4L,8L,9L,15L,15L,7L,14L,3L,6L,13L,10L,19L,6L,6L,12L,5L,10L,8L,7L,16L,6L,10L,4L,7L,19L,11L,13L,3L,12L,5L,6L,13L,5L,12L,7L,8L,4L,5L,6L,10L,6L,4L,6L,4L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230141Inst : IEnumerable<long>
{
public static readonly long[] Value=A230141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230141.Bytes);
public long this[int i]=>Value[i];

public static A230141Inst Instance=new A230141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230140
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,2L,3L,1L,2L,2L,2L,3L,3L,4L,2L,3L,2L,3L,3L,3L,4L,2L,5L,2L,6L,3L,6L,5L,4L,5L,3L,5L,5L,8L,7L,6L,5L,6L,5L,5L,7L,6L,8L,4L,6L,5L,6L,7L,9L,8L,8L,5L,7L,6L,8L,10L,6L,10L,4L,8L,6L,6L,10L,6L,9L,5L,6L,5L,7L,7L,9L,6L,7L,8L,5L,10L,6L,9L,6L,6L,7L,4L,7L,7L,9L,6L,5L,5L,4L,6L,5L,6L,5L,5L,6L,4L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230140Inst : IEnumerable<long>
{
public static readonly long[] Value=A230140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230140.Bytes);
public long this[int i]=>Value[i];

public static A230140Inst Instance=new A230140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230139
{
public static readonly long[] Value={ 3L,5L,7L,11L,31L,101L,887L,4861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230139Inst : IEnumerable<long>
{
public static readonly long[] Value=A230139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230139.Bytes);
public long this[int i]=>Value[i];

public static A230139Inst Instance=new A230139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230138
{
public static readonly long[] Value={ 5L,11L,17L,29L,59L,71L,101L,137L,149L,179L,197L,227L,281L,311L,431L,599L,617L,641L,809L,821L,857L,1151L,1277L,1319L,1451L,1481L,1487L,1607L,1667L,1697L,1997L,2027L,2081L,2111L,2129L,2339L,2657L,2711L,2789L,3167L,3329L,3371L,3461L,3557L,3767L,3917L,3929L,4049L,4217L,4259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230138Inst : IEnumerable<long>
{
public static readonly long[] Value=A230138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230138.Bytes);
public long this[int i]=>Value[i];

public static A230138Inst Instance=new A230138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230137
{
public static readonly long[] Value={ 0L,2L,6L,18L,44L,110L,252L,588L,1304L,2934L,6380L,14036L,30120L,65260L,138712L,297240L,627248L,1332902L,2796876L,5904516L,12333320L,25899972L,53897096L,112693928L,233776464L,487034300L,1007623032L,2092755528L,4319728784L,8948009624L,18432890160L,38094639664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230137Inst : IEnumerable<long>
{
public static readonly long[] Value=A230137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230137.Bytes);
public long this[int i]=>Value[i];

public static A230137Inst Instance=new A230137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230136
{
public static readonly long[] Value={ 48L,240L,480L,1440L,1680L,2640L,5040L,6720L,7920L,10560L,12480L,13680L,18720L,21840L,28560L,31200L,32640L,34320L,36960L,44880L,48720L,53040L,63840L,71760L,77520L,87360L,92400L,100320L,115920L,147840L,187680L,201600L,215280L,236640L,244800L,257040L,277200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230136Inst : IEnumerable<long>
{
public static readonly long[] Value=A230136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230136.Bytes);
public long this[int i]=>Value[i];

public static A230136Inst Instance=new A230136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230135
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230135Inst : IEnumerable<long>
{
public static readonly long[] Value=A230135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230135.Bytes);
public long this[int i]=>Value[i];

public static A230135Inst Instance=new A230135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230134
{
public static readonly BigInteger[] Value={ 1L,1L,6L,41L,456L,6301L,108576L,2207981L,52012416L,1390239481L,41593598976L,1376769180401L,49955931795456L,1971671764875541L,84095262825824256L,3854514200269774901L,BigInteger.Parse("188942180401957502976"),BigInteger.Parse("9863099585213327293681"),BigInteger.Parse("546266997049408050364416"),BigInteger.Parse("31993839349571172423492281") };
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
public class A230134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230134Inst Instance=new A230134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230133
{
public static readonly BigInteger[] Value={ 2L,40L,698L,11908L,206388L,3690960L,68577600L,1327697280L,26812356480L,564796979240L,12403183337690L,283718956204402L,6753363090218970L,167092903876164794L,4292602805804464576L,BigInteger.Parse("114374394103260000000"),BigInteger.Parse("3157276569203744863200"),BigInteger.Parse("90202107365906127228000") };
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
public class A230133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230133Inst Instance=new A230133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230132
{
public static readonly BigInteger[] Value={ 2L,36L,574L,9024L,145080L,2419872L,42129360L,767370240L,14631376500L,291914163322L,6088804487138L,132624737931726L,3012939864521998L,71296697740927172L,1755099895042102380L,BigInteger.Parse("44889002698811118240"),BigInteger.Parse("1191389820174200208622"),BigInteger.Parse("32774409073391657243622") };
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
public class A230132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230132Inst Instance=new A230132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230131
{
public static readonly BigInteger[] Value={ 2L,32L,462L,6644L,98472L,1523808L,24744720L,422335056L,7575963254L,142706934722L,2819192544786L,58323311592602L,1261634626792744L,28492765388656632L,670804322638496378L,16439609940896532018UL,BigInteger.Parse("418816100433422180196"),BigInteger.Parse("11077009292500273732470") };
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
public class A230131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230131Inst Instance=new A230131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230130
{
public static readonly BigInteger[] Value={ 2L,28L,362L,4720L,64020L,913440L,13760472L,219040274L,3681354658L,65231186514L,1216489698082L,23832126613268L,489566931234322L,10526180908026522L,236475437787567496L,5541690642862917134L,BigInteger.Parse("135258139216049657102"),BigInteger.Parse("3433304061341792767884"),BigInteger.Parse("90508485528963754208076") };
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
public class A230130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230130Inst Instance=new A230130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230129
{
public static readonly BigInteger[] Value={ 2L,24L,274L,3204L,39420L,514296L,7137818L,105318770L,1649355338L,27356466626L,479446719522L,8858271760146L,172151975433756L,3511580514677006L,75032190827549478L,1676210011258705592L,BigInteger.Parse("39082263260517298658"),BigInteger.Parse("949481770375318700914"),BigInteger.Parse("23998362106238648271276") };
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
public class A230129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230129Inst Instance=new A230129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230128
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,2L,3L,3L,2L,4L,4L,4L,4L,5L,5L,6L,5L,6L,7L,7L,6L,8L,8L,8L,8L,9L,9L,10L,9L,10L,11L,11L,10L,12L,12L,12L,12L,13L,13L,14L,13L,14L,15L,15L,14L,16L,16L,16L,16L,17L,17L,18L,17L,18L,19L,19L,18L,20L,20L,20L,20L,21L,21L,22L,21L,22L,23L,23L,22L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230128Inst : IEnumerable<long>
{
public static readonly long[] Value=A230128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230128.Bytes);
public long this[int i]=>Value[i];

public static A230128Inst Instance=new A230128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229967
{
public static readonly long[] Value={ 18L,26L,28L,39L,65L,115L,119L,133L,319L,341L,377L,403L,481L,517L,629L,697L,731L,779L,799L,817L,893L,1007L,1207L,1219L,1357L,1403L,1541L,1769L,1943L,2059L,2077L,2117L,2201L,2263L,2291L,2407L,2449L,2573L,2759L,2923L,3071L,3293L,3589L,3649L,3737L,3811L,3827L,3959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229967Inst : IEnumerable<long>
{
public static readonly long[] Value=A229967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229967.Bytes);
public long this[int i]=>Value[i];

public static A229967Inst Instance=new A229967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229966
{
public static readonly long[] Value={ 12L,14L,22L,27L,33L,57L,85L,161L,203L,533L,689L,901L,1121L,1633L,2581L,4181L,5513L,5633L,7439L,10561L,18023L,18881L,20833L,21389L,23941L,25043L,28421L,32033L,37733L,48641L,58241L,64643L,66901L,77423L,80033L,84001L,90133L,106439L,116821L,119201L,149189L,155041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229966Inst : IEnumerable<long>
{
public static readonly long[] Value=A229966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229966.Bytes);
public long this[int i]=>Value[i];

public static A229966Inst Instance=new A229966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229965
{
public static readonly long[] Value={ 6L,8L,10L,16L,21L,55L,253L,1081L,1711L,3403L,5671L,13861L,15931L,25651L,34453L,60031L,64261L,73153L,108811L,114481L,126253L,158203L,171991L,258121L,351541L,371953L,392941L,482653L,518671L,703891L,822403L,853471L,869221L,933661L,1034641L,1104841L,1159003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229965Inst : IEnumerable<long>
{
public static readonly long[] Value=A229965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229965.Bytes);
public long this[int i]=>Value[i];

public static A229965Inst Instance=new A229965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229964
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,3L,0L,3L,2L,1L,0L,4L,0L,5L,1L,3L,0L,8L,0L,4L,3L,4L,0L,10L,0L,7L,3L,5L,2L,9L,0L,6L,4L,9L,0L,13L,0L,12L,6L,6L,0L,16L,0L,9L,6L,9L,0L,14L,1L,12L,3L,8L,0L,25L,0L,12L,10L,11L,4L,17L,0L,12L,7L,17L,0L,25L,0L,14L,12L,14L,2L,21L,0L,21L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229964Inst : IEnumerable<long>
{
public static readonly long[] Value=A229964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229964.Bytes);
public long this[int i]=>Value[i];

public static A229964Inst Instance=new A229964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229963
{
public static readonly BigInteger[] Value={ 1L,11L,165L,2860L,53900L,1072797L,22188859L,472214600L,10273141395L,227440759700L,5107663394691L,116068178638776L,2664012608972000L,61668340817988135L,1438101958237201950L,BigInteger.Parse("33753007927148177360"),BigInteger.Parse("796704536753910327114") };
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
public class A229963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229963Inst Instance=new A229963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229962
{
public static readonly long[] Value={ 2L,1L,1L,9L,8L,5L,2L,8L,0L,0L,0L,0L,3L,8L,3L,2L,3L,8L,8L,7L,3L,9L,4L,4L,1L,0L,8L,5L,9L,0L,8L,5L,4L,7L,4L,7L,2L,0L,6L,1L,3L,9L,5L,2L,7L,8L,8L,6L,3L,6L,2L,4L,6L,9L,6L,9L,8L,0L,0L,0L,3L,4L,3L,4L,6L,5L,5L,1L,8L,8L,3L,5L,4L,6L,9L,2L,9L,3L,5L,6L,4L,5L,1L,8L,0L,2L,9L,5L,8L,6L,5L,8L,4L,3L,2L,1L,5L,2L,2L,2L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229962Inst : IEnumerable<long>
{
public static readonly long[] Value=A229962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229962.Bytes);
public long this[int i]=>Value[i];

public static A229962Inst Instance=new A229962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229961
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,2L,1L,7L,5L,2L,3L,1L,1L,10L,7L,5L,3L,1L,6L,3L,1L,2L,3L,1L,1L,13L,11L,8L,6L,4L,2L,9L,7L,4L,2L,5L,3L,1L,7L,4L,2L,3L,4L,2L,1L,17L,14L,12L,10L,8L,5L,3L,1L,13L,10L,8L,6L,4L,1L,9L,6L,4L,2L,5L,2L,1L,10L,8L,6L,4L,1L,6L,4L,2L,2L,4L,2L,8L,5L,3L,1L,4L,1L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229961Inst : IEnumerable<long>
{
public static readonly long[] Value=A229961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229961.Bytes);
public long this[int i]=>Value[i];

public static A229961Inst Instance=new A229961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229960
{
public static readonly long[] Value={ 53L,109L,683L,4759L,7789L,9029L,13523L,15299L,45989L,63179L,68059L,90089L,116423L,174019L,225089L,370619L,610469L,700963L,994949L,1025149L,1119403L,1398599L,1594709L,1898873L,2291189L,2561899L,2734129L,2975543L,3038039L,3296773L,3784169L,3857489L,5913269L,6212483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229960Inst : IEnumerable<long>
{
public static readonly long[] Value=A229960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229960.Bytes);
public long this[int i]=>Value[i];

public static A229960Inst Instance=new A229960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229959
{
public static readonly long[] Value={ 1L,5L,2L,1L,65L,17L,3L,5L,1L,13L,82L,37L,346L,798L,10L,1L,41L,257L,72829155L,65L,4238L,269L,3L,17L,1L,2501L,626L,2039422L,2522L,101L,3303936030L,2567L,646L,23358L,26L,1L,5185L,1297L,577L,13L,1507985L,145L,15004500051L,189987L,445445L,143733855087930L,431211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229959Inst : IEnumerable<long>
{
public static readonly long[] Value=A229959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229959.Bytes);
public long this[int i]=>Value[i];

public static A229959Inst Instance=new A229959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229958
{
public static readonly long[] Value={ 1L,5L,3L,1L,10L,42L,330L,11L,1L,17L,110L,2L,219962L,910L,42L,1L,26L,15L,6162806L,110L,371795L,933478L,510L,255L,1L,37L,462L,28985L,1329410L,39L,266477057L,4807L,4389L,3990L,10L,1L,2L,203L,462L,1295L,15130L,210L,3742742978L,9318265L,1898195L,66915741571718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229958Inst : IEnumerable<long>
{
public static readonly long[] Value=A229958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229958.Bytes);
public long this[int i]=>Value[i];

public static A229958Inst Instance=new A229958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229957
{
public static readonly long[] Value={ 1L,13L,15L,1L,29L,285L,34L,35L,1L,53L,14L,21L,51533L,62L,7L,1L,85L,5L,1299599L,93L,17765L,16445L,2L,11L,1L,5L,1155L,1610L,112897L,1221L,85183670L,35L,141L,142L,143L,1L,173L,8645L,4485L,182L,185L,1677L,1580795L,101177L,235613L,8647745897021L,194L,195L,1L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229957Inst : IEnumerable<long>
{
public static readonly long[] Value=A229957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229957.Bytes);
public long this[int i]=>Value[i];

public static A229957Inst Instance=new A229957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229956
{
public static readonly long[] Value={ 1L,17L,1L,1L,65L,33L,33L,17L,1L,145L,73L,1L,73L,1105L,1L,1L,257L,129L,24465L,65L,129L,97L,2737L,33L,1L,401L,201L,57889L,353L,1L,32929L,161L,105L,609L,41L,1L,577L,1L,193L,145L,481L,97L,142809601L,28985L,2497L,337L,385L,1L,1L,785L,393L,36985L,254473L,219185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229956Inst : IEnumerable<long>
{
public static readonly long[] Value=A229956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229956.Bytes);
public long this[int i]=>Value[i];

public static A229956Inst Instance=new A229956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229955
{
public static readonly long[] Value={ 8L,152L,64L,5056L,2432L,512L,205720L,104000L,29184L,4096L,9305152L,4828544L,1525248L,311296L,32768L,449404224L,236984448L,79898624L,19226624L,3112960L,262144L,22695553536L,12099474432L,4251479040L,1123909632L,221839360L,29884416L,2097152L,1183891745688L,636162156096L,230017430016L,64636047360L,14330265600L,2413559808L,278921216L,16777216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229955Inst : IEnumerable<long>
{
public static readonly long[] Value=A229955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229955.Bytes);
public long this[int i]=>Value[i];

public static A229955Inst Instance=new A229955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229954
{
public static readonly long[] Value={ 3L,16L,152L,2326L,52132L,1602420L,64529264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229954Inst : IEnumerable<long>
{
public static readonly long[] Value=A229954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229954.Bytes);
public long this[int i]=>Value[i];

public static A229954Inst Instance=new A229954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229953
{
public static readonly long[] Value={ 4L,8L,32L,60L,128L,8192L,43200L,69360L,120960L,131072L,524288L,4146912L,6549984L,12927600L,13335840L,16329600L,34715520L,51603840L,57879360L,59633280L,107775360L,160797000L,169155840L,252067200L,371226240L,391789440L,436230144L,439883136L,489888000L,657296640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229953Inst : IEnumerable<long>
{
public static readonly long[] Value=A229953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229953.Bytes);
public long this[int i]=>Value[i];

public static A229953Inst Instance=new A229953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229952
{
public static readonly long[] Value={ 2L,7L,3L,0L,9L,2L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229952Inst : IEnumerable<long>
{
public static readonly long[] Value=A229952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229952.Bytes);
public long this[int i]=>Value[i];

public static A229952Inst Instance=new A229952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229903
{
public static readonly BigInteger[] Value={ 190L,19190L,191919190L,19191919190L,191919191919190L,19191919191919190L,BigInteger.Parse("191919191919191919190"),BigInteger.Parse("19191919191919191919190"),BigInteger.Parse("191919191919191919191919190"),BigInteger.Parse("19191919191919191919191919190"),BigInteger.Parse("191919191919191919191919191919190") };
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
public class A229903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229903Inst Instance=new A229903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229902
{
public static readonly long[] Value={ 10L,10L,10L,2080L,178030L,41697270L,4355942080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229902Inst : IEnumerable<long>
{
public static readonly long[] Value=A229902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229902.Bytes);
public long this[int i]=>Value[i];

public static A229902Inst Instance=new A229902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229901
{
public static readonly BigInteger[] Value={ 1L,2L,12L,120L,2208L,75840L,5026048L,654140416L,168815832320L,86777091183104L,89034709122434048L,BigInteger.Parse("182521862861195356160"),BigInteger.Parse("747975313568170390573056"),BigInteger.Parse("6128911186837999697172176896"),BigInteger.Parse("100428344706090874604628656668672"),BigInteger.Parse("3291036905110044354733349281915109376") };
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
public class A229901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229901Inst Instance=new A229901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229900
{
public static readonly long[] Value={ 1L,1L,3L,7L,22L,54L,192L,496L,1722L,4799L,17013L,48362L,169458L,498733L,1776570L,5331037L,18608396L,57109292L,201213331L,625146398L,2176243724L,6873338754L,24052502138L,76626395556L,265774736523L,856909651252L,2979519037203L,9675077715466L,33455355338926L,109591055905415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229900Inst : IEnumerable<long>
{
public static readonly long[] Value=A229900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229900.Bytes);
public long this[int i]=>Value[i];

public static A229900Inst Instance=new A229900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229899
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,1L,1L,0L,1L,2L,2L,2L,4L,6L,7L,0L,1L,2L,2L,1L,10L,10L,8L,4L,4L,13L,4L,6L,3L,5L,10L,3L,20L,2L,6L,6L,19L,18L,22L,4L,11L,6L,16L,4L,3L,7L,28L,8L,28L,16L,4L,16L,32L,31L,30L,5L,8L,16L,13L,32L,7L,17L,6L,40L,7L,2L,43L,8L,36L,43L,10L,12L,8L,46L,44L,8L,30L,16L,39L,8L,24L,20L,11L,39L,30L,14L,22L,9L,58L,58L,22L,17L,22L,61L,60L,30L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229899Inst : IEnumerable<long>
{
public static readonly long[] Value=A229899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229899.Bytes);
public long this[int i]=>Value[i];

public static A229899Inst Instance=new A229899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229898
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,13L,24L,37L,56L,83L,140L,205L,306L,439L,632L,983L,1418L,2035L,2886L,4063L,5618L,8369L,11666L,16423L,22716L,31477L,42782L,58385L,82700L,113161L,155028L,210769L,285644L,383687L,514496L,682921L,940326L,1256299L,1687364L,2245691L,2997182L,3955447L,5233314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229898Inst : IEnumerable<long>
{
public static readonly long[] Value=A229898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229898.Bytes);
public long this[int i]=>Value[i];

public static A229898Inst Instance=new A229898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229897
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,2L,2L,2L,1L,1L,1L,4L,1L,3L,2L,3L,3L,3L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,5L,1L,4L,2L,4L,3L,4L,4L,4L,1L,1L,3L,1L,2L,3L,2L,2L,3L,1L,3L,3L,2L,3L,3L,3L,3L,3L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229897Inst : IEnumerable<long>
{
public static readonly long[] Value=A229897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229897.Bytes);
public long this[int i]=>Value[i];

public static A229897Inst Instance=new A229897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229896
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,27L,1L,7L,37L,256L,1L,9L,61L,369L,3125L,1L,11L,91L,671L,4651L,46656L,1L,13L,127L,1105L,9031L,70993L,823543L,1L,15L,169L,1695L,15961L,144495L,1273609L,16777216L,1L,17L,217L,2465L,26281L,269297L,2685817L,26269505L,387420489L,1L,19L,271L,3439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229896Inst : IEnumerable<long>
{
public static readonly long[] Value=A229896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229896.Bytes);
public long this[int i]=>Value[i];

public static A229896Inst Instance=new A229896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229895
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229895Inst : IEnumerable<long>
{
public static readonly long[] Value=A229895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229895.Bytes);
public long this[int i]=>Value[i];

public static A229895Inst Instance=new A229895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229894
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229894Inst : IEnumerable<long>
{
public static readonly long[] Value=A229894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229894.Bytes);
public long this[int i]=>Value[i];

public static A229894Inst Instance=new A229894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229893
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,0L,2L,2L,-1L,-2L,-1L,2L,-1L,-2L,0L,0L,0L,1L,3L,2L,-2L,2L,-6L,-4L,3L,0L,4L,0L,3L,2L,0L,-4L,0L,-2L,-2L,0L,-3L,0L,2L,0L,0L,4L,-5L,-2L,1L,6L,0L,4L,0L,-3L,2L,2L,5L,-8L,2L,4L,-6L,0L,3L,-4L,-9L,-8L,0L,8L,0L,-2L,-5L,4L,6L,0L,10L,-2L,4L,6L,-3L,-6L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229893Inst : IEnumerable<long>
{
public static readonly long[] Value=A229893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229893.Bytes);
public long this[int i]=>Value[i];

public static A229893Inst Instance=new A229893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229892
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,5L,3L,1L,1L,0L,16L,6L,4L,1L,1L,0L,61L,26L,10L,5L,1L,1L,0L,272L,71L,20L,15L,6L,1L,1L,0L,1385L,413L,125L,35L,21L,7L,1L,1L,0L,7936L,1456L,461L,70L,56L,28L,8L,1L,1L,0L,50521L,10576L,1301L,574L,126L,84L,36L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229892Inst : IEnumerable<long>
{
public static readonly long[] Value=A229892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229892.Bytes);
public long this[int i]=>Value[i];

public static A229892Inst Instance=new A229892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229891
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,66L,286L,1001L,3003L,8008L,19448L,43758L,92378L,184756L,3711916L,39277446L,290971966L,1693270006L,8237327526L,34822561201L,131333661601L,450356465701L,1424215551901L,4199713947571L,122741742741301L,1863639732429616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229891Inst : IEnumerable<long>
{
public static readonly long[] Value=A229891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229891.Bytes);
public long this[int i]=>Value[i];

public static A229891Inst Instance=new A229891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229890
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,55L,220L,715L,2002L,5005L,11440L,24310L,48620L,880022L,8438222L,56936672L,303159572L,1354883102L,5281317614L,18427861739L,58640820239L,172577535989L,4529938877492L,62058701943644L,590100171030140L,4371834356234285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229890Inst : IEnumerable<long>
{
public static readonly long[] Value=A229890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229890.Bytes);
public long this[int i]=>Value[i];

public static A229890Inst Instance=new A229890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229889
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,9L,45L,165L,495L,1287L,3003L,6435L,12870L,207350L,1782638L,10852478L,52422578L,213586658L,762311978L,2445069626L,7177825511L,167072419775L,2041472747275L,17401832788275L,116094500641665L,645070724513865L,3103383925397925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229889Inst : IEnumerable<long>
{
public static readonly long[] Value=A229889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229889.Bytes);
public long this[int i]=>Value[i];

public static A229889Inst Instance=new A229889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229888
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,36L,120L,330L,792L,1716L,3432L,48477L,368797L,2002429L,8685469L,31964725L,103593205L,303129685L,6156709438L,66139517554L,498859498016L,2961422519550L,14715247475500L,63593705003400L,245316996896400L,6498850067259615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229888Inst : IEnumerable<long>
{
public static readonly long[] Value=A229888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229888.Bytes);
public long this[int i]=>Value[i];

public static A229888Inst Instance=new A229888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229823
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,7L,1L,-21L,-1L,49L,-1L,-91L,7L,119L,1L,0L,-21L,-2L,-1L,6L,49L,-14L,-1L,28L,-91L,-42L,7L,28L,119L,62L,1L,-2L,0L,4L,-21L,-8L,-2L,14L,-1L,-14L,6L,-14L,49L,90L,-14L,-174L,-1L,2L,28L,-4L,-91L,6L,-42L,0L,7L,-28L,28L,76L,119L,-84L,62L,-78L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229823Inst : IEnumerable<long>
{
public static readonly long[] Value=A229823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229823.Bytes);
public long this[int i]=>Value[i];

public static A229823Inst Instance=new A229823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229822
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,7L,1L,-21L,-1L,49L,-1L,-91L,7L,0L,1L,-2L,-21L,6L,-1L,-14L,49L,28L,-1L,-42L,-91L,28L,7L,-2L,0L,4L,1L,-8L,-2L,14L,-21L,-14L,6L,-14L,-1L,90L,-14L,2L,49L,-4L,28L,6L,-1L,0L,-42L,-28L,-91L,76L,28L,-84L,7L,-2L,-2L,2L,0L,6L,4L,-28L,1L,48L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229822Inst : IEnumerable<long>
{
public static readonly long[] Value=A229822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229822.Bytes);
public long this[int i]=>Value[i];

public static A229822Inst Instance=new A229822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229821
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,7L,1L,-21L,-1L,49L,-1L,0L,7L,-2L,1L,6L,-21L,-14L,-1L,28L,49L,-42L,-1L,-2L,0L,4L,7L,-8L,-2L,14L,1L,-14L,6L,-14L,-21L,2L,-14L,-4L,-1L,6L,28L,0L,49L,-28L,-42L,76L,-1L,-2L,-2L,2L,0L,6L,4L,-28L,7L,48L,-8L,-8L,-2L,0L,14L,8L,1L,-22L,-14L,20L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229821Inst : IEnumerable<long>
{
public static readonly long[] Value=A229821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229821.Bytes);
public long this[int i]=>Value[i];

public static A229821Inst Instance=new A229821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229820
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,7L,1L,-21L,-1L,0L,-1L,-2L,7L,6L,1L,-14L,-21L,28L,-1L,-2L,0L,4L,-1L,-8L,-2L,14L,7L,-14L,6L,2L,1L,-4L,-14L,6L,-21L,0L,28L,-28L,-1L,-2L,-2L,2L,0L,6L,4L,-28L,-1L,48L,-8L,0L,-2L,8L,14L,-22L,7L,20L,-14L,40L,6L,8L,2L,-14L,1L,-2L,-4L,60L,-14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229820Inst : IEnumerable<long>
{
public static readonly long[] Value=A229820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229820.Bytes);
public long this[int i]=>Value[i];

public static A229820Inst Instance=new A229820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229819
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,7L,1L,0L,-1L,-2L,-1L,6L,7L,-14L,1L,-2L,0L,4L,-1L,-8L,-2L,14L,-1L,2L,6L,-4L,7L,6L,-14L,0L,1L,-2L,-2L,2L,0L,6L,4L,-28L,-1L,0L,-8L,8L,-2L,-22L,14L,41L,-1L,8L,2L,-14L,6L,19L,-4L,-24L,7L,-6L,6L,5L,-14L,-5L,0L,5L,1L,-1L,-2L,0L,-2L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229819Inst : IEnumerable<long>
{
public static readonly long[] Value=A229819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229819.Bytes);
public long this[int i]=>Value[i];

public static A229819Inst Instance=new A229819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229818
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,-2L,-1L,6L,-1L,-2L,0L,4L,1L,-8L,-2L,2L,-1L,-4L,6L,6L,-1L,-2L,-2L,2L,0L,-1L,4L,0L,1L,1L,-8L,-1L,-2L,1L,2L,0L,-1L,-4L,-4L,1L,6L,-4L,6L,8L,-1L,-3L,-2L,4L,-2L,2L,2L,1L,0L,6L,-1L,-20L,4L,7L,0L,-14L,1L,20L,1L,-7L,-8L,6L,-1L,-3L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229818Inst : IEnumerable<long>
{
public static readonly long[] Value=A229818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229818.Bytes);
public long this[int i]=>Value[i];

public static A229818Inst Instance=new A229818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229817
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,0L,-1L,-2L,1L,-2L,0L,4L,-1L,2L,-2L,-3L,1L,-1L,-2L,0L,0L,-1L,4L,0L,-1L,-1L,2L,4L,-2L,3L,-3L,-6L,1L,-3L,-1L,5L,-2L,2L,0L,2L,0L,4L,-1L,-9L,4L,-5L,0L,8L,-1L,3L,-1L,-7L,2L,-4L,4L,3L,-2L,-1L,3L,5L,-3L,4L,-6L,-6L,1L,-2L,-3L,1L,-1L,-1L,5L,3L,-2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229817Inst : IEnumerable<long>
{
public static readonly long[] Value=A229817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229817.Bytes);
public long this[int i]=>Value[i];

public static A229817Inst Instance=new A229817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229816
{
public static readonly long[] Value={ 1L,0L,2L,2L,4L,5L,9L,11L,18L,23L,34L,44L,63L,80L,111L,142L,190L,242L,319L,402L,522L,655L,837L,1045L,1322L,1638L,2053L,2532L,3144L,3857L,4757L,5803L,7111L,8636L,10516L,12716L,15404L,18543L,22355L,26807L,32168L,38430L,45929L,54670L,65088L,77220L,91599L,108330L,128077L,151006L,177974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229816Inst : IEnumerable<long>
{
public static readonly long[] Value=A229816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229816.Bytes);
public long this[int i]=>Value[i];

public static A229816Inst Instance=new A229816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229815
{
public static readonly long[] Value={ 2L,65L,72L,128L,250L,370L,468L,520L,637L,730L,793L,1125L,1241L,1332L,1458L,1853L,2000L,2205L,2745L,2960L,3528L,3744L,3925L,4097L,4160L,4394L,4608L,4706L,4825L,4941L,5096L,5256L,5840L,5913L,6344L,6641L,6984L,7202L,8125L,8192L,9000L,9325L,9386L,9477L,9773L,9826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229815Inst : IEnumerable<long>
{
public static readonly long[] Value=A229815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229815.Bytes);
public long this[int i]=>Value[i];

public static A229815Inst Instance=new A229815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229814
{
public static readonly long[] Value={ 23L,1759L,2383L,41179L,61283L,71353L,83431L,127709L,2271433L,3372269L,3532381L,4993559L,5033593L,5714153L,7275503L,8876899L,9117109L,9377351L,9717649L,10618513L,142711909L,157913297L,166314107L,169314437L,170914591L,187116073L,187716127L,190716451L,194916901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229814Inst : IEnumerable<long>
{
public static readonly long[] Value=A229814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229814.Bytes);
public long this[int i]=>Value[i];

public static A229814Inst Instance=new A229814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229813
{
public static readonly long[] Value={ 1L,3L,9L,45L,225L,1275L,7389L,44745L,276849L,1750275L,11236833L,73114437L,480936033L,3193267467L,21372274341L,144040951953L,976706321121L,6658535367555L,45611307797049L,313782691341597L,2167022784185505L,15018193080454491L,104413014897103917L,728039790269173209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229813Inst : IEnumerable<long>
{
public static readonly long[] Value=A229813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229813.Bytes);
public long this[int i]=>Value[i];

public static A229813Inst Instance=new A229813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229812
{
public static readonly long[] Value={ 1L,2L,8L,34L,184L,1010L,5936L,35770L,221872L,1401890L,9005240L,58596754L,385519912L,2560003442L,17135913440L,115500024010L,783243325792L,5340020544962L,36581801008616L,251678879996290L,1738217149202584L,12046997299005938L,83759578272807440L,584052716966420698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229812Inst : IEnumerable<long>
{
public static readonly long[] Value=A229812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229812.Bytes);
public long this[int i]=>Value[i];

public static A229812Inst Instance=new A229812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229811
{
public static readonly long[] Value={ 1L,1L,5L,23L,121L,673L,3953L,23891L,148321L,938257L,6031565L,39273839L,258529513L,1717533025L,11501168105L,77546905595L,526026614209L,3587296445473L,24580453618709L,169145840067335L,1168420570513177L,8099287225541473L,56320768883163425L,392777334265548323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229811Inst : IEnumerable<long>
{
public static readonly long[] Value=A229811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229811.Bytes);
public long this[int i]=>Value[i];

public static A229811Inst Instance=new A229811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229810
{
public static readonly BigInteger[] Value={ 1L,5L,25L,215L,1825L,17525L,172525L,1772435L,18615025L,199711445L,2176008625L,24027883055L,268226469025L,3022357427765L,34328716158325L,392633368190075L,4518132270765025L,52271679549480485L,607648547991054025L,7094152934668535495L,BigInteger.Parse("83143099009577766625") };
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
public class A229810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229810Inst Instance=new A229810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229809
{
public static readonly BigInteger[] Value={ 1L,3L,21L,153L,1401L,13083L,130401L,1334613L,14048481L,150675363L,1642689501L,18141639153L,202569926121L,2282923197003L,25934267869401L,296661689600733L,3414170774033601L,39503727765284163L,459266320623014181L,5362271816243579913L,BigInteger.Parse("62850255058362431001") };
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
public class A229809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229809Inst Instance=new A229809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229808
{
public static readonly BigInteger[] Value={ 1L,2L,16L,122L,1096L,10322L,102856L,1054322L,11104336L,119175842L,1299844576L,14360860202L,160403229016L,1808192266322L,20545886851096L,235069897341122L,2705792876561056L,31312112470672322L,364079737402597936L,4251402314343575642L,BigInteger.Parse("49835252820257276776") };
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
public class A229808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229808Inst Instance=new A229808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229791
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,12L,13L,15L,17L,19L,20L,21L,25L,26L,27L,28L,29L,30L,31L,34L,35L,37L,39L,40L,41L,43L,45L,48L,49L,50L,51L,52L,53L,55L,57L,58L,60L,61L,63L,65L,67L,68L,70L,73L,74L,75L,76L,78L,79L,80L,82L,84L,85L,87L,89L,90L,91L,93L,95L,97L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229791Inst : IEnumerable<long>
{
public static readonly long[] Value=A229791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229791.Bytes);
public long this[int i]=>Value[i];

public static A229791Inst Instance=new A229791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229790
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,6L,6L,6L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229790Inst : IEnumerable<long>
{
public static readonly long[] Value=A229790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229790.Bytes);
public long this[int i]=>Value[i];

public static A229790Inst Instance=new A229790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229789
{
public static readonly long[] Value={ 1L,-2L,5L,4L,-28L,35L,-8L,108L,-378L,315L,16L,-352L,2376L,-5544L,3465L,-32L,1040L,-11440L,51480L,-90090L,45045L,64L,-2880L,46800L,-343200L,1158300L,-1621620L,675675L,-128L,7616L,-171360L,1856400L,-10210200L,27567540L,-32162130L,11486475L,256L,-19456L,578816L,-8682240L,70543200L,-310390080L,698377680L,-698377680L,218243025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229789Inst : IEnumerable<long>
{
public static readonly long[] Value=A229789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229789.Bytes);
public long this[int i]=>Value[i];

public static A229789Inst Instance=new A229789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229788
{
public static readonly long[] Value={ 0L,0L,4L,18L,54L,136L,312L,678L,1426L,2940L,5988L,12106L,24366L,48912L,98032L,196302L,392874L,786052L,1572444L,3145266L,6290950L,12582360L,25165224L,50330998L,100662594L,201325836L,402652372L,805305498L,1610611806L,3221224480L,6442449888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229788Inst : IEnumerable<long>
{
public static readonly long[] Value=A229788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229788.Bytes);
public long this[int i]=>Value[i];

public static A229788Inst Instance=new A229788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229787
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,5L,7L,13L,17L,19L,23L,5L,11L,13L,19L,23L,1L,7L,11L,17L,1L,5L,7L,11L,13L,17L,7L,11L,17L,19L,5L,7L,13L,19L,23L,5L,11L,13L,23L,1L,5L,7L,19L,7L,11L,13L,17L,23L,1L,11L,17L,23L,5L,7L,13L,17L,19L,5L,19L,23L,1L,5L,19L,1L,11L,13L,17L,23L,7L,13L,19L,23L,5L,13L,17L,1L,11L,13L,23L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229787Inst : IEnumerable<long>
{
public static readonly long[] Value=A229787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229787.Bytes);
public long this[int i]=>Value[i];

public static A229787Inst Instance=new A229787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229786
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,0L,6L,8L,14L,18L,20L,1L,7L,13L,15L,21L,2L,4L,10L,14L,20L,5L,9L,11L,15L,17L,21L,12L,16L,22L,1L,11L,13L,19L,2L,6L,12L,18L,20L,7L,9L,13L,15L,4L,16L,20L,22L,3L,9L,11L,21L,4L,10L,16L,18L,1L,5L,7L,17L,8L,12L,14L,18L,9L,15L,2L,4L,8L,14L,22L,5L,11L,15L,21L,6L,10L,18L,5L,7L,17L,19L,2L,6L,12L,20L,1L,3L,7L,19L,4L,8L,16L,20L,3L,15L,17L,12L,18L,5L,11L,17L,19L,2L,12L,18L,1L,3L,9L,15L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229786Inst : IEnumerable<long>
{
public static readonly long[] Value=A229786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229786.Bytes);
public long this[int i]=>Value[i];

public static A229786Inst Instance=new A229786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229785
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,9L,10L,12L,14L,16L,18L,19L,20L,22L,24L,25L,26L,28L,30L,31L,32L,33L,34L,36L,38L,40L,42L,43L,44L,45L,46L,48L,50L,52L,54L,55L,56L,58L,60L,61L,62L,63L,64L,66L,68L,70L,72L,73L,74L,76L,78L,79L,80L,81L,82L,84L,86L,88L,90L,91L,92L,94L,96L,97L,98L,100L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229785Inst : IEnumerable<long>
{
public static readonly long[] Value=A229785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229785.Bytes);
public long this[int i]=>Value[i];

public static A229785Inst Instance=new A229785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229784
{
public static readonly long[] Value={ 1L,7L,4L,0L,5L,1L,4L,0L,9L,9L,0L,6L,9L,5L,0L,6L,3L,9L,8L,8L,9L,5L,2L,8L,3L,9L,2L,8L,7L,7L,8L,4L,7L,3L,8L,4L,1L,7L,6L,6L,7L,3L,0L,6L,1L,7L,0L,6L,5L,5L,6L,2L,5L,1L,6L,2L,9L,5L,4L,4L,5L,1L,8L,4L,9L,5L,8L,4L,3L,3L,4L,0L,3L,9L,4L,0L,7L,3L,2L,2L,3L,9L,6L,2L,7L,3L,6L,2L,1L,1L,2L,8L,1L,7L,2L,8L,5L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229784Inst : IEnumerable<long>
{
public static readonly long[] Value=A229784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229784.Bytes);
public long this[int i]=>Value[i];

public static A229784Inst Instance=new A229784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229783
{
public static readonly long[] Value={ 1110000L,810000L,8100000L,81000000L,81000000L,111000000L,111000000L,81000000L,81000000L,810000000L,810000000L,1110000000L,810000000L,810000000L,810000000L,810000000L,810000000L,1110000000L,1110000000L,810000000L,810000000L,810000000L,1110000000L,1110000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229783Inst : IEnumerable<long>
{
public static readonly long[] Value=A229783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229783.Bytes);
public long this[int i]=>Value[i];

public static A229783Inst Instance=new A229783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229782
{
public static readonly long[] Value={ 3000L,30000L,81000L,30000L,81000L,810000L,810000L,1110000L,1110000L,810000L,300000L,300000L,810000L,1920000L,810000L,300000L,300000L,300000L,300000L,300000L,1110000L,8100000L,8100000L,11100000L,8100000L,8100000L,3000000L,11100000L,8100000L,8100000L,8100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229782Inst : IEnumerable<long>
{
public static readonly long[] Value=A229782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229782.Bytes);
public long this[int i]=>Value[i];

public static A229782Inst Instance=new A229782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229781
{
public static readonly long[] Value={ 2L,30L,810L,300L,300L,3000L,3000L,3000L,3000L,3000L,8100L,3000L,3000L,3000L,81000L,30000L,30000L,30000L,81000L,111000L,30000L,30000L,30000L,30000L,81000L,111000L,30000L,30000L,30000L,81000L,111000L,30000L,30000L,30000L,111000L,30000L,141000L,81000L,81000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229781Inst : IEnumerable<long>
{
public static readonly long[] Value=A229781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229781.Bytes);
public long this[int i]=>Value[i];

public static A229781Inst Instance=new A229781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229780
{
public static readonly long[] Value={ 5L,2L,3L,6L,0L,6L,7L,9L,7L,7L,4L,9L,9L,7L,8L,9L,6L,9L,6L,4L,0L,9L,1L,7L,3L,6L,6L,8L,7L,3L,1L,2L,7L,6L,2L,3L,5L,4L,4L,0L,6L,1L,8L,3L,5L,9L,6L,1L,1L,5L,2L,5L,7L,2L,4L,2L,7L,0L,8L,9L,7L,2L,4L,5L,4L,1L,0L,5L,2L,0L,9L,2L,5L,6L,3L,7L,8L,0L,4L,8L,9L,9L,4L,1L,4L,4L,1L,4L,4L,0L,8L,3L,7L,8L,7L,8L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229780Inst : IEnumerable<long>
{
public static readonly long[] Value=A229780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229780.Bytes);
public long this[int i]=>Value[i];

public static A229780Inst Instance=new A229780Inst();

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