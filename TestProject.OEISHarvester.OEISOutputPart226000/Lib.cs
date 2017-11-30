using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A264382
{
public static readonly long[] Value={ 0L,25L,441L,3778L,60858L,711068L,9407584L,115929779L,1485398475L,18746069596L,237937556367L,3012183685044L,38165904080061L,483579364451792L,6125734123144467L,77617437527388938L,983250878745280550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264382Inst : IEnumerable<long>
{
public static readonly long[] Value=A264382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264382.Bytes);
public long this[int i]=>Value[i];

public static A264382Inst Instance=new A264382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264383
{
public static readonly BigInteger[] Value={ 1L,128L,3249L,63575L,1742881L,45132986L,1187897216L,30373276651L,792780331712L,20444262438305L,530521904672461L,13716515010894393L,355463297798764953L,9199078922790223336L,BigInteger.Parse("238250431643039032101"),BigInteger.Parse("6167702521336260154448") };
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
public class A264383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264383.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264383Inst Instance=new A264383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264384
{
public static readonly BigInteger[] Value={ 0L,347L,22484L,828400L,48714516L,2546661201L,135926940964L,7028273171990L,373730198247984L,19642240165929614L,1037225681776050162L,BigInteger.Parse("54639267702225385178"),BigInteger.Parse("2881673580028315975296"),BigInteger.Parse("151886941377998952959800") };
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
public class A264384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264384Inst Instance=new A264384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264385
{
public static readonly BigInteger[] Value={ 1L,1343L,156293L,11888603L,1363452981L,149731056598L,16353452350876L,1735328063172744L,188810032043800381L,BigInteger.Parse("20288902506786356394"),BigInteger.Parse("2189915587683013427440"),BigInteger.Parse("235922552838031495595870") };
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
public class A264385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264385Inst Instance=new A264385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264386
{
public static readonly long[] Value={ 1L,10L,19L,4L,13L,22L,7L,16L,25L,2L,11L,20L,5L,14L,23L,8L,17L,26L,3L,12L,21L,6L,15L,24L,9L,18L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264386Inst : IEnumerable<long>
{
public static readonly long[] Value=A264386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264386.Bytes);
public long this[int i]=>Value[i];

public static A264386Inst Instance=new A264386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264387
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,59L,61L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,77L,78L,79L,80L,81L,82L,83L,86L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264387Inst : IEnumerable<long>
{
public static readonly long[] Value=A264387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264387.Bytes);
public long this[int i]=>Value[i];

public static A264387Inst Instance=new A264387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264388
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,5L,5L,7L,14L,3L,15L,55L,11L,13L,91L,35L,20L,34L,51L,57L,95L,35L,77L,253L,46L,25L,325L,117L,63L,203L,145L,155L,248L,44L,187L,595L,105L,111L,703L,247L,130L,205L,287L,301L,473L,165L,345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264388Inst : IEnumerable<long>
{
public static readonly long[] Value=A264388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264388.Bytes);
public long this[int i]=>Value[i];

public static A264388Inst Instance=new A264388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264389
{
public static readonly long[] Value={ 1L,1L,18L,8L,5L,18L,14L,16L,27L,5L,22L,72L,13L,14L,90L,32L,17L,27L,38L,40L,63L,22L,46L,144L,25L,13L,162L,56L,29L,90L,62L,64L,99L,17L,70L,216L,37L,38L,234L,80L,41L,63L,86L,88L,135L,46L,94L,288L,49L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264389Inst : IEnumerable<long>
{
public static readonly long[] Value=A264389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264389.Bytes);
public long this[int i]=>Value[i];

public static A264389Inst Instance=new A264389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264390
{
public static readonly long[] Value={ 8L,32L,136L,160L,408L,720L,1176L,1200L,2168L,2912L,3976L,4288L,5752L,7120L,10344L,10368L,12824L,15728L,18776L,19520L,25448L,28640L,33064L,33376L,39624L,44016L,52760L,54128L,61096L,70768L,78712L,78736L,92568L,99936L,114072L,116976L,128232L,137376L,156408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264390Inst : IEnumerable<long>
{
public static readonly long[] Value=A264390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264390.Bytes);
public long this[int i]=>Value[i];

public static A264390Inst Instance=new A264390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264391
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,2L,2L,1L,1L,0L,1L,4L,2L,2L,1L,1L,0L,1L,4L,4L,2L,2L,1L,1L,0L,1L,6L,5L,4L,2L,2L,1L,1L,0L,1L,8L,6L,5L,4L,2L,2L,1L,1L,0L,1L,11L,9L,6L,5L,4L,2L,2L,1L,1L,0L,1L,13L,12L,9L,6L,5L,4L,2L,2L,1L,1L,0L,1L,19L,15L,12L,9L,6L,5L,4L,2L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264391Inst : IEnumerable<long>
{
public static readonly long[] Value=A264391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264391.Bytes);
public long this[int i]=>Value[i];

public static A264391Inst Instance=new A264391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264392
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,19L,30L,46L,68L,99L,142L,200L,279L,384L,523L,707L,946L,1256L,1656L,2169L,2822L,3652L,4699L,6017L,7666L,9725L,12282L,15452L,19362L,24176L,30080L,37307L,46117L,56843L,69854L,85613L,104640L,127578L,155150L,188249L,227872L,275242L,331738L,399027L,478988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264392Inst : IEnumerable<long>
{
public static readonly long[] Value=A264392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264392.Bytes);
public long this[int i]=>Value[i];

public static A264392Inst Instance=new A264392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264393
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,6L,8L,11L,13L,19L,22L,30L,37L,48L,58L,76L,91L,116L,141L,176L,212L,265L,317L,390L,468L,571L,681L,828L,983L,1185L,1407L,1685L,1993L,2378L,2802L,3326L,3913L,4624L,5421L,6387L,7466L,8762L,10223L,11955L,13910L,16225L,18831L,21898L,25365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264393Inst : IEnumerable<long>
{
public static readonly long[] Value=A264393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264393.Bytes);
public long this[int i]=>Value[i];

public static A264393Inst Instance=new A264393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264394
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,2L,0L,2L,0L,1L,1L,3L,0L,2L,0L,1L,3L,1L,4L,0L,2L,0L,1L,1L,6L,1L,4L,0L,2L,0L,1L,5L,2L,7L,1L,4L,0L,2L,0L,1L,3L,9L,2L,8L,1L,4L,0L,2L,0L,1L,8L,4L,12L,2L,8L,1L,4L,0L,2L,0L,1L,5L,15L,5L,13L,2L,8L,1L,4L,0L,2L,0L,1L,12L,9L,19L,5L,14L,2L,8L,1L,4L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264394Inst : IEnumerable<long>
{
public static readonly long[] Value=A264394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264394.Bytes);
public long this[int i]=>Value[i];

public static A264394Inst Instance=new A264394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264395
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,14L,23L,37L,55L,84L,121L,175L,247L,346L,476L,654L,881L,1184L,1574L,2081L,2725L,3559L,4605L,5939L,7610L,9713L,12327L,15598L,19631L,24633L,30780L,38342L,47577L,58884L,72615L,89324L,109539L,133998L,163455L,198949L,241505L,292550L,353547L,426394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264395Inst : IEnumerable<long>
{
public static readonly long[] Value=A264395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264395.Bytes);
public long this[int i]=>Value[i];

public static A264395Inst Instance=new A264395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264396
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,5L,5L,6L,8L,8L,9L,12L,12L,14L,17L,18L,21L,25L,26L,30L,36L,39L,43L,51L,55L,62L,73L,78L,88L,101L,110L,125L,141L,154L,172L,195L,215L,238L,269L,294L,327L,368L,402L,446L,498L,547L,606L,672L,737L,814L,903L,991L,1091L,1205L,1320L,1452L,1603L,1752L,1924L,2118L,2314L,2539L,2785L,3042L,3329L,3648L,3984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264396Inst : IEnumerable<long>
{
public static readonly long[] Value=A264396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264396.Bytes);
public long this[int i]=>Value[i];

public static A264396Inst Instance=new A264396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264397
{
public static readonly long[] Value={ 1L,3L,5L,10L,15L,26L,38L,60L,86L,127L,178L,255L,349L,484L,652L,885L,1174L,1565L,2049L,2689L,3481L,4510L,5779L,7407L,9403L,11933L,15029L,18908L,23636L,29511L,36641L,45432L,56063L,69076L,84753L,103833L,126730L,154438L,187584L,227485L,275056L,332066L,399811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264397Inst : IEnumerable<long>
{
public static readonly long[] Value=A264397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264397.Bytes);
public long this[int i]=>Value[i];

public static A264397Inst Instance=new A264397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264398
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,2L,1L,2L,2L,1L,0L,4L,3L,3L,4L,3L,1L,0L,7L,7L,1L,5L,7L,7L,3L,0L,12L,14L,4L,7L,12L,14L,8L,1L,0L,19L,26L,10L,1L,11L,19L,26L,18L,3L,0L,30L,45L,22L,4L,15L,30L,45L,36L,9L,0L,45L,75L,44L,11L,1L,22L,45L,75L,67L,21L,1L,0L,67L,120L,81L,26L,3L,30L,67L,120L,119L,45L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264398Inst : IEnumerable<long>
{
public static readonly long[] Value=A264398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264398.Bytes);
public long this[int i]=>Value[i];

public static A264398Inst Instance=new A264398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264399
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,3L,5L,2L,6L,4L,1L,9L,6L,9L,11L,2L,16L,13L,1L,20L,15L,7L,25L,28L,3L,32L,33L,11L,1L,40L,52L,9L,54L,55L,24L,2L,69L,82L,25L,84L,101L,40L,6L,101L,148L,46L,2L,136L,163L,73L,13L,156L,239L,89L,6L,202L,274L,127L,23L,1L,244L,364L,170L,14L,306L,437L,211L,46L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264399Inst : IEnumerable<long>
{
public static readonly long[] Value=A264399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264399.Bytes);
public long this[int i]=>Value[i];

public static A264399Inst Instance=new A264399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264400
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,2L,6L,6L,15L,15L,29L,34L,58L,70L,109L,132L,199L,246L,348L,435L,601L,746L,1005L,1252L,1653L,2053L,2666L,3298L,4231L,5219L,6608L,8124L,10198L,12476L,15525L,18927L,23374L,28387L,34823L,42122L,51376L,61922L,75098L,90200L,108874L,130298L,156564L,186777L,223490L,265779L,316799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264400Inst : IEnumerable<long>
{
public static readonly long[] Value=A264400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264400.Bytes);
public long this[int i]=>Value[i];

public static A264400Inst Instance=new A264400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264401
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,3L,2L,4L,4L,2L,1L,4L,6L,4L,1L,7L,8L,5L,2L,8L,11L,8L,3L,12L,15L,10L,4L,1L,14L,20L,15L,6L,1L,21L,26L,19L,9L,2L,24L,35L,27L,12L,3L,34L,45L,34L,17L,5L,41L,58L,47L,23L,6L,1L,55L,75L,59L,31L,10L,1L,66L,96L,79L,41L,13L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264401Inst : IEnumerable<long>
{
public static readonly long[] Value=A264401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264401.Bytes);
public long this[int i]=>Value[i];

public static A264401Inst Instance=new A264401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264402
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,2L,2L,4L,1L,4L,5L,2L,2L,8L,4L,1L,4L,9L,7L,2L,3L,12L,10L,4L,1L,4L,14L,15L,7L,2L,2L,17L,20L,12L,4L,1L,6L,18L,27L,17L,7L,2L,2L,23L,33L,26L,12L,4L,1L,4L,24L,44L,35L,19L,7L,2L,4L,27L,51L,49L,28L,12L,4L,1L,5L,30L,64L,63L,41L,19L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264402Inst : IEnumerable<long>
{
public static readonly long[] Value=A264402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264402.Bytes);
public long this[int i]=>Value[i];

public static A264402Inst Instance=new A264402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264403
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,0L,0L,2L,2L,0L,1L,0L,2L,1L,1L,1L,1L,0L,3L,4L,0L,1L,1L,1L,0L,4L,2L,2L,1L,2L,1L,2L,0L,5L,6L,0L,2L,1L,3L,2L,2L,0L,6L,5L,2L,1L,4L,1L,4L,2L,3L,0L,8L,9L,1L,3L,2L,5L,2L,4L,3L,3L,0L,10L,7L,3L,3L,6L,2L,7L,2L,6L,3L,5L,0L,12L,16L,0L,4L,4L,7L,3L,8L,3L,7L,5L,5L,0L,15L,11L,6L,4L,8L,5L,9L,3L,12L,3L,10L,5L,7L,0L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264403Inst : IEnumerable<long>
{
public static readonly long[] Value=A264403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264403.Bytes);
public long this[int i]=>Value[i];

public static A264403Inst Instance=new A264403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264404
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,3L,1L,4L,4L,1L,2L,5L,6L,2L,2L,6L,8L,3L,3L,2L,8L,11L,4L,5L,2L,10L,14L,5L,7L,3L,3L,12L,19L,7L,10L,5L,3L,15L,24L,9L,15L,6L,4L,4L,18L,31L,12L,20L,9L,7L,4L,22L,39L,15L,26L,13L,9L,6L,5L,27L,49L,19L,36L,17L,13L,10L,5L,32L,61L,24L,46L,23L,18L,14L,7L,6L,38L,76L,30L,60L,31L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264404Inst : IEnumerable<long>
{
public static readonly long[] Value=A264404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264404.Bytes);
public long this[int i]=>Value[i];

public static A264404Inst Instance=new A264404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264405
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,2L,0L,1L,3L,0L,2L,1L,0L,1L,4L,0L,2L,2L,2L,0L,1L,5L,0L,4L,2L,1L,2L,0L,1L,6L,0L,6L,2L,3L,2L,2L,0L,1L,8L,0L,7L,4L,4L,2L,2L,2L,0L,1L,10L,0L,8L,6L,6L,4L,3L,2L,2L,0L,1L,12L,0L,13L,6L,6L,8L,3L,3L,2L,2L,0L,1L,15L,0L,15L,9L,11L,6L,9L,4L,3L,2L,2L,0L,1L,18L,0L,21L,10L,13L,12L,7L,8L,4L,3L,2L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264405Inst : IEnumerable<long>
{
public static readonly long[] Value=A264405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264405.Bytes);
public long this[int i]=>Value[i];

public static A264405Inst Instance=new A264405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264406
{
public static readonly long[] Value={ 1L,11L,101L,111L,1001L,1111L,10001L,10101L,10201L,11011L,11111L,100001L,101101L,102201L,110011L,111111L,1000001L,1001001L,1002001L,1010101L,1011101L,1012101L,1020201L,1021201L,1022201L,1023201L,1100011L,1101011L,1102011L,1110111L,1111111L,10000001L,10011001L,10022001L,10100101L,10111101L,10122101L,10200201L,10211201L,10222201L,10233201L,11000011L,11011011L,11022011L,11100111L,11111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264406Inst : IEnumerable<long>
{
public static readonly long[] Value=A264406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264406.Bytes);
public long this[int i]=>Value[i];

public static A264406Inst Instance=new A264406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264407
{
public static readonly BigInteger[] Value={ 1L,1L,6L,66L,1084L,23920L,665388L,22374884L,883177328L,40043323728L,2051202965280L,117166763184768L,7384596609153696L,509084508866799840L,BigInteger.Parse("38108295339435463296"),BigInteger.Parse("3078340850588419228800"),BigInteger.Parse("266906341797637061659392"),BigInteger.Parse("24724454378396015985551616"),BigInteger.Parse("2436960508983873399401081856"),BigInteger.Parse("254658073346711773211982974976"),BigInteger.Parse("28122779871625104764662272952320") };
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
public class A264407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264407Inst Instance=new A264407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264408
{
public static readonly BigInteger[] Value={ 1L,1L,8L,123L,2880L,91380L,3670422L,178637046L,10220188584L,672297233904L,49998246211440L,4148400045354048L,379922492043352728L,BigInteger.Parse("38069325641907527760"),BigInteger.Parse("4143052833221549219112"),BigInteger.Parse("486645149764644576491160"),BigInteger.Parse("61364015736691449905270208"),BigInteger.Parse("8267876533375590035644494336"),BigInteger.Parse("1185420892076469924434688605760") };
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
public class A264408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264408Inst Instance=new A264408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264409
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,53L,376L,3187L,31312L,348833L,4318804L,58583231L,862021084L,13650998473L,231123405124L,4160680867085L,79272259679386L,1592221255517713L,33599025754872240L,742661269363444447L,17149370461633306924UL,BigInteger.Parse("412742027009797487561"),BigInteger.Parse("10331628852664232678356"),BigInteger.Parse("268469799828424474556585"),BigInteger.Parse("7229580560131818394109850"),BigInteger.Parse("201438863633591604857727001") };
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
public class A264409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264409Inst Instance=new A264409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264410
{
public static readonly BigInteger[] Value={ 1L,2L,6L,299L,2630475L,5194717544512L,BigInteger.Parse("3708580324835714831258"),BigInteger.Parse("1461034854533485247412937306733067"),BigInteger.Parse("450538787986948219326155652866541933427447505845"),BigInteger.Parse("146413934927214452212855330835382443952802497537220927026261910086"),BigInteger.Parse("64954656894649578286072291957497800888821547620744164639686415856667115998603764278502") };
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
public class A264410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264410Inst Instance=new A264410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264411
{
public static readonly BigInteger[] Value={ 1L,2L,28L,816L,35960L,2118760L,156238908L,13834413152L,1429702652400L,168899639028120L,22451004309013280L,3316276739861976176L,BigInteger.Parse("538884034480519066248"),BigInteger.Parse("95533608280955635872536"),BigInteger.Parse("18348499272339029224271680"),BigInteger.Parse("3795302872076181378439692480"),BigInteger.Parse("841141456821158064519401490400"),BigInteger.Parse("198852623925936212550698141090040"),BigInteger.Parse("49949550731916384239220134110005024") };
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
public class A264411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264411Inst Instance=new A264411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264412
{
public static readonly long[] Value={ 1L,3L,-3L,9L,-33L,126L,-513L,2214L,-9876L,45045L,-209493L,990198L,-4741191L,22946247L,-112079214L,551793303L,-2735330190L,13641353118L,-68394016548L,344539469889L,-1743035351958L,8851923849123L,-45110440515753L,230615809867476L,-1182376529280117L,6078184963674498L,-31322206517658453L,161774639164275552L,-837290923919381322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264412Inst : IEnumerable<long>
{
public static readonly long[] Value=A264412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264412.Bytes);
public long this[int i]=>Value[i];

public static A264412Inst Instance=new A264412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264413
{
public static readonly BigInteger[] Value={ 1L,6L,-15L,90L,-660L,5310L,-45765L,413640L,-3864345L,37014120L,-361577790L,3588484140L,-36079979085L,366728363460L,-3762120325140L,38901621985290L,-405039437707575L,4242802537386450L,-44681704461745740L,472795814216587140L,-5024232597805717410L,BigInteger.Parse("53596341229925979360"),BigInteger.Parse("-573736849659978481665"),BigInteger.Parse("6161218734911098973490"),BigInteger.Parse("-66355728143871653462745") };
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
public class A264413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264413Inst Instance=new A264413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264414
{
public static readonly BigInteger[] Value={ 1L,10L,-45L,450L,-5535L,75600L,-1106100L,16953750L,-268652880L,4365638550L,-72354858300L,1218356280000L,-20784495119850L,358457180010750L,-6239532583193625L,109476057598087500L,-1934128026918961515L,BigInteger.Parse("34378012275668994150"),BigInteger.Parse("-614328464414815220025"),BigInteger.Parse("11030366153872043358750"),BigInteger.Parse("-198899407327466712808800"),BigInteger.Parse("3600377821710426377668500") };
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
public class A264414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264414Inst Instance=new A264414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264415
{
public static readonly BigInteger[] Value={ 1L,15L,-105L,1575L,-29190L,603225L,-13352850L,309605625L,-7422255645L,182481301800L,-4575894819300L,116581172754375L,-3009161401332975L,78523515330379875L,-2068113764887828875L,BigInteger.Parse("54904020923799337500"),BigInteger.Parse("-1467692309121298737960"),BigInteger.Parse("39472725372798507822900"),BigInteger.Parse("-1067296235915278105855650"),BigInteger.Parse("28996357915496677935088125"),BigInteger.Parse("-791147023483262777604486675"),BigInteger.Parse("21669197341488265510394307750") };
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
public class A264415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264415Inst Instance=new A264415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264416
{
public static readonly BigInteger[] Value={ 1L,1L,3L,11L,46L,234L,1269L,7609L,48501L,328831L,2347655L,17551462L,136902440L,1109043889L,9308756773L,80704240807L,721319484280L,6632169860334L,62631220229804L,606525577239266L,6015393685594488L,61024457251302195L,632560831051022660L,6693134988051996106L,BigInteger.Parse("72226722923184020925"),BigInteger.Parse("794238562047133369308") };
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
public class A264416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264416Inst Instance=new A264416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264417
{
public static readonly long[] Value={ 2L,3L,20L,85L,351L,1462L,6021L,25188L,104870L,437164L,1821829L,7592125L,31637827L,131836355L,549380672L,2289347792L,9540065618L,39754914509L,165664757540L,690350003398L,2876792156808L,11988025615109L,49955906989734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264417Inst : IEnumerable<long>
{
public static readonly long[] Value=A264417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264417.Bytes);
public long this[int i]=>Value[i];

public static A264417Inst Instance=new A264417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264418
{
public static readonly long[] Value={ 0L,12L,96L,529L,4843L,44264L,352713L,2840274L,23795758L,197390196L,1619132059L,13345740560L,110326933611L,910298134238L,7505842151352L,61932503872184L,511075503235669L,4216464623838747L,34786555887673881L,287016646384919794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264418Inst : IEnumerable<long>
{
public static readonly long[] Value=A264418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264418.Bytes);
public long this[int i]=>Value[i];

public static A264418Inst Instance=new A264418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264419
{
public static readonly long[] Value={ 0L,37L,499L,7311L,137584L,2486429L,40217261L,681146169L,11846231201L,202674077729L,3440768212887L,58817070295375L,1006675030473401L,17189924020400699L,293506491114760927L,5015242699900223807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264419Inst : IEnumerable<long>
{
public static readonly long[] Value=A264419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264419.Bytes);
public long this[int i]=>Value[i];

public static A264419Inst Instance=new A264419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264420
{
public static readonly BigInteger[] Value={ 4L,119L,2681L,101862L,4023076L,147984724L,5498758183L,201733617932L,7423226389478L,272586759114218L,10017280306174267L,368272005900678107L,13531455789624669204UL,BigInteger.Parse("497163630139105690695"),BigInteger.Parse("18268217310170065817424") };
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
public class A264420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264420Inst Instance=new A264420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264421
{
public static readonly long[] Value={ 0L,385L,15088L,1103666L,95946259L,7577203142L,577598946184L,44052069039720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264421Inst : IEnumerable<long>
{
public static readonly long[] Value=A264421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264421.Bytes);
public long this[int i]=>Value[i];

public static A264421Inst Instance=new A264421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264422
{
public static readonly long[] Value={ 0L,2L,1L,0L,3L,1L,0L,12L,20L,1L,4L,37L,96L,85L,1L,0L,119L,499L,529L,351L,3L,0L,385L,2681L,7311L,4843L,1462L,3L,8L,1252L,15088L,101862L,137584L,44264L,6021L,4L,0L,4061L,86469L,1103666L,4023076L,2486429L,352713L,25188L,6L,0L,13166L,479787L,13805196L,95946259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264422Inst : IEnumerable<long>
{
public static readonly long[] Value=A264422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264422.Bytes);
public long this[int i]=>Value[i];

public static A264422Inst Instance=new A264422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264423
{
public static readonly long[] Value={ 1L,3L,12L,37L,119L,385L,1252L,4061L,13166L,42687L,138419L,448847L,1455443L,4719435L,15303308L,49622768L,160907641L,521761825L,1691873630L,5486097814L,17789312907L,57683924784L,187046863084L,606521298870L,1966716147754L,6377306803896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264423Inst : IEnumerable<long>
{
public static readonly long[] Value=A264423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264423.Bytes);
public long this[int i]=>Value[i];

public static A264423Inst Instance=new A264423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264424
{
public static readonly long[] Value={ 1L,20L,96L,499L,2681L,15088L,86469L,479787L,2666733L,14940857L,83531649L,466766772L,2608467230L,14576309209L,81469725947L,455319456892L,2544569549821L,14220929241086L,79476850018075L,444172492025104L,2482352553030166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264424Inst : IEnumerable<long>
{
public static readonly long[] Value=A264424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264424.Bytes);
public long this[int i]=>Value[i];

public static A264424Inst Instance=new A264424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264425
{
public static readonly long[] Value={ 1L,85L,529L,7311L,101862L,1103666L,13805196L,169633649L,2021225139L,24679272503L,299292066678L,3620259337857L,43944809107738L,532640833103943L,6455594272133455L,78276807986884628L,948887621876714100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264425Inst : IEnumerable<long>
{
public static readonly long[] Value=A264425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264425.Bytes);
public long this[int i]=>Value[i];

public static A264425Inst Instance=new A264425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264426
{
public static readonly BigInteger[] Value={ 1L,351L,4843L,137584L,4023076L,95946259L,2486418295L,64826165535L,1652429011909L,42508454066939L,1094317644738425L,28099100591929747L,722286772733295541L,BigInteger.Parse("18567899507526341784"),BigInteger.Parse("477183716427656944275"),BigInteger.Parse("12264894190427166009575") };
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
public class A264426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264426Inst Instance=new A264426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264427
{
public static readonly long[] Value={ 3L,1462L,44264L,2486429L,147984724L,7577203142L,396849643846L,20924743041507L,1094394105909728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264427Inst : IEnumerable<long>
{
public static readonly long[] Value=A264427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264427.Bytes);
public long this[int i]=>Value[i];

public static A264427Inst Instance=new A264427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264428
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,3L,1L,0L,5L,11L,6L,1L,0L,15L,45L,35L,10L,1L,0L,52L,205L,210L,85L,15L,1L,0L,203L,1029L,1330L,700L,175L,21L,1L,0L,877L,5635L,8946L,5845L,1890L,322L,28L,1L,0L,4140L,33387L,63917L,50358L,20055L,4410L,546L,36L,1L,0L,21147L,212535L,484140L,450905L,214515L,57855L,9240L,870L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264428Inst : IEnumerable<long>
{
public static readonly long[] Value=A264428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264428.Bytes);
public long this[int i]=>Value[i];

public static A264428Inst Instance=new A264428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264429
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-3L,1L,0L,0L,7L,-6L,1L,0L,-5L,-10L,25L,-10L,1L,0L,18L,-20L,-75L,65L,-15L,1L,0L,-7L,231L,70L,-315L,140L,-21L,1L,0L,-338L,-840L,1064L,945L,-980L,266L,-28L,1L,0L,2215L,-1278L,-8918L,1512L,4935L,-2520L,462L,-36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264429Inst : IEnumerable<long>
{
public static readonly long[] Value=A264429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264429.Bytes);
public long this[int i]=>Value[i];

public static A264429Inst Instance=new A264429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264430
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,3L,1L,0L,6L,11L,6L,1L,0L,23L,50L,35L,10L,1L,0L,106L,268L,225L,85L,15L,1L,0L,568L,1645L,1603L,735L,175L,21L,1L,0L,3459L,11348L,12572L,6713L,1960L,322L,28L,1L,0L,23544L,86775L,107738L,65352L,22323L,4536L,546L,36L,1L,0L,176850L,727629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264430Inst : IEnumerable<long>
{
public static readonly long[] Value=A264430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264430.Bytes);
public long this[int i]=>Value[i];

public static A264430Inst Instance=new A264430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264431
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-3L,1L,0L,-1L,7L,-6L,1L,0L,2L,-15L,25L,-10L,1L,0L,-8L,37L,-90L,65L,-15L,1L,0L,27L,-133L,322L,-350L,140L,-21L,1L,0L,-70L,587L,-1330L,1757L,-1050L,266L,-28L,1L,0L,265L,-2526L,6607L,-9114L,7077L,-2646L,462L,-36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264431Inst : IEnumerable<long>
{
public static readonly long[] Value=A264431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264431.Bytes);
public long this[int i]=>Value[i];

public static A264431Inst Instance=new A264431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264432
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,119L,700L,4748L,36403L,310851L,2922606L,29977587L,332929492L,3978258079L,50872884285L,692985674373L,10015172966221L,153021613683924L,2464031776132958L,41698912656882644L,739771703127828419L,13727160292457369098UL,BigInteger.Parse("265876635231121617716") };
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
public class A264432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264432Inst Instance=new A264432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264433
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,3L,1L,0L,6L,11L,6L,1L,0L,24L,50L,35L,10L,1L,0L,119L,274L,225L,85L,15L,1L,0L,700L,1757L,1624L,735L,175L,21L,1L,0L,4748L,12880L,13104L,6769L,1960L,322L,28L,1L,0L,36403L,106068L,117152L,67200L,22449L,4536L,546L,36L,1L,0L,310851L,968206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264433Inst : IEnumerable<long>
{
public static readonly long[] Value=A264433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264433.Bytes);
public long this[int i]=>Value[i];

public static A264433Inst Instance=new A264433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264434
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-3L,1L,0L,-1L,7L,-6L,1L,0L,1L,-15L,25L,-10L,1L,0L,0L,31L,-90L,65L,-15L,1L,0L,-7L,-56L,301L,-350L,140L,-21L,1L,0L,33L,35L,-938L,1701L,-1050L,266L,-28L,1L,0L,-102L,423L,2485L,-7686L,6951L,-2646L,462L,-36L,1L,0L,240L,-3219L,-3450L,31885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264434Inst : IEnumerable<long>
{
public static readonly long[] Value=A264434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264434.Bytes);
public long this[int i]=>Value[i];

public static A264434Inst Instance=new A264434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264435
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,0L,-3L,1L,0L,1L,3L,-6L,1L,0L,1L,5L,15L,-10L,1L,0L,-2L,-9L,0L,45L,-15L,1L,0L,-9L,-35L,-84L,-70L,105L,-21L,1L,0L,-9L,19L,-14L,-259L,-350L,210L,-28L,1L,0L,50L,369L,873L,966L,-189L,-1134L,378L,-36L,1L,0L,267L,611L,1260L,3645L,5565L,1827L,-2940L,630L,-45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264435Inst : IEnumerable<long>
{
public static readonly long[] Value=A264435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264435.Bytes);
public long this[int i]=>Value[i];

public static A264435Inst Instance=new A264435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264436
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,3L,1L,0L,14L,15L,6L,1L,0L,89L,100L,45L,10L,1L,0L,716L,834L,405L,105L,15L,1L,0L,6967L,8351L,4284L,1225L,210L,21L,1L,0L,79524L,97596L,52220L,16009L,3080L,378L,28L,1L,0L,1041541L,1303956L,721674L,233268L,48699L,6804L,630L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264436Inst : IEnumerable<long>
{
public static readonly long[] Value=A264436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264436.Bytes);
public long this[int i]=>Value[i];

public static A264436Inst Instance=new A264436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264437
{
public static readonly BigInteger[] Value={ 1L,-1L,2L,0L,-56L,0L,15840L,0L,-17297280L,0L,50791104000L,0L,-327856732600320L,0L,4080179409546240000L,0L,BigInteger.Parse("-89192941330901151744000"),0L,BigInteger.Parse("3193957788339335451033600000"),0L,BigInteger.Parse("-177450861021098776794591068160000"),0L,BigInteger.Parse("14644425624059165645548485417369600000"),0L };
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
public class A264437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264437Inst Instance=new A264437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264438
{
public static readonly long[] Value={ 2L,45L,4L,235L,118521L,6L,156L,665L,8L,410581L,1431L,1464L,10L,217061235L,2629L,20578212225L,12L,143681684300109L,88L,4355L,53946009001L,14L,4149148875801021L,244L,6705L,108L,30839304871L,16L,103789115L,78990793279586649L,9775L,2068L,138751721731L,18L,7987764L,2984191388685L,13661L,5246209297401255L,406200L,5142295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264438Inst : IEnumerable<long>
{
public static readonly long[] Value=A264438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264438.Bytes);
public long this[int i]=>Value[i];

public static A264438Inst Instance=new A264438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264439
{
public static readonly long[] Value={ 1L,17L,1L,49L,21287L,1L,23L,97L,1L,48727L,161L,151L,1L,21387679L,241L,1826021057L,1L,11692649642023L,7L,337L,3903396217L,1L,294125365483681L,17L,449L,7L,1994828801L,1L,6399911L,4798348971487087L,577L,119L,7867888313L,1L,437071L,161131189369L,721L,273849896195263L,20783L,262759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264439Inst : IEnumerable<long>
{
public static readonly long[] Value=A264439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264439.Bytes);
public long this[int i]=>Value[i];

public static A264439Inst Instance=new A264439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264440
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,2L,3L,1L,4L,1L,4L,2L,2L,1L,6L,1L,2L,2L,4L,1L,6L,1L,4L,2L,2L,2L,7L,1L,2L,2L,6L,1L,6L,1L,4L,4L,2L,1L,8L,1L,4L,2L,4L,1L,6L,2L,6L,2L,2L,1L,10L,1L,2L,4L,5L,2L,6L,1L,4L,2L,6L,1L,10L,1L,2L,4L,4L,2L,6L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264440Inst : IEnumerable<long>
{
public static readonly long[] Value=A264440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264440.Bytes);
public long this[int i]=>Value[i];

public static A264440Inst Instance=new A264440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264441
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,5L,4L,4L,1L,7L,1L,7L,6L,9L,1L,9L,3L,11L,6L,11L,1L,15L,1L,11L,10L,15L,8L,16L,1L,17L,12L,17L,1L,23L,1L,19L,16L,21L,1L,23L,5L,25L,16L,23L,1L,29L,12L,25L,18L,27L,1L,33L,1L,29L,22L,26L,14L,39L,1L,31L,22L,39L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264441Inst : IEnumerable<long>
{
public static readonly long[] Value=A264441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264441.Bytes);
public long this[int i]=>Value[i];

public static A264441Inst Instance=new A264441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264442
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264442Inst : IEnumerable<long>
{
public static readonly long[] Value=A264442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264442.Bytes);
public long this[int i]=>Value[i];

public static A264442Inst Instance=new A264442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264443
{
public static readonly long[] Value={ 0L,11L,28L,52L,84L,125L,176L,238L,312L,399L,500L,616L,748L,897L,1064L,1250L,1456L,1683L,1932L,2204L,2500L,2821L,3168L,3542L,3944L,4375L,4836L,5328L,5852L,6409L,7000L,7626L,8288L,8987L,9724L,10500L,11316L,12173L,13072L,14014L,15000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264443Inst : IEnumerable<long>
{
public static readonly long[] Value=A264443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264443.Bytes);
public long this[int i]=>Value[i];

public static A264443Inst Instance=new A264443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264444
{
public static readonly long[] Value={ 0L,20L,48L,85L,132L,190L,260L,343L,440L,552L,680L,825L,988L,1170L,1372L,1595L,1840L,2108L,2400L,2717L,3060L,3430L,3828L,4255L,4712L,5200L,5720L,6273L,6860L,7482L,8140L,8835L,9568L,10340L,11152L,12005L,12900L,13838L,14820L,15847L,16920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264444Inst : IEnumerable<long>
{
public static readonly long[] Value=A264444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264444.Bytes);
public long this[int i]=>Value[i];

public static A264444Inst Instance=new A264444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264445
{
public static readonly long[] Value={ 0L,46L,104L,175L,260L,360L,476L,609L,760L,930L,1120L,1331L,1564L,1820L,2100L,2405L,2736L,3094L,3480L,3895L,4340L,4816L,5324L,5865L,6440L,7050L,7696L,8379L,9100L,9860L,10660L,11501L,12384L,13310L,14280L,15295L,16356L,17464L,18620L,19825L,21080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264445Inst : IEnumerable<long>
{
public static readonly long[] Value=A264445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264445.Bytes);
public long this[int i]=>Value[i];

public static A264445Inst Instance=new A264445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264446
{
public static readonly long[] Value={ 0L,44L,119L,234L,399L,625L,924L,1309L,1794L,2394L,3125L,4004L,5049L,6279L,7714L,9375L,11284L,13464L,15939L,18734L,21875L,25389L,29304L,33649L,38454L,43750L,49569L,55944L,62909L,70499L,78750L,87699L,97384L,107844L,119119L,131250L,144279L,158249L,173204L,189189L,206250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264446Inst : IEnumerable<long>
{
public static readonly long[] Value=A264446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264446.Bytes);
public long this[int i]=>Value[i];

public static A264446Inst Instance=new A264446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264447
{
public static readonly long[] Value={ 0L,110L,276L,510L,825L,1235L,1755L,2401L,3190L,4140L,5270L,6600L,8151L,9945L,12005L,14355L,17020L,20026L,23400L,27170L,31365L,36015L,41151L,46805L,53010L,59800L,67210L,75276L,84035L,93525L,103785L,114855L,126776L,139590L,153340L,168070L,183825L,200651L,218595L,237705L,258030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264447Inst : IEnumerable<long>
{
public static readonly long[] Value=A264447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264447.Bytes);
public long this[int i]=>Value[i];

public static A264447Inst Instance=new A264447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264448
{
public static readonly long[] Value={ 0L,391L,910L,1575L,2405L,3420L,4641L,6090L,7790L,9765L,12040L,14641L,17595L,20930L,24675L,28860L,33516L,38675L,44370L,50635L,57505L,65016L,73205L,82110L,91770L,102225L,113516L,125685L,138775L,152830L,167895L,184016L,201240L,219615L,239190L,260015L,282141L,305620L,330505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264448Inst : IEnumerable<long>
{
public static readonly long[] Value=A264448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264448.Bytes);
public long this[int i]=>Value[i];

public static A264448Inst Instance=new A264448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264449
{
public static readonly long[] Value={ 0L,638L,1656L,3162L,5280L,8151L,11934L,16807L,22968L,30636L,40052L,51480L,65208L,81549L,100842L,123453L,149776L,180234L,215280L,255398L,301104L,352947L,411510L,477411L,551304L,633880L,725868L,828036L,941192L,1066185L,1203906L,1355289L,1521312L,1702998L,1901416L,2117682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264449Inst : IEnumerable<long>
{
public static readonly long[] Value=A264449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264449.Bytes);
public long this[int i]=>Value[i];

public static A264449Inst Instance=new A264449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264450
{
public static readonly long[] Value={ 0L,3519L,8372L,14805L,23088L,33516L,46410L,62118L,81016L,103509L,130032L,161051L,197064L,238602L,286230L,340548L,402192L,471835L,550188L,638001L,736064L,845208L,966306L,1100274L,1248072L,1410705L,1589224L,1784727L,1998360L,2231318L,2484846L,2760240L,3058848L,3382071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264450Inst : IEnumerable<long>
{
public static readonly long[] Value=A264450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264450.Bytes);
public long this[int i]=>Value[i];

public static A264450Inst Instance=new A264450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264451
{
public static readonly ulong[] Value={ 1L,13L,112L,843L,6089L,43887L,321357L,2411686L,18631631L,148490575L,1221894598L,10382648734L,91073271181L,824221683639L,7690752545310L,73932347642395L,731636916804531L,7447376286108705L,77913394499688645L,837113596053971008L,9229808681562243113UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264451Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A264451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264451.Bytes);
public ulong this[int i]=>Value[i];

public static A264451Inst Instance=new A264451Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264452
{
public static readonly BigInteger[] Value={ 1L,12L,103L,811L,6273L,48806L,386041L,3122069L,25900188L,220791812L,1935811756L,17461471292L,162038542377L,1546528485770L,15174625184321L,152994813139537L,1584120732683571L,16834244135840106L,183496533502593453L,2050337555698723711L,BigInteger.Parse("23470542944212951050") };
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
public class A264452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264452Inst Instance=new A264452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264453
{
public static readonly BigInteger[] Value={ 2L,41L,492L,4851L,44291L,394154L,3502159L,31450283L,287335089L,2680535274L,25586566853L,250169461829L,2506738712869L,25745302689807L,270994937686871L,2922760610595872L,32288420619988347L,365214362676429903L,4227719744153328064L,BigInteger.Parse("50063651356822568135") };
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
public class A264453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264453Inst Instance=new A264453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264454
{
public static readonly BigInteger[] Value={ 1L,24L,337L,3798L,38795L,379611L,3659389L,35291284L,343556139L,3394140548L,34141603945L,350367304972L,3672490264985L,39344027488644L,430933818393770L,4825995839698429L,55254816421477438L,646659542446548212L,7733703865241542989L,BigInteger.Parse("94486241595833611364") };
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
public class A264454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264454Inst Instance=new A264454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264455
{
public static readonly BigInteger[] Value={ 1L,17L,238L,2956L,33343L,355182L,3681762L,37839385L,389940538L,4056942189L,42796503464L,458995025669L,5013561835833L,55832699192796L,634322118799677L,7354538207075076L,87032355679553323L,1051183375285792257L,12956782873283747998UL,BigInteger.Parse("162950022525866642259") };
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
public class A264455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264455Inst Instance=new A264455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264456
{
public static readonly BigInteger[] Value={ 5L,122L,1960L,25922L,308912L,3488684L,38438284L,420224213L,4604712333L,50891058160L,569534211553L,6470640729869L,74755213239764L,879145839345147L,10531462769901577L,128554339635477023L,1599307831822386125L,BigInteger.Parse("20278763016658278490"),BigInteger.Parse("262052769447634167173") };
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
public class A264456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264456Inst Instance=new A264456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264457
{
public static readonly BigInteger[] Value={ 2L,68L,1303L,19637L,259676L,3187742L,37608672L,435669452L,5021292420L,58054439247L,676861345712L,7985430177542L,95546837440564L,1161199181184289L,14348225375153127L,180370057811385955L,2307651822107975903L,BigInteger.Parse("30054039071752083133"),BigInteger.Parse("398467881283163344126") };
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
public class A264457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264457Inst Instance=new A264457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264458
{
public static readonly BigInteger[] Value={ 1L,39L,859L,14531L,211877L,2822490L,35642278L,437300537L,5296987965L,63998700926L,776411239316L,9499309138937L,117556007163447L,1474385436584002L,18766076242349261L,242618101536221884L,3187985361564230544L,BigInteger.Parse("42590476320847716703"),BigInteger.Parse("578630818810648513246") };
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
public class A264458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264458Inst Instance=new A264458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264459
{
public static readonly BigInteger[] Value={ 1L,28L,594L,10735L,169753L,2438911L,32897588L,427124523L,5433554133L,68546679923L,864462182024L,10957001813778L,140087846414020L,1811142056680743L,23718822943004668L,315018653189118579L,4246519279200474842L,BigInteger.Parse("58132401024629625298"),BigInteger.Parse("808428792791995327013") };
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
public class A264459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264459Inst Instance=new A264459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264460
{
public static readonly long[] Value={ 1L,6L,32L,171L,944L,5444L,32919L,208816L,1388240L,9657929L,70187054L,531857288L,4194927585L,34379859346L,292303350268L,2574284790795L,23450837821836L,220681535036288L,2142618638738279L,21438586249394500L,220827871704427308L,2339281577294955745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264460Inst : IEnumerable<long>
{
public static readonly long[] Value=A264460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264460.Bytes);
public long this[int i]=>Value[i];

public static A264460Inst Instance=new A264460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264461
{
public static readonly long[] Value={ 3L,23L,152L,984L,6460L,43626L,304939L,2211467L,16649780L,130097338L,1054226016L,8850736900L,76901730751L,690749091147L,6406953787268L,61300205459232L,604367205789092L,6133919028981542L,64027105979768111L,686736004045762143L,7562191796264603160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264461Inst : IEnumerable<long>
{
public static readonly long[] Value=A264461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264461.Bytes);
public long this[int i]=>Value[i];

public static A264461Inst Instance=new A264461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264462
{
public static readonly BigInteger[] Value={ 10L,98L,791L,6082L,46508L,360376L,2855580L,23244370L,194796665L,1682243510L,14973751272L,137345968648L,1297620307926L,12620234271634L,126265094967383L,1298634572382618L,13720327052477584L,148800093788609512L,1655374072150829472L,BigInteger.Parse("18877499531817214482") };
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
public class A264462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264462Inst Instance=new A264462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264463
{
public static readonly BigInteger[] Value={ 3L,62L,624L,5513L,46880L,396545L,3388893L,29497132L,262619041L,2397130075L,22458202716L,216063700398L,2134707078315L,21655074753266L,225471830153938L,2408463527492433L,26380434283682048L,296130434080550183L,3404883834560222589L,BigInteger.Parse("40077202708717399396") };
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
public class A264463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264463Inst Instance=new A264463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264464
{
public static readonly BigInteger[] Value={ 22L,392L,4302L,41979L,393476L,3652779L,34099448L,322746351L,3111556310L,30637025849L,308542096284L,3180677263083L,33574281993047L,362907367462521L,4016295885663247L,45496983534864142L,527373693673894161L,6252643277063017082L,BigInteger.Parse("75794122449729562363") };
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
public class A264464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264464Inst Instance=new A264464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264465
{
public static readonly BigInteger[] Value={ 11L,240L,3328L,36774L,377610L,3775281L,37545239L,375714151L,3808210872L,39250117725L,412320359485L,4420852570619L,48416817503118L,541846406216437L,6197311080340307L,72436698579083259L,865110836456018947L,10554489471399030408UL,BigInteger.Parse("131500190867301682844") };
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
public class A264465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264465Inst Instance=new A264465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264466
{
public static readonly BigInteger[] Value={ 1L,111L,2141L,29066L,336137L,3663730L,39037155L,414003430L,4414401391L,47606401475L,521147444815L,5804080039932L,65854473968668L,761861585833395L,8990938684395442L,108258685340444377L,1330041483208589743L,16671576238569453924UL,BigInteger.Parse("213169773223813966680") };
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
public class A264466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264466Inst Instance=new A264466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264467
{
public static readonly BigInteger[] Value={ 55L,1393L,22180L,290341L,3443222L,39212955L,439762906L,4922646194L,55440198721L,631281758915L,7290146619344L,85550258610256L,1021466597564828L,12418915430929303L,153814790549535203L,1941191617618161308L,BigInteger.Parse("24964754218212162461"),BigInteger.Parse("327159226788279647296") };
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
public class A264467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264467Inst Instance=new A264467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264468
{
public static readonly BigInteger[] Value={ 18L,780L,15627L,235045L,3086010L,37816568L,449766437L,5291113080L,62237008779L,736806459069L,8816027319934L,106900514193980L,1315953951437664L,16464756848575162L,209528329365176670L,2713295547732215190L,BigInteger.Parse("35762229764646245816"),BigInteger.Parse("479809424452611001696") };
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
public class A264468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264468Inst Instance=new A264468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264469
{
public static readonly BigInteger[] Value={ 4L,432L,10723L,185030L,2679741L,35436222L,447105877L,5525656829L,67836294722L,834260210092L,10332749157300L,129333951912536L,1639800629344515L,21092071947142268L,275512690552878512L,3657197040905519063L,BigInteger.Parse("49353853545913899116"),BigInteger.Parse("677272710732166102115") };
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
public class A264469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264469Inst Instance=new A264469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264470
{
public static readonly long[] Value={ 0L,2L,6L,120L,3540L,310748L,74367790L,44706530288L,66581992940380L,252580385620049120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264470Inst : IEnumerable<long>
{
public static readonly long[] Value=A264470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264470.Bytes);
public long this[int i]=>Value[i];

public static A264470Inst Instance=new A264470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264471
{
public static readonly long[] Value={ 0L,4L,6L,16L,49L,124L,384L,1041L,2868L,8189L,22760L,63910L,179095L,500979L,1405340L,3935526L,11024880L,30892270L,86537090L,242454683L,679254490L,1902958308L,5331384633L,14936238820L,41845207329L,117233159460L,328438385380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264471Inst : IEnumerable<long>
{
public static readonly long[] Value=A264471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264471.Bytes);
public long this[int i]=>Value[i];

public static A264471Inst Instance=new A264471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264472
{
public static readonly long[] Value={ 0L,8L,16L,120L,456L,2232L,10116L,45792L,212112L,960336L,4418388L,20134008L,92208780L,421315344L,1926779076L,8809428456L,40277366640L,184164908040L,842016117672L,3849965354232L,17602701446772L,80483933441520L,367989633268848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264472Inst : IEnumerable<long>
{
public static readonly long[] Value=A264472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264472.Bytes);
public long this[int i]=>Value[i];

public static A264472Inst Instance=new A264472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264473
{
public static readonly long[] Value={ 1L,17L,57L,456L,3540L,24773L,174927L,1262270L,8905776L,63373156L,449506816L,3184860720L,22596207841L,160137303788L,1135302681211L,8048142435691L,57049038241053L,404414221946254L,2866733296182372L,20321383697508618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264473Inst : IEnumerable<long>
{
public static readonly long[] Value=A264473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264473.Bytes);
public long this[int i]=>Value[i];

public static A264473Inst Instance=new A264473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264474
{
public static readonly long[] Value={ 0L,36L,160L,2272L,28489L,310748L,3842048L,43644384L,505769648L,5849013488L,67135006848L,774054696448L,8896767499776L,102334987567872L,1176757087435008L,13529311221840896L,155560070455705600L,1788454272171147264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264474Inst : IEnumerable<long>
{
public static readonly long[] Value=A264474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264474.Bytes);
public long this[int i]=>Value[i];

public static A264474Inst Instance=new A264474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264475
{
public static readonly ulong[] Value={ 0L,76L,484L,11044L,215607L,4039259L,74367790L,1358980008L,25131223920L,454913826610L,8308148502158L,150817534124764L,2737572458162063L,49698482940927931L,901239835437298103L,16348456871339244625UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264475Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A264475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264475.Bytes);
public ulong this[int i]=>Value[i];

public static A264475Inst Instance=new A264475Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264476
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,0L,0L,4L,4L,1L,1L,8L,6L,8L,1L,0L,17L,16L,16L,16L,1L,0L,36L,57L,120L,49L,32L,2L,1L,76L,160L,456L,456L,124L,64L,2L,0L,160L,484L,2272L,3540L,2232L,384L,128L,3L,0L,337L,1449L,11044L,28489L,24773L,10116L,1041L,256L,4L,1L,710L,4250L,49200L,215607L,310748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264476Inst : IEnumerable<long>
{
public static readonly long[] Value=A264476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264476.Bytes);
public long this[int i]=>Value[i];

public static A264476Inst Instance=new A264476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264477
{
public static readonly long[] Value={ 0L,4L,6L,16L,57L,160L,484L,1449L,4250L,12736L,37980L,112684L,335528L,998929L,2971856L,8844112L,26318889L,78319204L,233069764L,693574740L,2063954658L,6142018600L,18277651737L,54391278960L,161859683044L,481668191001L,1433366397054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264477Inst : IEnumerable<long>
{
public static readonly long[] Value=A264477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264477.Bytes);
public long this[int i]=>Value[i];

public static A264477Inst Instance=new A264477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264478
{
public static readonly long[] Value={ 1L,8L,16L,120L,456L,2272L,11044L,49200L,236196L,1113296L,5157772L,24352896L,114256032L,534574312L,2511482164L,11778946872L,55224573264L,259130295272L,1215413555584L,5700599522328L,26741489475588L,125432405841016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264478Inst : IEnumerable<long>
{
public static readonly long[] Value=A264478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264478.Bytes);
public long this[int i]=>Value[i];

public static A264478Inst Instance=new A264478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264479
{
public static readonly long[] Value={ 1L,16L,49L,456L,3540L,28489L,215607L,1711113L,13390929L,103239049L,808268548L,6305839174L,49028148726L,382311026201L,2980060222502L,23211745902165L,180884486207033L,1409598089228359L,10983040186007341L,85581889782163761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264479Inst : IEnumerable<long>
{
public static readonly long[] Value=A264479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264479.Bytes);
public long this[int i]=>Value[i];

public static A264479Inst Instance=new A264479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264480
{
public static readonly long[] Value={ 1L,32L,124L,2232L,24773L,310748L,4039259L,50217832L,620351086L,7791932046L,96985215280L,1205278291192L,15033721660535L,187188468194402L,2330142431854154L,29024775202912332L,361434709901725109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264480Inst : IEnumerable<long>
{
public static readonly long[] Value=A264480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264480.Bytes);
public long this[int i]=>Value[i];

public static A264480Inst Instance=new A264480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264481
{
public static readonly BigInteger[] Value={ 2L,64L,384L,10116L,174927L,3842048L,74367790L,1462247321L,29509300516L,577847245296L,11385134340072L,225727859320572L,4442739834521648L,87589711996716421L,1729226298092553854L,BigInteger.Parse("34086490092213796815") };
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
public class A264481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A264481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A264481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A264481Inst Instance=new A264481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}