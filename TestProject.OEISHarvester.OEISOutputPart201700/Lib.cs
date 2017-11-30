using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276705
{
public static readonly long[] Value={ 4L,5L,7L,8L,9L,20L,55L,91L,187L,247L,391L,475L,667L,775L,1015L,1147L,1435L,1591L,1927L,2107L,2491L,2695L,3127L,3355L,3835L,4087L,4615L,4891L,5467L,5767L,6391L,6715L,7387L,7735L,8455L,8827L,9595L,9991L,10807L,11227L,12091L,12535L,13447L,13915L,14875L,15367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276705Inst : IEnumerable<long>
{
public static readonly long[] Value=A276705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276705.Bytes);
public long this[int i]=>Value[i];

public static A276705Inst Instance=new A276705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276706
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,10L,14L,16L,20L,22L,26L,28L,32L,34L,38L,40L,44L,46L,50L,52L,56L,58L,62L,64L,68L,70L,74L,76L,80L,82L,86L,88L,92L,94L,98L,100L,104L,106L,110L,112L,116L,118L,122L,124L,128L,130L,134L,136L,140L,142L,146L,148L,152L,154L,158L,160L,164L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276706Inst : IEnumerable<long>
{
public static readonly long[] Value=A276706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276706.Bytes);
public long this[int i]=>Value[i];

public static A276706Inst Instance=new A276706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276707
{
public static readonly long[] Value={ 4L,12L,60L,381L,2522L,19094L,151286L,1237792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276707Inst : IEnumerable<long>
{
public static readonly long[] Value=A276707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276707.Bytes);
public long this[int i]=>Value[i];

public static A276707Inst Instance=new A276707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276724
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,17007L,64077L,231180L,821132L,2918753L,10483154L,38264066L,142423894L,533308705L,1995314365L,7437442700L,27604521795L,102095937121L,376790770192L,1389739254904L,5130664114644L,18964932885093L,70170215134155L,259770146382666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276724Inst : IEnumerable<long>
{
public static readonly long[] Value=A276724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276724.Bytes);
public long this[int i]=>Value[i];

public static A276724Inst Instance=new A276724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276725
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,21147L,94828L,389946L,1527058L,5846917L,22257299L,85116719L,329147169L,1292371138L,5165744159L,20781403539L,83617668276L,335483033770L,1340729704086L,5338181115652L,21193583922048L,84001778063348L,332811761809618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276725Inst : IEnumerable<long>
{
public static readonly long[] Value=A276725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276725.Bytes);
public long this[int i]=>Value[i];

public static A276725Inst Instance=new A276725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276726
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,21147L,115975L,562595L,2504665L,10579224L,43453459L,176472854L,716369167L,2927448727L,12099445274L,50734619570L,216264854789L,928045216933L,3986352066095L,17086933963355L,72987960721209L,310631150855373L,1317808552742134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276726Inst : IEnumerable<long>
{
public static readonly long[] Value=A276726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276726.Bytes);
public long this[int i]=>Value[i];

public static A276726Inst Instance=new A276726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276727
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,4L,5L,5L,0L,1L,7L,12L,17L,15L,0L,1L,12L,29L,45L,64L,52L,0L,1L,20L,66L,121L,201L,265L,203L,0L,1L,33L,145L,336L,585L,966L,1197L,877L,0L,1L,54L,315L,901L,1741L,3172L,4971L,5852L,4140L,0L,1L,88L,676L,2347L,5375L,10100L,18223L,27267L,30751L,21147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276727Inst : IEnumerable<long>
{
public static readonly long[] Value=A276727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276727.Bytes);
public long this[int i]=>Value[i];

public static A276727Inst Instance=new A276727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276728
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,336L,5375L,111138L,2845864L,87597223L,3170429794L,132647186513L,6328769607152L,340517379645028L,20469645334387763L,1363935094328964210L,BigInteger.Parse("100052662656438620359"),BigInteger.Parse("8032243625863280744704") };
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
public class A276728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276728Inst Instance=new A276728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276729
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276729Inst : IEnumerable<long>
{
public static readonly long[] Value=A276729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276729.Bytes);
public long this[int i]=>Value[i];

public static A276729Inst Instance=new A276729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276730
{
public static readonly long[] Value={ 2L,3L,7L,7L,11L,7L,15L,19L,23L,39L,31L,39L,31L,43L,47L,39L,59L,71L,67L,71L,79L,79L,83L,79L,79L,103L,103L,107L,103L,127L,127L,131L,159L,139L,135L,151L,135L,163L,167L,199L,179L,199L,191L,207L,199L,199L,211L,223L,227L,199L,207L,239L,271L,251L,255L,263L,295L,271L,295L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276730Inst : IEnumerable<long>
{
public static readonly long[] Value=A276730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276730.Bytes);
public long this[int i]=>Value[i];

public static A276730Inst Instance=new A276730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276731
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,8L,17L,26L,23L,29L,35L,26L,41L,35L,47L,53L,59L,62L,62L,71L,80L,62L,83L,89L,116L,101L,116L,107L,107L,113L,107L,131L,137L,116L,149L,170L,143L,188L,167L,173L,179L,188L,191L,170L,197L,188L,224L,251L,227L,251L,233L,239L,224L,251L,257L,263L,269L,242L,251L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276731Inst : IEnumerable<long>
{
public static readonly long[] Value=A276731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276731.Bytes);
public long this[int i]=>Value[i];

public static A276731Inst Instance=new A276731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276732
{
public static readonly long[] Value={ 19L,29L,109L,229L,409L,709L,829L,1009L,1069L,1129L,1489L,1669L,1789L,2269L,2389L,2689L,3109L,3169L,3469L,3529L,3889L,4789L,4909L,5209L,5569L,5689L,5869L,6469L,6529L,6829L,8089L,8209L,8269L,8389L,8629L,9109L,9769L,9829L,10909L,12289L,12589L,12829L,12889L,13009L,13669L,13729L,14389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276732Inst : IEnumerable<long>
{
public static readonly long[] Value=A276732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276732.Bytes);
public long this[int i]=>Value[i];

public static A276732Inst Instance=new A276732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276733
{
public static readonly long[] Value={ 341L,1247L,1387L,2047L,2701L,3277L,3683L,4033L,4369L,4681L,5461L,5963L,7957L,8321L,9017L,9211L,10261L,13747L,14351L,14491L,15709L,17593L,18721L,19951L,20191L,23377L,24929L,25351L,29041L,31417L,31609L,31621L,33227L,35333L,37901L,42799L,45761L,46513L,49141L,49601L,49981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276733Inst : IEnumerable<long>
{
public static readonly long[] Value=A276733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276733.Bytes);
public long this[int i]=>Value[i];

public static A276733Inst Instance=new A276733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276734
{
public static readonly long[] Value={ 1L,5L,7L,9L,21L,22L,44L,45L,66L,70L,78L,112L,150L,156L,160L,264L,270L,280L,432L,600L,1080L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276734Inst : IEnumerable<long>
{
public static readonly long[] Value=A276734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276734.Bytes);
public long this[int i]=>Value[i];

public static A276734Inst Instance=new A276734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276735
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,3L,5L,12L,87L,261L,324L,1433L,5881L,37444L,196797L,708901L,2020836L,12375966L,105896734L,955344450L,11136621319L,95274505723L,590283352231L,4285001635230L,36417581252044L,272699023606314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276735Inst : IEnumerable<long>
{
public static readonly long[] Value=A276735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276735.Bytes);
public long this[int i]=>Value[i];

public static A276735Inst Instance=new A276735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276736
{
public static readonly long[] Value={ 1L,2L,5L,11L,7L,10L,9L,13L,2L,14L,13L,55L,15L,18L,7L,57L,19L,4L,21L,77L,15L,26L,25L,65L,38L,30L,58L,99L,31L,14L,33L,15L,65L,38L,9L,11L,39L,42L,25L,91L,43L,30L,45L,13L,14L,50L,49L,95L,66L,76L,95L,165L,55L,116L,91L,117L,35L,62L,61L,77L,63L,66L,18L,247L,21L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276736Inst : IEnumerable<long>
{
public static readonly long[] Value=A276736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276736.Bytes);
public long this[int i]=>Value[i];

public static A276736Inst Instance=new A276736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276737
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,3L,7L,4L,1L,5L,11L,12L,13L,7L,3L,16L,17L,1L,19L,20L,7L,11L,23L,12L,25L,13L,27L,28L,29L,3L,31L,4L,33L,17L,5L,2L,37L,19L,13L,20L,41L,7L,43L,4L,5L,23L,47L,16L,49L,25L,51L,52L,53L,27L,55L,28L,19L,29L,59L,12L,61L,31L,7L,64L,13L,33L,67L,68L,69L,5L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276737Inst : IEnumerable<long>
{
public static readonly long[] Value=A276737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276737.Bytes);
public long this[int i]=>Value[i];

public static A276737Inst Instance=new A276737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276738
{
public static readonly long[] Value={ -1L,-1L,5L,-1L,12L,-32L,-1L,14L,7L,-126L,231L,-1L,16L,16L,-160L,-160L,1280L,-1792L,-1L,18L,18L,-198L,9L,-396L,1716L,-66L,2574L,-12870L,14586L,-1L,20L,20L,-240L,20L,-480L,2240L,-240L,-240L,6720L,-17920L,2240L,-35840L,129024L,-122880L,-1L,22L,22L,-286L,22L,-572L,2860L,11L,-572L,-286L,8580L,-24310L,-286L,4290L,8580L,-97240L,184756L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276738Inst : IEnumerable<long>
{
public static readonly long[] Value=A276738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276738.Bytes);
public long this[int i]=>Value[i];

public static A276738Inst Instance=new A276738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276739
{
public static readonly long[] Value={ 1L,19L,10699L,102589L,10000112389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276739Inst : IEnumerable<long>
{
public static readonly long[] Value=A276739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276739.Bytes);
public long this[int i]=>Value[i];

public static A276739Inst Instance=new A276739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276756
{
public static readonly long[] Value={ 1L,21L,30L,979L,1411L,1463L,1547L,1742L,1947L,2059L,2090L,2210L,2318L,2405L,2419L,2491L,2703L,2886L,2945L,3182L,3243L,3534L,3567L,16102L,17654L,20559L,21243L,25543L,25705L,27145L,27307L,27805L,28045L,29323L,29370L,29631L,30485L,30846L,32574L,33366L,33465L,33654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276756Inst : IEnumerable<long>
{
public static readonly long[] Value=A276756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276756.Bytes);
public long this[int i]=>Value[i];

public static A276756Inst Instance=new A276756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276757
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276757Inst : IEnumerable<long>
{
public static readonly long[] Value=A276757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276757.Bytes);
public long this[int i]=>Value[i];

public static A276757Inst Instance=new A276757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276758
{
public static readonly long[] Value={ 10L,1010L,1100L,1119L,1339L,1519L,3139L,5119L,8899L,27799L,46699L,48499L,50559L,55059L,64699L,72799L,84499L,100110L,101010L,101100L,110010L,110100L,111000L,111229L,112129L,117799L,121129L,136699L,147499L,163699L,168199L,171799L,174499L,177199L,186199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276758Inst : IEnumerable<long>
{
public static readonly long[] Value=A276758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276758.Bytes);
public long this[int i]=>Value[i];

public static A276758Inst Instance=new A276758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276759
{
public static readonly long[] Value={ 1L,5L,3L,3L,9L,1L,3L,3L,1L,9L,7L,9L,3L,5L,7L,4L,5L,0L,7L,9L,1L,9L,7L,4L,1L,0L,8L,2L,0L,7L,2L,7L,3L,3L,7L,7L,9L,7L,8L,5L,2L,9L,8L,6L,1L,0L,6L,5L,0L,7L,6L,6L,6L,7L,1L,7L,3L,3L,0L,7L,6L,0L,0L,5L,6L,8L,9L,4L,4L,9L,0L,8L,1L,1L,0L,0L,4L,3L,9L,2L,4L,4L,9L,9L,0L,6L,1L,0L,5L,6L,5L,5L,3L,4L,6L,3L,7L,0L,9L,6L,2L,0L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276759Inst : IEnumerable<long>
{
public static readonly long[] Value=A276759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276759.Bytes);
public long this[int i]=>Value[i];

public static A276759Inst Instance=new A276759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276760
{
public static readonly long[] Value={ 4L,3L,7L,5L,1L,8L,5L,1L,5L,3L,0L,6L,1L,8L,9L,8L,3L,8L,5L,4L,7L,0L,9L,0L,6L,5L,6L,4L,8L,5L,2L,5L,8L,4L,2L,9L,1L,6L,2L,3L,8L,2L,3L,1L,1L,4L,6L,7L,7L,0L,1L,1L,8L,6L,4L,9L,6L,1L,0L,4L,4L,4L,9L,1L,8L,0L,3L,7L,2L,1L,5L,6L,3L,0L,8L,9L,3L,4L,7L,2L,8L,1L,7L,5L,9L,8L,8L,1L,8L,2L,3L,9L,9L,0L,9L,5L,9L,5L,1L,4L,1L,7L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276760Inst : IEnumerable<long>
{
public static readonly long[] Value=A276760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276760.Bytes);
public long this[int i]=>Value[i];

public static A276760Inst Instance=new A276760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276761
{
public static readonly long[] Value={ 4L,6L,3L,6L,2L,8L,4L,6L,3L,2L,7L,8L,6L,6L,2L,5L,1L,8L,9L,5L,4L,4L,9L,5L,2L,3L,1L,8L,0L,3L,4L,2L,0L,5L,3L,8L,7L,0L,4L,4L,6L,9L,9L,3L,5L,5L,6L,7L,7L,5L,7L,5L,2L,5L,2L,9L,6L,3L,9L,3L,5L,1L,0L,1L,9L,3L,0L,2L,5L,4L,4L,9L,3L,1L,0L,4L,5L,0L,9L,4L,5L,2L,4L,9L,4L,6L,6L,2L,2L,6L,1L,9L,3L,7L,3L,2L,8L,7L,8L,3L,9L,2L,7L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276761Inst : IEnumerable<long>
{
public static readonly long[] Value=A276761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276761.Bytes);
public long this[int i]=>Value[i];

public static A276761Inst Instance=new A276761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276762
{
public static readonly long[] Value={ 1L,8L,7L,8L,8L,8L,1L,7L,4L,7L,9L,0L,8L,1L,2L,3L,0L,9L,1L,9L,6L,9L,4L,8L,6L,4L,9L,7L,3L,2L,6L,8L,8L,3L,4L,6L,9L,6L,8L,9L,5L,9L,4L,9L,5L,2L,8L,5L,5L,6L,3L,6L,6L,0L,6L,8L,9L,4L,5L,2L,7L,5L,1L,5L,0L,8L,5L,2L,1L,2L,5L,5L,4L,2L,6L,4L,7L,2L,6L,6L,9L,8L,8L,5L,0L,4L,8L,4L,5L,1L,2L,7L,0L,8L,9L,4L,4L,8L,5L,3L,5L,0L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276762Inst : IEnumerable<long>
{
public static readonly long[] Value=A276762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276762.Bytes);
public long this[int i]=>Value[i];

public static A276762Inst Instance=new A276762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276763
{
public static readonly long[] Value={ 2L,0L,6L,5L,9L,2L,2L,2L,0L,2L,3L,7L,0L,6L,6L,2L,1L,8L,8L,9L,8L,8L,1L,0L,4L,6L,1L,1L,2L,5L,4L,1L,0L,8L,4L,3L,0L,0L,1L,4L,2L,4L,9L,8L,5L,3L,1L,9L,0L,0L,6L,7L,3L,2L,8L,3L,8L,5L,7L,9L,1L,1L,8L,0L,4L,5L,9L,8L,8L,5L,9L,4L,9L,3L,2L,6L,0L,6L,7L,7L,7L,7L,8L,3L,5L,5L,5L,4L,5L,7L,0L,2L,8L,2L,7L,1L,5L,9L,2L,8L,4L,6L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276763Inst : IEnumerable<long>
{
public static readonly long[] Value=A276763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276763.Bytes);
public long this[int i]=>Value[i];

public static A276763Inst Instance=new A276763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276764
{
public static readonly long[] Value={ 10L,20L,74L,100L,202L,244L,394L,452L,650L,724L,970L,1060L,1354L,1460L,1802L,1924L,2314L,2452L,2890L,3044L,3530L,3700L,4234L,4420L,5002L,5204L,5834L,6052L,6730L,6964L,7690L,7940L,8714L,8980L,9802L,10084L,10954L,11252L,12170L,12484L,13450L,13780L,14794L,15140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276764Inst : IEnumerable<long>
{
public static readonly long[] Value=A276764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276764.Bytes);
public long this[int i]=>Value[i];

public static A276764Inst Instance=new A276764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276765
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,13L,14L,15L,16L,18L,19L,20L,30L,40L,50L,60L,80L,90L,100L,200L,300L,400L,500L,600L,800L,900L,7000L,70000L,700000L,800001L,800002L,800003L,800004L,800005L,800006L,800008L,800009L,800010L,800012L,801000L,802000L,803000L,804000L,805000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276765Inst : IEnumerable<long>
{
public static readonly long[] Value=A276765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276765.Bytes);
public long this[int i]=>Value[i];

public static A276765Inst Instance=new A276765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276766
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,23L,14L,20L,13L,24L,15L,26L,17L,25L,16L,27L,18L,29L,30L,12L,34L,19L,28L,31L,40L,21L,35L,41L,32L,45L,36L,42L,37L,46L,38L,47L,39L,48L,50L,43L,51L,49L,52L,60L,53L,61L,54L,62L,57L,63L,58L,64L,59L,67L,80L,56L,70L,65L,71L,68L,72L,69L,73L,81L,74L,82L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276766Inst : IEnumerable<long>
{
public static readonly long[] Value=A276766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276766.Bytes);
public long this[int i]=>Value[i];

public static A276766Inst Instance=new A276766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276767
{
public static readonly long[] Value={ 2L,5L,17L,17L,17L,359L,359L,359L,163L,163L,163L,163L,163L,163L,163L,163L,163L,448L,448L,448L,448L,448L,448L,71L,71L,71L,17L,17L,443L,443L,443L,443L,443L,443L,37L,37L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L,2789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276767Inst : IEnumerable<long>
{
public static readonly long[] Value=A276767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276767.Bytes);
public long this[int i]=>Value[i];

public static A276767Inst Instance=new A276767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276768
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10000L,1111L,1000000L,101111L,100000000L,10111111L,10000000000L,1011111111L,1000000000000L,101011111111L,100000000000000L,10101011111111L,10000000000000000L,1010101111111111L,1000000000000000000L,101010111111111111L,BigInteger.Parse("100000000000000000000") };
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
public class A276768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276768Inst Instance=new A276768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276769
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,100L,111L,21L,31L,41L,51L,61L,71L,81L,91L,200L,112L,222L,32L,42L,52L,62L,72L,82L,92L,300L,113L,223L,333L,43L,53L,63L,73L,83L,93L,400L,114L,224L,334L,444L,54L,64L,74L,84L,94L,500L,115L,225L,335L,445L,555L,65L,75L,85L,95L,600L,116L,226L,336L,446L,556L,666L,76L,86L,96L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276769Inst : IEnumerable<long>
{
public static readonly long[] Value=A276769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276769.Bytes);
public long this[int i]=>Value[i];

public static A276769Inst Instance=new A276769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276770
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,1L,0L,3L,0L,3L,3L,2L,0L,1L,0L,4L,2L,1L,0L,4L,2L,4L,4L,3L,0L,1L,0L,2L,4L,1L,4L,5L,0L,3L,3L,2L,0L,1L,0L,5L,2L,3L,0L,5L,4L,5L,5L,4L,0L,1L,3L,2L,2L,1L,0L,3L,0L,5L,5L,2L,2L,5L,0L,6L,5L,1L,0L,4L,0L,4L,4L,3L,2L,1L,0L,2L,2L,1L,0L,6L,2L,3L,3L,4L,0L,1L,5L,6L,2L,5L,5L,6L,0L,6L,6L,5L,0L,1L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276770Inst : IEnumerable<long>
{
public static readonly long[] Value=A276770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276770.Bytes);
public long this[int i]=>Value[i];

public static A276770Inst Instance=new A276770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276771
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,2L,0L,1L,0L,2L,2L,2L,0L,2L,1L,1L,2L,3L,0L,1L,0L,2L,2L,2L,1L,3L,0L,1L,2L,2L,0L,1L,0L,3L,3L,3L,0L,3L,1L,1L,2L,3L,0L,2L,2L,2L,3L,3L,0L,4L,0L,1L,2L,2L,2L,1L,0L,3L,3L,3L,0L,3L,0L,2L,3L,4L,2L,1L,0L,2L,3L,3L,0L,3L,3L,1L,2L,2L,0L,1L,2L,4L,4L,4L,2L,4L,0L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276771Inst : IEnumerable<long>
{
public static readonly long[] Value=A276771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276771.Bytes);
public long this[int i]=>Value[i];

public static A276771Inst Instance=new A276771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276788
{
public static readonly long[] Value={ 2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276788Inst : IEnumerable<long>
{
public static readonly long[] Value=A276788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276788.Bytes);
public long this[int i]=>Value[i];

public static A276788Inst Instance=new A276788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276789
{
public static readonly long[] Value={ 4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,3L,4L,2L,4L,3L,4L,4L,3L,4L,2L,4L,3L,4L,3L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276789Inst : IEnumerable<long>
{
public static readonly long[] Value=A276789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276789.Bytes);
public long this[int i]=>Value[i];

public static A276789Inst Instance=new A276789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276790
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276790Inst : IEnumerable<long>
{
public static readonly long[] Value=A276790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276790.Bytes);
public long this[int i]=>Value[i];

public static A276790Inst Instance=new A276790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276791
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276791Inst : IEnumerable<long>
{
public static readonly long[] Value=A276791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276791.Bytes);
public long this[int i]=>Value[i];

public static A276791Inst Instance=new A276791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276792
{
public static readonly long[] Value={ 7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,6L,7L,4L,7L,6L,7L,7L,6L,7L,4L,7L,6L,7L,6L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276792Inst : IEnumerable<long>
{
public static readonly long[] Value=A276792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276792.Bytes);
public long this[int i]=>Value[i];

public static A276792Inst Instance=new A276792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276793
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276793Inst : IEnumerable<long>
{
public static readonly long[] Value=A276793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276793.Bytes);
public long this[int i]=>Value[i];

public static A276793Inst Instance=new A276793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276794
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276794Inst : IEnumerable<long>
{
public static readonly long[] Value=A276794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276794.Bytes);
public long this[int i]=>Value[i];

public static A276794Inst Instance=new A276794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276795
{
public static readonly long[] Value={ 1L,6L,22L,28L,78L,90L,108L,120L,286L,310L,346L,370L,412L,436L,472L,496L,1086L,1134L,1206L,1254L,1338L,1386L,1458L,1506L,1596L,1644L,1716L,1764L,1848L,1896L,1968L,2016L,4222L,4318L,4462L,4558L,4726L,4822L,4966L,5062L,5242L,5338L,5482L,5578L,5746L,5842L,5986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276795Inst : IEnumerable<long>
{
public static readonly long[] Value=A276795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276795.Bytes);
public long this[int i]=>Value[i];

public static A276795Inst Instance=new A276795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276796
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,25L,25L,26L,26L,27L,27L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,36L,36L,37L,37L,38L,38L,39L,39L,40L,40L,41L,42L,42L,43L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276796Inst : IEnumerable<long>
{
public static readonly long[] Value=A276796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276796.Bytes);
public long this[int i]=>Value[i];

public static A276796Inst Instance=new A276796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276797
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276797Inst : IEnumerable<long>
{
public static readonly long[] Value=A276797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276797.Bytes);
public long this[int i]=>Value[i];

public static A276797Inst Instance=new A276797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276798
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276798Inst : IEnumerable<long>
{
public static readonly long[] Value=A276798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276798.Bytes);
public long this[int i]=>Value[i];

public static A276798Inst Instance=new A276798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276799
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,2L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276799Inst : IEnumerable<long>
{
public static readonly long[] Value=A276799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276799.Bytes);
public long this[int i]=>Value[i];

public static A276799Inst Instance=new A276799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276800
{
public static readonly long[] Value={ 3L,3L,8L,2L,9L,7L,5L,7L,6L,7L,9L,0L,6L,2L,3L,7L,4L,9L,4L,1L,2L,2L,7L,0L,8L,5L,3L,6L,4L,5L,5L,0L,3L,4L,5L,8L,6L,9L,4L,9L,3L,8L,2L,0L,4L,3L,7L,4L,8L,5L,7L,6L,1L,8L,2L,0L,1L,9L,5L,6L,2L,6L,7L,7L,2L,3L,5L,3L,7L,1L,8L,9L,6L,0L,0L,9L,9L,4L,0L,2L,9L,2L,2L,2L,3L,5L,9L,3L,3L,3L,4L,0L,0L,4L,3L,6L,6L,1L,3L,9L,6L,0L,4L,1L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276800Inst : IEnumerable<long>
{
public static readonly long[] Value=A276800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276800.Bytes);
public long this[int i]=>Value[i];

public static A276800Inst Instance=new A276800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276801
{
public static readonly long[] Value={ 6L,2L,2L,2L,2L,6L,2L,5L,2L,3L,1L,2L,0L,3L,9L,8L,6L,2L,6L,6L,7L,4L,5L,6L,1L,1L,0L,1L,1L,0L,8L,3L,2L,1L,1L,8L,7L,3L,7L,3L,5L,6L,0L,7L,8L,9L,8L,4L,6L,1L,6L,8L,4L,2L,8L,7L,9L,8L,3L,2L,1L,3L,1L,6L,6L,3L,9L,5L,7L,5L,1L,1L,8L,0L,9L,1L,9L,0L,6L,7L,1L,7L,9L,6L,2L,0L,2L,8L,7L,5L,3L,4L,3L,2L,6L,7L,3L,1L,5L,3L,7L,4L,6L,0L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276801Inst : IEnumerable<long>
{
public static readonly long[] Value=A276801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276801.Bytes);
public long this[int i]=>Value[i];

public static A276801Inst Instance=new A276801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276802
{
public static readonly long[] Value={ 554L,3328L,55553L,77764L,222221L,444442L,666663L,888865L,888884L,5555552L,6666595L,9999840L,33332680L,55555526L,66666557L,99998670L,333332176L,333333312L,555555551L,666665752L,666666624L,999997536L,999999936L,9999976480L,9999997844L,9999999668L,9999999923L,11111111110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276802Inst : IEnumerable<long>
{
public static readonly long[] Value=A276802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276802.Bytes);
public long this[int i]=>Value[i];

public static A276802Inst Instance=new A276802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276803
{
public static readonly long[] Value={ 6L,21L,22L,33L,39L,46L,51L,58L,82L,93L,111L,115L,133L,141L,142L,159L,166L,177L,187L,201L,205L,219L,226L,235L,237L,247L,249L,253L,262L,267L,274L,291L,301L,319L,327L,355L,358L,391L,411L,427L,478L,489L,501L,502L,505L,511L,535L,538L,543L,562L,565L,573L,583L,586L,589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276803Inst : IEnumerable<long>
{
public static readonly long[] Value=A276803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276803.Bytes);
public long this[int i]=>Value[i];

public static A276803Inst Instance=new A276803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276884
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,10L,11L,14L,15L,18L,19L,20L,23L,24L,27L,28L,31L,32L,35L,36L,37L,40L,41L,44L,45L,48L,49L,52L,53L,54L,57L,58L,61L,62L,65L,66L,69L,70L,71L,74L,75L,78L,79L,82L,83L,86L,87L,90L,91L,92L,95L,96L,99L,100L,103L,104L,107L,108L,109L,112L,113L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276884Inst : IEnumerable<long>
{
public static readonly long[] Value=A276884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276884.Bytes);
public long this[int i]=>Value[i];

public static A276884Inst Instance=new A276884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276885
{
public static readonly long[] Value={ 1L,4L,9L,12L,17L,22L,25L,30L,33L,38L,43L,46L,51L,56L,59L,64L,67L,72L,77L,80L,85L,88L,93L,98L,101L,106L,111L,114L,119L,122L,127L,132L,135L,140L,145L,148L,153L,156L,161L,166L,169L,174L,177L,182L,187L,190L,195L,200L,203L,208L,211L,216L,221L,224L,229L,232L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276885Inst : IEnumerable<long>
{
public static readonly long[] Value=A276885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276885.Bytes);
public long this[int i]=>Value[i];

public static A276885Inst Instance=new A276885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276886
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,12L,13L,16L,17L,20L,23L,24L,27L,30L,31L,34L,35L,38L,41L,42L,45L,46L,49L,52L,53L,56L,59L,60L,63L,64L,67L,70L,71L,74L,77L,78L,81L,82L,85L,88L,89L,92L,93L,96L,99L,100L,103L,106L,107L,110L,111L,114L,117L,118L,121L,122L,125L,128L,129L,132L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276886Inst : IEnumerable<long>
{
public static readonly long[] Value=A276886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276886.Bytes);
public long this[int i]=>Value[i];

public static A276886Inst Instance=new A276886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276887
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,11L,12L,15L,16L,17L,20L,21L,22L,25L,26L,29L,30L,31L,34L,35L,38L,39L,40L,43L,44L,45L,48L,49L,52L,53L,54L,57L,58L,59L,62L,63L,66L,67L,68L,71L,72L,75L,76L,77L,80L,81L,82L,85L,86L,89L,90L,91L,94L,95L,98L,99L,100L,103L,104L,105L,108L,109L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276887Inst : IEnumerable<long>
{
public static readonly long[] Value=A276887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276887.Bytes);
public long this[int i]=>Value[i];

public static A276887Inst Instance=new A276887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276888
{
public static readonly long[] Value={ 1L,4L,7L,12L,15L,20L,23L,26L,31L,34L,39L,42L,45L,50L,53L,58L,61L,66L,69L,72L,77L,80L,85L,88L,91L,96L,99L,104L,107L,112L,115L,118L,123L,126L,131L,134L,137L,142L,145L,150L,153L,156L,161L,164L,169L,172L,177L,180L,183L,188L,191L,196L,199L,202L,207L,210L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276888Inst : IEnumerable<long>
{
public static readonly long[] Value=A276888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276888.Bytes);
public long this[int i]=>Value[i];

public static A276888Inst Instance=new A276888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276889
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,14L,17L,20L,21L,24L,27L,30L,33L,36L,39L,42L,43L,46L,49L,52L,55L,58L,61L,64L,65L,68L,71L,74L,77L,80L,83L,86L,87L,90L,93L,96L,99L,102L,105L,108L,109L,112L,115L,118L,121L,124L,127L,130L,131L,134L,137L,140L,143L,146L,149L,150L,153L,156L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276889Inst : IEnumerable<long>
{
public static readonly long[] Value=A276889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276889.Bytes);
public long this[int i]=>Value[i];

public static A276889Inst Instance=new A276889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276890
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,3L,6L,0L,1L,1L,3L,10L,24L,0L,1L,1L,3L,13L,44L,120L,0L,1L,1L,3L,13L,62L,234L,720L,0L,1L,1L,3L,13L,75L,352L,1470L,5040L,0L,1L,1L,3L,13L,75L,466L,2348L,10656L,40320L,0L,1L,1L,3L,13L,75L,541L,3272L,17880L,87624L,362880L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276890Inst : IEnumerable<long>
{
public static readonly long[] Value=A276890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276890.Bytes);
public long this[int i]=>Value[i];

public static A276890Inst Instance=new A276890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276891
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,4L,3L,0L,24L,20L,18L,13L,0L,120L,114L,118L,114L,75L,0L,720L,750L,878L,924L,870L,541L,0L,5040L,5616L,7224L,8152L,8760L,7818L,4683L,0L,40320L,47304L,65514L,79682L,90084L,94560L,81078L,47293L,0L,362880L,443400L,652446L,845874L,998560L,1135776L,1148016L,954474L,545835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276891Inst : IEnumerable<long>
{
public static readonly long[] Value=A276891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276891.Bytes);
public long this[int i]=>Value[i];

public static A276891Inst Instance=new A276891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276892
{
public static readonly BigInteger[] Value={ 1L,2L,20L,878L,79682L,12043772L,2716968332L,853336081124L,355520118746132L,189580735777428836L,BigInteger.Parse("125874638274228457172"),BigInteger.Parse("101804159684084842005380"),BigInteger.Parse("98514573603328714169588852"),BigInteger.Parse("112376135259125932230989633060"),BigInteger.Parse("149216698787792363945310009639572") };
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
public class A276892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276892Inst Instance=new A276892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276893
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,62L,352L,2348L,17880L,153138L,1458726L,15303672L,175387056L,2180632824L,29240091480L,420683340840L,6464876260440L,105699125013120L,1832140771795440L,33562515077608320L,647929998101403360L,13148236101412979280UL,BigInteger.Parse("279809650659550924080") };
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
public class A276893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276893Inst Instance=new A276893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276894
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,466L,3272L,26032L,232820L,2304600L,25003176L,295139034L,3767545662L,51729553992L,760326663792L,11913105530016L,198246166468224L,3492246172917240L,64928731038925800L,1270685662509505560L,BigInteger.Parse("26112819120798942120"),BigInteger.Parse("562241528313838756560") };
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
public class A276894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276894Inst Instance=new A276894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276895
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4142L,34792L,322904L,3303160L,37046948L,451109712L,5923255272L,83424945768L,1254842021634L,20081656282038L,340747127912616L,6111343349250912L,115529870445001392L,2296160998268520576L,BigInteger.Parse("47869541875153872144"),BigInteger.Parse("1044601509263870430000") };
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
public class A276895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276895Inst Instance=new A276895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276896
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,42610L,417464L,4438936L,51245936L,640642456L,8640223604L,124868055888L,1924066147008L,31484641736040L,545300469146760L,9967163998036554L,191772882094520910L,3874791064947232008L,BigInteger.Parse("82035921068376624096"),BigInteger.Parse("1816274191193756670912") };
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
public class A276896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276896Inst Instance=new A276896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276897
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,498542L,5586952L,67067528L,863967424L,11931711152L,176258744536L,2777402228132L,46453613044464L,821540685443328L,15314758450069728L,300131246157443016L,6169170736959823656L,BigInteger.Parse("132727347264381285042"),BigInteger.Parse("2983326113743943646918") };
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
public class A276897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276897Inst Instance=new A276897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276898
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,6541426L,82575992L,1105638712L,15740668640L,238286993344L,3830996668880L,65290928665336L,1177060804189460L,22361980927148976L,446348461695232608L,9336784271669066016UL,BigInteger.Parse("204240575957464571232"),BigInteger.Parse("4663193421334759826472") };
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
public class A276898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276898Inst Instance=new A276898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276899
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,7087261L,95160302L,1336605832L,19761235784L,308372439520L,5082485111648L,88427826212320L,1622190325391504L,31329432209039896L,635929197472661444L,13526250938401091568UL,BigInteger.Parse("300743675140836904032"),BigInteger.Parse("6975365075051730713856") };
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
public class A276899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276899Inst Instance=new A276899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276916
{
public static readonly long[] Value={ 1L,5L,41L,61L,145L,181L,313L,365L,545L,613L,841L,925L,1201L,1301L,1625L,1741L,2113L,2245L,2665L,2813L,3281L,3445L,3961L,4141L,4705L,4901L,5513L,5725L,6385L,6613L,7321L,7565L,8321L,8581L,9385L,9661L,10513L,10805L,11705L,12013L,12961L,13285L,14281L,14621L,15665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276916Inst : IEnumerable<long>
{
public static readonly long[] Value=A276916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276916.Bytes);
public long this[int i]=>Value[i];

public static A276916Inst Instance=new A276916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276917
{
public static readonly long[] Value={ 1L,6L,16L,31L,71L,106L,236L,311L,711L,866L,2076L,2391L,6031L,6666L,17596L,18871L,51671L,54226L,152636L,157751L,452991L,463226L,1348956L,1369431L,4026631L,4067586L,12039196L,12121111L,36035951L,36199786L,107944316L,108271991L,323505591L,324160946L,969861756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276917Inst : IEnumerable<long>
{
public static readonly long[] Value=A276917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276917.Bytes);
public long this[int i]=>Value[i];

public static A276917Inst Instance=new A276917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276918
{
public static readonly long[] Value={ 1L,5L,9L,25L,49L,113L,225L,481L,961L,1985L,3969L,8065L,16129L,32513L,65025L,130561L,261121L,523265L,1046529L,2095105L,4190209L,8384513L,16769025L,33546241L,67092481L,134201345L,268402689L,536838145L,1073676289L,2147418113L,4294836225L,8589803521L,17179607041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276918Inst : IEnumerable<long>
{
public static readonly long[] Value=A276918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276918.Bytes);
public long this[int i]=>Value[i];

public static A276918Inst Instance=new A276918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276919
{
public static readonly long[] Value={ 1L,8L,27L,64L,125L,216L,336L,512L,1296L,1000L,1331L,1728L,1794L,2688L,3375L,4096L,4913L,10368L,7410L,8000L,9072L,10648L,12167L,13824L,15625L,14352L,34992L,21504L,24389L,27000L,30225L,32768L,35937L,39304L,42000L,82944L,48396L,59280L,48438L,64000L,68921L,72576L,77529L,85184L,162000L,97336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276919Inst : IEnumerable<long>
{
public static readonly long[] Value=A276919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276919.Bytes);
public long this[int i]=>Value[i];

public static A276919Inst Instance=new A276919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276920
{
public static readonly long[] Value={ 1L,8L,27L,72L,125L,216L,595L,704L,1539L,1000L,1331L,1944L,3133L,4760L,3375L,5632L,4913L,12312L,8911L,9000L,16065L,10648L,12167L,19008L,16125L,25064L,45927L,42840L,24389L,27000L,35371L,47104L,35937L,39304L,74375L,110808L,58645L,71288L,84591L,88000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276920Inst : IEnumerable<long>
{
public static readonly long[] Value=A276920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276920.Bytes);
public long this[int i]=>Value[i];

public static A276920Inst Instance=new A276920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276921
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,3L,6L,0L,1L,1L,3L,12L,24L,0L,1L,1L,3L,13L,66L,120L,0L,1L,1L,3L,13L,74L,450L,720L,0L,1L,1L,3L,13L,75L,530L,3690L,5040L,0L,1L,1L,3L,13L,75L,540L,4550L,35280L,40320L,0L,1L,1L,3L,13L,75L,541L,4670L,45570L,385560L,362880L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276921Inst : IEnumerable<long>
{
public static readonly long[] Value=A276921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276921.Bytes);
public long this[int i]=>Value[i];

public static A276921Inst Instance=new A276921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276922
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,6L,1L,0L,24L,42L,8L,1L,0L,120L,330L,80L,10L,1L,0L,720L,2970L,860L,120L,12L,1L,0L,5040L,30240L,10290L,1540L,168L,14L,1L,0L,40320L,345240L,136080L,21490L,2464L,224L,16L,1L,0L,362880L,4377240L,1977360L,326970L,38808L,3696L,288L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276922Inst : IEnumerable<long>
{
public static readonly long[] Value=A276922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276922.Bytes);
public long this[int i]=>Value[i];

public static A276922Inst Instance=new A276922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276923
{
public static readonly BigInteger[] Value={ 1L,2L,42L,860L,21490L,657972L,24011988L,1017804216L,49118959890L,2657929522820L,159340977018652L,10480673825750856L,750335572490293972L,BigInteger.Parse("58077997318270046600"),BigInteger.Parse("4832536579295065540200"),BigInteger.Parse("430136064463753547944560"),BigInteger.Parse("40779223639911413185024530") };
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
public class A276923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276923Inst Instance=new A276923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276924
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,540L,4670L,47110L,543130L,7044450L,101519250L,1609319250L,27830729850L,521397676800L,10519576867800L,227400111939000L,5243385642495000L,128458209887007000L,3332234177825553000L,BigInteger.Parse("91241046790816923000"),BigInteger.Parse("2629791992312269785000") };
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
public class A276924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276924.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276924Inst Instance=new A276924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276925
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4682L,47278L,545594L,7083258L,102177222L,1621316466L,28065324210L,526301293518L,10628781887724L,229983021824556L,5308071700475544L,130168746864660504L,3379871981604782664L,BigInteger.Parse("92634950510491052664"),BigInteger.Parse("2672550322299614660904") };
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
public class A276925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276925Inst Instance=new A276925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276926
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47292L,545818L,7086954L,102241902L,1622523210L,28089336198L,526810157874L,10640241569958L,230256584914356L,5314976561846952L,130352566702702344L,3385021286975255928L,BigInteger.Parse("92786398312428612792"),BigInteger.Parse("2677217312112863784264") };
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
public class A276926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276926Inst Instance=new A276926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276927
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545834L,7087242L,102247182L,1622624850L,28091404902L,526854753282L,10641259374174L,230281144233426L,5315601950221992L,130369339178641992L,3385494089758915992L,BigInteger.Parse("92800379366660198376"),BigInteger.Parse("2677650178353887869704") };
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
public class A276927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276927Inst Instance=new A276927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276928
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,7087260L,102247542L,1622632110L,28091557362L,526858114926L,10641337416138L,230283052622766L,5315651069181882L,130370668142722722L,3385531828379161890L,BigInteger.Parse("92801502294634265418"),BigInteger.Parse("2677685131818279016434") };
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
public class A276928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276928Inst Instance=new A276928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276929
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,7087261L,102247562L,1622632550L,28091567042L,526858335146L,10641342645362L,230283182692706L,5315654461874042L,130370760923004602L,3385534486308684710L,BigInteger.Parse("92801581965119911026"),BigInteger.Parse("2677687627216659136794") };
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
public class A276929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276929Inst Instance=new A276929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276930
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,7087261L,102247563L,1622632572L,28091567570L,526858347730L,10641342953670L,230283190536542L,5315654669985946L,130370766690581274L,3385534653313192094L,BigInteger.Parse("92801587015186096762"),BigInteger.Parse("2677687786557636155446") };
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
public class A276930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276930Inst Instance=new A276930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276931
{
public static readonly long[] Value={ 1L,4L,6L,7L,13L,16L,18L,19L,25L,28L,30L,31L,36L,37L,39L,40L,42L,43L,61L,64L,66L,67L,73L,76L,78L,79L,85L,88L,90L,91L,96L,97L,99L,100L,102L,103L,121L,124L,126L,127L,133L,136L,138L,139L,145L,148L,150L,151L,156L,157L,159L,160L,162L,163L,181L,184L,186L,187L,193L,196L,198L,199L,205L,208L,210L,211L,216L,217L,219L,220L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276931Inst : IEnumerable<long>
{
public static readonly long[] Value=A276931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276931.Bytes);
public long this[int i]=>Value[i];

public static A276931Inst Instance=new A276931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276996
{
public static readonly long[] Value={ 1L,0L,0L,1L,-1L,1L,0L,1L,-3L,1L,1L,-1L,6L,-10L,5L,0L,-1L,-15L,95L,-40L,16L,239L,-1L,13L,-85L,240L,-237L,79L,0L,403L,21L,385L,-1575L,3577L,-2947L,421L,-46409L,-239L,3841L,175L,861L,-8036L,45458L,-10692L,2673L,0L,-82451L,-2657L,56177L,1638L,19488L,-85260L,139656L,-86472L,19216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276996Inst : IEnumerable<long>
{
public static readonly long[] Value=A276996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276996.Bytes);
public long this[int i]=>Value[i];

public static A276996Inst Instance=new A276996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276997
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,1L,1L,2L,2L,1L,60L,1L,1L,1L,1L,1L,6L,2L,3L,1L,1L,504L,4L,4L,1L,1L,1L,1L,1L,24L,8L,12L,2L,2L,2L,1L,2160L,18L,9L,3L,2L,1L,3L,1L,1L,1L,60L,4L,6L,1L,5L,1L,1L,1L,1L,3168L,48L,16L,6L,3L,2L,2L,1L,2L,1L,1L,1L,288L,32L,144L,12L,12L,4L,2L,1L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276997Inst : IEnumerable<long>
{
public static readonly long[] Value=A276997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276997.Bytes);
public long this[int i]=>Value[i];

public static A276997Inst Instance=new A276997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276998
{
public static readonly long[] Value={ 1L,1L,2L,1L,12L,6L,-1L,72L,24L,-24L,1L,1440L,120L,-960L,200L,37L,43200L,-9360L,-44280L,20640L,3750L,-1493L,1814400L,-997920L,-2484720L,2028600L,271740L,-378966L,14017L,25401600L,-23042880L,-42497280L,54159840L,3328080L,-18236064L,1977248L,751267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276998Inst : IEnumerable<long>
{
public static readonly long[] Value=A276998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276998.Bytes);
public long this[int i]=>Value[i];

public static A276998Inst Instance=new A276998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276999
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,9L,0L,0L,1L,12L,93L,0L,0L,1L,15L,147L,1175L,0L,0L,1L,18L,213L,2070L,17835L,0L,0L,1L,21L,291L,3325L,33825L,317667L,0L,0L,1L,24L,381L,5000L,58575L,635208L,6506647L,0L,0L,1L,27L,483L,7155L,94785L,1164429L,13536453L,150776397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276999Inst : IEnumerable<long>
{
public static readonly long[] Value=A276999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276999.Bytes);
public long this[int i]=>Value[i];

public static A276999Inst Instance=new A276999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277000
{
public static readonly BigInteger[] Value={ 1L,-1L,19L,-2561L,874831L,-319094777L,47095708213409L,-751163826506551L,BigInteger.Parse("281559662236405100437"),BigInteger.Parse("-49061598325832137241324057"),BigInteger.Parse("5012066724315488368700829665081"),BigInteger.Parse("-26602063280041700132088988446735433"),BigInteger.Parse("40762630349420684160007591156102493590477") };
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
public class A277000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277000.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277000Inst Instance=new A277000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277001
{
public static readonly BigInteger[] Value={ 1L,24L,5760L,2903040L,1393459200L,367873228800L,24103053950976000L,115694658964684800L,BigInteger.Parse("9440684171518279680000"),BigInteger.Parse("271211974879377138647040000"),BigInteger.Parse("3579998068407778230140928000000"),BigInteger.Parse("1976158933761093583037792256000000"),BigInteger.Parse("258955866680053703121272297226240000000") };
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
public class A277001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277001Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277001.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277001.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277001Inst Instance=new A277001Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277002
{
public static readonly BigInteger[] Value={ -1L,7L,-31L,127L,-511L,1414477L,-8191L,118518239L,-5749691557L,91546277357L,-23273283019L,1982765468311237L,-22076500342261L,455371239541065869L,BigInteger.Parse("-925118910976041358111"),BigInteger.Parse("16555640865486520478399"),BigInteger.Parse("-1302480594081611886641"),BigInteger.Parse("904185845619475242495834469891") };
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
public class A277002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277002Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277002.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277002.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277002Inst Instance=new A277002Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277003
{
public static readonly BigInteger[] Value={ 24L,2880L,40320L,215040L,608256L,738017280L,1277952L,4010803200L,32006209536L,65745715200L,1736441856L,12641296711680L,10066329600L,12611097722880L,1337897345089536L,1086454927196160L,3401614098432L,BigInteger.Parse("83088011510887219200"),61022895341568L };
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
public class A277003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277003.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277003Inst Instance=new A277003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277004
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,4L,2L,1L,0L,27L,9L,2L,4L,0L,256L,44L,9L,8L,27L,0L,3125L,265L,44L,36L,54L,256L,0L,46656L,1854L,265L,176L,243L,512L,3125L,0L,823543L,14833L,1854L,1060L,1188L,2304L,6250L,46656L,0L,16777216L,133496L,14833L,7416L,7155L,11264L,28125L,93312L,823543L,0L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277004Inst : IEnumerable<long>
{
public static readonly long[] Value=A277004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277004.Bytes);
public long this[int i]=>Value[i];

public static A277004Inst Instance=new A277004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277005
{
public static readonly BigInteger[] Value={ 2L,5L,29L,193L,1733L,17291L,207367L,2903041L,43545611L,696729629L,12541132817L,250822656001L,5267275776047L,115880067072017L,2781121609728037L,69528040243200079L,1807729046323200001L,BigInteger.Parse("48808684250726400031"),BigInteger.Parse("136664315902033920001") };
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
public class A277005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277005.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277005Inst Instance=new A277005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277006
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,15L,11L,14L,21L,35L,30L,13L,22L,33L,55L,42L,77L,70L,105L,17L,26L,39L,65L,66L,91L,110L,165L,143L,154L,231L,385L,210L,19L,34L,51L,85L,78L,119L,130L,195L,187L,182L,273L,455L,330L,221L,286L,429L,715L,462L,1001L,770L,1155L,23L,38L,57L,95L,102L,133L,170L,255L,209L,238L,357L,595L,390L,247L,374L,561L,935L,546L,1309L,910L,1365L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277006Inst : IEnumerable<long>
{
public static readonly long[] Value=A277006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277006.Bytes);
public long this[int i]=>Value[i];

public static A277006Inst Instance=new A277006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277007
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277007Inst : IEnumerable<long>
{
public static readonly long[] Value=A277007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277007.Bytes);
public long this[int i]=>Value[i];

public static A277007Inst Instance=new A277007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277008
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,32L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,48L,49L,50L,52L,53L,54L,56L,57L,58L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,80L,81L,82L,84L,85L,86L,88L,89L,90L,92L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,109L,112L,113L,114L,116L,117L,118L,120L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277008Inst : IEnumerable<long>
{
public static readonly long[] Value=A277008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277008.Bytes);
public long this[int i]=>Value[i];

public static A277008Inst Instance=new A277008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277009
{
public static readonly long[] Value={ 3L,7L,11L,14L,15L,19L,23L,27L,29L,30L,31L,35L,39L,43L,46L,47L,51L,55L,59L,60L,61L,62L,63L,67L,71L,75L,78L,79L,83L,87L,91L,93L,94L,95L,99L,103L,107L,110L,111L,115L,119L,121L,122L,123L,124L,125L,126L,127L,131L,135L,139L,142L,143L,147L,151L,155L,157L,158L,159L,163L,167L,171L,174L,175L,179L,183L,187L,188L,189L,190L,191L,195L,199L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277009Inst : IEnumerable<long>
{
public static readonly long[] Value=A277009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277009.Bytes);
public long this[int i]=>Value[i];

public static A277009Inst Instance=new A277009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277010
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,9L,16L,32L,17L,10L,64L,128L,18L,33L,256L,65L,512L,21L,1024L,34L,129L,20L,2048L,257L,66L,4096L,37L,8192L,513L,16384L,130L,32768L,36L,258L,1025L,65536L,131072L,2049L,68L,69L,262144L,514L,41L,524288L,1048576L,4097L,40L,133L,2097152L,8193L,4194304L,132L,16385L,1026L,8388608L,72L,2050L,32769L,260L,16777216L,33554432L,261L,67108864L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277010Inst : IEnumerable<long>
{
public static readonly long[] Value=A277010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277010.Bytes);
public long this[int i]=>Value[i];

public static A277010Inst Instance=new A277010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277011
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,3L,4L,3L,24L,7L,8L,4L,12L,5L,6L,4L,120L,25L,26L,8L,30L,9L,10L,5L,48L,13L,14L,6L,18L,7L,8L,5L,720L,121L,122L,26L,126L,27L,28L,9L,144L,31L,32L,10L,36L,11L,12L,6L,240L,49L,50L,14L,54L,15L,16L,7L,72L,19L,20L,8L,24L,9L,10L,6L,5040L,721L,722L,122L,726L,123L,124L,27L,744L,127L,128L,28L,132L,29L,30L,10L,840L,145L,146L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277011Inst : IEnumerable<long>
{
public static readonly long[] Value=A277011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277011.Bytes);
public long this[int i]=>Value[i];

public static A277011Inst Instance=new A277011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277044
{
public static readonly long[] Value={ 0L,0L,0L,16L,96L,216L,600L,1008L,2064L,3040L,5280L,7200L,11280L,14616L,21336L,26656L,36960L,44928L,59904L,71280L,92160L,107800L,135960L,156816L,193776L,220896L,268320L,302848L,362544L,405720L,479640L,532800L,623040L,687616L,796416L,873936L,1003680L,1095768L,1248984L,1357360L,1536720L,1663200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277044Inst : IEnumerable<long>
{
public static readonly long[] Value=A277044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277044.Bytes);
public long this[int i]=>Value[i];

public static A277044Inst Instance=new A277044Inst();

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