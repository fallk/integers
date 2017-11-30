using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A124489
{
public static readonly long[] Value={ 77385L,87675L,320775L,329175L,509355L,1137045L,1447110L,2623005L,3310965L,3974880L,4095000L,4339335L,5183220L,6163815L,6975780L,9080190L,9462285L,10957170L,11139975L,11148900L,12382755L,12796140L,15514695L,15917580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124489Inst : IEnumerable<long>
{
public static readonly long[] Value=A124489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124489.Bytes);
public long this[int i]=>Value[i];

public static A124489Inst Instance=new A124489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124490
{
public static readonly long[] Value={ 1447110L,2623005L,4095000L,4339335L,6975780L,9080190L,12382755L,19455975L,20322960L,30020760L,32261985L,54202995L,62014155L,63196350L,66383520L,71369340L,94571295L,121012185L,124225920L,162780660L,177109380L,196068180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124490Inst : IEnumerable<long>
{
public static readonly long[] Value=A124490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124490.Bytes);
public long this[int i]=>Value[i];

public static A124490Inst Instance=new A124490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124491
{
public static readonly long[] Value={ 1447110L,30020760L,32261985L,121012185L,203937090L,546020475L,546037695L,837344865L,1140530160L,2517567255L,2664703335L,2841691440L,2896212165L,3000108405L,3190108740L,5204790360L,5744351970L,6872932605L,7090912185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124491Inst : IEnumerable<long>
{
public static readonly long[] Value=A124491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124491.Bytes);
public long this[int i]=>Value[i];

public static A124491Inst Instance=new A124491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124492
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,77385L,1447110L,1447110L,203937090L,107290072890L,4724240531010L,123618251967210L,1272603355923900L,9089306184994125090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124492Inst : IEnumerable<long>
{
public static readonly long[] Value=A124492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124492.Bytes);
public long this[int i]=>Value[i];

public static A124492Inst Instance=new A124492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124493
{
public static readonly long[] Value={ 3L,6L,21L,45L,90L,180L,255L,360L,510L,516L,615L,705L,726L,741L,756L,906L,945L,951L,966L,1230L,1350L,1410L,1725L,1746L,1770L,1911L,1956L,2541L,2700L,2721L,2925L,3051L,3066L,3225L,3540L,3576L,3675L,3951L,4485L,4611L,5295L,5346L,5355L,5586L,5736L,5775L,5901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124493Inst : IEnumerable<long>
{
public static readonly long[] Value=A124493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124493.Bytes);
public long this[int i]=>Value[i];

public static A124493Inst Instance=new A124493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124494
{
public static readonly long[] Value={ 3L,45L,90L,180L,255L,615L,705L,1350L,1770L,3225L,5295L,5775L,5955L,6060L,8580L,9855L,9945L,11175L,13095L,13740L,15195L,21825L,26820L,26925L,27615L,28920L,30075L,30705L,31710L,33375L,35700L,37350L,37665L,41250L,43770L,49185L,50700L,52185L,53640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124494Inst : IEnumerable<long>
{
public static readonly long[] Value=A124494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124494.Bytes);
public long this[int i]=>Value[i];

public static A124494Inst Instance=new A124494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124495
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,14L,43L,81L,283L,556L,2243L,4512L,21374L,43469L,243817L,497217L,3289606L,6697795L,51583952L,104698998L,922789643L,1867079621L,18522929815L,37380015420L,411572179999L,828925168492L,10014624164666L,20140445929353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124495Inst : IEnumerable<long>
{
public static readonly long[] Value=A124495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124495.Bytes);
public long this[int i]=>Value[i];

public static A124495Inst Instance=new A124495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124496
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,9L,4L,1L,1L,31L,14L,5L,1L,1L,121L,54L,20L,6L,1L,1L,523L,233L,85L,27L,7L,1L,1L,2469L,1101L,400L,125L,35L,8L,1L,1L,12611L,5625L,2046L,635L,175L,44L,9L,1L,1L,69161L,30846L,11226L,3488L,952L,236L,54L,10L,1L,1L,404663L,180474L,65676L,20425L,5579L,1366L,309L,65L,11L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124496Inst : IEnumerable<long>
{
public static readonly long[] Value=A124496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124496.Bytes);
public long this[int i]=>Value[i];

public static A124496Inst Instance=new A124496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124497
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,20L,48L,116L,288L,724L,1849L,4768L,12423L,32628L,86342L,229952L,616042L,1659012L,4489101L,12199521L,33284546L,91140797L,250396629L,690043032L,1907022197L,5284167884L,14677681554L,40862469713L,114001697975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124497Inst : IEnumerable<long>
{
public static readonly long[] Value=A124497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124497.Bytes);
public long this[int i]=>Value[i];

public static A124497Inst Instance=new A124497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124498
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,6L,3L,17L,20L,15L,53L,90L,45L,15L,205L,357L,210L,105L,871L,1484L,1260L,420L,105L,3876L,7380L,6426L,2520L,945L,18820L,39195L,33390L,18900L,4725L,945L,99585L,213180L,202950L,117810L,34650L,10395L,558847L,1242120L,1293435L,734580L,311850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124498Inst : IEnumerable<long>
{
public static readonly long[] Value=A124498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124498.Bytes);
public long this[int i]=>Value[i];

public static A124498Inst Instance=new A124498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124499
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,62L,160L,425L,1140L,3105L,8528L,23643L,66008L,185526L,524384L,1489810L,4251852L,12184745L,35048405L,101156752L,292865417L,850314803L,2475327088L,7223400899L,21126670372L,61920289652L,181838859665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124499Inst : IEnumerable<long>
{
public static readonly long[] Value=A124499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124499.Bytes);
public long this[int i]=>Value[i];

public static A124499Inst Instance=new A124499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124500
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,25L,67L,180L,495L,1375L,3871L,10993L,31493L,90843L,263686L,769466L,2256135L,6643082L,19634705L,58232350L,173242381L,516860717L,1546035258L,4635543843L,13929569399L,41943013047L,126532961332L,382396277940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124500Inst : IEnumerable<long>
{
public static readonly long[] Value=A124500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124500.Bytes);
public long this[int i]=>Value[i];

public static A124500Inst Instance=new A124500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124501
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,25L,68L,186L,522L,1479L,4246L,12289L,35872L,105411L,311662L,926270L,2765778L,8292296L,24953437L,75338686L,228140842L,692733127L,2108652750L,6433255041L,19668210742L,60247367313L,184879648441L,568281131800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124501Inst : IEnumerable<long>
{
public static readonly long[] Value=A124501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124501.Bytes);
public long this[int i]=>Value[i];

public static A124501Inst Instance=new A124501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124502
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,14L,23L,37L,60L,98L,158L,256L,414L,670L,1085L,1755L,2840L,4595L,7435L,12031L,19466L,31497L,50963L,82460L,133424L,215884L,349308L,565192L,914500L,1479693L,2394193L,3873886L,6268079L,10141965L,16410045L,26552010L,42962055L,69514065L,112476120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124502Inst : IEnumerable<long>
{
public static readonly long[] Value=A124502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124502.Bytes);
public long this[int i]=>Value[i];

public static A124502Inst Instance=new A124502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124503
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,11L,4L,32L,20L,113L,80L,10L,422L,385L,70L,1788L,1792L,560L,8015L,9492L,3360L,280L,39435L,50640L,23100L,2800L,204910L,295020L,147840L,30800L,1144377L,1763300L,1044120L,246400L,15400L,6722107L,11278410L,7241520L,2202200L,200200L,41877722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124503Inst : IEnumerable<long>
{
public static readonly long[] Value=A124503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124503.Bytes);
public long this[int i]=>Value[i];

public static A124503Inst Instance=new A124503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124632
{
public static readonly long[] Value={ 1L,0L,3L,4L,24L,44L,171L,388L,1166L,2808L,7344L,17281L,41569L,93936L,211251L,456531L,972231L,2009719L,4083805L,8100885L,15793128L,30169374L,56685408L,104633216L,190186136L,340286657L,600267525L,1044006248L,1792246370L,3037619066L,5087101373L,8420649189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124632Inst : IEnumerable<long>
{
public static readonly long[] Value=A124632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124632.Bytes);
public long this[int i]=>Value[i];

public static A124632Inst Instance=new A124632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124633
{
public static readonly long[] Value={ 1L,2L,9L,25L,66L,149L,329L,650L,1248L,2255L,3941L,6608L,10799L,17085L,26456L,39983L,59306L,86274L,123572L,174146L,242186L,332312L,450738L,604418L,802447L,1054848L,1374561L,1775839L,2276528L,2896401L,3659799L,4593424L,5729858L,7104777L,8760897L,10745098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124633Inst : IEnumerable<long>
{
public static readonly long[] Value=A124633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124633.Bytes);
public long this[int i]=>Value[i];

public static A124633Inst Instance=new A124633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124634
{
public static readonly long[] Value={ 1L,2L,10L,34L,116L,332L,948L,2450L,6126L,15522L,34938L,77676L,164746L,338024L,666934L,1283264L,2393329L,4361006L,7753340L,13502336L,23035680L,38603394L,63558590L,103010192L,164426156L,258818678L,401977394L,616628128L,934719004L,1401251614L,2078441930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124634Inst : IEnumerable<long>
{
public static readonly long[] Value=A124634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124634.Bytes);
public long this[int i]=>Value[i];

public static A124634Inst Instance=new A124634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124635
{
public static readonly long[] Value={ 1L,2L,10L,37L,143L,478L,1588L,4910L,14748L,42235L,116910L,311478L,803343L,2004434L,4853669L,11414943L,26127222L,58267164L,126811068L,269647980L,560935635L,1142812869L,2282784640L,4475122564L,8618047164L,16317369805L,30400944921L,55776101043L,100842883244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124635Inst : IEnumerable<long>
{
public static readonly long[] Value=A124635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124635.Bytes);
public long this[int i]=>Value[i];

public static A124635Inst Instance=new A124635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124636
{
public static readonly long[] Value={ 1L,0L,3L,4L,7L,12L,24L,28L,55L,76L,111L,160L,238L,304L,447L,588L,784L,1036L,1379L,1728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124636Inst : IEnumerable<long>
{
public static readonly long[] Value=A124636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124636.Bytes);
public long this[int i]=>Value[i];

public static A124636Inst Instance=new A124636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124637
{
public static readonly long[] Value={ 1L,0L,3L,4L,12L,14L,42L,56L,126L,182L,360L,532L,972L,1432L,2452L,3636L,5902L,8654L,13560L,19664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124637Inst : IEnumerable<long>
{
public static readonly long[] Value=A124637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124637.Bytes);
public long this[int i]=>Value[i];

public static A124637Inst Instance=new A124637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124638
{
public static readonly long[] Value={ 1L,0L,3L,4L,12L,20L,45L,80L,168L,296L,573L,1012L,1874L,3268L,5824L,10020L,17338L,29308L,49511L,82168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124638Inst : IEnumerable<long>
{
public static readonly long[] Value=A124638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124638.Bytes);
public long this[int i]=>Value[i];

public static A124638Inst Instance=new A124638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124639
{
public static readonly long[] Value={ 1L,0L,3L,4L,12L,20L,52L,84L,198L,352L,730L,1332L,2648L,4808L,9232L,16780L,31227L,56312L,102641L,182808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124639Inst : IEnumerable<long>
{
public static readonly long[] Value=A124639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124639.Bytes);
public long this[int i]=>Value[i];

public static A124639Inst Instance=new A124639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124640
{
public static readonly long[] Value={ 1L,3L,11L,33L,98L,270L,736L,1932L,5009L,12727L,31977L,79307L,194947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124640Inst : IEnumerable<long>
{
public static readonly long[] Value=A124640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124640.Bytes);
public long this[int i]=>Value[i];

public static A124640Inst Instance=new A124640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124641
{
public static readonly long[] Value={ 1L,6L,27L,103L,1159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124641Inst : IEnumerable<long>
{
public static readonly long[] Value=A124641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124641.Bytes);
public long this[int i]=>Value[i];

public static A124641Inst Instance=new A124641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124642
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,15L,29L,50L,99L,176L,351L,638L,1275L,2354L,4707L,8789L,17577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124642Inst : IEnumerable<long>
{
public static readonly long[] Value=A124642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124642.Bytes);
public long this[int i]=>Value[i];

public static A124642Inst Instance=new A124642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124643
{
public static readonly long[] Value={ 29L,59L,599L,2999L,8999L,29999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124643Inst : IEnumerable<long>
{
public static readonly long[] Value=A124643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124643.Bytes);
public long this[int i]=>Value[i];

public static A124643Inst Instance=new A124643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124644
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,6L,3L,1L,14L,20L,12L,4L,1L,42L,70L,50L,20L,5L,1L,132L,252L,210L,100L,30L,6L,1L,429L,924L,882L,490L,175L,42L,7L,1L,1430L,3432L,3696L,2352L,980L,280L,56L,8L,1L,4862L,12870L,15444L,11088L,5292L,1764L,420L,72L,9L,1L,16796L,48620L,64350L,51480L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124644Inst : IEnumerable<long>
{
public static readonly long[] Value=A124644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124644.Bytes);
public long this[int i]=>Value[i];

public static A124644Inst Instance=new A124644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124645
{
public static readonly long[] Value={ 1L,1L,-1L,0L,1L,-1L,0L,1L,-2L,1L,0L,0L,1L,-2L,1L,0L,0L,1L,-3L,3L,-1L,0L,0L,0L,1L,-3L,3L,-1L,0L,0L,0L,1L,-4L,6L,-4L,1L,0L,0L,0L,0L,1L,-4L,6L,-4L,1L,0L,0L,0L,0L,1L,-5L,10L,-10L,5L,-1L,0L,0L,0L,0L,0L,1L,-5L,10L,-10L,5L,-1L,0L,0L,0L,0L,0L,1L,-6L,15L,-20L,15L,-6L,1L,0L,0L,0L,0L,0L,0L,1L,-6L,15L,-20L,15L,-6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124645Inst : IEnumerable<long>
{
public static readonly long[] Value=A124645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124645.Bytes);
public long this[int i]=>Value[i];

public static A124645Inst Instance=new A124645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124646
{
public static readonly long[] Value={ -1L,-2L,-10L,-37L,-143L,-478L,-1588L,-4910L,-14748L,-42235L,-116910L,-311478L,-803343L,-2004434L,-4853669L,-11414943L,-26127222L,-58267164L,-126811068L,-269647980L,-560935635L,-1142812869L,-2282784640L,-4475122564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124646Inst : IEnumerable<long>
{
public static readonly long[] Value=A124646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124646.Bytes);
public long this[int i]=>Value[i];

public static A124646Inst Instance=new A124646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124647
{
public static readonly long[] Value={ 1L,9L,45L,189L,729L,2673L,9477L,32805L,111537L,373977L,1240029L,4074381L,13286025L,43046721L,138706101L,444816117L,1420541793L,4519905705L,14334558093L,45328197213L,142958160441L,449795187729L,1412147682405L,4424729404869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124647Inst : IEnumerable<long>
{
public static readonly long[] Value=A124647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124647.Bytes);
public long this[int i]=>Value[i];

public static A124647Inst Instance=new A124647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124712
{
public static readonly long[] Value={ 1L,19L,55L,127L,339L,899L,2455L,6767L,18859L,52939L,149535L,424487L,1210059L,3461659L,9933055L,28577687L,82409179L,238128539L,689345935L,1998806327L,5804195179L,16876837979L,49132180735L,143192973047L,417751959379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124712Inst : IEnumerable<long>
{
public static readonly long[] Value=A124712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124712.Bytes);
public long this[int i]=>Value[i];

public static A124712Inst Instance=new A124712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124713
{
public static readonly long[] Value={ 1L,20L,58L,134L,358L,950L,2596L,7160L,19966L,56078L,158488L,450140L,1283848L,3674600L,10549282L,30365294L,87605806L,253263470L,733498744L,2127803180L,6181574548L,17982188708L,52373316262L,152706201170L,445700295760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124713Inst : IEnumerable<long>
{
public static readonly long[] Value=A124713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124713.Bytes);
public long this[int i]=>Value[i];

public static A124713Inst Instance=new A124713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124714
{
public static readonly long[] Value={ 1L,21L,61L,141L,377L,1001L,2737L,7553L,21073L,59217L,167441L,475793L,1357637L,3887541L,11165509L,32152901L,92802433L,268398401L,777651553L,2256800033L,6558953917L,19087539437L,55614451789L,162219429293L,473648632141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124714Inst : IEnumerable<long>
{
public static readonly long[] Value=A124714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124714.Bytes);
public long this[int i]=>Value[i];

public static A124714Inst Instance=new A124714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124715
{
public static readonly long[] Value={ 1L,22L,64L,148L,396L,1052L,2878L,7946L,22180L,62356L,176394L,501446L,1431426L,4100482L,11781736L,33940508L,97999060L,283533332L,821804362L,2385796886L,6936333286L,20192890166L,58855587316L,171732657416L,501596968522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124715Inst : IEnumerable<long>
{
public static readonly long[] Value=A124715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124715.Bytes);
public long this[int i]=>Value[i];

public static A124715Inst Instance=new A124715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124716
{
public static readonly long[] Value={ 1L,23L,67L,155L,415L,1103L,3019L,8339L,23287L,65495L,185347L,527099L,1505215L,4313423L,12397963L,35728115L,103195687L,298668263L,865957171L,2514793739L,7313712655L,21298240895L,62096722843L,181245885539L,529545304903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124716Inst : IEnumerable<long>
{
public static readonly long[] Value=A124716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124716.Bytes);
public long this[int i]=>Value[i];

public static A124716Inst Instance=new A124716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124717
{
public static readonly long[] Value={ 1L,24L,70L,162L,434L,1154L,3160L,8732L,24394L,68634L,194300L,552752L,1579004L,4526364L,13014190L,37515722L,108392314L,313803194L,910109980L,2643790592L,7691092024L,22403591624L,65337858370L,190759113662L,557493641284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124717Inst : IEnumerable<long>
{
public static readonly long[] Value=A124717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124717.Bytes);
public long this[int i]=>Value[i];

public static A124717Inst Instance=new A124717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124718
{
public static readonly long[] Value={ 1L,25L,73L,169L,453L,1205L,3301L,9125L,25501L,71773L,203253L,578405L,1652793L,4739305L,13630417L,39303329L,113588941L,328938125L,954262789L,2772787445L,8068471393L,23508942353L,68578993897L,200272341785L,585441977665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124718Inst : IEnumerable<long>
{
public static readonly long[] Value=A124718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124718.Bytes);
public long this[int i]=>Value[i];

public static A124718Inst Instance=new A124718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124719
{
public static readonly long[] Value={ 1L,26L,76L,176L,472L,1256L,3442L,9518L,26608L,74912L,212206L,604058L,1726582L,4952246L,14246644L,41090936L,118785568L,344073056L,998415598L,2901784298L,8445850762L,24614293082L,71820129424L,209785569908L,613390314046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124719Inst : IEnumerable<long>
{
public static readonly long[] Value=A124719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124719.Bytes);
public long this[int i]=>Value[i];

public static A124719Inst Instance=new A124719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124720
{
public static readonly long[] Value={ 2L,5L,16L,38L,96L,220L,512L,1144L,2560L,5616L,12288L,26592L,57344L,122816L,262144L,556928L,1179648L,2490112L,5242880L,11009536L,23068672L,48233472L,100663296L,209713152L,436207616L,905965568L,1879048192L,3892305920L,8053063680L,16642981888L,34359738368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124720Inst : IEnumerable<long>
{
public static readonly long[] Value=A124720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124720.Bytes);
public long this[int i]=>Value[i];

public static A124720Inst Instance=new A124720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124721
{
public static readonly long[] Value={ 2L,8L,26L,80L,224L,596L,1536L,3840L,9384L,22528L,53248L,124240L,286720L,655360L,1485472L,3342336L,7471104L,16602432L,36700160L,80740352L,176859776L,385875968L,838860800L,1817531648L,3925868544L,8455716864L,18164132352L,38923141120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124721Inst : IEnumerable<long>
{
public static readonly long[] Value=A124721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124721.Bytes);
public long this[int i]=>Value[i];

public static A124721Inst Instance=new A124721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124722
{
public static readonly long[] Value={ 2L,9L,40L,137L,448L,1336L,3840L,10540L,28160L,73168L,186368L,465808L,1146880L,2785024L,6684672L,15875520L,37355520L,87161600L,201850880L,464254208L,1061158912L,2411718656L,5452595200L,12268325888L,27481079808L,61303918592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124722Inst : IEnumerable<long>
{
public static readonly long[] Value=A124722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124722.Bytes);
public long this[int i]=>Value[i];

public static A124722Inst Instance=new A124722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124723
{
public static readonly long[] Value={ 2L,12L,56L,224L,806L,2688L,8448L,25344L,73216L,205004L,559104L,1490944L,3899392L,10027008L,25401752L,63504384L,156893184L,383516672L,928514048L,2228433712L,5305794560L,12540968960L,29444014080L,68702699520L,159390262880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124723Inst : IEnumerable<long>
{
public static readonly long[] Value=A124723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124723.Bytes);
public long this[int i]=>Value[i];

public static A124723Inst Instance=new A124723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124724
{
public static readonly long[] Value={ 4L,10L,60L,455L,3876L,35420L,339300L,3362260L,34179860L,354465254L,3735373880L,39884521950L,430571952300L,4691735290080L,51534335175776L,570003171679020L,6343110854237300L,70968228417131850L,797820661622862900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124724Inst : IEnumerable<long>
{
public static readonly long[] Value=A124724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124724.Bytes);
public long this[int i]=>Value[i];

public static A124724Inst Instance=new A124724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124725
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,4L,3L,1L,7L,8L,7L,4L,1L,11L,15L,15L,11L,5L,1L,16L,26L,30L,26L,16L,6L,1L,22L,42L,56L,56L,42L,22L,7L,1L,29L,64L,98L,112L,98L,64L,29L,8L,1L,37L,93L,162L,210L,210L,162L,93L,37L,9L,1L,46L,130L,255L,372L,420L,372L,255L,130L,46L,10L,1L,56L,176L,385L,627L,792L,792L,627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124725Inst : IEnumerable<long>
{
public static readonly long[] Value=A124725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124725.Bytes);
public long this[int i]=>Value[i];

public static A124725Inst Instance=new A124725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124726
{
public static readonly long[] Value={ 1L,27L,79L,183L,491L,1307L,3583L,9911L,27715L,78051L,221159L,629711L,1800371L,5165187L,14862871L,42878543L,123982195L,359207987L,1042568407L,3030781151L,8823230131L,25719643811L,75061264951L,219298798031L,641338650427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124726Inst : IEnumerable<long>
{
public static readonly long[] Value=A124726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124726.Bytes);
public long this[int i]=>Value[i];

public static A124726Inst Instance=new A124726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124727
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,10L,4L,5L,14L,22L,17L,5L,6L,20L,40L,45L,26L,6L,7L,27L,65L,95L,81L,37L,7L,8L,35L,98L,175L,196L,133L,50L,8L,9L,44L,140L,294L,406L,364L,204L,65L,9L,10L,54L,192L,462L,756L,840L,624L,297L,82L,10L,11L,65L,255L,690L,1302L,1722L,1590L,1005L,415L,101L,11L,12L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124727Inst : IEnumerable<long>
{
public static readonly long[] Value=A124727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124727.Bytes);
public long this[int i]=>Value[i];

public static A124727Inst Instance=new A124727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124760
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124760Inst : IEnumerable<long>
{
public static readonly long[] Value=A124760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124760.Bytes);
public long this[int i]=>Value[i];

public static A124760Inst Instance=new A124760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124761
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,0L,1L,1L,1L,0L,2L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124761Inst : IEnumerable<long>
{
public static readonly long[] Value=A124761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124761.Bytes);
public long this[int i]=>Value[i];

public static A124761Inst Instance=new A124761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124762
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,3L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,1L,1L,1L,1L,2L,4L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,2L,2L,0L,0L,1L,3L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,2L,2L,2L,2L,3L,5L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,1L,1L,0L,0L,1L,3L,0L,0L,0L,1L,1L,2L,1L,3L,0L,0L,1L,1L,1L,1L,2L,4L,0L,0L,0L,1L,1L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124762Inst : IEnumerable<long>
{
public static readonly long[] Value=A124762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124762.Bytes);
public long this[int i]=>Value[i];

public static A124762Inst Instance=new A124762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124763
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,0L,1L,1L,2L,0L,1L,1L,3L,0L,1L,1L,2L,0L,2L,1L,3L,0L,1L,1L,2L,1L,2L,2L,4L,0L,1L,1L,2L,1L,2L,1L,3L,0L,1L,2L,3L,1L,2L,2L,4L,0L,1L,1L,2L,0L,2L,1L,3L,1L,2L,2L,3L,2L,3L,3L,5L,0L,1L,1L,2L,1L,2L,1L,3L,0L,2L,2L,3L,1L,2L,2L,4L,0L,1L,1L,2L,1L,3L,2L,4L,1L,2L,2L,3L,2L,3L,3L,5L,0L,1L,1L,2L,1L,2L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124763Inst : IEnumerable<long>
{
public static readonly long[] Value=A124763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124763.Bytes);
public long this[int i]=>Value[i];

public static A124763Inst Instance=new A124763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124764
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,1L,1L,1L,2L,3L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,3L,4L,0L,0L,0L,1L,1L,0L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,4L,5L,0L,0L,0L,1L,0L,0L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,2L,2L,2L,2L,3L,4L,1L,1L,1L,2L,2L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124764Inst : IEnumerable<long>
{
public static readonly long[] Value=A124764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124764.Bytes);
public long this[int i]=>Value[i];

public static A124764Inst Instance=new A124764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124765
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124765Inst : IEnumerable<long>
{
public static readonly long[] Value=A124765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124765.Bytes);
public long this[int i]=>Value[i];

public static A124765Inst Instance=new A124765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124766
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,1L,2L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,1L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124766Inst : IEnumerable<long>
{
public static readonly long[] Value=A124766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124766.Bytes);
public long this[int i]=>Value[i];

public static A124766Inst Instance=new A124766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124767
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,3L,2L,1L,1L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,1L,1L,2L,2L,2L,1L,3L,3L,2L,2L,3L,1L,2L,3L,4L,3L,2L,2L,3L,3L,3L,3L,3L,4L,3L,2L,3L,2L,3L,2L,3L,2L,1L,1L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,3L,3L,4L,3L,2L,2L,3L,3L,3L,2L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,2L,2L,3L,3L,3L,2L,4L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124767Inst : IEnumerable<long>
{
public static readonly long[] Value=A124767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124767.Bytes);
public long this[int i]=>Value[i];

public static A124767Inst Instance=new A124767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124768
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,1L,2L,2L,3L,1L,2L,2L,4L,1L,2L,2L,3L,1L,3L,2L,4L,1L,2L,2L,3L,2L,3L,3L,5L,1L,2L,2L,3L,2L,3L,2L,4L,1L,2L,3L,4L,2L,3L,3L,5L,1L,2L,2L,3L,1L,3L,2L,4L,2L,3L,3L,4L,3L,4L,4L,6L,1L,2L,2L,3L,2L,3L,2L,4L,1L,3L,3L,4L,2L,3L,3L,5L,1L,2L,2L,3L,2L,4L,3L,5L,2L,3L,3L,4L,3L,4L,4L,6L,1L,2L,2L,3L,2L,3L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124768Inst : IEnumerable<long>
{
public static readonly long[] Value=A124768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124768.Bytes);
public long this[int i]=>Value[i];

public static A124768Inst Instance=new A124768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124769
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,2L,2L,2L,3L,4L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,4L,5L,1L,1L,1L,2L,2L,1L,2L,3L,2L,2L,3L,3L,2L,2L,3L,4L,2L,2L,2L,3L,3L,3L,3L,4L,3L,3L,4L,4L,4L,4L,5L,6L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,2L,2L,2L,3L,4L,2L,2L,2L,3L,3L,3L,3L,4L,2L,2L,3L,3L,3L,3L,4L,5L,2L,2L,2L,3L,3L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124769Inst : IEnumerable<long>
{
public static readonly long[] Value=A124769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124769.Bytes);
public long this[int i]=>Value[i];

public static A124769Inst Instance=new A124769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124770
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,3L,3L,1L,3L,2L,5L,3L,5L,5L,4L,1L,3L,3L,5L,3L,5L,5L,7L,3L,5L,5L,8L,5L,8L,7L,5L,1L,3L,3L,5L,2L,6L,6L,7L,3L,6L,3L,8L,6L,7L,8L,9L,3L,5L,6L,8L,6L,8L,7L,11L,5L,8L,8L,11L,7L,11L,9L,6L,1L,3L,3L,5L,3L,6L,6L,7L,3L,5L,5L,9L,5L,9L,9L,9L,3L,6L,5L,9L,5L,7L,8L,11L,6L,9L,8L,11L,9L,11L,11L,11L,3L,5L,6L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124770Inst : IEnumerable<long>
{
public static readonly long[] Value=A124770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124770.Bytes);
public long this[int i]=>Value[i];

public static A124770Inst Instance=new A124770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124771
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,4L,4L,2L,4L,3L,6L,4L,6L,6L,5L,2L,4L,4L,6L,4L,6L,6L,8L,4L,6L,6L,9L,6L,9L,8L,6L,2L,4L,4L,6L,3L,7L,7L,8L,4L,7L,4L,9L,7L,8L,9L,10L,4L,6L,7L,9L,7L,9L,8L,12L,6L,9L,9L,12L,8L,12L,10L,7L,2L,4L,4L,6L,4L,7L,7L,8L,4L,6L,6L,10L,6L,10L,10L,10L,4L,7L,6L,10L,6L,8L,9L,12L,7L,10L,9L,12L,10L,12L,12L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124771Inst : IEnumerable<long>
{
public static readonly long[] Value=A124771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124771.Bytes);
public long this[int i]=>Value[i];

public static A124771Inst Instance=new A124771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124772
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,3L,3L,1L,2L,1L,1L,1L,4L,6L,6L,4L,8L,4L,4L,1L,3L,3L,3L,1L,2L,1L,1L,1L,5L,10L,10L,10L,20L,10L,10L,5L,15L,15L,15L,5L,10L,5L,5L,1L,4L,6L,6L,4L,8L,4L,4L,1L,3L,3L,3L,1L,2L,1L,1L,1L,6L,15L,15L,20L,40L,20L,20L,15L,45L,45L,45L,15L,30L,15L,15L,6L,24L,36L,36L,24L,48L,24L,24L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124772Inst : IEnumerable<long>
{
public static readonly long[] Value=A124772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124772.Bytes);
public long this[int i]=>Value[i];

public static A124772Inst Instance=new A124772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124773
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,6L,6L,3L,3L,2L,2L,1L,1L,24L,24L,12L,12L,8L,8L,4L,4L,6L,6L,3L,3L,2L,2L,1L,1L,120L,120L,60L,60L,40L,40L,20L,20L,30L,30L,15L,15L,10L,10L,5L,5L,24L,24L,12L,12L,8L,8L,4L,4L,6L,6L,3L,3L,2L,2L,1L,1L,720L,720L,360L,360L,240L,240L,120L,120L,180L,180L,90L,90L,60L,60L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124773Inst : IEnumerable<long>
{
public static readonly long[] Value=A124773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124773.Bytes);
public long this[int i]=>Value[i];

public static A124773Inst Instance=new A124773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124774
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,3L,6L,1L,4L,6L,12L,4L,12L,12L,24L,1L,5L,10L,20L,10L,30L,30L,60L,5L,20L,30L,60L,20L,60L,60L,120L,1L,6L,15L,30L,20L,60L,60L,120L,15L,60L,90L,180L,60L,180L,180L,360L,6L,30L,60L,120L,60L,180L,180L,360L,30L,120L,180L,360L,120L,360L,360L,720L,1L,7L,21L,42L,35L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124774Inst : IEnumerable<long>
{
public static readonly long[] Value=A124774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124774.Bytes);
public long this[int i]=>Value[i];

public static A124774Inst Instance=new A124774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124775
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,4L,3L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124775Inst : IEnumerable<long>
{
public static readonly long[] Value=A124775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124775.Bytes);
public long this[int i]=>Value[i];

public static A124775Inst Instance=new A124775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124824
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,235L,2727L,38699L,649931L,12616132L,278054700L,6861571205L,187474460527L,5619443518165L,183375548287557L,6472290237774352L,245705256222934490L,9983967457086797107UL,BigInteger.Parse("432392173830077506403") };
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
public class A124824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A124824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124824Inst Instance=new A124824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124825
{
public static readonly long[] Value={ 1L,3L,9L,13L,27L,31L,33L,39L,57L,67L,79L,87L,93L,109L,111L,121L,159L,163L,169L,177L,187L,223L,229L,237L,241L,267L,277L,303L,351L,363L,367L,369L,379L,387L,421L,433L,439L,451L,463L,493L,507L,519L,523L,541L,571L,573L,589L,603L,621L,633L,639L,663L,673L,697L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124825Inst : IEnumerable<long>
{
public static readonly long[] Value=A124825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124825.Bytes);
public long this[int i]=>Value[i];

public static A124825Inst Instance=new A124825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124826
{
public static readonly long[] Value={ 43L,127L,211L,337L,379L,421L,463L,547L,631L,673L,757L,883L,967L,1009L,1051L,1093L,1303L,1429L,1471L,1597L,1723L,1933L,2017L,2143L,2269L,2311L,2437L,2521L,2647L,2689L,2731L,2857L,3067L,3109L,3319L,3361L,3529L,3571L,3613L,3697L,3739L,3823L,3907L,4159L,4201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124826Inst : IEnumerable<long>
{
public static readonly long[] Value=A124826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124826.Bytes);
public long this[int i]=>Value[i];

public static A124826Inst Instance=new A124826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124827
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,12L,42L,16L,54L,40L,110L,48L,156L,84L,120L,64L,272L,108L,342L,160L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124827Inst : IEnumerable<long>
{
public static readonly long[] Value=A124827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124827.Bytes);
public long this[int i]=>Value[i];

public static A124827Inst Instance=new A124827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124828
{
public static readonly long[] Value={ 1L,7L,29L,103L,417L,1717L,7229L,30793L,132225L,570649L,2470769L,10719793L,46569777L,202477633L,880792193L,3832748833L,16681516545L,72613292353L,316105114817L,1376159456641L,5991281182977L,26084303730049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124828Inst : IEnumerable<long>
{
public static readonly long[] Value=A124828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124828.Bytes);
public long this[int i]=>Value[i];

public static A124828Inst Instance=new A124828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124829
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,4L,1L,2L,3L,1L,1L,1L,1L,5L,2L,2L,4L,1L,1L,3L,2L,1L,1L,6L,3L,2L,1L,2L,1L,5L,1L,2L,3L,3L,1L,1L,7L,4L,2L,1L,1L,2L,1L,4L,2L,2L,1L,6L,1L,1L,1L,1L,1L,3L,3L,4L,1L,1L,8L,1L,3L,1L,5L,2L,2L,1L,2L,2L,4L,3L,2L,1L,7L,1L,2L,1L,1L,1L,4L,3L,1L,2L,2L,5L,1L,1L,1L,5L,9L,2L,3L,1L,6L,2L,3L,1L,2L,1L,2L,1L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124829Inst : IEnumerable<long>
{
public static readonly long[] Value=A124829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124829.Bytes);
public long this[int i]=>Value[i];

public static A124829Inst Instance=new A124829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124830
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,2L,2L,2L,3L,1L,2L,3L,2L,2L,3L,1L,2L,3L,2L,3L,2L,4L,2L,3L,1L,3L,2L,3L,2L,3L,2L,4L,2L,3L,3L,2L,1L,3L,2L,3L,4L,2L,3L,3L,2L,3L,4L,2L,3L,3L,2L,1L,4L,3L,2L,3L,4L,2L,3L,3L,2L,4L,3L,2L,3L,4L,2L,3L,4L,3L,2L,1L,4L,3L,3L,2L,5L,3L,3L,4L,2L,3L,3L,2L,4L,3L,2L,4L,3L,4L,2L,3L,3L,4L,3L,2L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124830Inst : IEnumerable<long>
{
public static readonly long[] Value=A124830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124830.Bytes);
public long this[int i]=>Value[i];

public static A124830Inst Instance=new A124830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124831
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,4L,3L,5L,4L,5L,4L,4L,6L,5L,4L,6L,5L,5L,7L,6L,4L,5L,5L,7L,4L,6L,6L,8L,5L,7L,5L,6L,6L,8L,5L,7L,5L,7L,6L,9L,6L,8L,6L,5L,7L,7L,5L,9L,6L,6L,8L,6L,8L,7L,10L,5L,7L,9L,7L,6L,8L,6L,8L,7L,5L,6L,10L,7L,7L,9L,7L,6L,9L,8L,11L,6L,8L,6L,10L,5L,8L,7L,7L,9L,7L,9L,8L,6L,7L,11L,6L,8L,8L,10L,8L,6L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124831Inst : IEnumerable<long>
{
public static readonly long[] Value=A124831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124831.Bytes);
public long this[int i]=>Value[i];

public static A124831Inst Instance=new A124831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124832
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,4L,3L,1L,1L,1L,1L,5L,2L,2L,4L,1L,2L,1L,1L,6L,3L,2L,5L,1L,3L,1L,1L,7L,4L,2L,2L,2L,1L,6L,1L,1L,1L,1L,1L,3L,3L,4L,1L,1L,8L,5L,2L,3L,2L,1L,7L,1L,2L,1L,1L,1L,4L,3L,5L,1L,1L,9L,6L,2L,4L,2L,1L,8L,1L,3L,1L,1L,1L,5L,3L,2L,2L,2L,6L,1L,1L,10L,3L,3L,1L,7L,2L,2L,2L,1L,1L,4L,4L,5L,2L,1L,9L,1L,4L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124832Inst : IEnumerable<long>
{
public static readonly long[] Value=A124832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124832.Bytes);
public long this[int i]=>Value[i];

public static A124832Inst Instance=new A124832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124833
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,9L,12L,5L,32L,18L,24L,27L,10L,64L,36L,15L,48L,54L,20L,128L,72L,25L,81L,30L,96L,7L,108L,40L,256L,45L,144L,50L,162L,60L,192L,14L,216L,75L,80L,243L,512L,90L,288L,100L,21L,324L,120L,125L,384L,135L,28L,432L,150L,160L,486L,1024L,35L,180L,576L,200L,42L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124833Inst : IEnumerable<long>
{
public static readonly long[] Value=A124833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124833.Bytes);
public long this[int i]=>Value[i];

public static A124833Inst Instance=new A124833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124834
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,11L,8L,1L,1L,5L,26L,42L,16L,1L,1L,6L,57L,184L,163L,32L,1L,1L,7L,120L,731L,1358L,638L,64L,1L,1L,8L,247L,2736L,10121L,10244L,2510L,128L,1L,1L,9L,502L,9844L,70436L,145475L,78320L,9908L,256L,1L,1L,10L,1013L,34448L,468735L,1911956L,2141835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124834Inst : IEnumerable<long>
{
public static readonly long[] Value=A124834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124834.Bytes);
public long this[int i]=>Value[i];

public static A124834Inst Instance=new A124834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124835
{
public static readonly BigInteger[] Value={ 1L,2L,4L,9L,25L,91L,444L,2920L,25996L,314752L,5201874L,117719942L,3658433597L,156505343943L,9234365056453L,752841451059559L,84938741035295776L,13279814559055121447UL,BigInteger.Parse("2880581923860441220144"),BigInteger.Parse("867855593621657824023139") };
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
public class A124835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A124835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124835Inst Instance=new A124835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124836
{
public static readonly BigInteger[] Value={ 1L,2L,11L,184L,10121L,1911956L,1277642344L,3076635199744L,27117951046505365L,BigInteger.Parse("883613507047099010632"),BigInteger.Parse("107474419453579127300333278"),BigInteger.Parse("49091717449041719016035290742176"),BigInteger.Parse("84772868574056134938044881265953518335"),BigInteger.Parse("555628412000611011592987340845035908323617024"),BigInteger.Parse("13889914561952086638362253697842716117160344082246744") };
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
public class A124836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A124836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124836Inst Instance=new A124836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124837
{
public static readonly long[] Value={ 1L,7L,47L,57L,459L,341L,3349L,3601L,42131L,44441L,605453L,631193L,655217L,1355479L,23763863L,24444543L,476698557L,162779395L,166474515L,34000335L,265842403L,812400067L,20666950267L,21010170067L,192066102203L,194934439103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124837Inst : IEnumerable<long>
{
public static readonly long[] Value=A124837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124837.Bytes);
public long this[int i]=>Value[i];

public static A124837Inst Instance=new A124837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124838
{
public static readonly long[] Value={ 1L,2L,6L,4L,20L,10L,70L,56L,504L,420L,4620L,3960L,3432L,6006L,90090L,80080L,1361360L,408408L,369512L,67184L,470288L,1293292L,29745716L,27457584L,228813200L,212469400L,5736673800L,5354228880L,155272637520L,291136195350L,273491577450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124838Inst : IEnumerable<long>
{
public static readonly long[] Value=A124838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124838.Bytes);
public long this[int i]=>Value[i];

public static A124838Inst Instance=new A124838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124839
{
public static readonly long[] Value={ 1L,-2L,2L,-1L,-2L,10L,-30L,76L,-173L,363L,-717L,1363L,-2551L,4797L,-9189L,18015L,-36008L,72725L,-146930L,294423L,-581758L,1130231L,-2158552L,4061201L,-7557522L,13983585L,-25872679L,48115364L,-90273986L,171186911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124839Inst : IEnumerable<long>
{
public static readonly long[] Value=A124839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124839.Bytes);
public long this[int i]=>Value[i];

public static A124839Inst Instance=new A124839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124904
{
public static readonly long[] Value={ 0L,2L,1L,2L,4L,3L,5L,7L,2L,4L,6L,8L,3L,10L,5L,12L,7L,14L,9L,4L,11L,6L,18L,13L,8L,32L,3L,10L,22L,5L,29L,12L,36L,7L,31L,14L,38L,9L,33L,4L,16L,40L,11L,35L,6L,18L,42L,13L,25L,49L,8L,32L,44L,15L,27L,39L,10L,22L,34L,5L,17L,29L,41L,12L,24L,36L,48L,7L,19L,31L,43L,14L,26L,38L,91L,9L,21L,33L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124904Inst : IEnumerable<long>
{
public static readonly long[] Value=A124904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124904.Bytes);
public long this[int i]=>Value[i];

public static A124904Inst Instance=new A124904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124905
{
public static readonly long[] Value={ 0L,2L,1L,9L,4L,3L,17L,7L,2L,11L,6L,20L,15L,10L,5L,24L,19L,14L,9L,4L,23L,47L,18L,13L,8L,32L,3L,51L,22L,17L,41L,12L,36L,7L,31L,26L,79L,21L,74L,45L,16L,40L,11L,35L,6L,30L,136L,54L,25L,49L,20L,73L,44L,15L,174L,39L,10L,169L,34L,5L,111L,29L,294L,53L,24L,130L,48L,260L,19L,284L,43L,14L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124905Inst : IEnumerable<long>
{
public static readonly long[] Value=A124905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124905.Bytes);
public long this[int i]=>Value[i];

public static A124905Inst Instance=new A124905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124906
{
public static readonly long[] Value={ 0L,8L,1L,13L,3L,9L,15L,21L,2L,8L,11L,14L,17L,20L,23L,4L,7L,10L,32L,13L,57L,16L,19L,41L,22L,44L,3L,47L,6L,50L,9L,31L,53L,12L,56L,15L,37L,59L,18L,40L,62L,21L,84L,43L,65L,24L,46L,5L,27L,90L,49L,8L,30L,93L,52L,11L,74L,33L,55L,118L,14L,36L,99L,58L,121L,17L,39L,102L,61L,124L,20L,146L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124906Inst : IEnumerable<long>
{
public static readonly long[] Value=A124906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124906.Bytes);
public long this[int i]=>Value[i];

public static A124906Inst Instance=new A124906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124907
{
public static readonly long[] Value={ 0L,1L,5L,2L,4L,9L,6L,3L,8L,5L,13L,10L,18L,7L,23L,4L,20L,9L,17L,44L,6L,14L,22L,30L,11L,19L,46L,8L,16L,62L,24L,5L,13L,59L,21L,48L,10L,56L,18L,64L,45L,7L,53L,15L,80L,42L,23L,69L,31L,12L,58L,39L,20L,66L,47L,9L,74L,55L,17L,82L,63L,44L,25L,6L,52L,33L,14L,79L,60L,41L,22L,68L,49L,30L,11L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124907Inst : IEnumerable<long>
{
public static readonly long[] Value=A124907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124907.Bytes);
public long this[int i]=>Value[i];

public static A124907Inst Instance=new A124907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124908
{
public static readonly long[] Value={ 0L,1L,4L,2L,7L,5L,33L,3L,38L,8L,36L,6L,13L,34L,55L,4L,25L,39L,60L,9L,23L,37L,44L,58L,7L,14L,28L,35L,49L,56L,70L,5L,19L,26L,33L,40L,54L,61L,68L,10L,17L,24L,31L,103L,38L,45L,52L,59L,66L,73L,8L,15L,22L,29L,101L,36L,43L,115L,50L,57L,64L,136L,71L,6L,13L,85L,20L,27L,99L,34L,106L,41L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124908Inst : IEnumerable<long>
{
public static readonly long[] Value=A124908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124908.Bytes);
public long this[int i]=>Value[i];

public static A124908Inst Instance=new A124908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124909
{
public static readonly long[] Value={ 0L,3L,4L,1L,2L,14L,3L,15L,4L,12L,16L,5L,9L,13L,21L,2L,10L,14L,18L,22L,3L,7L,11L,15L,38L,19L,23L,4L,8L,31L,12L,35L,16L,39L,20L,24L,5L,28L,9L,32L,97L,13L,36L,17L,40L,21L,44L,151L,25L,6L,29L,136L,10L,33L,98L,14L,37L,102L,18L,41L,148L,22L,45L,3L,26L,175L,7L,72L,30L,53L,11L,34L,267L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124909Inst : IEnumerable<long>
{
public static readonly long[] Value=A124909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124909.Bytes);
public long this[int i]=>Value[i];

public static A124909Inst Instance=new A124909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124910
{
public static readonly long[] Value={ 0L,2L,7L,3L,1L,8L,4L,2L,13L,11L,7L,5L,3L,16L,14L,27L,12L,10L,8L,21L,6L,19L,4L,17L,2L,15L,28L,13L,26L,11L,39L,24L,9L,22L,7L,35L,20L,5L,33L,18L,3L,31L,16L,44L,29L,57L,14L,42L,27L,55L,12L,40L,25L,53L,10L,38L,23L,94L,8L,36L,107L,21L,49L,6L,34L,105L,19L,47L,4L,32L,103L,17L,88L,45L,116L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124910Inst : IEnumerable<long>
{
public static readonly long[] Value=A124910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124910.Bytes);
public long this[int i]=>Value[i];

public static A124910Inst Instance=new A124910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124911
{
public static readonly long[] Value={ 0L,1L,2L,4L,1L,2L,3L,16L,4L,20L,8L,2L,18L,9L,3L,22L,16L,10L,4L,26L,20L,14L,8L,5L,2L,24L,18L,15L,9L,6L,3L,28L,22L,19L,16L,13L,10L,7L,4L,29L,26L,23L,20L,17L,14L,11L,8L,5L,33L,30L,27L,24L,52L,21L,18L,15L,43L,12L,9L,37L,6L,3L,31L,28L,56L,25L,22L,50L,19L,47L,16L,13L,41L,10L,38L,7L,35L,4L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124911Inst : IEnumerable<long>
{
public static readonly long[] Value=A124911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124911.Bytes);
public long this[int i]=>Value[i];

public static A124911Inst Instance=new A124911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124912
{
public static readonly long[] Value={ 0L,2L,0L,1L,4L,2L,5L,8L,0L,3L,6L,9L,1L,12L,4L,15L,7L,18L,10L,2L,13L,5L,24L,16L,8L,46L,0L,11L,30L,3L,41L,14L,52L,6L,44L,17L,55L,9L,47L,1L,20L,58L,12L,50L,4L,23L,61L,15L,34L,72L,7L,45L,64L,18L,37L,56L,10L,29L,48L,2L,21L,40L,59L,13L,32L,51L,70L,5L,24L,43L,62L,16L,35L,54L,138L,8L,27L,46L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124912Inst : IEnumerable<long>
{
public static readonly long[] Value=A124912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124912.Bytes);
public long this[int i]=>Value[i];

public static A124912Inst Instance=new A124912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124913
{
public static readonly long[] Value={ 0L,1L,0L,6L,2L,1L,12L,4L,0L,7L,3L,14L,10L,6L,2L,17L,13L,9L,5L,1L,16L,35L,12L,8L,4L,23L,0L,38L,15L,11L,30L,7L,26L,3L,22L,18L,60L,14L,56L,33L,10L,29L,6L,25L,2L,21L,105L,40L,17L,36L,13L,55L,32L,9L,135L,28L,5L,131L,24L,1L,85L,20L,230L,39L,16L,100L,35L,203L,12L,222L,31L,8L,50L,27L,69L,4L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124913Inst : IEnumerable<long>
{
public static readonly long[] Value=A124913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124913.Bytes);
public long this[int i]=>Value[i];

public static A124913Inst Instance=new A124913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124914
{
public static readonly long[] Value={ 0L,5L,0L,8L,1L,5L,9L,13L,0L,4L,6L,8L,10L,12L,14L,1L,3L,5L,20L,7L,37L,9L,11L,26L,13L,28L,0L,30L,2L,32L,4L,19L,34L,6L,36L,8L,23L,38L,10L,25L,40L,12L,55L,27L,42L,14L,29L,1L,16L,59L,31L,3L,18L,61L,33L,5L,48L,20L,35L,78L,7L,22L,65L,37L,80L,9L,24L,67L,39L,82L,11L,97L,26L,112L,41L,84L,13L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124914Inst : IEnumerable<long>
{
public static readonly long[] Value=A124914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124914.Bytes);
public long this[int i]=>Value[i];

public static A124914Inst Instance=new A124914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124915
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,4L,2L,0L,3L,1L,6L,4L,9L,2L,12L,0L,10L,3L,8L,25L,1L,6L,11L,16L,4L,9L,26L,2L,7L,36L,12L,0L,5L,34L,10L,27L,3L,32L,8L,37L,25L,1L,30L,6L,47L,23L,11L,40L,16L,4L,33L,21L,9L,38L,26L,2L,43L,31L,7L,48L,36L,24L,12L,0L,29L,17L,5L,46L,34L,22L,10L,39L,27L,15L,3L,44L,32L,20L,8L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124915Inst : IEnumerable<long>
{
public static readonly long[] Value=A124915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124915.Bytes);
public long this[int i]=>Value[i];

public static A124915Inst Instance=new A124915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124916
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,13L,0L,15L,2L,14L,1L,4L,13L,22L,0L,9L,15L,24L,2L,8L,14L,17L,23L,1L,4L,10L,13L,19L,22L,28L,0L,6L,9L,12L,15L,21L,24L,27L,2L,5L,8L,11L,42L,14L,17L,20L,23L,26L,29L,1L,4L,7L,10L,41L,13L,16L,47L,19L,22L,25L,56L,28L,0L,3L,34L,6L,9L,40L,12L,43L,15L,18L,49L,21L,52L,24L,55L,27L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124916Inst : IEnumerable<long>
{
public static readonly long[] Value=A124916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124916.Bytes);
public long this[int i]=>Value[i];

public static A124916Inst Instance=new A124916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124917
{
public static readonly long[] Value={ 0L,3L,4L,0L,1L,16L,2L,17L,3L,13L,18L,4L,9L,14L,24L,0L,10L,15L,20L,25L,1L,6L,11L,16L,45L,21L,26L,2L,7L,36L,12L,41L,17L,46L,22L,27L,3L,32L,8L,37L,119L,13L,42L,18L,47L,23L,52L,187L,28L,4L,33L,168L,9L,38L,120L,14L,43L,125L,19L,48L,183L,24L,53L,0L,29L,217L,5L,87L,34L,63L,10L,39L,333L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124917Inst : IEnumerable<long>
{
public static readonly long[] Value=A124917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124917.Bytes);
public long this[int i]=>Value[i];

public static A124917Inst Instance=new A124917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124918
{
public static readonly long[] Value={ 0L,2L,9L,3L,0L,10L,4L,1L,17L,14L,8L,5L,2L,21L,18L,37L,15L,12L,9L,28L,6L,25L,3L,22L,0L,19L,38L,16L,35L,13L,54L,32L,10L,29L,7L,48L,26L,4L,45L,23L,1L,42L,20L,61L,39L,80L,17L,58L,36L,77L,14L,55L,33L,74L,11L,52L,30L,134L,8L,49L,153L,27L,68L,5L,46L,150L,24L,65L,2L,43L,147L,21L,125L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124918Inst : IEnumerable<long>
{
public static readonly long[] Value=A124918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124918.Bytes);
public long this[int i]=>Value[i];

public static A124918Inst Instance=new A124918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124919
{
public static readonly long[] Value={ 0L,1L,3L,7L,0L,2L,4L,34L,6L,43L,15L,1L,38L,17L,3L,47L,33L,19L,5L,56L,42L,28L,14L,7L,0L,51L,37L,30L,16L,9L,2L,60L,46L,39L,32L,25L,18L,11L,4L,62L,55L,48L,41L,34L,27L,20L,13L,6L,71L,64L,57L,50L,115L,43L,36L,29L,94L,22L,15L,80L,8L,1L,66L,59L,124L,52L,45L,110L,38L,103L,31L,24L,89L,17L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124919Inst : IEnumerable<long>
{
public static readonly long[] Value=A124919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124919.Bytes);
public long this[int i]=>Value[i];

public static A124919Inst Instance=new A124919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124936
{
public static readonly long[] Value={ 5L,34L,50L,56L,86L,92L,94L,120L,122L,142L,144L,160L,184L,186L,202L,204L,214L,216L,218L,220L,236L,248L,266L,288L,290L,300L,302L,304L,320L,322L,328L,340L,392L,394L,412L,414L,416L,446L,452L,470L,472L,516L,518L,528L,534L,536L,544L,552L,580L,582L,590L,634L,668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124936Inst : IEnumerable<long>
{
public static readonly long[] Value=A124936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124936.Bytes);
public long this[int i]=>Value[i];

public static A124936Inst Instance=new A124936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124937
{
public static readonly long[] Value={ 1L,1L,2L,5L,3L,12L,4L,45L,30L,24L,4L,265L,6L,36L,64L,1905L,5L,892L,6L,759L,108L,32L,4L,24193L,132L,70L,2328L,1237L,6L,3816L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124937Inst : IEnumerable<long>
{
public static readonly long[] Value=A124937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124937.Bytes);
public long this[int i]=>Value[i];

public static A124937Inst Instance=new A124937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124938
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,4L,3L,5L,4L,21L,4L,36L,3L,27L,40L,49L,5L,91L,2L,358L,56L,27L,3L,807L,79L,26L,64L,617L,2L,1896L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124938Inst : IEnumerable<long>
{
public static readonly long[] Value=A124938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124938.Bytes);
public long this[int i]=>Value[i];

public static A124938Inst Instance=new A124938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124939
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,1L,6L,5L,1L,1L,10L,1L,12L,7L,1L,16L,3L,8L,1L,1L,18L,1L,22L,9L,1L,28L,13L,24L,1L,30L,11L,20L,17L,1L,1L,36L,1L,40L,19L,1L,42L,25L,34L,1L,46L,15L,14L,23L,1L,52L,21L,26L,27L,32L,1L,1L,58L,1L,60L,29L,1L,66L,31L,48L,1L,70L,33L,38L,35L,1L,72L,37L,64L,39L,44L,1L,78L,49L,54L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124939Inst : IEnumerable<long>
{
public static readonly long[] Value=A124939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124939.Bytes);
public long this[int i]=>Value[i];

public static A124939Inst Instance=new A124939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124940
{
public static readonly long[] Value={ 27L,42L,63L,75L,99L,102L,114L,171L,172L,242L,255L,258L,279L,282L,322L,354L,363L,366L,385L,399L,423L,425L,426L,435L,452L,474L,531L,575L,595L,602L,603L,606L,615L,639L,642L,651L,654L,665L,722L,759L,772L,830L,844L,894L,903L,906L,932L,935L,978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124940Inst : IEnumerable<long>
{
public static readonly long[] Value=A124940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124940.Bytes);
public long this[int i]=>Value[i];

public static A124940Inst Instance=new A124940Inst();

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