using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112141
{
public static readonly BigInteger[] Value={ 4L,24L,216L,2160L,30240L,453600L,9525600L,209563200L,5239080000L,136216080000L,4495130640000L,152834441760000L,5349205461600000L,203269807540800000L,7927522494091200000L,BigInteger.Parse("364666034728195200000"),BigInteger.Parse("17868635701681564800000"),BigInteger.Parse("911300420785759804800000") };
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
public class A112141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112141Inst Instance=new A112141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112142
{
public static readonly long[] Value={ 1L,12L,66L,232L,639L,1596L,3774L,8328L,17283L,34520L,66882L,125568L,229244L,409236L,716412L,1231048L,2079237L,3459264L,5677832L,9200232L,14729592L,23325752L,36567222L,56778888L,87369483L,133315692L,201825420L,303257512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112142Inst : IEnumerable<long>
{
public static readonly long[] Value=A112142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112142.Bytes);
public long this[int i]=>Value[i];

public static A112142Inst Instance=new A112142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112143
{
public static readonly long[] Value={ 1L,-4L,2L,8L,-1L,-20L,-2L,40L,3L,-72L,2L,128L,-4L,-220L,-4L,360L,5L,-576L,8L,904L,-8L,-1384L,-10L,2088L,11L,-3108L,12L,4552L,-15L,-6592L,-18L,9448L,22L,-13392L,26L,18816L,-29L,-26216L,-34L,36224L,38L,-49700L,42L,67728L,-51L,-91688L,-56L,123392L,66L,-165128L,78L,219784L,-85L,-291072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112143Inst : IEnumerable<long>
{
public static readonly long[] Value=A112143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112143.Bytes);
public long this[int i]=>Value[i];

public static A112143Inst Instance=new A112143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112144
{
public static readonly long[] Value={ 1L,-20L,-62L,-216L,-641L,-1636L,-3778L,-8248L,-17277L,-34664L,-66878L,-125312L,-229252L,-409676L,-716420L,-1230328L,-2079227L,-3460416L,-5677816L,-9198424L,-14729608L,-23328520L,-36567242L,-56774712L,-87369461L,-133321908L,-201825396L,-303248408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112144Inst : IEnumerable<long>
{
public static readonly long[] Value=A112144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112144.Bytes);
public long this[int i]=>Value[i];

public static A112144Inst Instance=new A112144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112145
{
public static readonly long[] Value={ 1L,-8L,-6L,-48L,15L,-168L,-26L,-496L,51L,-1296L,-102L,-3072L,172L,-6840L,-276L,-14448L,453L,-29184L,-728L,-56880L,1128L,-107472L,-1698L,-197616L,2539L,-354888L,-3780L,-624048L,5505L,-1076736L,-7882L,-1826416L,11238L,-3050400L,-15918L,-5022720L,22259L,-8163152L,-30810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112145Inst : IEnumerable<long>
{
public static readonly long[] Value=A112145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112145.Bytes);
public long this[int i]=>Value[i];

public static A112145Inst Instance=new A112145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112146
{
public static readonly long[] Value={ 1L,0L,9L,-4L,0L,36L,2L,0L,126L,12L,0L,324L,-21L,0L,801L,4L,0L,1764L,36L,0L,3744L,-68L,0L,7452L,21L,0L,14400L,112L,0L,26748L,-184L,0L,48510L,44L,0L,85536L,275L,0L,147924L,-456L,0L,250452L,112L,0L,417276L,644L,0L,683640L,-1019L,0L,1104948L,240L,0L,1761552L,1370L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112146Inst : IEnumerable<long>
{
public static readonly long[] Value=A112146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112146.Bytes);
public long this[int i]=>Value[i];

public static A112146Inst Instance=new A112146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112147
{
public static readonly long[] Value={ 1L,0L,15L,32L,87L,192L,343L,672L,1290L,2176L,3705L,6336L,10214L,16320L,25905L,39936L,61227L,92928L,138160L,204576L,300756L,435328L,626727L,897408L,1271205L,1790592L,2508783L,3487424L,4824825L,6641664L,9083400L,12371904L,16778784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112147Inst : IEnumerable<long>
{
public static readonly long[] Value=A112147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112147.Bytes);
public long this[int i]=>Value[i];

public static A112147Inst Instance=new A112147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112148
{
public static readonly long[] Value={ 1L,0L,6L,-4L,-3L,12L,-8L,-12L,30L,-20L,-30L,72L,-46L,-60L,156L,-96L,-117L,300L,-188L,-228L,552L,-344L,-420L,1008L,-603L,-732L,1770L,-1048L,-1245L,2976L,-1776L,-2088L,4908L,-2900L,-3420L,7992L,-4658L,-5460L,12756L,-7408L,-8583L,19944L,-11564L,-13344L,30756L,-17744L,-20448L,46944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112148Inst : IEnumerable<long>
{
public static readonly long[] Value=A112148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112148.Bytes);
public long this[int i]=>Value[i];

public static A112148Inst Instance=new A112148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112149
{
public static readonly long[] Value={ 1L,-4L,0L,-4L,-16L,0L,6L,-40L,0L,-8L,-96L,0L,17L,-204L,0L,-28L,-400L,0L,38L,-760L,0L,-56L,-1376L,0L,84L,-2404L,0L,-124L,-4096L,0L,172L,-6808L,0L,-232L,-11072L,0L,325L,-17688L,0L,-448L,-27792L,0L,594L,-43008L,0L,-784L,-65696L,0L,1049L,-99128L,0L,-1388L,-147888L,0L,1796L,-218408L,0L,-2320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112149Inst : IEnumerable<long>
{
public static readonly long[] Value=A112149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112149.Bytes);
public long this[int i]=>Value[i];

public static A112149Inst Instance=new A112149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112150
{
public static readonly long[] Value={ 1L,6L,15L,26L,51L,102L,172L,276L,453L,728L,1128L,1698L,2539L,3780L,5505L,7882L,11238L,15918L,22259L,30810L,42438L,58110L,78909L,106392L,142770L,190698L,253179L,334266L,439581L,575784L,750613L,974316L,1260336L,1624702L,2086530L,2670162L,3406695L,4333590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112150Inst : IEnumerable<long>
{
public static readonly long[] Value=A112150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112150.Bytes);
public long this[int i]=>Value[i];

public static A112150Inst Instance=new A112150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112151
{
public static readonly long[] Value={ 1L,4L,-2L,8L,-1L,20L,2L,40L,3L,72L,-2L,128L,-4L,220L,4L,360L,5L,576L,-8L,904L,-8L,1384L,10L,2088L,11L,3108L,-12L,4552L,-15L,6592L,18L,9448L,22L,13392L,-26L,18816L,-29L,26216L,34L,36224L,38L,49700L,-42L,67728L,-51L,91688L,56L,123392L,66L,165128L,-78L,219784L,-85L,291072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112151Inst : IEnumerable<long>
{
public static readonly long[] Value=A112151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112151.Bytes);
public long this[int i]=>Value[i];

public static A112151Inst Instance=new A112151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112152
{
public static readonly long[] Value={ 1L,-4L,-2L,-8L,-1L,-20L,2L,-40L,3L,-72L,-2L,-128L,-4L,-220L,4L,-360L,5L,-576L,-8L,-904L,-8L,-1384L,10L,-2088L,11L,-3108L,-12L,-4552L,-15L,-6592L,18L,-9448L,22L,-13392L,-26L,-18816L,-29L,-26216L,34L,-36224L,38L,-49700L,-42L,-67728L,-51L,-91688L,56L,-123392L,66L,-165128L,-78L,-219784L,-85L,-291072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112152Inst : IEnumerable<long>
{
public static readonly long[] Value=A112152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112152.Bytes);
public long this[int i]=>Value[i];

public static A112152Inst Instance=new A112152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112153
{
public static readonly long[] Value={ 1L,-2L,-2L,-4L,3L,-2L,-6L,-4L,7L,-12L,-10L,-16L,16L,-14L,-20L,-20L,29L,-40L,-40L,-52L,52L,-52L,-70L,-68L,91L,-114L,-116L,-148L,149L,-152L,-190L,-196L,242L,-296L,-306L,-368L,383L,-396L,-478L,-496L,590L,-698L,-730L,-856L,897L,-940L,-1096L,-1152L,1342L,-1548L,-1630L,-1876L,1975L,-2080L,-2390L,-2516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112153Inst : IEnumerable<long>
{
public static readonly long[] Value=A112153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112153.Bytes);
public long this[int i]=>Value[i];

public static A112153Inst Instance=new A112153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112154
{
public static readonly long[] Value={ 1L,2L,2L,-4L,3L,2L,6L,-4L,7L,12L,10L,-16L,16L,14L,20L,-20L,29L,40L,40L,-52L,52L,52L,70L,-68L,91L,114L,116L,-148L,149L,152L,190L,-196L,242L,296L,306L,-368L,383L,396L,478L,-496L,590L,698L,730L,-856L,897L,940L,1096L,-1152L,1342L,1548L,1630L,-1876L,1975L,2080L,2390L,-2516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112154Inst : IEnumerable<long>
{
public static readonly long[] Value=A112154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112154.Bytes);
public long this[int i]=>Value[i];

public static A112154Inst Instance=new A112154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112155
{
public static readonly long[] Value={ 1L,-2L,2L,4L,3L,-2L,6L,4L,7L,-12L,10L,16L,16L,-14L,20L,20L,29L,-40L,40L,52L,52L,-52L,70L,68L,91L,-114L,116L,148L,149L,-152L,190L,196L,242L,-296L,306L,368L,383L,-396L,478L,496L,590L,-698L,730L,856L,897L,-940L,1096L,1152L,1342L,-1548L,1630L,1876L,1975L,-2080L,2390L,2516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112155Inst : IEnumerable<long>
{
public static readonly long[] Value=A112155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112155.Bytes);
public long this[int i]=>Value[i];

public static A112155Inst Instance=new A112155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112156
{
public static readonly long[] Value={ 1L,3L,0L,-2L,6L,0L,-1L,15L,0L,4L,24L,0L,-3L,48L,0L,0L,78L,0L,7L,132L,0L,-8L,204L,0L,-3L,324L,0L,14L,486L,0L,-14L,735L,0L,-4L,1068L,0L,26L,1563L,0L,-26L,2220L,0L,-7L,3159L,0L,44L,4404L,0L,-41L,6135L,0L,-10L,8412L,0L,73L,11508L,0L,-72L,15552L,0L,-20L,20964L,0L,118L,27978L,0L,-109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112156Inst : IEnumerable<long>
{
public static readonly long[] Value=A112156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112156.Bytes);
public long this[int i]=>Value[i];

public static A112156Inst Instance=new A112156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112157
{
public static readonly long[] Value={ 1L,-2L,-1L,4L,-3L,0L,7L,-8L,-3L,14L,-14L,-4L,26L,-26L,-7L,44L,-41L,-10L,73L,-72L,-20L,118L,-109L,-28L,182L,-174L,-47L,280L,-260L,-66L,419L,-392L,-102L,618L,-568L,-144L,898L,-832L,-216L,1292L,-1178L,-296L,1828L,-1676L,-429L,2568L,-2334L,-588L,3570L,-3248L,-822L,4920L,-4446L,-1114L,6722L,-6084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112157Inst : IEnumerable<long>
{
public static readonly long[] Value=A112157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112157.Bytes);
public long this[int i]=>Value[i];

public static A112157Inst Instance=new A112157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112158
{
public static readonly long[] Value={ 1L,0L,6L,8L,17L,32L,54L,80L,116L,192L,290L,408L,585L,832L,1192L,1648L,2237L,3072L,4156L,5576L,7414L,9824L,12964L,16896L,22002L,28544L,36794L,47184L,60185L,76736L,97388L,122864L,154615L,194048L,242904L,302800L,376271L,466720L,577176L,711840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112158Inst : IEnumerable<long>
{
public static readonly long[] Value=A112158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112158.Bytes);
public long this[int i]=>Value[i];

public static A112158Inst Instance=new A112158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112159
{
public static readonly long[] Value={ 1L,0L,1L,-2L,2L,2L,-1L,0L,-4L,2L,5L,-2L,0L,-8L,2L,8L,-3L,2L,-14L,6L,14L,-6L,4L,-24L,12L,24L,-11L,4L,-40L,16L,38L,-16L,5L,-62L,24L,60L,-24L,10L,-94L,40L,91L,-38L,18L,-144L,62L,136L,-57L,24L,-214L,88L,201L,-82L,30L,-308L,122L,288L,-117L,48L,-440L,180L,410L,-168L,74L,-624L,262L,578L,-238L,96L,-874L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112159Inst : IEnumerable<long>
{
public static readonly long[] Value=A112159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112159.Bytes);
public long this[int i]=>Value[i];

public static A112159Inst Instance=new A112159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112160
{
public static readonly long[] Value={ 1L,4L,6L,8L,17L,28L,38L,56L,84L,124L,172L,232L,325L,448L,594L,784L,1049L,1388L,1796L,2320L,3005L,3864L,4912L,6216L,7877L,9940L,12430L,15488L,19309L,23972L,29580L,36408L,44766L,54876L,66978L,81536L,99150L,120272L,145374L,175344L,211242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112160Inst : IEnumerable<long>
{
public static readonly long[] Value=A112160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112160.Bytes);
public long this[int i]=>Value[i];

public static A112160Inst Instance=new A112160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112161
{
public static readonly long[] Value={ 1L,-1L,-2L,2L,-1L,0L,5L,-3L,-4L,6L,-3L,-4L,12L,-8L,-10L,16L,-9L,-8L,29L,-17L,-22L,38L,-20L,-20L,61L,-36L,-44L,80L,-43L,-44L,121L,-70L,-82L,156L,-84L,-88L,229L,-131L,-154L,294L,-158L,-164L,417L,-234L,-268L,528L,-284L,-300L,730L,-408L,-462L,922L,-495L,-520L,1246L,-690L,-776L,1562L,-837L,-884L,2074L,-1143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112161Inst : IEnumerable<long>
{
public static readonly long[] Value=A112161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112161.Bytes);
public long this[int i]=>Value[i];

public static A112161Inst Instance=new A112161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112162
{
public static readonly long[] Value={ 1L,1L,7L,9L,10L,23L,38L,47L,75L,112L,148L,217L,293L,385L,553L,728L,928L,1272L,1670L,2111L,2765L,3566L,4504L,5784L,7300L,9123L,11592L,14458L,17838L,22342L,27668L,33884L,41843L,51344L,62548L,76515L,92989L,112514L,136687L,164961L,198190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112162Inst : IEnumerable<long>
{
public static readonly long[] Value=A112162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112162.Bytes);
public long this[int i]=>Value[i];

public static A112162Inst Instance=new A112162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112163
{
public static readonly long[] Value={ 1L,1L,3L,-3L,6L,3L,10L,-1L,15L,0L,24L,-3L,37L,9L,57L,-12L,84L,12L,118L,-9L,165L,6L,228L,-12L,316L,27L,432L,-42L,582L,42L,776L,-28L,1023L,24L,1344L,-45L,1757L,82L,2283L,-111L,2946L,111L,3774L,-91L,4812L,84L,6108L,-123L,7725L,208L,9732L,-279L,12204L,282L,15240L,-234L,18957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112163Inst : IEnumerable<long>
{
public static readonly long[] Value=A112163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112163.Bytes);
public long this[int i]=>Value[i];

public static A112163Inst Instance=new A112163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112164
{
public static readonly long[] Value={ 1L,3L,-1L,3L,-2L,9L,2L,9L,-1L,24L,0L,27L,5L,51L,-3L,60L,-4L,108L,6L,129L,-3L,210L,-4L,252L,12L,393L,-8L,474L,-10L,702L,16L,852L,-9L,1224L,-8L,1485L,29L,2070L,-17L,2511L,-22L,3429L,38L,4155L,-20L,5556L,-20L,6723L,61L,8856L,-36L,10695L,-44L,13878L,80L,16722L,-43L,21450L,-44L,25785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112164Inst : IEnumerable<long>
{
public static readonly long[] Value=A112164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112164.Bytes);
public long this[int i]=>Value[i];

public static A112164Inst Instance=new A112164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112165
{
public static readonly long[] Value={ 1L,1L,-1L,1L,2L,-1L,-2L,-1L,3L,0L,-4L,1L,5L,1L,-7L,0L,8L,0L,-10L,-1L,13L,-2L,-16L,0L,20L,3L,-24L,2L,30L,-2L,-36L,-4L,43L,0L,-52L,3L,61L,2L,-73L,1L,86L,-1L,-102L,-3L,120L,-4L,-140L,1L,165L,8L,-192L,5L,224L,-6L,-260L,-10L,301L,-2L,-348L,7L,401L,7L,-462L,2L,530L,-2L,-608L,-8L,696L,-10L,-796L,3L,909L,18L,-1035L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112165Inst : IEnumerable<long>
{
public static readonly long[] Value=A112165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112165.Bytes);
public long this[int i]=>Value[i];

public static A112165Inst Instance=new A112165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112166
{
public static readonly long[] Value={ 1L,2L,0L,0L,0L,0L,-2L,4L,0L,0L,0L,0L,1L,6L,0L,0L,0L,0L,-2L,12L,0L,0L,0L,0L,4L,18L,0L,0L,0L,0L,-4L,28L,0L,0L,0L,0L,5L,44L,0L,0L,0L,0L,-6L,64L,0L,0L,0L,0L,9L,92L,0L,0L,0L,0L,-12L,132L,0L,0L,0L,0L,13L,186L,0L,0L,0L,0L,-16L,256L,0L,0L,0L,0L,21L,352L,0L,0L,0L,0L,-26L,476L,0L,0L,0L,0L,29L,638L,0L,0L,0L,0L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112166Inst : IEnumerable<long>
{
public static readonly long[] Value=A112166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112166.Bytes);
public long this[int i]=>Value[i];

public static A112166Inst Instance=new A112166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112167
{
public static readonly long[] Value={ 1L,-2L,0L,0L,0L,0L,-2L,-4L,0L,0L,0L,0L,1L,-6L,0L,0L,0L,0L,-2L,-12L,0L,0L,0L,0L,4L,-18L,0L,0L,0L,0L,-4L,-28L,0L,0L,0L,0L,5L,-44L,0L,0L,0L,0L,-6L,-64L,0L,0L,0L,0L,9L,-92L,0L,0L,0L,0L,-12L,-132L,0L,0L,0L,0L,13L,-186L,0L,0L,0L,0L,-16L,-256L,0L,0L,0L,0L,21L,-352L,0L,0L,0L,0L,-26L,-476L,0L,0L,0L,0L,29L,-638L,0L,0L,0L,0L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112167Inst : IEnumerable<long>
{
public static readonly long[] Value=A112167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112167.Bytes);
public long this[int i]=>Value[i];

public static A112167Inst Instance=new A112167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112168
{
public static readonly long[] Value={ 1L,-1L,2L,3L,0L,1L,3L,-2L,3L,7L,-4L,5L,11L,-3L,7L,14L,-5L,9L,23L,-11L,19L,35L,-11L,20L,44L,-19L,31L,66L,-27L,45L,91L,-32L,57L,118L,-45L,75L,164L,-68L,112L,222L,-77L,134L,279L,-109L,181L,376L,-148L,242L,490L,-178L,304L,617L,-233L,385L,803L,-314L,517L,1032L,-372L,626L,1281L,-487L,803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112168Inst : IEnumerable<long>
{
public static readonly long[] Value=A112168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112168.Bytes);
public long this[int i]=>Value[i];

public static A112168Inst Instance=new A112168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112169
{
public static readonly long[] Value={ 1L,0L,3L,4L,9L,12L,15L,24L,39L,52L,66L,96L,130L,168L,219L,292L,390L,492L,625L,804L,1023L,1280L,1599L,2016L,2508L,3096L,3807L,4688L,5760L,7020L,8532L,10368L,12585L,15156L,18213L,21912L,26287L,31404L,37410L,44584L,53004L,62784L,74245L,87768L,103578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112169Inst : IEnumerable<long>
{
public static readonly long[] Value=A112169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112169.Bytes);
public long this[int i]=>Value[i];

public static A112169Inst Instance=new A112169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112170
{
public static readonly long[] Value={ 1L,1L,1L,0L,-2L,2L,0L,1L,0L,-1L,2L,1L,3L,0L,-2L,5L,2L,3L,0L,-5L,7L,3L,4L,0L,-5L,9L,3L,7L,0L,-7L,14L,8L,11L,0L,-14L,21L,7L,13L,0L,-14L,26L,11L,20L,0L,-21L,39L,16L,26L,0L,-32L,51L,20L,34L,0L,-38L,65L,25L,47L,0L,-49L,90L,40L,63L,0L,-74L,118L,44L,77L,0L,-85L,146L,60L,105L,0L,-111L,196L,80L,132L,0L,-152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112170Inst : IEnumerable<long>
{
public static readonly long[] Value=A112170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112170.Bytes);
public long this[int i]=>Value[i];

public static A112170Inst Instance=new A112170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112171
{
public static readonly long[] Value={ 1L,2L,0L,0L,-1L,2L,0L,0L,-1L,4L,0L,0L,0L,6L,0L,0L,1L,8L,0L,0L,0L,12L,0L,0L,-1L,18L,0L,0L,1L,24L,0L,0L,2L,32L,0L,0L,-1L,44L,0L,0L,-2L,58L,0L,0L,1L,76L,0L,0L,2L,100L,0L,0L,-1L,128L,0L,0L,-3L,164L,0L,0L,1L,210L,0L,0L,4L,264L,0L,0L,-2L,332L,0L,0L,-5L,416L,0L,0L,2L,516L,0L,0L,5L,640L,0L,0L,-2L,790L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112171Inst : IEnumerable<long>
{
public static readonly long[] Value=A112171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112171.Bytes);
public long this[int i]=>Value[i];

public static A112171Inst Instance=new A112171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112172
{
public static readonly long[] Value={ 1L,-2L,0L,0L,-1L,-2L,0L,0L,-1L,-4L,0L,0L,0L,-6L,0L,0L,1L,-8L,0L,0L,0L,-12L,0L,0L,-1L,-18L,0L,0L,1L,-24L,0L,0L,2L,-32L,0L,0L,-1L,-44L,0L,0L,-2L,-58L,0L,0L,1L,-76L,0L,0L,2L,-100L,0L,0L,-1L,-128L,0L,0L,-3L,-164L,0L,0L,1L,-210L,0L,0L,4L,-264L,0L,0L,-2L,-332L,0L,0L,-5L,-416L,0L,0L,2L,-516L,0L,0L,5L,-640L,0L,0L,-2L,-790L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112172Inst : IEnumerable<long>
{
public static readonly long[] Value=A112172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112172.Bytes);
public long this[int i]=>Value[i];

public static A112172Inst Instance=new A112172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112173
{
public static readonly long[] Value={ 1L,2L,1L,4L,8L,6L,10L,16L,18L,26L,33L,40L,58L,74L,82L,112L,147L,166L,212L,268L,316L,392L,476L,560L,695L,838L,967L,1184L,1430L,1648L,1970L,2352L,2731L,3236L,3803L,4404L,5206L,6080L,6984L,8192L,9553L,10942L,12709L,14736L,16886L,19506L,22448L,25648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112173Inst : IEnumerable<long>
{
public static readonly long[] Value=A112173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112173.Bytes);
public long this[int i]=>Value[i];

public static A112173Inst Instance=new A112173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112174
{
public static readonly long[] Value={ 1L,1L,0L,2L,-2L,0L,3L,1L,0L,4L,0L,0L,5L,0L,0L,8L,-2L,0L,11L,4L,0L,16L,-4L,0L,21L,4L,0L,26L,-2L,0L,34L,1L,0L,44L,-4L,0L,58L,9L,0L,74L,-12L,0L,93L,9L,0L,116L,-4L,0L,143L,5L,0L,178L,-12L,0L,221L,20L,0L,272L,-24L,0L,332L,20L,0L,402L,-14L,0L,487L,13L,0L,588L,-24L,0L,710L,42L,0L,854L,-50L,0L,1021L,42L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112174Inst : IEnumerable<long>
{
public static readonly long[] Value=A112174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112174.Bytes);
public long this[int i]=>Value[i];

public static A112174Inst Instance=new A112174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112175
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,2L,-1L,2L,-2L,3L,-4L,4L,-4L,7L,-7L,6L,-10L,11L,-11L,14L,-16L,17L,-21L,22L,-24L,32L,-34L,34L,-44L,49L,-50L,60L,-66L,72L,-84L,90L,-98L,117L,-125L,132L,-156L,171L,-181L,206L,-226L,245L,-277L,298L,-322L,369L,-397L,422L,-480L,522L,-557L,620L,-674L,728L,-807L,868L,-936L,1043L,-1121L,1198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112175Inst : IEnumerable<long>
{
public static readonly long[] Value=A112175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112175.Bytes);
public long this[int i]=>Value[i];

public static A112175Inst Instance=new A112175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112176
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,-2L,2L,-2L,3L,-4L,4L,-4L,5L,-7L,7L,-8L,10L,-12L,14L,-14L,17L,-20L,22L,-24L,28L,-33L,36L,-40L,45L,-52L,56L,-62L,71L,-80L,88L,-96L,109L,-122L,133L,-144L,163L,-182L,198L,-216L,240L,-268L,290L,-316L,349L,-386L,420L,-456L,502L,-552L,600L,-650L,713L,-780L,846L,-916L,1001L,-1093L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112176Inst : IEnumerable<long>
{
public static readonly long[] Value=A112176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112176.Bytes);
public long this[int i]=>Value[i];

public static A112176Inst Instance=new A112176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112177
{
public static readonly long[] Value={ 1L,-2L,0L,-1L,-2L,0L,0L,-2L,0L,-2L,-6L,0L,2L,-6L,0L,-1L,-8L,0L,2L,-14L,0L,-2L,-16L,0L,3L,-20L,0L,-4L,-32L,0L,4L,-38L,0L,-4L,-46L,0L,7L,-66L,0L,-7L,-78L,0L,6L,-96L,0L,-10L,-130L,0L,11L,-154L,0L,-11L,-186L,0L,14L,-244L,0L,-16L,-288L,0L,17L,-346L,0L,-21L,-440L,0L,22L,-518L,0L,-24L,-618L,0L,32L,-768L,0L,-34L,-902L,0L,34L,-1068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112177Inst : IEnumerable<long>
{
public static readonly long[] Value=A112177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112177.Bytes);
public long this[int i]=>Value[i];

public static A112177Inst Instance=new A112177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112178
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,0L,-1L,-1L,0L,2L,-1L,0L,-2L,-2L,0L,0L,-1L,0L,2L,-1L,0L,-2L,-1L,0L,-1L,-2L,0L,4L,-3L,0L,-4L,-3L,0L,0L,-3L,0L,5L,-2L,0L,-4L,-2L,0L,-2L,-3L,0L,8L,-5L,0L,-7L,-6L,0L,-1L,-5L,0L,9L,-4L,0L,-8L,-4L,0L,-3L,-6L,0L,14L,-9L,0L,-13L,-10L,0L,-2L,-9L,0L,16L,-8L,0L,-14L,-8L,0L,-5L,-11L,0L,24L,-14L,0L,-21L,-16L,0L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112178Inst : IEnumerable<long>
{
public static readonly long[] Value=A112178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112178.Bytes);
public long this[int i]=>Value[i];

public static A112178Inst Instance=new A112178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112179
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,6L,9L,8L,13L,20L,22L,28L,34L,46L,57L,68L,87L,104L,127L,152L,187L,232L,267L,318L,388L,462L,545L,632L,753L,896L,1043L,1216L,1416L,1664L,1928L,2228L,2597L,2996L,3454L,3976L,4585L,5286L,6031L,6900L,7918L,9060L,10325L,11720L,13372L,15228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112179Inst : IEnumerable<long>
{
public static readonly long[] Value=A112179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112179.Bytes);
public long this[int i]=>Value[i];

public static A112179Inst Instance=new A112179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112180
{
public static readonly long[] Value={ 1L,0L,3L,4L,4L,4L,7L,12L,13L,16L,22L,28L,38L,44L,55L,72L,83L,104L,129L,156L,187L,220L,273L,328L,384L,452L,539L,652L,757L,880L,1041L,1220L,1428L,1652L,1924L,2244L,2585L,2992L,3458L,3992L,4581L,5244L,6053L,6936L,7910L,9024L,10303L,11784L,13380L,15176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112180Inst : IEnumerable<long>
{
public static readonly long[] Value=A112180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112180.Bytes);
public long this[int i]=>Value[i];

public static A112180Inst Instance=new A112180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112181
{
public static readonly long[] Value={ 1L,2L,-1L,2L,0L,2L,-1L,4L,1L,4L,-2L,8L,2L,10L,-1L,12L,3L,16L,-3L,20L,3L,28L,-3L,34L,4L,42L,-5L,52L,5L,64L,-7L,84L,8L,100L,-8L,120L,9L,148L,-10L,176L,13L,218L,-15L,260L,14L,308L,-17L,368L,20L,436L,-23L,524L,24L,616L,-26L,724L,31L,852L,-34L,996L,38L,1178L,-41L,1370L,46L,1592L,-52L,1856L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112181Inst : IEnumerable<long>
{
public static readonly long[] Value=A112181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112181.Bytes);
public long this[int i]=>Value[i];

public static A112181Inst Instance=new A112181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112182
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-2L,2L,-1L,3L,-3L,3L,-3L,4L,-5L,5L,-7L,8L,-8L,9L,-10L,13L,-15L,14L,-17L,20L,-23L,24L,-26L,31L,-34L,38L,-41L,46L,-52L,55L,-62L,70L,-75L,82L,-90L,103L,-112L,118L,-131L,145L,-161L,172L,-185L,208L,-225L,244L,-265L,288L,-316L,339L,-370L,404L,-435L,469L,-507L,557L,-601L,640L,-696L,755L,-818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112182Inst : IEnumerable<long>
{
public static readonly long[] Value=A112182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112182.Bytes);
public long this[int i]=>Value[i];

public static A112182Inst Instance=new A112182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112183
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,0L,-1L,0L,0L,2L,2L,-1L,1L,0L,2L,1L,-1L,1L,0L,4L,3L,-3L,2L,0L,4L,2L,-3L,1L,0L,7L,5L,-5L,4L,0L,7L,4L,-5L,3L,0L,12L,9L,-8L,6L,0L,13L,7L,-9L,5L,0L,19L,14L,-13L,9L,0L,21L,12L,-14L,8L,0L,31L,22L,-21L,15L,0L,34L,19L,-23L,13L,0L,47L,33L,-31L,22L,0L,52L,31L,-35L,21L,0L,71L,49L,-48L,33L,0L,79L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112183Inst : IEnumerable<long>
{
public static readonly long[] Value=A112183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112183.Bytes);
public long this[int i]=>Value[i];

public static A112183Inst Instance=new A112183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112184
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-1L,1L,-1L,2L,-2L,2L,-3L,4L,-3L,4L,-5L,6L,-6L,6L,-8L,9L,-10L,10L,-12L,14L,-15L,16L,-19L,21L,-22L,24L,-27L,31L,-34L,36L,-40L,46L,-48L,52L,-58L,64L,-69L,74L,-82L,91L,-98L,104L,-115L,127L,-136L,145L,-159L,174L,-186L,200L,-218L,238L,-254L,272L,-296L,322L,-343L,366L,-398L,430L,-460L,492L,-531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112184Inst : IEnumerable<long>
{
public static readonly long[] Value=A112184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112184.Bytes);
public long this[int i]=>Value[i];

public static A112184Inst Instance=new A112184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112185
{
public static readonly long[] Value={ 1L,-1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,-1L,0L,1L,1L,2L,-2L,0L,1L,1L,3L,-1L,0L,2L,1L,3L,-2L,0L,2L,1L,5L,-4L,0L,4L,3L,6L,-3L,0L,4L,2L,7L,-5L,0L,5L,4L,10L,-7L,0L,7L,5L,12L,-7L,0L,9L,5L,14L,-9L,0L,10L,6L,20L,-14L,0L,14L,10L,23L,-13L,0L,16L,9L,27L,-18L,0L,19L,13L,35L,-24L,0L,24L,16L,42L,-25L,0L,29L,18L,48L,-31L,0L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112185Inst : IEnumerable<long>
{
public static readonly long[] Value=A112185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112185.Bytes);
public long this[int i]=>Value[i];

public static A112185Inst Instance=new A112185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112186
{
public static readonly long[] Value={ 1L,1L,1L,-1L,2L,-1L,2L,1L,3L,0L,4L,-1L,5L,1L,7L,0L,8L,0L,10L,1L,13L,-2L,16L,0L,20L,3L,24L,-2L,30L,-2L,36L,4L,43L,0L,52L,-3L,61L,2L,73L,-1L,86L,-1L,102L,3L,120L,-4L,140L,-1L,165L,8L,192L,-5L,224L,-6L,260L,10L,301L,-2L,348L,-7L,401L,7L,462L,-2L,530L,-2L,608L,8L,696L,-10L,796L,-3L,909L,18L,1035L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112186Inst : IEnumerable<long>
{
public static readonly long[] Value=A112186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112186.Bytes);
public long this[int i]=>Value[i];

public static A112186Inst Instance=new A112186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112187
{
public static readonly long[] Value={ 1L,-1L,1L,1L,2L,1L,2L,-1L,3L,0L,4L,1L,5L,-1L,7L,0L,8L,0L,10L,-1L,13L,2L,16L,0L,20L,-3L,24L,2L,30L,2L,36L,-4L,43L,0L,52L,3L,61L,-2L,73L,1L,86L,1L,102L,-3L,120L,4L,140L,1L,165L,-8L,192L,5L,224L,6L,260L,-10L,301L,2L,348L,7L,401L,-7L,462L,2L,530L,2L,608L,-8L,696L,10L,796L,3L,909L,-18L,1035L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112187Inst : IEnumerable<long>
{
public static readonly long[] Value=A112187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112187.Bytes);
public long this[int i]=>Value[i];

public static A112187Inst Instance=new A112187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112188
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,-1L,0L,1L,1L,0L,2L,1L,1L,-1L,1L,2L,2L,-2L,2L,1L,1L,-2L,2L,2L,4L,-3L,4L,4L,2L,-4L,2L,4L,5L,-4L,6L,5L,5L,-6L,5L,7L,8L,-7L,8L,7L,6L,-8L,8L,9L,13L,-12L,14L,13L,10L,-14L,10L,14L,17L,-14L,20L,17L,17L,-19L,18L,22L,24L,-24L,26L,24L,22L,-26L,26L,29L,37L,-34L,39L,38L,32L,-40L,34L,42L,48L,-44L,54L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112188Inst : IEnumerable<long>
{
public static readonly long[] Value=A112188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112188.Bytes);
public long this[int i]=>Value[i];

public static A112188Inst Instance=new A112188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112189
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,0L,-1L,1L,0L,2L,-1L,1L,1L,1L,-2L,2L,2L,2L,-1L,1L,2L,2L,-2L,4L,3L,4L,-4L,2L,4L,2L,-4L,5L,4L,6L,-5L,5L,6L,5L,-7L,8L,7L,8L,-7L,6L,8L,8L,-9L,13L,12L,14L,-13L,10L,14L,10L,-14L,17L,14L,20L,-17L,17L,19L,18L,-22L,24L,24L,26L,-24L,22L,26L,26L,-29L,37L,34L,39L,-38L,32L,40L,34L,-42L,48L,44L,54L,-49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112189Inst : IEnumerable<long>
{
public static readonly long[] Value=A112189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112189.Bytes);
public long this[int i]=>Value[i];

public static A112189Inst Instance=new A112189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112190
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,0L,-1L,0L,-1L,1L,0L,-2L,-1L,1L,-1L,-1L,-2L,2L,-2L,-2L,-1L,1L,-2L,-2L,-2L,4L,-3L,-4L,-4L,2L,-4L,-2L,-4L,5L,-4L,-6L,-5L,5L,-6L,-5L,-7L,8L,-7L,-8L,-7L,6L,-8L,-8L,-9L,13L,-12L,-14L,-13L,10L,-14L,-10L,-14L,17L,-14L,-20L,-17L,17L,-19L,-18L,-22L,24L,-24L,-26L,-24L,22L,-26L,-26L,-29L,37L,-34L,-39L,-38L,32L,-40L,-34L,-42L,48L,-44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112190Inst : IEnumerable<long>
{
public static readonly long[] Value=A112190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112190.Bytes);
public long this[int i]=>Value[i];

public static A112190Inst Instance=new A112190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112191
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,0L,1L,1L,0L,-2L,1L,1L,1L,-1L,2L,2L,2L,-2L,1L,1L,2L,-2L,2L,4L,3L,-4L,4L,2L,4L,-2L,4L,5L,4L,-6L,5L,5L,6L,-5L,7L,8L,7L,-8L,7L,6L,8L,-8L,9L,13L,12L,-14L,13L,10L,14L,-10L,14L,17L,14L,-20L,17L,17L,19L,-18L,22L,24L,24L,-26L,24L,22L,26L,-26L,29L,37L,34L,-39L,38L,32L,40L,-34L,42L,48L,44L,-54L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112191Inst : IEnumerable<long>
{
public static readonly long[] Value=A112191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112191.Bytes);
public long this[int i]=>Value[i];

public static A112191Inst Instance=new A112191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112192
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,7L,8L,10L,13L,16L,20L,24L,30L,36L,43L,52L,61L,73L,86L,102L,120L,140L,165L,192L,224L,260L,301L,348L,401L,462L,530L,608L,696L,796L,909L,1035L,1178L,1338L,1518L,1720L,1945L,2198L,2480L,2796L,3148L,3540L,3978L,4464L,5006L,5606L,6273L,7012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112192Inst : IEnumerable<long>
{
public static readonly long[] Value=A112192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112192.Bytes);
public long this[int i]=>Value[i];

public static A112192Inst Instance=new A112192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112193
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,11L,13L,16L,19L,23L,27L,32L,38L,44L,52L,61L,71L,82L,95L,110L,127L,145L,167L,191L,218L,249L,283L,322L,365L,414L,469L,529L,597L,673L,757L,851L,955L,1071L,1199L,1341L,1499L,1673L,1865L,2078L,2313L,2572L,2857L,3171L,3517L,3897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112193Inst : IEnumerable<long>
{
public static readonly long[] Value=A112193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112193.Bytes);
public long this[int i]=>Value[i];

public static A112193Inst Instance=new A112193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112194
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,4L,4L,6L,8L,10L,11L,14L,16L,20L,23L,28L,32L,40L,45L,55L,61L,74L,83L,98L,111L,130L,148L,172L,195L,224L,253L,291L,327L,374L,420L,481L,539L,612L,683L,775L,865L,976L,1087L,1224L,1365L,1530L,1701L,1902L,2113L,2358L,2613L,2910L,3221L,3584L,3960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112194Inst : IEnumerable<long>
{
public static readonly long[] Value=A112194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112194.Bytes);
public long this[int i]=>Value[i];

public static A112194Inst Instance=new A112194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112195
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,0L,1L,1L,0L,2L,1L,-1L,2L,1L,-1L,2L,1L,-1L,4L,3L,-2L,4L,2L,-1L,5L,3L,-2L,7L,4L,-3L,8L,4L,-3L,9L,5L,-3L,13L,8L,-6L,14L,7L,-5L,16L,10L,-6L,21L,12L,-9L,24L,13L,-9L,27L,15L,-10L,35L,21L,-15L,39L,20L,-14L,45L,26L,-17L,55L,31L,-22L,62L,34L,-23L,70L,39L,-26L,86L,50L,-35L,96L,51L,-35L,109L,62L,-41L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112195Inst : IEnumerable<long>
{
public static readonly long[] Value=A112195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112195.Bytes);
public long this[int i]=>Value[i];

public static A112195Inst Instance=new A112195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112196
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,2L,5L,6L,7L,7L,9L,12L,13L,16L,20L,25L,27L,31L,38L,44L,51L,58L,69L,80L,92L,102L,118L,141L,157L,177L,203L,234L,261L,292L,336L,382L,428L,475L,540L,610L,677L,757L,852L,957L,1060L,1179L,1318L,1470L,1634L,1806L,2011L,2236L,2469L,2724L,3020L,3350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112196Inst : IEnumerable<long>
{
public static readonly long[] Value=A112196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112196.Bytes);
public long this[int i]=>Value[i];

public static A112196Inst Instance=new A112196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112197
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,0L,2L,-1L,2L,1L,3L,-1L,4L,1L,4L,0L,5L,1L,7L,-2L,8L,1L,10L,-1L,12L,2L,14L,-2L,17L,3L,21L,-3L,24L,3L,28L,-4L,34L,4L,39L,-4L,46L,5L,53L,-4L,61L,4L,71L,-6L,82L,6L,94L,-7L,108L,7L,124L,-8L,142L,11L,162L,-11L,185L,10L,210L,-12L,238L,14L,271L,-15L,306L,15L,345L,-14L,390L,17L,439L,-20L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112197Inst : IEnumerable<long>
{
public static readonly long[] Value=A112197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112197.Bytes);
public long this[int i]=>Value[i];

public static A112197Inst Instance=new A112197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112198
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,0L,2L,1L,2L,-1L,3L,1L,4L,-1L,4L,0L,5L,-1L,7L,2L,8L,-1L,10L,1L,12L,-2L,14L,2L,17L,-3L,21L,3L,24L,-3L,28L,4L,34L,-4L,39L,4L,46L,-5L,53L,4L,61L,-4L,71L,6L,82L,-6L,94L,7L,108L,-7L,124L,8L,142L,-11L,162L,11L,185L,-10L,210L,12L,238L,-14L,271L,15L,306L,-15L,345L,14L,390L,-17L,439L,20L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112198Inst : IEnumerable<long>
{
public static readonly long[] Value=A112198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112198.Bytes);
public long this[int i]=>Value[i];

public static A112198Inst Instance=new A112198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112199
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,4L,4L,5L,6L,8L,9L,12L,13L,16L,18L,23L,25L,31L,36L,43L,48L,57L,64L,76L,86L,99L,112L,131L,146L,169L,190L,217L,243L,278L,310L,353L,394L,446L,498L,562L,624L,704L,781L,877L,972L,1088L,1204L,1345L,1488L,1656L,1829L,2033L,2240L,2486L,2738L,3030L,3334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112199Inst : IEnumerable<long>
{
public static readonly long[] Value=A112199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112199.Bytes);
public long this[int i]=>Value[i];

public static A112199Inst Instance=new A112199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112200
{
public static readonly long[] Value={ 1L,0L,0L,-1L,1L,-1L,1L,0L,1L,-1L,1L,-1L,2L,-2L,1L,-3L,2L,-2L,3L,-3L,4L,-4L,3L,-4L,6L,-5L,5L,-7L,7L,-7L,9L,-8L,9L,-11L,10L,-12L,14L,-13L,14L,-17L,18L,-18L,20L,-21L,23L,-27L,25L,-27L,33L,-32L,34L,-39L,39L,-42L,46L,-48L,51L,-56L,57L,-61L,71L,-69L,72L,-83L,85L,-90L,97L,-99L,108L,-117L,119L,-126L,140L,-143L,149L,-167L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112200Inst : IEnumerable<long>
{
public static readonly long[] Value=A112200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112200.Bytes);
public long this[int i]=>Value[i];

public static A112200Inst Instance=new A112200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112201
{
public static readonly long[] Value={ 1L,-1L,0L,1L,1L,0L,1L,0L,0L,2L,1L,0L,2L,-1L,0L,2L,0L,0L,3L,0L,0L,4L,1L,0L,4L,-1L,0L,6L,1L,0L,7L,-2L,0L,8L,2L,0L,10L,-2L,0L,12L,2L,0L,14L,-2L,0L,16L,1L,0L,19L,-2L,0L,22L,3L,0L,26L,-2L,0L,30L,3L,0L,35L,-5L,0L,41L,5L,0L,47L,-4L,0L,54L,5L,0L,62L,-6L,0L,70L,4L,0L,80L,-4L,0L,92L,7L,0L,104L,-7L,0L,118L,7L,0L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112201Inst : IEnumerable<long>
{
public static readonly long[] Value=A112201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112201.Bytes);
public long this[int i]=>Value[i];

public static A112201Inst Instance=new A112201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112202
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,0L,0L,-1L,0L,-1L,0L,-1L,-1L,0L,0L,1L,0L,-1L,0L,-1L,1L,-1L,-2L,0L,-1L,1L,-1L,-1L,0L,-1L,2L,-2L,-3L,0L,0L,1L,-1L,-3L,0L,-2L,2L,-3L,-4L,0L,-1L,3L,-2L,-4L,0L,-2L,3L,-4L,-6L,0L,-2L,3L,-3L,-5L,0L,-3L,6L,-6L,-9L,0L,-2L,4L,-4L,-9L,0L,-5L,6L,-8L,-11L,0L,-3L,8L,-6L,-12L,0L,-6L,9L,-10L,-16L,0L,-6L,9L,-9L,-15L,0L,-8L,14L,-15L,-22L,0L,-6L,12L,-11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112202Inst : IEnumerable<long>
{
public static readonly long[] Value=A112202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112202.Bytes);
public long this[int i]=>Value[i];

public static A112202Inst Instance=new A112202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112203
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,0L,0L,2L,-1L,0L,2L,1L,0L,2L,0L,0L,3L,0L,0L,4L,-1L,0L,4L,1L,0L,6L,-1L,0L,7L,2L,0L,8L,-2L,0L,10L,2L,0L,12L,-2L,0L,14L,2L,0L,16L,-1L,0L,19L,2L,0L,22L,-3L,0L,26L,2L,0L,30L,-3L,0L,35L,5L,0L,41L,-5L,0L,47L,4L,0L,54L,-5L,0L,62L,6L,0L,70L,-4L,0L,80L,4L,0L,92L,-7L,0L,104L,7L,0L,118L,-7L,0L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112203Inst : IEnumerable<long>
{
public static readonly long[] Value=A112203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112203.Bytes);
public long this[int i]=>Value[i];

public static A112203Inst Instance=new A112203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112204
{
public static readonly long[] Value={ 1L,0L,2L,2L,1L,2L,3L,2L,4L,6L,6L,6L,9L,8L,13L,14L,15L,18L,23L,22L,29L,34L,35L,44L,52L,52L,65L,74L,80L,92L,110L,114L,134L,152L,164L,188L,215L,230L,266L,296L,321L,362L,412L,438L,503L,558L,602L,674L,755L,810L,912L,1010L,1093L,1210L,1346L,1446L,1614L,1772L,1922L,2118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112204Inst : IEnumerable<long>
{
public static readonly long[] Value=A112204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112204.Bytes);
public long this[int i]=>Value[i];

public static A112204Inst Instance=new A112204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112205
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,7L,7L,8L,10L,12L,14L,14L,17L,20L,22L,24L,28L,33L,36L,40L,45L,52L,56L,62L,71L,80L,88L,96L,109L,122L,133L,144L,163L,182L,198L,216L,240L,268L,290L,316L,349L,386L,420L,456L,502L,552L,600L,650L,713L,780L,846L,916L,1001L,1093L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112205Inst : IEnumerable<long>
{
public static readonly long[] Value=A112205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112205.Bytes);
public long this[int i]=>Value[i];

public static A112205Inst Instance=new A112205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112206
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,1L,2L,2L,3L,4L,4L,4L,7L,7L,6L,10L,11L,11L,14L,16L,17L,21L,22L,24L,32L,34L,34L,44L,49L,50L,60L,66L,72L,84L,90L,98L,117L,125L,132L,156L,171L,181L,206L,226L,245L,277L,298L,322L,369L,397L,422L,480L,522L,557L,620L,674L,728L,807L,868L,936L,1043L,1121L,1198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112206Inst : IEnumerable<long>
{
public static readonly long[] Value=A112206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112206.Bytes);
public long this[int i]=>Value[i];

public static A112206Inst Instance=new A112206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112207
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,0L,3L,-1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,5L,1L,0L,0L,0L,0L,6L,-2L,0L,0L,0L,0L,7L,2L,0L,0L,0L,0L,8L,-1L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,10L,-1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112207Inst : IEnumerable<long>
{
public static readonly long[] Value=A112207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112207.Bytes);
public long this[int i]=>Value[i];

public static A112207Inst Instance=new A112207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112208
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,3L,-1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,5L,-1L,0L,0L,0L,0L,6L,2L,0L,0L,0L,0L,7L,-2L,0L,0L,0L,0L,8L,1L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,10L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112208Inst : IEnumerable<long>
{
public static readonly long[] Value=A112208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112208.Bytes);
public long this[int i]=>Value[i];

public static A112208Inst Instance=new A112208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112209
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,2L,1L,3L,3L,3L,3L,4L,5L,5L,7L,8L,8L,9L,10L,13L,15L,14L,17L,20L,23L,24L,26L,31L,34L,38L,41L,46L,52L,55L,62L,70L,75L,82L,90L,103L,112L,118L,131L,145L,161L,172L,185L,208L,225L,244L,265L,288L,316L,339L,370L,404L,435L,469L,507L,557L,601L,640L,696L,755L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112209Inst : IEnumerable<long>
{
public static readonly long[] Value=A112209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112209.Bytes);
public long this[int i]=>Value[i];

public static A112209Inst Instance=new A112209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112210
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,6L,7L,7L,9L,9L,11L,12L,14L,15L,18L,19L,22L,24L,27L,29L,34L,36L,41L,44L,50L,54L,61L,65L,73L,79L,88L,95L,106L,114L,126L,136L,150L,162L,179L,192L,211L,228L,249L,268L,294L,316L,345L,371L,404L,434L,473L,507L,551L,592L,641L,688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112210Inst : IEnumerable<long>
{
public static readonly long[] Value=A112210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112210.Bytes);
public long this[int i]=>Value[i];

public static A112210Inst Instance=new A112210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112211
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,1L,-1L,1L,0L,1L,-2L,2L,-2L,1L,0L,1L,-2L,3L,-3L,1L,0L,2L,-4L,5L,-4L,2L,-2L,3L,-4L,6L,-6L,3L,-2L,3L,-7L,10L,-8L,5L,-4L,5L,-10L,13L,-10L,6L,-4L,7L,-14L,16L,-14L,11L,-8L,11L,-18L,22L,-21L,14L,-8L,14L,-24L,29L,-26L,17L,-14L,22L,-32L,39L,-36L,24L,-20L,28L,-40L,49L,-44L,32L,-28L,34L,-52L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112211Inst : IEnumerable<long>
{
public static readonly long[] Value=A112211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112211.Bytes);
public long this[int i]=>Value[i];

public static A112211Inst Instance=new A112211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112212
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,3L,2L,3L,3L,4L,4L,4L,6L,7L,7L,7L,9L,10L,12L,13L,14L,17L,18L,19L,22L,26L,28L,29L,34L,38L,41L,44L,50L,57L,60L,65L,72L,81L,86L,94L,105L,114L,124L,133L,146L,161L,174L,187L,204L,224L,240L,258L,282L,309L,332L,354L,386L,419L,450L,481L,524L,569L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112212Inst : IEnumerable<long>
{
public static readonly long[] Value=A112212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112212.Bytes);
public long this[int i]=>Value[i];

public static A112212Inst Instance=new A112212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112213
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,3L,4L,5L,6L,6L,6L,8L,9L,10L,10L,12L,14L,15L,16L,19L,21L,22L,24L,27L,31L,34L,36L,40L,46L,48L,52L,58L,64L,69L,74L,82L,91L,98L,104L,115L,127L,136L,145L,159L,174L,186L,200L,218L,238L,254L,272L,296L,322L,343L,366L,398L,430L,460L,492L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112213Inst : IEnumerable<long>
{
public static readonly long[] Value=A112213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112213.Bytes);
public long this[int i]=>Value[i];

public static A112213Inst Instance=new A112213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112214
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,-1L,0L,2L,1L,0L,2L,0L,0L,2L,0L,0L,2L,-1L,0L,3L,1L,0L,3L,-1L,0L,4L,1L,0L,5L,0L,0L,5L,0L,0L,5L,-1L,0L,6L,2L,0L,7L,-2L,0L,8L,2L,0L,9L,-1L,0L,10L,0L,0L,11L,-1L,0L,12L,3L,0L,14L,-2L,0L,15L,1L,0L,17L,-1L,0L,18L,1L,0L,20L,-2L,0L,22L,4L,0L,25L,-5L,0L,28L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112214Inst : IEnumerable<long>
{
public static readonly long[] Value=A112214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112214.Bytes);
public long this[int i]=>Value[i];

public static A112214Inst Instance=new A112214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112215
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,-1L,1L,0L,0L,-1L,2L,-2L,2L,-1L,0L,-1L,3L,-2L,1L,-1L,1L,-2L,4L,-5L,3L,-1L,1L,-2L,4L,-6L,4L,-2L,3L,-5L,6L,-7L,6L,-2L,1L,-6L,10L,-10L,9L,-6L,4L,-7L,12L,-12L,9L,-7L,6L,-10L,18L,-20L,13L,-8L,9L,-12L,18L,-24L,20L,-12L,13L,-21L,27L,-29L,24L,-14L,13L,-25L,36L,-38L,35L,-25L,19L,-30L,46L,-46L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112215Inst : IEnumerable<long>
{
public static readonly long[] Value=A112215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112215.Bytes);
public long this[int i]=>Value[i];

public static A112215Inst Instance=new A112215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112216
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,10L,12L,12L,13L,15L,17L,18L,19L,22L,25L,27L,28L,32L,36L,38L,41L,46L,51L,54L,58L,64L,71L,76L,81L,89L,99L,105L,112L,123L,134L,143L,153L,167L,182L,194L,207L,225L,244L,260L,277L,301L,325L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112216Inst : IEnumerable<long>
{
public static readonly long[] Value=A112216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112216.Bytes);
public long this[int i]=>Value[i];

public static A112216Inst Instance=new A112216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112217
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,9L,10L,12L,12L,14L,15L,17L,18L,21L,22L,25L,27L,30L,32L,36L,38L,43L,46L,51L,54L,60L,64L,71L,76L,83L,89L,98L,104L,114L,122L,133L,142L,155L,165L,180L,192L,208L,222L,241L,256L,278L,296L,320L,341L,368L,391L,422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112217Inst : IEnumerable<long>
{
public static readonly long[] Value=A112217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112217.Bytes);
public long this[int i]=>Value[i];

public static A112217Inst Instance=new A112217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112218
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,3L,2L,2L,4L,3L,4L,5L,5L,5L,7L,6L,7L,9L,9L,9L,12L,11L,13L,15L,15L,16L,20L,19L,22L,25L,26L,27L,33L,32L,36L,41L,42L,44L,52L,52L,57L,64L,66L,70L,81L,82L,89L,99L,103L,109L,123L,125L,136L,150L,156L,165L,185L,189L,204L,223L,233L,247L,273L,281L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112218Inst : IEnumerable<long>
{
public static readonly long[] Value=A112218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112218.Bytes);
public long this[int i]=>Value[i];

public static A112218Inst Instance=new A112218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112219
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,3L,2L,3L,3L,4L,3L,5L,4L,6L,5L,7L,6L,9L,7L,11L,9L,13L,11L,15L,13L,18L,16L,21L,19L,25L,22L,29L,27L,34L,31L,40L,37L,46L,43L,53L,50L,62L,58L,71L,68L,83L,78L,95L,91L,109L,104L,124L,120L,143L,137L,162L,158L,185L,180L,210L,206L,239L,234L,270L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112219Inst : IEnumerable<long>
{
public static readonly long[] Value=A112219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112219.Bytes);
public long this[int i]=>Value[i];

public static A112219Inst Instance=new A112219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112220
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,4L,3L,4L,5L,4L,6L,6L,6L,7L,8L,7L,9L,10L,10L,11L,13L,12L,15L,16L,16L,18L,21L,19L,23L,25L,25L,28L,31L,30L,35L,38L,38L,42L,47L,46L,52L,56L,57L,62L,69L,68L,77L,82L,84L,91L,100L,100L,111L,118L,121L,131L,142L,144L,158L,168L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112220Inst : IEnumerable<long>
{
public static readonly long[] Value=A112220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112220.Bytes);
public long this[int i]=>Value[i];

public static A112220Inst Instance=new A112220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112221
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,3L,4L,4L,3L,4L,6L,5L,5L,7L,7L,7L,9L,8L,9L,11L,10L,12L,14L,13L,14L,17L,18L,18L,20L,21L,23L,27L,25L,27L,33L,32L,34L,39L,39L,42L,46L,48L,51L,56L,57L,61L,71L,69L,72L,83L,85L,90L,97L,99L,108L,117L,119L,126L,140L,143L,149L,167L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112221Inst : IEnumerable<long>
{
public static readonly long[] Value=A112221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112221.Bytes);
public long this[int i]=>Value[i];

public static A112221Inst Instance=new A112221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112222
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,6L,6L,8L,7L,8L,9L,9L,10L,12L,11L,13L,14L,14L,15L,19L,17L,20L,22L,21L,23L,27L,26L,29L,32L,32L,34L,39L,38L,43L,46L,47L,50L,56L,55L,61L,67L,67L,72L,80L,79L,86L,93L,96L,101L,112L,112L,121L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112222Inst : IEnumerable<long>
{
public static readonly long[] Value=A112222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112222.Bytes);
public long this[int i]=>Value[i];

public static A112222Inst Instance=new A112222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112223
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,3L,2L,3L,3L,5L,3L,5L,4L,5L,5L,7L,5L,8L,7L,8L,8L,11L,8L,12L,10L,12L,12L,16L,12L,18L,16L,19L,18L,23L,19L,26L,23L,27L,27L,33L,28L,37L,34L,39L,38L,47L,41L,52L,48L,55L,55L,66L,58L,73L,68L,77L,77L,91L,82L,100L,95L,107L,107L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112223Inst : IEnumerable<long>
{
public static readonly long[] Value=A112223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112223.Bytes);
public long this[int i]=>Value[i];

public static A112223Inst Instance=new A112223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112224
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,2L,4L,3L,4L,3L,5L,4L,5L,5L,6L,5L,8L,6L,9L,6L,9L,8L,11L,10L,12L,11L,14L,12L,16L,13L,18L,16L,20L,18L,22L,20L,25L,23L,29L,25L,31L,29L,36L,33L,39L,36L,45L,40L,49L,45L,54L,51L,61L,58L,66L,63L,75L,70L,84L,77L,91L,86L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112224Inst : IEnumerable<long>
{
public static readonly long[] Value=A112224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112224.Bytes);
public long this[int i]=>Value[i];

public static A112224Inst Instance=new A112224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112225
{
public static readonly BigInteger[] Value={ 1L,13L,135L,1537L,19811L,289073L,4741923L,86705417L,1752264235L,38832482641L,937035652035L,24465531961465L,687363659349179L,20679220894484897L,663327190230305715L,BigInteger.Parse("22600083539456536457"),BigInteger.Parse("815088161465498630635") };
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
public class A112225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112225Inst Instance=new A112225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112226
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,13L,7L,3L,1L,135L,40L,12L,4L,1L,1537L,293L,66L,18L,5L,1L,19811L,2646L,451L,100L,25L,6L,1L,289073L,28887L,3753L,663L,143L,33L,7L,1L,4741923L,374820L,37798L,5232L,940L,196L,42L,8L,1L,86705417L,5676121L,457508L,49444L,7174L,1294L,260L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112226Inst : IEnumerable<long>
{
public static readonly long[] Value=A112226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112226.Bytes);
public long this[int i]=>Value[i];

public static A112226Inst Instance=new A112226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112227
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,1L,0L,-6L,0L,1L,12L,0L,-12L,0L,1L,0L,60L,0L,-20L,0L,1L,-120L,0L,180L,0L,-30L,0L,1L,0L,-840L,0L,420L,0L,-42L,0L,1L,1680L,0L,-3360L,0L,840L,0L,-56L,0L,1L,0L,15120L,0L,-10080L,0L,1512L,0L,-72L,0L,1L,-30240L,0L,75600L,0L,-25200L,0L,2520L,0L,-90L,0L,1L,0L,-332640L,0L,277200L,0L,-55440L,0L,3960L,0L,-110L,0L,1L,665280L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112227Inst : IEnumerable<long>
{
public static readonly long[] Value=A112227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112227.Bytes);
public long this[int i]=>Value[i];

public static A112227Inst Instance=new A112227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112228
{
public static readonly BigInteger[] Value={ 3L,15L,120L,1080L,14040L,196560L,3931200L,82555200L,1981324800L,49533120000L,1585059840000L,52306974720000L,1778437140480000L,65802174197760000L,2500482619514880000L,BigInteger.Parse("112521717878169600000"),BigInteger.Parse("5401042458152140800000") };
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
public class A112228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112228Inst Instance=new A112228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112229
{
public static readonly long[] Value={ 2L,4L,1L,2L,2L,4L,1L,4L,2L,8L,1L,2L,4L,28L,2L,11L,2L,4L,1L,4L,2L,32L,1L,3L,4L,40L,2L,14L,2L,4L,1L,37L,6L,138L,1L,2L,10L,40L,2L,5L,2L,16L,1L,16L,2L,26L,3L,4L,4L,10L,2L,20L,4L,10L,1L,7L,2L,50L,1L,2L,10L,22L,3L,6L,2L,6L,3L,69L,2L,8L,1L,2L,4L,40L,5L,20L,2L,4L,1L,7L,2L,20L,1L,8L,4L,10L,2L,32L,4L,12L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112229Inst : IEnumerable<long>
{
public static readonly long[] Value=A112229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112229.Bytes);
public long this[int i]=>Value[i];

public static A112229Inst Instance=new A112229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112230
{
public static readonly long[] Value={ 13L,13L,89L,83L,449L,89L,5711L,1511L,701L,449L,8117L,479L,27611L,5711L,1889L,10079L,241739L,701L,145349L,4139L,14489L,8117L,28151L,7079L,25349L,27611L,29537L,5711L,85607L,1889L,212411L,18719L,13331L,241739L,19949L,2699L,220667L,145349L,12401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112230Inst : IEnumerable<long>
{
public static readonly long[] Value=A112230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112230.Bytes);
public long this[int i]=>Value[i];

public static A112230Inst Instance=new A112230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112231
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,11L,12L,13L,13L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,23L,23L,24L,25L,26L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,41L,42L,43L,43L,44L,45L,46L,47L,47L,48L,49L,50L,51L,52L,53L,53L,54L,55L,56L,57L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112231Inst : IEnumerable<long>
{
public static readonly long[] Value=A112231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112231.Bytes);
public long this[int i]=>Value[i];

public static A112231Inst Instance=new A112231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112232
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112232Inst : IEnumerable<long>
{
public static readonly long[] Value=A112232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112232.Bytes);
public long this[int i]=>Value[i];

public static A112232Inst Instance=new A112232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112233
{
public static readonly long[] Value={ 2L,4L,5L,7L,7L,9L,11L,11L,13L,15L,15L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,48L,50L,52L,53L,54L,55L,57L,57L,59L,60L,62L,63L,65L,67L,67L,69L,71L,72L,74L,74L,76L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112233Inst : IEnumerable<long>
{
public static readonly long[] Value=A112233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112233.Bytes);
public long this[int i]=>Value[i];

public static A112233Inst Instance=new A112233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112234
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,12L,14L,16L,19L,23L,27L,30L,35L,39L,41L,46L,49L,51L,56L,58L,61L,64L,66L,68L,70L,73L,75L,80L,83L,87L,90L,93L,97L,99L,102L,107L,111L,114L,117L,119L,122L,124L,126L,131L,134L,137L,141L,143L,148L,151L,154L,156L,158L,161L,164L,167L,171L,173L,178L,180L,183L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112234Inst : IEnumerable<long>
{
public static readonly long[] Value=A112234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112234.Bytes);
public long this[int i]=>Value[i];

public static A112234Inst Instance=new A112234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112235
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,11L,13L,15L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,48L,50L,52L,53L,54L,55L,57L,59L,60L,62L,63L,65L,67L,69L,71L,72L,74L,76L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L,100L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112235Inst : IEnumerable<long>
{
public static readonly long[] Value=A112235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112235.Bytes);
public long this[int i]=>Value[i];

public static A112235Inst Instance=new A112235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112236
{
public static readonly long[] Value={ 1L,3L,12L,24L,42L,46L,42L,24L,12L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112236Inst : IEnumerable<long>
{
public static readonly long[] Value=A112236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112236.Bytes);
public long this[int i]=>Value[i];

public static A112236Inst Instance=new A112236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112237
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,144L,BigInteger.Parse("9969216677189303386214405760200") };
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
public class A112237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112237Inst Instance=new A112237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112238
{
public static readonly long[] Value={ 1L,0L,0L,0L,3L,0L,4L,6L,7L,9L,2L,9L,1L,6L,4L,8L,2L,9L,1L,5L,9L,2L,4L,9L,9L,5L,1L,4L,1L,9L,2L,2L,6L,3L,7L,0L,2L,7L,2L,6L,5L,3L,6L,6L,3L,5L,8L,5L,5L,8L,4L,3L,9L,7L,3L,7L,8L,0L,6L,8L,8L,5L,6L,2L,1L,3L,3L,9L,9L,7L,0L,7L,9L,9L,9L,7L,6L,5L,7L,6L,7L,1L,6L,5L,2L,2L,6L,6L,7L,1L,0L,9L,0L,6L,8L,8L,8L,9L,2L,3L,1L,2L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112238Inst : IEnumerable<long>
{
public static readonly long[] Value=A112238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112238.Bytes);
public long this[int i]=>Value[i];

public static A112238Inst Instance=new A112238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112239
{
public static readonly long[] Value={ 0L,0L,0L,1L,-2L,0L,3L,3L,-6L,0L,12L,12L,6L,-12L,0L,60L,60L,30L,10L,-20L,0L,360L,360L,180L,60L,15L,-30L,0L,2520L,2520L,1260L,420L,105L,21L,-42L,0L,20160L,20160L,10080L,3360L,840L,168L,28L,-56L,0L,181440L,181440L,90720L,30240L,7560L,1512L,252L,36L,-72L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112239Inst : IEnumerable<long>
{
public static readonly long[] Value=A112239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112239.Bytes);
public long this[int i]=>Value[i];

public static A112239Inst Instance=new A112239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112240
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,217L,2541L,34531L,550453L,9957585L,202137337L,4543312771L,112004037201L,3003936136873L,87057179039845L,2710682505789987L,90230919126896941L,3197152300287286561L,BigInteger.Parse("120131212083966304113") };
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
public class A112240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112240Inst Instance=new A112240Inst();

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